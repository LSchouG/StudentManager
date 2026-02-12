namespace StudentManager
{
    partial class NewScoreForm
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
            panel1 = new Panel();
            label4 = new Label();
            label7 = new Label();
            dataGridView_StudentList = new DataGridView();
            button1 = new Button();
            button_addCourse = new Button();
            textBox_Score = new TextBox();
            label1 = new Label();
            textBox_studentScoreId = new TextBox();
            label2 = new Label();
            textBox_description = new TextBox();
            label5 = new Label();
            panel3 = new Panel();
            comboBox_Course = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            button_clearScore = new Button();
            button_addScore = new Button();
            button_clear = new Button();
            button_add = new Button();
            dataGridView_ScoreList = new DataGridView();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_StudentList).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ScoreList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 49);
            panel1.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(654, 18);
            label4.Name = "label4";
            label4.Size = new Size(102, 24);
            label4.TabIndex = 21;
            label4.Text = "Score List";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(174, 18);
            label7.Name = "label7";
            label7.Size = new Size(118, 24);
            label7.TabIndex = 20;
            label7.Text = "Student List";
            // 
            // dataGridView_StudentList
            // 
            dataGridView_StudentList.AllowUserToAddRows = false;
            dataGridView_StudentList.AllowUserToDeleteRows = false;
            dataGridView_StudentList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_StudentList.BackgroundColor = Color.Gainsboro;
            dataGridView_StudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_StudentList.Location = new Point(3, 53);
            dataGridView_StudentList.Name = "dataGridView_StudentList";
            dataGridView_StudentList.Size = new Size(460, 368);
            dataGridView_StudentList.TabIndex = 25;
            dataGridView_StudentList.Click += dataGridView_StudentList_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1428, 242);
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
            button_addCourse.Location = new Point(1543, 242);
            button_addCourse.Name = "button_addCourse";
            button_addCourse.Size = new Size(109, 28);
            button_addCourse.TabIndex = 21;
            button_addCourse.Text = "Add";
            button_addCourse.UseVisualStyleBackColor = false;
            // 
            // textBox_Score
            // 
            textBox_Score.Location = new Point(164, 75);
            textBox_Score.Name = "textBox_Score";
            textBox_Score.Size = new Size(130, 23);
            textBox_Score.TabIndex = 5;
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
            textBox_description.Size = new Size(422, 71);
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
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            panel3.Location = new Point(0, 422);
            panel3.Name = "panel3";
            panel3.Size = new Size(934, 190);
            panel3.TabIndex = 27;
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 10);
            panel2.TabIndex = 20;
            // 
            // button_clearScore
            // 
            button_clearScore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clearScore.BackColor = Color.Silver;
            button_clearScore.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_clearScore.ForeColor = Color.White;
            button_clearScore.Location = new Point(696, 146);
            button_clearScore.Name = "button_clearScore";
            button_clearScore.Size = new Size(109, 28);
            button_clearScore.TabIndex = 24;
            button_clearScore.Text = "Clear";
            button_clearScore.UseVisualStyleBackColor = false;
            button_clearScore.Click += button_clearScore_Click;
            // 
            // button_addScore
            // 
            button_addScore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_addScore.BackColor = Color.Green;
            button_addScore.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_addScore.ForeColor = Color.White;
            button_addScore.Location = new Point(811, 146);
            button_addScore.Name = "button_addScore";
            button_addScore.Size = new Size(109, 28);
            button_addScore.TabIndex = 23;
            button_addScore.Text = "Add";
            button_addScore.UseVisualStyleBackColor = false;
            button_addScore.Click += button_addScore_Click;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Silver;
            button_clear.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(2163, 334);
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
            button_add.Location = new Point(2278, 334);
            button_add.Name = "button_add";
            button_add.Size = new Size(109, 28);
            button_add.TabIndex = 17;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            // 
            // dataGridView_ScoreList
            // 
            dataGridView_ScoreList.AllowUserToAddRows = false;
            dataGridView_ScoreList.AllowUserToDeleteRows = false;
            dataGridView_ScoreList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_ScoreList.BackgroundColor = Color.Gainsboro;
            dataGridView_ScoreList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ScoreList.Location = new Point(478, 54);
            dataGridView_ScoreList.Name = "dataGridView_ScoreList";
            dataGridView_ScoreList.Size = new Size(455, 368);
            dataGridView_ScoreList.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(0, 71, 160);
            panel4.Location = new Point(465, 47);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 385);
            panel4.TabIndex = 21;
            // 
            // NewScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(panel4);
            Controls.Add(dataGridView_ScoreList);
            Controls.Add(panel1);
            Controls.Add(dataGridView_StudentList);
            Controls.Add(panel3);
            Name = "NewScoreForm";
            Load += NewScoreForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_StudentList).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ScoreList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView_StudentList;
        private Button button1;
        private Button button_addCourse;
        private TextBox textBox_Score;
        private Label label1;
        private TextBox textBox_studentScoreId;
        private Label label2;
        private TextBox textBox_description;
        private Label label5;
        private Panel panel3;
        private Panel panel2;
        private Button button_clear;
        private Button button_add;
        private ComboBox comboBox_Course;
        private Label label3;
        private Button button_clearScore;
        private Button button_addScore;
        private DataGridView dataGridView_ScoreList;
        private Panel panel4;
        private Label label4;
    }
}