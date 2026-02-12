using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class ManageCourseForm : Form
    {
        CourseClass course = new CourseClass();
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        // Show courses list in Datagridview
        public void showTable()
        {
            DataTable table = course.getCourseList();

            // Set the row height to 24
            // dataGridView_courses.RowTemplate.Height = 80;

            dataGridView_courses.AutoGenerateColumns = true;
            dataGridView_courses.DataSource = table;

        }
        private bool verify()
        {
            // Try to parse hours into a temp variable
            if (string.IsNullOrWhiteSpace(textBox_courseName.Text) ||
                string.IsNullOrWhiteSpace(textBox_description.Text) ||
                !int.TryParse(textBox_hours.Text, out _) ||
                !int.TryParse(textBox_courseId.Text, out _))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
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

            int courseId;
            if (int.TryParse(textBox_courseId.Text, out courseId))
            {
                // OK – courseId is usable here
            }
            else
            {
                MessageBox.Show("Please enter a valid number for course Id.");
                return;
            }

            if (verify())
            {
                try
                {
                    if (course.UpdateCourse(courseId, courseName, courseHour, courseDescription))
                    {
                        showTable();
                        MessageBox.Show("New Course Updated", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_courseName.Clear();
                        textBox_hours.Clear();
                        textBox_description.Clear();
                        textBox_courseId.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_clearMC_Click(object sender, EventArgs e)
        {
            textBox_courseName.Clear();
            textBox_hours.Clear();
            textBox_description.Clear();
            textBox_courseId.Clear();
        }


        // Display course data 
        private void dataGridView_courses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_courses.CurrentRow == null) return;

            textBox_courseId.Text = dataGridView_courses.CurrentRow.Cells[0].Value?.ToString();
            textBox_courseName.Text = dataGridView_courses.CurrentRow.Cells[1].Value?.ToString();
            textBox_hours.Text = dataGridView_courses.CurrentRow.Cells[2].Value?.ToString();
            textBox_description.Text = dataGridView_courses.CurrentRow.Cells[3].Value?.ToString();
        }

        private void button_delete_Click_1(object sender, EventArgs e)
        {
            string courseName = textBox_courseName.Text;
            if (string.IsNullOrWhiteSpace(textBox_courseId.Text))
            {
                MessageBox.Show("Select a course to delete", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete course: " + courseName, "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(textBox_courseId.Text);

                try
                {
                    if (course.DeleteCourse(id))
                    {
                        showTable();
                        MessageBox.Show($"Deleted course: {courseName}", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Course could not be deleted.", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine(ex.Message);
                }
            }
        }
    }
}
