namespace StudentManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();

        }












        // Form Load Event
        private void Form1_Load(object sender, EventArgs e)
        {

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
        private void button_registration_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void button_manageStudent_Click(object sender, EventArgs e)
        {
            // TODO
        }
        private void button_studentStatus_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void button_StudentPrint_Click(object sender, EventArgs e)
        {
            // TODO
        }

        // Course Buttons
        private void button_course_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_courseSubMenu);
        }

        private void button_addCourse_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void button_manageCourse_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void button_coursePrint_Click(object sender, EventArgs e)
        {
            //TODO
        }

        // Score Buttons
        private void button_Score_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_scoreSubMenu);
        }

        private void button_addScore_Click(object sender, EventArgs e)
        {
            // TODO
        }
        private void button_manageScore_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // TODO
        }

        // Exit Button
        private void button_Exit_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
