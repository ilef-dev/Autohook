using brod;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace microp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadOfficesAsync();

            if(!IsRunAsAdmin())
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

        private async void button1_Click(object sender, EventArgs e)
        {
            int result;
            button1.Enabled = false;
            label1.Enabled = true;

            richTextBox1.AppendText("�������� ������������� ������ ��� sppc.dll" + Environment.NewLine);
            result = await Task.Run(() => OfficeActivation.CreateMklink());
            if (result == 0)
            {
                richTextBox1.AppendText("�� ������� ������� ������������� ������ ��� sppc.dll" + Environment.NewLine);
                label1.Text = "������";
                label1.ForeColor = Color.Red;
                progressBar1.Enabled = false;
                return;
            }
            progressBar1.Value = 10;

            richTextBox1.AppendText("���������� ���������������� ��������� sppcs.dll" + Environment.NewLine);
            result = await Task.Run(() => OfficeActivation.UploadSppc64());
            if (result == 0)
            {
                richTextBox1.AppendText("�� ������� �������� ���������������� ��������� sppcs.dll" + Environment.NewLine);
                label1.Text = "������";
                label1.ForeColor = Color.Red;
                progressBar1.Enabled = false;
                //return;
            }
            progressBar1.Value = 90;

            richTextBox1.AppendText("��������� �����" + Environment.NewLine);
            richTextBox1.AppendText("������� OK" + Environment.NewLine);

            string key = null;
            string year = comboBox3.SelectedItem as string;
            string name = comboBox1.SelectedItem as string;
            foreach(var office in OfficeLoader.data)
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
            if (result == 0)
            {
                richTextBox1.AppendText("�� ������� ������������ ����" + Environment.NewLine);
                label1.Text = "������";
                label1.ForeColor = Color.Red;
                progressBar1.Enabled = false;
                return;
            }
            progressBar1.Value = 100;

            label1.Text = "�������";
            label1.ForeColor = Color.Green;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            linkLabel1.Enabled = false;
            comboBox2.Enabled = true;
            button1.Enabled = true;
            groupBox1.Enabled = true;
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
