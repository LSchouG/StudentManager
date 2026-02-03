namespace StudentManager
{
    partial class ManageCourseForm
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
            panel3 = new Panel();
            textBox_courseId = new TextBox();
            label3 = new Label();
            button_clearMC = new Button();
            button_delete = new Button();
            button1 = new Button();
            button_update = new Button();
            button_addCourse = new Button();
            textBox_hours = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            textBox_courseName = new TextBox();
            button_clear = new Button();
            label2 = new Label();
            button_add = new Button();
            textBox_description = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            dataGridView_courses = new DataGridView();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_courses).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(textBox_courseId);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button_clearMC);
            panel3.Controls.Add(button_delete);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button_update);
            panel3.Controls.Add(button_addCourse);
            panel3.Controls.Add(textBox_hours);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBox_courseName);
            panel3.Controls.Add(button_clear);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button_add);
            panel3.Controls.Add(textBox_description);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(2, 418);
            panel3.Name = "panel3";
            panel3.Size = new Size(934, 199);
            panel3.TabIndex = 27;
            // 
            // textBox_courseId
            // 
            textBox_courseId.Location = new Point(624, 27);
            textBox_courseId.Name = "textBox_courseId";
            textBox_courseId.ReadOnly = true;
            textBox_courseId.Size = new Size(130, 23);
            textBox_courseId.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(527, 29);
            label3.Name = "label3";
            label3.Size = new Size(91, 18);
            label3.TabIndex = 26;
            label3.Text = "Course Id :";
            // 
            // button_clearMC
            // 
            button_clearMC.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clearMC.BackColor = Color.Silver;
            button_clearMC.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_clearMC.ForeColor = Color.White;
            button_clearMC.Location = new Point(581, 155);
            button_clearMC.Name = "button_clearMC";
            button_clearMC.Size = new Size(109, 28);
            button_clearMC.TabIndex = 25;
            button_clearMC.Text = "Clear";
            button_clearMC.UseVisualStyleBackColor = false;
            button_clearMC.Click += button_clearMC_Click;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.Firebrick;
            button_delete.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(696, 155);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(109, 28);
            button_delete.TabIndex = 24;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1428, 251);
            button1.Name = "button1";
            button1.Size = new Size(109, 28);
            button1.TabIndex = 22;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_update.BackColor = Color.Green;
            button_update.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(811, 155);
            button_update.Name = "button_update";
            button_update.Size = new Size(109, 28);
            button_update.TabIndex = 23;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // button_addCourse
            // 
            button_addCourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_addCourse.BackColor = Color.Green;
            button_addCourse.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_addCourse.ForeColor = Color.White;
            button_addCourse.Location = new Point(1543, 251);
            button_addCourse.Name = "button_addCourse";
            button_addCourse.Size = new Size(109, 28);
            button_addCourse.TabIndex = 21;
            button_addCourse.Text = "Add";
            button_addCourse.UseVisualStyleBackColor = false;
            // 
            // textBox_hours
            // 
            textBox_hours.Location = new Point(384, 27);
            textBox_hours.Name = "textBox_hours";
            textBox_hours.Size = new Size(130, 23);
            textBox_hours.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Location = new Point(2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 10);
            panel2.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(127, 18);
            label1.TabIndex = 1;
            label1.Text = "Course  Name :";
            // 
            // textBox_courseName
            // 
            textBox_courseName.Location = new Point(166, 27);
            textBox_courseName.Name = "textBox_courseName";
            textBox_courseName.Size = new Size(130, 23);
            textBox_courseName.TabIndex = 2;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Silver;
            button_clear.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(2163, 343);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(109, 28);
            button_clear.TabIndex = 18;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(314, 29);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 4;
            label2.Text = "Hours :";
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.Green;
            button_add.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(2278, 343);
            button_add.Name = "button_add";
            button_add.Size = new Size(109, 28);
            button_add.TabIndex = 17;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            // 
            // textBox_description
            // 
            textBox_description.Location = new Point(166, 67);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(512, 71);
            textBox_description.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(49, 67);
            label5.Name = "label5";
            label5.Size = new Size(104, 18);
            label5.TabIndex = 11;
            label5.Text = "Description :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 49);
            panel1.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(381, 9);
            label7.Name = "label7";
            label7.Size = new Size(164, 24);
            label7.TabIndex = 20;
            label7.Text = "Manage  Course";
            // 
            // dataGridView_courses
            // 
            dataGridView_courses.AllowUserToAddRows = false;
            dataGridView_courses.AllowUserToDeleteRows = false;
            dataGridView_courses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_courses.BackgroundColor = Color.Gainsboro;
            dataGridView_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_courses.Location = new Point(-1, 51);
            dataGridView_courses.Name = "dataGridView_courses";
            dataGridView_courses.Size = new Size(934, 369);
            dataGridView_courses.TabIndex = 25;
            dataGridView_courses.CellContentClick += dataGridView_courses_CellContentClick;
            // 
            // ManageCourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridView_courses);
            Name = "ManageCourseForm";
            Text = "ManageCourseForm";
            Load += ManageCourseForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_courses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button button1;
        private Button button_addCourse;
        private TextBox textBox_hours;
        private Panel panel2;
        private Label label1;
        private TextBox textBox_courseName;
        private Button button_clear;
        private Label label2;
        private Button button_add;
        private TextBox textBox_description;
        private Label label5;
        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView_courses;
        private TextBox textBox_courseId;
        private Label label3;
        private Button button_clearMC;
        private Button button_delete;
        private Button button_update;
    }
}