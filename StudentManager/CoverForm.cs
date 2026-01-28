using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace StudentManager
{
    public partial class CoverForm : Form
    {
        public CoverForm()
        {
            InitializeComponent();
        }
        private void CoverForm_Load(object sender, EventArgs e)
        {
            StudentClass student = new StudentClass();
            string totalStudents = student.totalStudent();
            string totalMale = student.totalMaleStudents();
            string totalFemale = student.totalFemaleStudents();


            if (!string.IsNullOrWhiteSpace(totalStudents))
            {
                label_totalStudents.Text = totalStudents;
            }
            else
            {
                label_totalStudents.Text = "Load error";
            }

            if (!string.IsNullOrWhiteSpace(totalMale))
            {
                label_male.Text = totalMale;
            }
            else
            {
                label_male.Text = "Load error";
            }

            if (!string.IsNullOrWhiteSpace(totalFemale))
            {
                label_female.Text = totalFemale;
            }
            else
            {
                label_female.Text = "Load error";
            }
        }



    }
}
