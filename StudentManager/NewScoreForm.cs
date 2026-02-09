using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class NewScoreForm : Form
    {
        CourseClass course = new CourseClass();
        public NewScoreForm()
        {
            InitializeComponent();
        }

        private void NewScoreForm_Load(object sender, EventArgs e)
        {
            // populate the combobox with courses name
            DataTable table = course.getCourseList();

            comboBox_Course.DataSource = table;
            comboBox_Course.DisplayMember = "CourseName";
            comboBox_Course.ValueMember = "CourseId";
        }
    }
}
