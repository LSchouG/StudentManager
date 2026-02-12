namespace StudentManager
{
    partial class PrintScoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_searchPrintScore = new Button();
            comboBox_score = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            radioButton_printSearchAll = new RadioButton();
            radioButton_all = new RadioButton();
            button_printScore = new Button();
            button_print = new Button();
            label2 = new Label();
            button_clear_MangeStudent = new Button();
            radioButton_printSearchMale = new RadioButton();
            button_delete = new Button();
            radioButton_printSearchFemale = new RadioButton();
            button_Update = new Button();
            button_uploadMG = new Button();
            pictureBox_studentMG = new PictureBox();
            panel2 = new Panel();
            button_clear = new Button();
            button_add = new Button();
            label4 = new Label();
            button_upload = new Button();
            radioButton_male = new RadioButton();
            pictureBox_student = new PictureBox();
            radioButton_female = new RadioButton();
            panel1 = new Panel();
            label7 = new Label();
            dataGridView_score = new DataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_studentMG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_score).BeginInit();
            SuspendLayout();
            // 
            // button_searchPrintScore
            // 
            button_searchPrintScore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_searchPrintScore.BackColor = Color.FromArgb(0, 71, 160);
            button_searchPrintScore.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_searchPrintScore.ForeColor = Color.White;
            button_searchPrintScore.Location = new Point(575, 12);
            button_searchPrintScore.Name = "button_searchPrintScore";
            button_searchPrintScore.Size = new Size(109, 28);
            button_searchPrintScore.TabIndex = 42;
            button_searchPrintScore.Text = "Search";
            button_searchPrintScore.UseVisualStyleBackColor = false;
            button_searchPrintScore.Click += button_searchPrintScore_Click;
            // 
            // comboBox_score
            // 
            comboBox_score.FormattingEnabled = true;
            comboBox_score.Location = new Point(425, 15);
            comboBox_score.Name = "comboBox_score";
            comboBox_score.Size = new Size(142, 23);
            comboBox_score.TabIndex = 41;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(304, 17);
            label1.Name = "label1";
            label1.Size = new Size(113, 18);
            label1.TabIndex = 40;
            label1.Text = "Select Class :";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(button_searchPrintScore);
            panel3.Controls.Add(radioButton_printSearchAll);
            panel3.Controls.Add(comboBox_score);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(radioButton_all);
            panel3.Controls.Add(button_printScore);
            panel3.Controls.Add(button_print);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button_clear_MangeStudent);
            panel3.Controls.Add(radioButton_printSearchMale);
            panel3.Controls.Add(button_delete);
            panel3.Controls.Add(radioButton_printSearchFemale);
            panel3.Controls.Add(button_Update);
            panel3.Controls.Add(button_uploadMG);
            panel3.Controls.Add(pictureBox_studentMG);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(button_clear);
            panel3.Controls.Add(button_add);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(button_upload);
            panel3.Controls.Add(radioButton_male);
            panel3.Controls.Add(pictureBox_student);
            panel3.Controls.Add(radioButton_female);
            panel3.Location = new Point(0, 567);
            panel3.Name = "panel3";
            panel3.Size = new Size(934, 51);
            panel3.TabIndex = 39;
            // 
            // radioButton_printSearchAll
            // 
            radioButton_printSearchAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_printSearchAll.AutoSize = true;
            radioButton_printSearchAll.Checked = true;
            radioButton_printSearchAll.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_printSearchAll.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_printSearchAll.Location = new Point(101, 16);
            radioButton_printSearchAll.Name = "radioButton_printSearchAll";
            radioButton_printSearchAll.Size = new Size(43, 20);
            radioButton_printSearchAll.TabIndex = 47;
            radioButton_printSearchAll.TabStop = true;
            radioButton_printSearchAll.Text = "All";
            radioButton_printSearchAll.UseVisualStyleBackColor = true;
            // 
            // radioButton_all
            // 
            radioButton_all.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_all.AutoSize = true;
            radioButton_all.Checked = true;
            radioButton_all.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_all.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_all.Location = new Point(99, -29);
            radioButton_all.Name = "radioButton_all";
            radioButton_all.Size = new Size(43, 20);
            radioButton_all.TabIndex = 35;
            radioButton_all.TabStop = true;
            radioButton_all.Text = "All";
            radioButton_all.UseVisualStyleBackColor = true;
            // 
            // button_printScore
            // 
            button_printScore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_printScore.BackColor = Color.FromArgb(0, 71, 160);
            button_printScore.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_printScore.ForeColor = Color.White;
            button_printScore.Location = new Point(815, 12);
            button_printScore.Name = "button_printScore";
            button_printScore.Size = new Size(109, 28);
            button_printScore.TabIndex = 46;
            button_printScore.Text = "Print";
            button_printScore.UseVisualStyleBackColor = false;
            button_printScore.Click += button_printScore_Click;
            // 
            // button_print
            // 
            button_print.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_print.BackColor = Color.FromArgb(0, 71, 160);
            button_print.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_print.ForeColor = Color.White;
            button_print.Location = new Point(1547, -33);
            button_print.Name = "button_print";
            button_print.Size = new Size(109, 28);
            button_print.TabIndex = 34;
            button_print.Text = "Print";
            button_print.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(20, 17);
            label2.Name = "label2";
            label2.Size = new Size(73, 18);
            label2.TabIndex = 43;
            label2.Text = "Gender :";
            // 
            // button_clear_MangeStudent
            // 
            button_clear_MangeStudent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear_MangeStudent.BackColor = Color.Gray;
            button_clear_MangeStudent.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_clear_MangeStudent.ForeColor = Color.White;
            button_clear_MangeStudent.Location = new Point(2044, 123);
            button_clear_MangeStudent.Name = "button_clear_MangeStudent";
            button_clear_MangeStudent.Size = new Size(109, 28);
            button_clear_MangeStudent.TabIndex = 25;
            button_clear_MangeStudent.Text = "Clear";
            button_clear_MangeStudent.UseVisualStyleBackColor = false;
            // 
            // radioButton_printSearchMale
            // 
            radioButton_printSearchMale.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_printSearchMale.AutoSize = true;
            radioButton_printSearchMale.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_printSearchMale.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_printSearchMale.Location = new Point(152, 16);
            radioButton_printSearchMale.Name = "radioButton_printSearchMale";
            radioButton_printSearchMale.Size = new Size(59, 20);
            radioButton_printSearchMale.TabIndex = 44;
            radioButton_printSearchMale.Text = "Male";
            radioButton_printSearchMale.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.Red;
            button_delete.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(2156, 123);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(109, 28);
            button_delete.TabIndex = 24;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            // 
            // radioButton_printSearchFemale
            // 
            radioButton_printSearchFemale.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_printSearchFemale.AutoSize = true;
            radioButton_printSearchFemale.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_printSearchFemale.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_printSearchFemale.Location = new Point(219, 16);
            radioButton_printSearchFemale.Name = "radioButton_printSearchFemale";
            radioButton_printSearchFemale.Size = new Size(77, 20);
            radioButton_printSearchFemale.TabIndex = 45;
            radioButton_printSearchFemale.Text = "Female";
            radioButton_printSearchFemale.UseVisualStyleBackColor = true;
            // 
            // button_Update
            // 
            button_Update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Update.BackColor = Color.Green;
            button_Update.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_Update.ForeColor = Color.White;
            button_Update.Location = new Point(2271, 123);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(109, 28);
            button_Update.TabIndex = 23;
            button_Update.Text = "Update";
            button_Update.UseVisualStyleBackColor = false;
            // 
            // button_uploadMG
            // 
            button_uploadMG.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_uploadMG.BackColor = Color.FromArgb(0, 71, 160);
            button_uploadMG.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_uploadMG.ForeColor = Color.White;
            button_uploadMG.Location = new Point(2271, 68);
            button_uploadMG.Name = "button_uploadMG";
            button_uploadMG.Size = new Size(109, 28);
            button_uploadMG.TabIndex = 22;
            button_uploadMG.Text = "Upload";
            button_uploadMG.UseVisualStyleBackColor = false;
            // 
            // pictureBox_studentMG
            // 
            pictureBox_studentMG.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox_studentMG.BackColor = Color.Gainsboro;
            pictureBox_studentMG.Location = new Point(2271, -67);
            pictureBox_studentMG.Name = "pictureBox_studentMG";
            pictureBox_studentMG.Size = new Size(109, 121);
            pictureBox_studentMG.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_studentMG.TabIndex = 21;
            pictureBox_studentMG.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 10);
            panel2.TabIndex = 20;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Silver;
            button_clear.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(2899, 282);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(109, 28);
            button_clear.TabIndex = 18;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.Green;
            button_add.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(3014, 282);
            button_add.Name = "button_add";
            button_add.Size = new Size(109, 28);
            button_add.TabIndex = 17;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(18, -28);
            label4.Name = "label4";
            label4.Size = new Size(73, 18);
            label4.TabIndex = 8;
            label4.Text = "Gender :";
            // 
            // button_upload
            // 
            button_upload.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_upload.BackColor = Color.FromArgb(0, 71, 160);
            button_upload.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(3014, 227);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(109, 28);
            button_upload.TabIndex = 14;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            // 
            // radioButton_male
            // 
            radioButton_male.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_male.AutoSize = true;
            radioButton_male.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_male.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_male.Location = new Point(148, -29);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(59, 20);
            radioButton_male.TabIndex = 9;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // pictureBox_student
            // 
            pictureBox_student.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox_student.BackColor = Color.Gainsboro;
            pictureBox_student.Location = new Point(3014, 92);
            pictureBox_student.Name = "pictureBox_student";
            pictureBox_student.Size = new Size(109, 121);
            pictureBox_student.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_student.TabIndex = 13;
            pictureBox_student.TabStop = false;
            // 
            // radioButton_female
            // 
            radioButton_female.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_female.AutoSize = true;
            radioButton_female.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_female.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_female.Location = new Point(213, -29);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(77, 20);
            radioButton_female.TabIndex = 10;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 58);
            panel1.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(406, 18);
            label7.Name = "label7";
            label7.Size = new Size(83, 24);
            label7.TabIndex = 20;
            label7.Text = "To Print";
            // 
            // dataGridView_score
            // 
            dataGridView_score.AllowUserToAddRows = false;
            dataGridView_score.AllowUserToDeleteRows = false;
            dataGridView_score.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_score.BackgroundColor = Color.Gainsboro;
            dataGridView_score.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_score.Location = new Point(0, 64);
            dataGridView_score.Name = "dataGridView_score";
            dataGridView_score.Size = new Size(934, 506);
            dataGridView_score.TabIndex = 37;
            // 
            // PrintScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridView_score);
            Name = "PrintScoreForm";
            Text = "PrintScoreForm";
            Load += PrintScoreForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_studentMG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_score).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_searchPrintScore;
        private ComboBox comboBox_score;
        private Label label1;
        private Panel panel3;
        private RadioButton radioButton_all;
        private Button button_print;
        private Button button_clear_MangeStudent;
        private Button button_delete;
        private Button button_Update;
        private Button button_uploadMG;
        private PictureBox pictureBox_studentMG;
        private Panel panel2;
        private Button button_clear;
        private Button button_add;
        private Label label4;
        private Button button_upload;
        private RadioButton radioButton_male;
        private PictureBox pictureBox_student;
        private RadioButton radioButton_female;
        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView_score;
        private RadioButton radioButton_printSearchAll;
        private Button button_printScore;
        private Label label2;
        private RadioButton radioButton_printSearchMale;
        private RadioButton radioButton_printSearchFemale;
    }
}