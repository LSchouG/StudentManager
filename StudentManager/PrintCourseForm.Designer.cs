namespace StudentManager
{
    partial class PrintCourseForm
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
            button_search = new Button();
            panel3 = new Panel();
            button1 = new Button();
            radioButton_all = new RadioButton();
            button_print = new Button();
            button_clear_MangeStudent = new Button();
            button_delete = new Button();
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
            dataGridView_course = new DataGridView();
            textBox_courseSearchBox = new TextBox();
            radioButton_StudentId = new RadioButton();
            radioButton_hours = new RadioButton();
            radioButton_description = new RadioButton();
            radioButton_name = new RadioButton();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_studentMG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_course).BeginInit();
            SuspendLayout();
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_search.BackColor = Color.FromArgb(0, 71, 160);
            button_search.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(813, 60);
            button_search.Name = "button_search";
            button_search.Size = new Size(109, 28);
            button_search.TabIndex = 42;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(radioButton_all);
            panel3.Controls.Add(button_print);
            panel3.Controls.Add(button_clear_MangeStudent);
            panel3.Controls.Add(button_delete);
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
            panel3.Location = new Point(0, 562);
            panel3.Name = "panel3";
            panel3.Size = new Size(934, 51);
            panel3.TabIndex = 39;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(0, 71, 160);
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(813, 16);
            button1.Name = "button1";
            button1.Size = new Size(109, 28);
            button1.TabIndex = 39;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            label7.Location = new Point(381, 9);
            label7.Name = "label7";
            label7.Size = new Size(83, 24);
            label7.TabIndex = 20;
            label7.Text = "To Print";
            // 
            // dataGridView_course
            // 
            dataGridView_course.AllowUserToAddRows = false;
            dataGridView_course.AllowUserToDeleteRows = false;
            dataGridView_course.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_course.BackgroundColor = Color.Gainsboro;
            dataGridView_course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_course.Location = new Point(0, 90);
            dataGridView_course.Name = "dataGridView_course";
            dataGridView_course.Size = new Size(934, 480);
            dataGridView_course.TabIndex = 37;
            // 
            // textBox_courseSearchBox
            // 
            textBox_courseSearchBox.Location = new Point(687, 63);
            textBox_courseSearchBox.Name = "textBox_courseSearchBox";
            textBox_courseSearchBox.Size = new Size(126, 23);
            textBox_courseSearchBox.TabIndex = 43;
            // 
            // radioButton_StudentId
            // 
            radioButton_StudentId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_StudentId.AutoSize = true;
            radioButton_StudentId.Checked = true;
            radioButton_StudentId.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_StudentId.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_StudentId.Location = new Point(411, 64);
            radioButton_StudentId.Name = "radioButton_StudentId";
            radioButton_StudentId.Size = new Size(40, 20);
            radioButton_StudentId.TabIndex = 47;
            radioButton_StudentId.TabStop = true;
            radioButton_StudentId.Text = "ID";
            radioButton_StudentId.UseVisualStyleBackColor = true;
            // 
            // radioButton_hours
            // 
            radioButton_hours.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_hours.AutoSize = true;
            radioButton_hours.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_hours.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_hours.Location = new Point(517, 64);
            radioButton_hours.Name = "radioButton_hours";
            radioButton_hours.Size = new Size(66, 20);
            radioButton_hours.TabIndex = 45;
            radioButton_hours.Text = "Hours";
            radioButton_hours.UseVisualStyleBackColor = true;
            // 
            // radioButton_description
            // 
            radioButton_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_description.AutoSize = true;
            radioButton_description.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_description.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_description.Location = new Point(583, 64);
            radioButton_description.Name = "radioButton_description";
            radioButton_description.Size = new Size(104, 20);
            radioButton_description.TabIndex = 46;
            radioButton_description.Text = "Description";
            radioButton_description.UseVisualStyleBackColor = true;
            // 
            // radioButton_name
            // 
            radioButton_name.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_name.AutoSize = true;
            radioButton_name.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_name.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_name.Location = new Point(451, 64);
            radioButton_name.Name = "radioButton_name";
            radioButton_name.Size = new Size(66, 20);
            radioButton_name.TabIndex = 48;
            radioButton_name.Text = "Name";
            radioButton_name.UseVisualStyleBackColor = true;
            // 
            // PrintCourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(radioButton_name);
            Controls.Add(radioButton_StudentId);
            Controls.Add(radioButton_hours);
            Controls.Add(radioButton_description);
            Controls.Add(textBox_courseSearchBox);
            Controls.Add(button_search);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridView_course);
            Name = "PrintCourseForm";
            Text = "PrintCourseForm";
            Load += PrintCourseForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_studentMG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_course).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_search;
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
        private DataGridView dataGridView_course;
        private Button button1;
        private TextBox textBox_courseSearchBox;
        private RadioButton radioButton_StudentId;
        private RadioButton radioButton_hours;
        private RadioButton radioButton_description;
        private RadioButton radioButton_name;
    }
}