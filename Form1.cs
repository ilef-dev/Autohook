using brod;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace brod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadOfficesAsync();

            if (!IsRunAsAdmin())
            {
                label4.Visible = true;
            }
        }

        static bool IsRunAsAdmin()
        {
            // �������� ������� ������������� ������������
            WindowsIdentity identity = WindowsIdentity.GetCurrent();

            // ���������, �������� �� ������������ ���������������
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private async void LoadOfficesAsync()
        {
            // ��������� �������� ������ � ��������� ������
            await Task.Run(() =>
            {
                OfficeLoader.Load();
            });
        }

        private async Task<List<String>> LoadOfficesByYearAsync(string year)
        {
            List<String> data = new List<String>();
            // ��������� �������� ������ � ��������� ������
            await Task.Run(() =>
            {
                List<OfficeLoader.Office> offices = OfficeLoader.GetOfficesByYear(year);
                foreach (OfficeLoader.Office office in offices)
                {
                    data.Add(office.name);
                }
            });

            return data;
        }

        private void UpdateComboBox(List<string> data)
        {
            // ��������, ��� ���������� ���������� � �������� ������
            if (InvokeRequired)
            {
                // ���������� Invoke ��� ���������� ��������� ���������� �� ������� ������
                Invoke(new Action(() => UpdateComboBox(data)));
                return;
            }

            comboBox1.Items.Clear();
            foreach (var item in data)
            {
                comboBox1.Items.Add(item);
            }
        }

        // ��������� ��� ��������� ����� ProgressBar
        private const int PBM_SETSTATE = 0x0410;
        private const int PBST_NORMAL = 0x0001;
        private const int PBST_ERROR = 0x0002;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);

        private async void button1_Click(object sender, EventArgs e)
        {
            // �������� �� ���� ��������� ���������� ������ GroupBox
            foreach (Control control in groupBox2.Controls)
            {
                control.Enabled = false; // ��������� ������ �������
            }

            int result;
            button1.Enabled = false;
            label1.Enabled = true;

            progressBar1.Value = 5;

            richTextBox1.AppendText("�������� ������������� ������ ��� sppcs.dll" + Environment.NewLine);
            result = await Task.Run(() => OfficeActivation.CreateMklink());
            if (result == 0)
            {
                richTextBox1.AppendText("�� ������� ������� ������������� ������ ��� sppcs.dll" + Environment.NewLine);
                label1.Text = "������";
                label1.ForeColor = Color.Red;
                SendMessage(progressBar1.Handle, PBM_SETSTATE, (IntPtr)PBST_ERROR, IntPtr.Zero);
                return;
            }
            progressBar1.Value = 10;
            progressBar1.Refresh();

            richTextBox1.AppendText("���������� ���������������� ��������� sppc.dll" + Environment.NewLine);
            result = await Task.Run(() => OfficeActivation.UploadSppc());
            if (result == 0)
            {
                richTextBox1.AppendText("�� ������� �������� ���������������� ��������� sppc.dll" + Environment.NewLine);
                label1.Text = "������";
                label1.ForeColor = Color.Red;
                SendMessage(progressBar1.Handle, PBM_SETSTATE, (IntPtr)PBST_ERROR, IntPtr.Zero);
                return;
            }
            progressBar1.Value = 90;
            progressBar1.Refresh();

            richTextBox1.AppendText("��������� �����" + Environment.NewLine);
            richTextBox1.AppendText("������� OK" + Environment.NewLine);

            string key = null;
            string year = comboBox3.SelectedItem as string;
            string name = comboBox1.SelectedItem as string;
            foreach (var office in OfficeLoader.data)
            {
                if (office.year == year && office.name == name)
                {
                    key = office.key;
                }
            }

            richTextBox1.AppendText("������ ����: " + key + Environment.NewLine);
            if (key != null)
            {
                result = await Task.Run(() => OfficeActivation.InsertKey(key));
            }
            if (result != 0)
            {
                richTextBox1.AppendText("�� ������� ������������ ����" + Environment.NewLine);
                label1.Text = "������";
                label1.ForeColor = Color.Red;
                SendMessage(progressBar1.Handle, PBM_SETSTATE, (IntPtr)PBST_ERROR, IntPtr.Zero);
                return;
            }
            progressBar1.Value = 100;

            label1.Text = "�������������";
            label1.ForeColor = Color.Green;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            linkLabel1.Enabled = false;
            comboBox2.Enabled = true;
            button1.Enabled = true;
            groupBox1.Enabled = true;
            comboBox2.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string link = @"https://officecdn.microsoft.com/db/492350f6-3a01-4f97-b9c0-c7c6ddf67d60/media";
            if (comboBox2.SelectedItem == "Ru")
            {
                link += "/ru-ru";
            }
            else
            {
                link += "/en-us";
            }
            link += "/" + comboBox1.SelectedItem + ".img";

            linkLabel1.Links.Clear();
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, link);

            linkLabel1.Enabled = true;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            linkLabel1.Enabled = false;
            button2.Enabled = true;
        }

        private async void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> offices = await LoadOfficesByYearAsync(comboBox3.SelectedItem as String);

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            button2.Enabled = false;
            linkLabel1.Enabled = false;
            comboBox1.Items.Clear();

            foreach (string office in offices)
            {
                comboBox1.Items.Add(office);
            }

            comboBox1.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // �������� ������ � ��������
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = e.Link.LinkData.ToString(), // URL ��� ��������
                UseShellExecute = true // ������������ ���������� ������ ��� �������� URL
            };
            System.Diagnostics.Process.Start(startInfo);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
