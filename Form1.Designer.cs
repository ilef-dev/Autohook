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
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(170, 435);
            button1.Name = "button1";
            button1.Size = new Size(134, 52);
            button1.TabIndex = 0;
            button1.Text = "Активировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(6, 56);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(385, 30);
            progressBar1.TabIndex = 1;
            progressBar1.Click += progressBar1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Location = new Point(41, 493);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 99);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(385, 30);
            label1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AccessRetail", "AccessVolume", "ExcelRetail", "ExcelVolume", "GrooveRetail", "GrooveVolume", "HomeBusinessPipcRetail", "HomeBusinessRetail", "HomeStudentRetail", "InfoPathRetail", "InfoPathVolume", "LyncAcademicRetail", "LyncEntryRetail", "LyncRetail", "LyncVolume", "MondoRetail", "MondoVolume", "OneNoteFreeRetail", "OneNoteRetail", "OneNoteVolume", "OutlookRetail", "OutlookVolume", "PersonalPipcRetail", "PersonalRetail", "PowerPointRetail", "PowerPointVolume", "ProPlusRetail", "ProPlusVolume", "ProfessionalPipcRetail", "ProfessionalRetail", "ProjectProRetail", "ProjectProVolume", "ProjectStdRetail", "ProjectStdVolume", "PublisherRetail", "PublisherVolume", "SPDRetail", "StandardRetail", "StandardVolume", "VisioProRetail", "VisioProVolume", "VisioStdRetail", "VisioStdVolume", "WordRetail", "WordVolume", "O365BusinessRetail", "O365HomePremRetail", "O365ProPlusRetail", "O365SmallBusPremRetail", "AccessRetail", "AccessRuntimeRetail", "AccessVolume", "ExcelRetail", "ExcelVolume", "HomeBusinessPipcRetail", "HomeBusinessRetail", "HomeStudentRetail", "HomeStudentVNextRetail", "MondoRetail", "MondoVolume", "OneNoteFreeRetail", "OneNoteRetail", "OneNoteVolume", "OutlookRetail", "OutlookVolume", "PersonalPipcRetail", "PersonalRetail", "PowerPointRetail", "PowerPointVolume", "ProPlusRetail", "ProPlusVolume", "ProfessionalPipcRetail", "ProfessionalRetail", "ProjectProRetail", "ProjectProVolume", "ProjectProXVolume", "ProjectStdRetail", "ProjectStdVolume", "ProjectStdXVolume", "PublisherRetail", "PublisherVolume", "SkypeServiceBypassRetail", "SkypeforBusinessEntryRetail", "SkypeforBusinessRetail", "SkypeforBusinessVolume", "StandardRetail", "StandardVolume", "VisioProRetail", "VisioProVolume", "VisioProXVolume", "VisioStdRetail", "VisioStdVolume", "VisioStdXVolume", "WordRetail", "WordVolume", "Access2019Retail", "Access2019Volume", "AccessRuntime2019Retail", "Excel2019Retail", "Excel2019Volume", "HomeBusiness2019Retail", "HomeStudent2019Retail", "Outlook2019Retail", "Outlook2019Volume", "Personal2019Retail", "PowerPoint2019Retail", "PowerPoint2019Volume", "ProPlus2019Retail", "ProPlus2019Volume", "Professional2019Retail", "ProjectPro2019Retail", "ProjectPro2019Volume", "ProjectStd2019Retail", "ProjectStd2019Volume", "Publisher2019Retail", "Publisher2019Volume", "SkypeforBusiness2019Retail", "SkypeforBusiness2019Volume", "SkypeforBusinessEntry2019Retail", "Standard2019Retail", "Standard2019Volume", "VisioPro2019Retail", "VisioPro2019Volume", "VisioStd2019Retail", "VisioStd2019Volume", "Word2019Retail", "Word2019Volume", "Access2021Retail", "Access2021Volume", "Excel2021Retail", "Excel2021Volume", "HomeBusiness2021Retail", "HomeStudent2021Retail", "OneNote2021Retail", "Outlook2021Retail", "Outlook2021Volume", "Personal2021Retail", "PowerPoint2021Retail", "PowerPoint2021Volume", "ProPlus2021Retail", "ProPlus2021Volume1", "ProPlusSPLA2021Volume", "Professional2021Retail", "ProjectPro2021Retail", "ProjectPro2021Volume1", "ProjectStd2021Retail", "ProjectStd2021Volume", "Publisher2021Retail", "Publisher2021Volume", "SkypeforBusiness2021Retail", "SkypeforBusiness2021Volume", "Standard2021Retail", "Standard2021Volume", "StandardSPLA2021Volume", "VisioPro2021Retail", "VisioPro2021Volume", "VisioStd2021Retail", "VisioStd2021Volume", "Word2021Retail", "Word2021Volume", "ProPlus2024Volume MAK", "ProjectPro2024Volume MAK", "VisioPro2024Volume MAK", "Access2024Retail", "Access2024Volume", "Excel2024Retail", "Excel2024Volume", "Home2024Retail", "HomeBusiness2024Retail", "Outlook2024Retail", "Outlook2024Volume", "PowerPoint2024Retail", "PowerPoint2024Volume", "ProjectPro2024Retail", "ProjectPro2024Volume1", "ProjectStd2024Retail", "ProjectStd2024Volume", "ProPlus2024Retail", "ProPlus2024Volume1", "SkypeforBusiness2024Volume", "Standard2024Volume1", "VisioPro2024Retail", "VisioPro2024Volume", "VisioStd2024Retail", "VisioStd2024Volume", "Word2024Retail", "Word2024Volume", "O365BusinessRetail", "O365EduCloudRetail", "O365HomePremRetail", "O365ProPlusRetail", "O365SmallBusPremRetail" });
            comboBox1.Location = new Point(23, 57);
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
            comboBox2.Location = new Point(296, 58);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(79, 28);
            comboBox2.TabIndex = 5;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(23, 100);
            button2.Name = "button2";
            button2.Size = new Size(118, 29);
            button2.TabIndex = 6;
            button2.Text = "Генерировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 23);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 7;
            label2.Text = "Язык";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 34);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 8;
            label3.Text = "Версия office";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(linkLabel1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(41, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 146);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выберите нужную версию";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Enabled = false;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel1.Location = new Point(197, 104);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(168, 20);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Оффициальная ссылка";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 208);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 10;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 653);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "MicrOp ver1.0";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ProgressBar progressBar1;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button2;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private LinkLabel linkLabel1;
        private Label label4;
    }
}
