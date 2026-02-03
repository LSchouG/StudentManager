namespace StudentManager
{
    partial class MainForm
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
            panel_slide = new Panel();
            button_dashboard = new Button();
            button_Exit = new Button();
            panel_scoreSubMenu = new Panel();
            button7 = new Button();
            button_manageScore = new Button();
            button_addScore = new Button();
            button_Score = new Button();
            panel_courseSubMenu = new Panel();
            button_coursePrint = new Button();
            button_manageCourse = new Button();
            button_addCourse = new Button();
            button_course = new Button();
            panel_studentSubMenu = new Panel();
            button_StudentPrint = new Button();
            button_manageStudent = new Button();
            button_registration = new Button();
            button_student = new Button();
            panel_logo = new Panel();
            label3 = new Label();
            label2 = new Label();
            M = new Label();
            panel_cover = new Panel();
            panel1 = new Panel();
            panel_main = new Panel();
            panel_slide.SuspendLayout();
            panel_scoreSubMenu.SuspendLayout();
            panel_courseSubMenu.SuspendLayout();
            panel_studentSubMenu.SuspendLayout();
            panel_logo.SuspendLayout();
            panel_cover.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_slide
            // 
            panel_slide.AutoScroll = true;
            panel_slide.BackColor = Color.FromArgb(0, 71, 160);
            panel_slide.Controls.Add(button_dashboard);
            panel_slide.Controls.Add(button_Exit);
            panel_slide.Controls.Add(panel_scoreSubMenu);
            panel_slide.Controls.Add(button_Score);
            panel_slide.Controls.Add(panel_courseSubMenu);
            panel_slide.Controls.Add(button_course);
            panel_slide.Controls.Add(panel_studentSubMenu);
            panel_slide.Controls.Add(button_student);
            panel_slide.Controls.Add(panel_logo);
            panel_slide.Dock = DockStyle.Left;
            panel_slide.Location = new Point(0, 0);
            panel_slide.Name = "panel_slide";
            panel_slide.Size = new Size(200, 611);
            panel_slide.TabIndex = 0;
            // 
            // button_dashboard
            // 
            button_dashboard.Dock = DockStyle.Top;
            button_dashboard.FlatAppearance.BorderSize = 0;
            button_dashboard.FlatStyle = FlatStyle.Flat;
            button_dashboard.ForeColor = Color.White;
            button_dashboard.Location = new Point(0, 707);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Padding = new Padding(10, 0, 0, 0);
            button_dashboard.Size = new Size(183, 50);
            button_dashboard.TabIndex = 8;
            button_dashboard.Text = "Dashboard";
            button_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            button_dashboard.UseVisualStyleBackColor = true;
            button_dashboard.Click += button_dashboard_Click;
            // 
            // button_Exit
            // 
            button_Exit.Dock = DockStyle.Bottom;
            button_Exit.FlatAppearance.BorderSize = 0;
            button_Exit.FlatStyle = FlatStyle.Flat;
            button_Exit.ForeColor = Color.White;
            button_Exit.Location = new Point(0, 757);
            button_Exit.Name = "button_Exit";
            button_Exit.Padding = new Padding(10, 0, 0, 0);
            button_Exit.Size = new Size(183, 50);
            button_Exit.TabIndex = 7;
            button_Exit.Text = "Exit";
            button_Exit.TextAlign = ContentAlignment.MiddleLeft;
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // panel_scoreSubMenu
            // 
            panel_scoreSubMenu.BackColor = Color.FromArgb(0, 71, 200);
            panel_scoreSubMenu.Controls.Add(button7);
            panel_scoreSubMenu.Controls.Add(button_manageScore);
            panel_scoreSubMenu.Controls.Add(button_addScore);
            panel_scoreSubMenu.Dock = DockStyle.Top;
            panel_scoreSubMenu.Location = new Point(0, 556);
            panel_scoreSubMenu.Name = "panel_scoreSubMenu";
            panel_scoreSubMenu.Size = new Size(183, 151);
            panel_scoreSubMenu.TabIndex = 6;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(0, 100);
            button7.Name = "button7";
            button7.Padding = new Padding(35, 0, 0, 0);
            button7.Size = new Size(183, 50);
            button7.TabIndex = 3;
            button7.Text = "Print";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            // 
            // button_manageScore
            // 
            button_manageScore.Dock = DockStyle.Top;
            button_manageScore.FlatAppearance.BorderSize = 0;
            button_manageScore.FlatStyle = FlatStyle.Flat;
            button_manageScore.ForeColor = Color.White;
            button_manageScore.Location = new Point(0, 50);
            button_manageScore.Name = "button_manageScore";
            button_manageScore.Padding = new Padding(35, 0, 0, 0);
            button_manageScore.Size = new Size(183, 50);
            button_manageScore.TabIndex = 1;
            button_manageScore.Text = "Manage Score";
            button_manageScore.TextAlign = ContentAlignment.MiddleLeft;
            button_manageScore.UseVisualStyleBackColor = true;
            button_manageScore.Click += button_manageScore_Click;
            // 
            // button_addScore
            // 
            button_addScore.Dock = DockStyle.Top;
            button_addScore.FlatAppearance.BorderSize = 0;
            button_addScore.FlatStyle = FlatStyle.Flat;
            button_addScore.ForeColor = Color.White;
            button_addScore.Location = new Point(0, 0);
            button_addScore.Name = "button_addScore";
            button_addScore.Padding = new Padding(35, 0, 0, 0);
            button_addScore.Size = new Size(183, 50);
            button_addScore.TabIndex = 0;
            button_addScore.Text = "Add Score";
            button_addScore.TextAlign = ContentAlignment.MiddleLeft;
            button_addScore.UseVisualStyleBackColor = true;
            button_addScore.Click += button_addScore_Click;
            // 
            // button_Score
            // 
            button_Score.Dock = DockStyle.Top;
            button_Score.FlatAppearance.BorderSize = 0;
            button_Score.FlatStyle = FlatStyle.Flat;
            button_Score.ForeColor = Color.White;
            button_Score.Location = new Point(0, 506);
            button_Score.Name = "button_Score";
            button_Score.Padding = new Padding(10, 0, 0, 0);
            button_Score.Size = new Size(183, 50);
            button_Score.TabIndex = 5;
            button_Score.Text = "Score";
            button_Score.TextAlign = ContentAlignment.MiddleLeft;
            button_Score.UseVisualStyleBackColor = true;
            button_Score.Click += button_Score_Click;
            // 
            // panel_courseSubMenu
            // 
            panel_courseSubMenu.BackColor = Color.FromArgb(0, 71, 200);
            panel_courseSubMenu.Controls.Add(button_coursePrint);
            panel_courseSubMenu.Controls.Add(button_manageCourse);
            panel_courseSubMenu.Controls.Add(button_addCourse);
            panel_courseSubMenu.Dock = DockStyle.Top;
            panel_courseSubMenu.Location = new Point(0, 356);
            panel_courseSubMenu.Name = "panel_courseSubMenu";
            panel_courseSubMenu.Size = new Size(183, 150);
            panel_courseSubMenu.TabIndex = 4;
            // 
            // button_coursePrint
            // 
            button_coursePrint.Dock = DockStyle.Top;
            button_coursePrint.FlatAppearance.BorderSize = 0;
            button_coursePrint.FlatStyle = FlatStyle.Flat;
            button_coursePrint.ForeColor = Color.White;
            button_coursePrint.Location = new Point(0, 100);
            button_coursePrint.Name = "button_coursePrint";
            button_coursePrint.Padding = new Padding(35, 0, 0, 0);
            button_coursePrint.Size = new Size(183, 50);
            button_coursePrint.TabIndex = 3;
            button_coursePrint.Text = "Print";
            button_coursePrint.TextAlign = ContentAlignment.MiddleLeft;
            button_coursePrint.UseVisualStyleBackColor = true;
            button_coursePrint.Click += button_coursePrint_Click;
            // 
            // button_manageCourse
            // 
            button_manageCourse.Dock = DockStyle.Top;
            button_manageCourse.FlatAppearance.BorderSize = 0;
            button_manageCourse.FlatStyle = FlatStyle.Flat;
            button_manageCourse.ForeColor = Color.White;
            button_manageCourse.Location = new Point(0, 50);
            button_manageCourse.Name = "button_manageCourse";
            button_manageCourse.Padding = new Padding(35, 0, 0, 0);
            button_manageCourse.Size = new Size(183, 50);
            button_manageCourse.TabIndex = 1;
            button_manageCourse.Text = "Manage Course";
            button_manageCourse.TextAlign = ContentAlignment.MiddleLeft;
            button_manageCourse.UseVisualStyleBackColor = true;
            button_manageCourse.Click += button_manageCourse_Click;
            // 
            // button_addCourse
            // 
            button_addCourse.Dock = DockStyle.Top;
            button_addCourse.FlatAppearance.BorderSize = 0;
            button_addCourse.FlatStyle = FlatStyle.Flat;
            button_addCourse.ForeColor = Color.White;
            button_addCourse.Location = new Point(0, 0);
            button_addCourse.Name = "button_addCourse";
            button_addCourse.Padding = new Padding(35, 0, 0, 0);
            button_addCourse.Size = new Size(183, 50);
            button_addCourse.TabIndex = 0;
            button_addCourse.Text = "Add Course";
            button_addCourse.TextAlign = ContentAlignment.MiddleLeft;
            button_addCourse.UseVisualStyleBackColor = true;
            button_addCourse.Click += button_addCourse_Click;
            // 
            // button_course
            // 
            button_course.Dock = DockStyle.Top;
            button_course.FlatAppearance.BorderSize = 0;
            button_course.FlatStyle = FlatStyle.Flat;
            button_course.ForeColor = Color.White;
            button_course.Location = new Point(0, 306);
            button_course.Name = "button_course";
            button_course.Padding = new Padding(10, 0, 0, 0);
            button_course.Size = new Size(183, 50);
            button_course.TabIndex = 3;
            button_course.Text = "Course";
            button_course.TextAlign = ContentAlignment.MiddleLeft;
            button_course.UseVisualStyleBackColor = true;
            button_course.Click += button_course_Click;
            // 
            // panel_studentSubMenu
            // 
            panel_studentSubMenu.BackColor = Color.FromArgb(0, 71, 200);
            panel_studentSubMenu.Controls.Add(button_StudentPrint);
            panel_studentSubMenu.Controls.Add(button_manageStudent);
            panel_studentSubMenu.Controls.Add(button_registration);
            panel_studentSubMenu.Dock = DockStyle.Top;
            panel_studentSubMenu.Location = new Point(0, 150);
            panel_studentSubMenu.Name = "panel_studentSubMenu";
            panel_studentSubMenu.Size = new Size(183, 156);
            panel_studentSubMenu.TabIndex = 2;
            // 
            // button_StudentPrint
            // 
            button_StudentPrint.Dock = DockStyle.Top;
            button_StudentPrint.FlatAppearance.BorderSize = 0;
            button_StudentPrint.FlatStyle = FlatStyle.Flat;
            button_StudentPrint.ForeColor = Color.White;
            button_StudentPrint.Location = new Point(0, 100);
            button_StudentPrint.Name = "button_StudentPrint";
            button_StudentPrint.Padding = new Padding(35, 0, 0, 0);
            button_StudentPrint.Size = new Size(183, 50);
            button_StudentPrint.TabIndex = 3;
            button_StudentPrint.Text = "Print";
            button_StudentPrint.TextAlign = ContentAlignment.MiddleLeft;
            button_StudentPrint.UseVisualStyleBackColor = true;
            button_StudentPrint.Click += button_StudentPrint_Click;
            // 
            // button_manageStudent
            // 
            button_manageStudent.Dock = DockStyle.Top;
            button_manageStudent.FlatAppearance.BorderSize = 0;
            button_manageStudent.FlatStyle = FlatStyle.Flat;
            button_manageStudent.ForeColor = Color.White;
            button_manageStudent.Location = new Point(0, 50);
            button_manageStudent.Name = "button_manageStudent";
            button_manageStudent.Padding = new Padding(35, 0, 0, 0);
            button_manageStudent.Size = new Size(183, 50);
            button_manageStudent.TabIndex = 1;
            button_manageStudent.Text = "Manage Student";
            button_manageStudent.TextAlign = ContentAlignment.MiddleLeft;
            button_manageStudent.UseVisualStyleBackColor = true;
            button_manageStudent.Click += button_manageStudent_Click;
            // 
            // button_registration
            // 
            button_registration.Dock = DockStyle.Top;
            button_registration.FlatAppearance.BorderSize = 0;
            button_registration.FlatStyle = FlatStyle.Flat;
            button_registration.ForeColor = Color.White;
            button_registration.Location = new Point(0, 0);
            button_registration.Name = "button_registration";
            button_registration.Padding = new Padding(35, 0, 0, 0);
            button_registration.Size = new Size(183, 50);
            button_registration.TabIndex = 0;
            button_registration.Text = "Registration";
            button_registration.TextAlign = ContentAlignment.MiddleLeft;
            button_registration.UseVisualStyleBackColor = true;
            button_registration.Click += button_registration_Click;
            // 
            // button_student
            // 
            button_student.Dock = DockStyle.Top;
            button_student.FlatAppearance.BorderSize = 0;
            button_student.FlatStyle = FlatStyle.Flat;
            button_student.ForeColor = Color.White;
            button_student.Location = new Point(0, 100);
            button_student.Name = "button_student";
            button_student.Padding = new Padding(10, 0, 0, 0);
            button_student.Size = new Size(183, 50);
            button_student.TabIndex = 0;
            button_student.Text = "Student";
            button_student.TextAlign = ContentAlignment.MiddleLeft;
            button_student.UseVisualStyleBackColor = true;
            button_student.Click += button_student_Click;
            // 
            // panel_logo
            // 
            panel_logo.Controls.Add(label3);
            panel_logo.Controls.Add(label2);
            panel_logo.Controls.Add(M);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(183, 100);
            panel_logo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(55, 71);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 2;
            label3.Text = "Mdemy school";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 54);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 1;
            label2.Text = "Welcome from ";
            // 
            // M
            // 
            M.AutoSize = true;
            M.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            M.ForeColor = Color.White;
            M.Location = new Point(55, 0);
            M.Name = "M";
            M.Size = new Size(66, 54);
            M.TabIndex = 1;
            M.Text = "M";
            // 
            // panel_cover
            // 
            panel_cover.Controls.Add(panel1);
            panel_cover.Dock = DockStyle.Fill;
            panel_cover.Location = new Point(200, 0);
            panel_cover.Name = "panel_cover";
            panel_cover.Size = new Size(935, 611);
            panel_cover.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel_main);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 43);
            panel1.TabIndex = 3;
            // 
            // panel_main
            // 
            panel_main.Location = new Point(0, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(934, 611);
            panel_main.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 611);
            Controls.Add(panel_cover);
            Controls.Add(panel_slide);
            MinimumSize = new Size(1150, 650);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += Form1_Load;
            panel_slide.ResumeLayout(false);
            panel_scoreSubMenu.ResumeLayout(false);
            panel_courseSubMenu.ResumeLayout(false);
            panel_studentSubMenu.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            panel_cover.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_slide;
        private Button button_student;
        private Panel panel_logo;
        private Panel panel_studentSubMenu;
        private Button button_StudentPrint;
        private Button button_manageStudent;
        private Button button_registration;
        private Panel panel_scoreSubMenu;
        private Button button7;
        private Button button_manageScore;
        private Button button_addScore;
        private Button button_Score;
        private Panel panel_courseSubMenu;
        private Button button_coursePrint;
        private Button button_manageCourse;
        private Button button_addCourse;
        private Button button_course;
        private Button button_Exit;
        private Panel panel_cover;
        private Label M;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel_main;
        private Button button_dashboard;
    }
}
