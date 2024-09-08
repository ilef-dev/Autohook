namespace microp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            progressBar1 = new ProgressBar();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox4 = new GroupBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            comboBox3 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(167, 286);
            button1.Name = "button1";
            button1.Size = new Size(134, 52);
            button1.TabIndex = 0;
            button1.Text = "Активировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(6, 131);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(386, 30);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(41, 344);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 231);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Активация";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 26);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(386, 99);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(100, 167);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(190, 58);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Состояние";
            // 
            // label1
            // 
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(178, 34);
            label1.TabIndex = 0;
            label1.Text = "Ожидание";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(100, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ru", "En" });
            comboBox2.Location = new Point(346, 58);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(46, 28);
            comboBox2.TabIndex = 5;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(23, 105);
            button2.Name = "button2";
            button2.Size = new Size(118, 30);
            button2.TabIndex = 6;
            button2.Text = "Генерировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 35);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 7;
            label2.Text = "Язык";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 35);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 8;
            label3.Text = "Версия office";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(41, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 159);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выберите нужную версию";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(linkLabel1);
            groupBox3.Location = new Point(147, 92);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(242, 51);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Получить";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Enabled = false;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel1.Location = new Point(6, 23);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(221, 20);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Оффициальный сайт Microsoft";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 35);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 12;
            label5.Text = "Год";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "2013", "2016", "2021", "2024", "O365" });
            comboBox3.Location = new Point(23, 58);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(71, 28);
            comboBox3.TabIndex = 11;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 653);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Brod ver1.0";
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ProgressBar progressBar1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button2;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private LinkLabel linkLabel1;
        private Label label5;
        private ComboBox comboBox3;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}
