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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel_slide = new Panel();
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
            button_studentStatus = new Button();
            button_manageStudent = new Button();
            button_registration = new Button();
            button_student = new Button();
            panel_logo = new Panel();
            label3 = new Label();
            label2 = new Label();
            M = new Label();
            panel_cover = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label12 = new Label();
            label10 = new Label();
            label11 = new Label();
            comboBox1 = new ComboBox();
            label_totalStudents = new Label();
            label_female = new Label();
            label_male = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label_role = new Label();
            label_user = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label13 = new Label();
            panel_slide.SuspendLayout();
            panel_scoreSubMenu.SuspendLayout();
            panel_courseSubMenu.SuspendLayout();
            panel_studentSubMenu.SuspendLayout();
            panel_logo.SuspendLayout();
            panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_slide
            // 
            panel_slide.AutoScroll = true;
            panel_slide.BackColor = Color.FromArgb(0, 71, 160);
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
            // button_Exit
            // 
            button_Exit.Dock = DockStyle.Top;
            button_Exit.FlatAppearance.BorderSize = 0;
            button_Exit.FlatStyle = FlatStyle.Flat;
            button_Exit.ForeColor = Color.White;
            button_Exit.Location = new Point(0, 753);
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
            panel_scoreSubMenu.Location = new Point(0, 602);
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
            button7.Click += button7_Click;
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
            button_Score.Location = new Point(0, 552);
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
            panel_courseSubMenu.Location = new Point(0, 402);
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
            button_course.Location = new Point(0, 352);
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
            panel_studentSubMenu.Controls.Add(button_studentStatus);
            panel_studentSubMenu.Controls.Add(button_manageStudent);
            panel_studentSubMenu.Controls.Add(button_registration);
            panel_studentSubMenu.Dock = DockStyle.Top;
            panel_studentSubMenu.Location = new Point(0, 150);
            panel_studentSubMenu.Name = "panel_studentSubMenu";
            panel_studentSubMenu.Size = new Size(183, 202);
            panel_studentSubMenu.TabIndex = 2;
            // 
            // button_StudentPrint
            // 
            button_StudentPrint.Dock = DockStyle.Top;
            button_StudentPrint.FlatAppearance.BorderSize = 0;
            button_StudentPrint.FlatStyle = FlatStyle.Flat;
            button_StudentPrint.ForeColor = Color.White;
            button_StudentPrint.Location = new Point(0, 150);
            button_StudentPrint.Name = "button_StudentPrint";
            button_StudentPrint.Padding = new Padding(35, 0, 0, 0);
            button_StudentPrint.Size = new Size(183, 50);
            button_StudentPrint.TabIndex = 3;
            button_StudentPrint.Text = "Print";
            button_StudentPrint.TextAlign = ContentAlignment.MiddleLeft;
            button_StudentPrint.UseVisualStyleBackColor = true;
            button_StudentPrint.Click += button_StudentPrint_Click;
            // 
            // button_studentStatus
            // 
            button_studentStatus.Dock = DockStyle.Top;
            button_studentStatus.FlatAppearance.BorderSize = 0;
            button_studentStatus.FlatStyle = FlatStyle.Flat;
            button_studentStatus.ForeColor = Color.White;
            button_studentStatus.Location = new Point(0, 100);
            button_studentStatus.Name = "button_studentStatus";
            button_studentStatus.Padding = new Padding(35, 0, 0, 0);
            button_studentStatus.Size = new Size(183, 50);
            button_studentStatus.TabIndex = 2;
            button_studentStatus.Text = "Status";
            button_studentStatus.TextAlign = ContentAlignment.MiddleLeft;
            button_studentStatus.UseVisualStyleBackColor = true;
            button_studentStatus.Click += button_studentStatus_Click;
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
            panel_cover.Controls.Add(pictureBox2);
            panel_cover.Controls.Add(panel3);
            panel_cover.Controls.Add(panel2);
            panel_cover.Controls.Add(panel1);
            panel_cover.Dock = DockStyle.Fill;
            panel_cover.Location = new Point(200, 0);
            panel_cover.Name = "panel_cover";
            panel_cover.Size = new Size(934, 611);
            panel_cover.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.teen_girls_studying_classroom;
            pictureBox2.Location = new Point(0, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(934, 447);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label_totalStudents);
            panel3.Controls.Add(label_female);
            panel3.Controls.Add(label_male);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 546);
            panel3.Name = "panel3";
            panel3.Size = new Size(934, 65);
            panel3.TabIndex = 5;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(618, 10);
            label12.Name = "label12";
            label12.Size = new Size(74, 15);
            label12.TabIndex = 13;
            label12.Text = "Select Class :";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(766, 39);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 12;
            label10.Text = "Female :";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(705, 39);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 11;
            label11.Text = "Male  :";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(698, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 23);
            comboBox1.TabIndex = 10;
            // 
            // label_totalStudents
            // 
            label_totalStudents.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_totalStudents.AutoSize = true;
            label_totalStudents.ForeColor = Color.White;
            label_totalStudents.Location = new Point(105, 15);
            label_totalStudents.Name = "label_totalStudents";
            label_totalStudents.Size = new Size(25, 15);
            label_totalStudents.TabIndex = 9;
            label_totalStudents.Text = "100";
            // 
            // label_female
            // 
            label_female.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_female.AutoSize = true;
            label_female.ForeColor = Color.White;
            label_female.Location = new Point(132, 39);
            label_female.Name = "label_female";
            label_female.Size = new Size(19, 15);
            label_female.TabIndex = 8;
            label_female.Text = "50";
            // 
            // label_male
            // 
            label_male.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_male.AutoSize = true;
            label_male.ForeColor = Color.White;
            label_male.Location = new Point(67, 39);
            label_male.Name = "label_male";
            label_male.Size = new Size(19, 15);
            label_male.TabIndex = 7;
            label_male.Text = "50";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(84, 39);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 6;
            label9.Text = "Female :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(23, 39);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 5;
            label8.Text = "Male  :";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(23, 15);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 4;
            label7.Text = "Total Students :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 56);
            panel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 71, 160);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label_role);
            panel4.Controls.Add(label_user);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(934, 56);
            panel4.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(856, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label_role
            // 
            label_role.AutoSize = true;
            label_role.ForeColor = Color.White;
            label_role.Location = new Point(92, 28);
            label_role.Name = "label_role";
            label_role.Size = new Size(43, 15);
            label_role.TabIndex = 3;
            label_role.Text = "Admin";
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.ForeColor = Color.White;
            label_user.Location = new Point(92, 14);
            label_user.Name = "label_user";
            label_user.Size = new Size(48, 15);
            label_user.TabIndex = 2;
            label_user.Text = "Mdemy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(47, 29);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 1;
            label5.Text = "Role  :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(23, 14);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 0;
            label6.Text = "Welcome :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(47, 29);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 1;
            label4.Text = "Role  :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 14);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome :";
            // 
            // panel1
            // 
            panel1.Controls.Add(label13);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 43);
            panel1.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(0, 71, 160);
            label13.Location = new Point(3, 9);
            label13.Name = "label13";
            label13.Size = new Size(166, 15);
            label13.TabIndex = 3;
            label13.Text = "Mdemy Internatianal School ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 611);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_slide;
        private Button button_student;
        private Panel panel_logo;
        private Panel panel_studentSubMenu;
        private Button button_StudentPrint;
        private Button button_studentStatus;
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
        private Panel panel3;
        private Panel panel2;
        private Label label4;
        private Label label1;
        private Panel panel1;
        private Panel panel4;
        private Label label_role;
        private Label label_user;
        private Label label5;
        private Label label6;
        private Label label_male;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label_totalStudents;
        private Label label_female;
        private PictureBox pictureBox1;
        private Label label12;
        private Label label10;
        private Label label11;
        private ComboBox comboBox1;
        private PictureBox pictureBox2;
        private Label label13;
    }
}
