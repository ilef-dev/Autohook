namespace microp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label1.Text = "Создание символической ссылки.";
            int result = await Task.Run(() => OfficeActivation.CreateMklink());

            progressBar1.Value = 10;

            result = await Task.Run(() => OfficeActivation.UploadSppc64());
            progressBar1.Value = 90;

            result = await Task.Run(() => OfficeActivation.InsertKey());
            progressBar1.Value = 100;
            label1.ForeColor = Color.Green;
            label1.Text = "Complete";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            linkLabel1.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
    }
}
