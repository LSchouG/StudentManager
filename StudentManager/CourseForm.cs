using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class CourseForm : Form
    {
        CourseClass course = new CourseClass();
        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {

            showTable();

        }
        // Show courses list in Datagridview
        public void showTable()
        {
            DataTable table = course.getCourseList();

            // Set the row height to 24
            dataGridView_courses.RowTemplate.Height = 80;

            dataGridView_courses.AutoGenerateColumns = true;
            dataGridView_courses.DataSource = table;

        }

        private void button_addCourse_Click(object sender, EventArgs e)
        {
            string courseName = textBox_courseName.Text;
            string courseDescription = textBox_description.Text;

            int courseHour;
            if (int.TryParse(textBox_hours.Text, out courseHour))
            {
                // OK – courseHour is usable here
            }
            else
            {
                MessageBox.Show("Please enter a valid number for course hours.");
                return;
            }

            if (verify())
            {
                try
                {
                    if (course.insertCourse(courseName, courseHour, courseDescription))
                    {
                        showTable();
                        MessageBox.Show("New Course Added", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_courseName.Clear();
                        textBox_hours.Clear();
                        textBox_description.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool verify()
        {
            // Try to parse hours into a temp variable
            if (string.IsNullOrWhiteSpace(textBox_courseName.Text) ||
                string.IsNullOrWhiteSpace(textBox_description.Text) ||
                !int.TryParse(textBox_hours.Text, out _)) // `_` discards the parsed int
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_courseName.Clear();
            textBox_hours.Clear();
            textBox_description.Clear();
        }
    }
}
