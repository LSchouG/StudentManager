using DGVPrinterHelper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class PrintCourseForm : Form
    {
        CourseClass course = new CourseClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintCourseForm()
        {
            InitializeComponent();
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM `course`"));
        }
        // function to display the datagridview
        public void showData(MySqlCommand command)
        {
            DataTable table = course.getCourseListByCommand(command);


            // Bind data
            dataGridView_course.ReadOnly = true;
            dataGridView_course.AutoGenerateColumns = true;
            dataGridView_course.DataSource = table;

            // Optional: auto-size columns
            dataGridView_course.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            // CheckBox the radio button
            string searchText = textBox_courseSearchBox.Text.Trim();
            MySqlCommand command = null;


            if (radioButton_StudentId.Checked)
            {
                if (!int.TryParse(searchText, out int id))
                {
                    MessageBox.Show("Please enter a valid Course ID.");
                    return;
                }
                command = new MySqlCommand("SELECT * FROM course WHERE CourseId = @id");
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(searchText);
            }
            if (radioButton_name.Checked)
            {
                command = new MySqlCommand("SELECT * FROM course WHERE CourseName LIKE @cName");
                command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = "%" + searchText + "%";
            }

            if (radioButton_hours.Checked)
            {
                if (!int.TryParse(searchText, out int hours))
                {
                    MessageBox.Show("Please enter a valid number for hours.");
                    return;
                }

                command = new MySqlCommand("SELECT * FROM course WHERE CourseHour = @hours");
                command.Parameters.Add("@hours", MySqlDbType.VarChar).Value = searchText;
            }
            if (radioButton_description.Checked)
            {
                command = new MySqlCommand("SELECT * FROM course WHERE CourseDescription LIKE @cDescription");
                command.Parameters.Add("@cDescription", MySqlDbType.VarChar).Value = "%" + searchText + "%";
            }
             showData(command);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            printer.Title = "Udemy Course list";
            printer.SubTitle = $"Date: {DateTime.Now:d}";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoWrap;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;

            printer.printDocument.DefaultPageSettings.Landscape = true;

            printer.PrintDataGridView(dataGridView_course);
        }
    }
}
