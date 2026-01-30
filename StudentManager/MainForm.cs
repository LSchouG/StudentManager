namespace StudentManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();

        }












        // Form Load Event
        private void Form1_Load(object sender, EventArgs e)
        {
            openChildForm(new CoverForm());
            hideSubMenu();
        }

        private void customizeDesign()
        {
            panel_studentSubMenu.Visible = false;
            panel_courseSubMenu.Visible = false;
            panel_scoreSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel_courseSubMenu.Visible == true)
            {
                panel_courseSubMenu.Visible = false;
            }

            if (panel_scoreSubMenu.Visible == true)
            {
                panel_scoreSubMenu.Visible = false;
            }

            if (panel_studentSubMenu.Visible == true)
            {
                panel_studentSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }


        // Event Handlers for Buttons

        // Student Buttons
        private void button_student_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_studentSubMenu);
        }
        #region subMenuStudent
        private void button_registration_Click(object sender, EventArgs e)
        {
            // TODO
            openChildForm(new RegistationForm());
            hideSubMenu();
        }

        private void button_manageStudent_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentForm());
            hideSubMenu();
        }
        private void button_studentStatus_Click(object sender, EventArgs e)
        {
            // TODO
            hideSubMenu();
        }

        private void button_StudentPrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintStudent());
            hideSubMenu();
        }

        #endregion


        // Course Buttons
        private void button_course_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_courseSubMenu);
        }
        #region subMenuCourse
        private void button_addCourse_Click(object sender, EventArgs e)
        {
            //TODO
            hideSubMenu();
        }

        private void button_manageCourse_Click(object sender, EventArgs e)
        {
            //TODO
            hideSubMenu();
        }

        private void button_coursePrint_Click(object sender, EventArgs e)
        {
            //TODO
            hideSubMenu();
        }
        #endregion


        // Score Buttons
        private void button_Score_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_scoreSubMenu);
        }
        #region subMenuScore
        private void button_addScore_Click(object sender, EventArgs e)
        {
            // TODO
            hideSubMenu();
        }
        private void button_manageScore_Click(object sender, EventArgs e)
        {
            // TODO
            hideSubMenu();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new CoverForm());
            hideSubMenu();
        }

        // Exit Button
        private void button_Exit_Click(object sender, EventArgs e)
        {
            // TODO
        }

        #endregion

        // show regitserform in mainform
        private Form activForm = null;
        private void openChildForm(Form childForm)
        {
            if (activForm != null)
                activForm.Close();
            activForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_cover.Controls.Add(childForm);
            panel_cover.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
