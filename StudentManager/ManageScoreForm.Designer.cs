namespace StudentManager
{
    partial class ManageScoreForm
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
            radioButton_name = new RadioButton();
            radioButton_StudentId = new RadioButton();
            textBox_scoreSearchBox = new TextBox();
            button_searchScore = new Button();
            panel1 = new Panel();
            label7 = new Label();
            dataGridView_MaganeScore = new DataGridView();
            panel3 = new Panel();
            button_clear_MangeStudent = new Button();
            button_delete = new Button();
            button_Update = new Button();
            comboBox_Course = new ComboBox();
            label3 = new Label();
            textBox_Score = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            textBox_studentScoreId = new TextBox();
            label2 = new Label();
            textBox_description = new TextBox();
            label5 = new Label();
            button_clearScore = new Button();
            button_addScore = new Button();
            button1 = new Button();
            button_addCourse = new Button();
            button_clear = new Button();
            button_add = new Button();
            radioButton_courseName = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_MaganeScore).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton_name
            // 
            radioButton_name.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_name.AutoSize = true;
            radioButton_name.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_name.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_name.Location = new Point(433, 65);
            radioButton_name.Name = "radioButton_name";
            radioButton_name.Size = new Size(122, 20);
            radioButton_name.TabIndex = 55;
            radioButton_name.Text = "Student Name";
            radioButton_name.UseVisualStyleBackColor = true;
            // 
            // radioButton_StudentId
            // 
            radioButton_StudentId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_StudentId.AutoSize = true;
            radioButton_StudentId.Checked = true;
            radioButton_StudentId.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_StudentId.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_StudentId.Location = new Point(387, 65);
            radioButton_StudentId.Name = "radioButton_StudentId";
            radioButton_StudentId.Size = new Size(40, 20);
            radioButton_StudentId.TabIndex = 54;
            radioButton_StudentId.TabStop = true;
            radioButton_StudentId.Text = "ID";
            radioButton_StudentId.UseVisualStyleBackColor = true;
            // 
            // textBox_scoreSearchBox
            // 
            textBox_scoreSearchBox.Location = new Point(687, 64);
            textBox_scoreSearchBox.Name = "textBox_scoreSearchBox";
            textBox_scoreSearchBox.Size = new Size(126, 23);
            textBox_scoreSearchBox.TabIndex = 51;
            // 
            // button_searchScore
            // 
            button_searchScore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_searchScore.BackColor = Color.FromArgb(0, 71, 160);
            button_searchScore.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_searchScore.ForeColor = Color.White;
            button_searchScore.Location = new Point(819, 61);
            button_searchScore.Name = "button_searchScore";
            button_searchScore.Size = new Size(109, 28);
            button_searchScore.TabIndex = 50;
            button_searchScore.Text = "Search";
            button_searchScore.UseVisualStyleBackColor = false;
            button_searchScore.Click += button_searchScore_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 58);
            panel1.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(381, 9);
            label7.Name = "label7";
            label7.Size = new Size(146, 24);
            label7.TabIndex = 20;
            label7.Text = "Manage Score";
            // 
            // dataGridView_MaganeScore
            // 
            dataGridView_MaganeScore.AllowUserToAddRows = false;
            dataGridView_MaganeScore.AllowUserToDeleteRows = false;
            dataGridView_MaganeScore.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_MaganeScore.BackgroundColor = Color.Gainsboro;
            dataGridView_MaganeScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_MaganeScore.Location = new Point(0, 94);
            dataGridView_MaganeScore.Name = "dataGridView_MaganeScore";
            dataGridView_MaganeScore.Size = new Size(934, 322);
            dataGridView_MaganeScore.TabIndex = 56;
            dataGridView_MaganeScore.Click += dataGridView_MaganeScore_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(button_clear_MangeStudent);
            panel3.Controls.Add(button_delete);
            panel3.Controls.Add(button_Update);
            panel3.Controls.Add(comboBox_Course);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox_Score);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBox_studentScoreId);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox_description);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(button_clearScore);
            panel3.Controls.Add(button_addScore);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button_addCourse);
            panel3.Controls.Add(button_clear);
            panel3.Controls.Add(button_add);
            panel3.Location = new Point(0, 415);
            panel3.Name = "panel3";
            panel3.Size = new Size(934, 197);
            panel3.TabIndex = 57;
            // 
            // button_clear_MangeStudent
            // 
            button_clear_MangeStudent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear_MangeStudent.BackColor = Color.Gray;
            button_clear_MangeStudent.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_clear_MangeStudent.ForeColor = Color.White;
            button_clear_MangeStudent.Location = new Point(589, 158);
            button_clear_MangeStudent.Name = "button_clear_MangeStudent";
            button_clear_MangeStudent.Size = new Size(109, 28);
            button_clear_MangeStudent.TabIndex = 29;
            button_clear_MangeStudent.Text = "Clear";
            button_clear_MangeStudent.UseVisualStyleBackColor = false;
            button_clear_MangeStudent.Click += button_clear_MangeStudent_Click;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.Red;
            button_delete.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(701, 158);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(109, 28);
            button_delete.TabIndex = 28;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_Update
            // 
            button_Update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Update.BackColor = Color.Green;
            button_Update.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_Update.ForeColor = Color.White;
            button_Update.Location = new Point(816, 158);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(109, 28);
            button_Update.TabIndex = 27;
            button_Update.Text = "Update";
            button_Update.UseVisualStyleBackColor = false;
            button_Update.Click += button_Update_Click;
            // 
            // comboBox_Course
            // 
            comboBox_Course.FormattingEnabled = true;
            comboBox_Course.Location = new Point(164, 46);
            comboBox_Course.Name = "comboBox_Course";
            comboBox_Course.Size = new Size(273, 23);
            comboBox_Course.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(8, 47);
            label3.Name = "label3";
            label3.Size = new Size(143, 18);
            label3.TabIndex = 25;
            label3.Text = "Selected Course :";
            // 
            // textBox_Score
            // 
            textBox_Score.Location = new Point(164, 75);
            textBox_Score.Name = "textBox_Score";
            textBox_Score.Size = new Size(130, 23);
            textBox_Score.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(931, 11);
            panel2.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(58, 19);
            label1.Name = "label1";
            label1.Size = new Size(93, 18);
            label1.TabIndex = 1;
            label1.Text = "Student Id :";
            // 
            // textBox_studentScoreId
            // 
            textBox_studentScoreId.Location = new Point(164, 17);
            textBox_studentScoreId.Name = "textBox_studentScoreId";
            textBox_studentScoreId.Size = new Size(130, 23);
            textBox_studentScoreId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(88, 75);
            label2.Name = "label2";
            label2.Size = new Size(63, 18);
            label2.TabIndex = 4;
            label2.Text = "Score :";
            // 
            // textBox_description
            // 
            textBox_description.Location = new Point(164, 105);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(411, 71);
            textBox_description.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(47, 105);
            label5.Name = "label5";
            label5.Size = new Size(104, 18);
            label5.TabIndex = 11;
            label5.Text = "Description :";
            // 
            // button_clearScore
            // 
            button_clearScore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clearScore.BackColor = Color.Silver;
            button_clearScore.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_clearScore.ForeColor = Color.White;
            button_clearScore.Location = new Point(1430, 243);
            button_clearScore.Name = "button_clearScore";
            button_clearScore.Size = new Size(109, 28);
            button_clearScore.TabIndex = 24;
            button_clearScore.Text = "Clear";
            button_clearScore.UseVisualStyleBackColor = false;
            // 
            // button_addScore
            // 
            button_addScore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_addScore.BackColor = Color.Green;
            button_addScore.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_addScore.ForeColor = Color.White;
            button_addScore.Location = new Point(1545, 243);
            button_addScore.Name = "button_addScore";
            button_addScore.Size = new Size(109, 28);
            button_addScore.TabIndex = 23;
            button_addScore.Text = "Add";
            button_addScore.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(2162, 339);
            button1.Name = "button1";
            button1.Size = new Size(109, 28);
            button1.TabIndex = 22;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            // 
            // button_addCourse
            // 
            button_addCourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_addCourse.BackColor = Color.Green;
            button_addCourse.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_addCourse.ForeColor = Color.White;
            button_addCourse.Location = new Point(2277, 339);
            button_addCourse.Name = "button_addCourse";
            button_addCourse.Size = new Size(109, 28);
            button_addCourse.TabIndex = 21;
            button_addCourse.Text = "Add";
            button_addCourse.UseVisualStyleBackColor = false;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Silver;
            button_clear.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(2897, 431);
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
            button_add.Location = new Point(3012, 431);
            button_add.Name = "button_add";
            button_add.Size = new Size(109, 28);
            button_add.TabIndex = 17;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            // 
            // radioButton_courseName
            // 
            radioButton_courseName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_courseName.AutoSize = true;
            radioButton_courseName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_courseName.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_courseName.Location = new Point(561, 65);
            radioButton_courseName.Name = "radioButton_courseName";
            radioButton_courseName.Size = new Size(119, 20);
            radioButton_courseName.TabIndex = 58;
            radioButton_courseName.Text = "Course Name";
            radioButton_courseName.UseVisualStyleBackColor = true;
            // 
            // ManageScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(radioButton_courseName);
            Controls.Add(panel3);
            Controls.Add(dataGridView_MaganeScore);
            Controls.Add(radioButton_name);
            Controls.Add(radioButton_StudentId);
            Controls.Add(textBox_scoreSearchBox);
            Controls.Add(button_searchScore);
            Controls.Add(panel1);
            Name = "ManageScoreForm";
            Text = "ManageScoreForm";
            Load += ManageScoreForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_MaganeScore).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton_name;
        private RadioButton radioButton_StudentId;
        private TextBox textBox_scoreSearchBox;
        private Button button_searchScore;
        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView_MaganeScore;
        private Panel panel3;
        private ComboBox comboBox_Course;
        private Label label3;
        private TextBox textBox_Score;
        private Panel panel2;
        private Label label1;
        private TextBox textBox_studentScoreId;
        private Label label2;
        private TextBox textBox_description;
        private Label label5;
        private Button button_clearScore;
        private Button button_addScore;
        private Button button1;
        private Button button_addCourse;
        private Button button_clear;
        private Button button_add;
        private Button button_clear_MangeStudent;
        private Button button_delete;
        private Button button_Update;
        private RadioButton radioButton_courseName;
    }
}