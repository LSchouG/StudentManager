using DGVPrinterHelper;
using Microsoft.VisualBasic.Devices;
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
    public partial class PrintStudent : Form
    {
        StudentClass student = new StudentClass();
        DGVPrinter printer = new DGVPrinter();
        CourseClass course = new CourseClass();
        public PrintStudent()
        {
            InitializeComponent();
        }

        private void PrintStudent_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM `student`"));
            showCombobox();
        }
        // funtion to display the combobox items
        private void showCombobox()
        {
            // populate the combobox with courses name
            DataTable table = course.getCourseList();

            // Create new row for all
            DataRow row = table.NewRow();
            row["CourseId"] = 0;
            row["CourseName"] = "All";

            // Insert at top
            table.Rows.InsertAt(row, 0);

            comboBox_class.DataSource = table;
            comboBox_class.DisplayMember = "CourseName";
            comboBox_class.ValueMember = "CourseId";

            // Select "All" by default
            comboBox_class.SelectedIndex = 0;

        }
        // function to display the datagridview
        public void showData(MySqlCommand command)
        {
            DataTable table = student.GetList(command);

            // Fix null or empty images
            foreach (DataRow row in table.Rows)
            {
                if (row["StdImage"] == DBNull.Value ||
                    ((byte[])row["StdImage"]).Length == 0)
                {
                    row["StdImage"] = DBNull.Value;
                }
            }

            // Set row height
            dataGridView_student.RowTemplate.Height = 80;

            // Bind data
            dataGridView_student.ReadOnly = true;
            dataGridView_student.AutoGenerateColumns = true;
            dataGridView_student.DataSource = table;

            // Set image column
            if (dataGridView_student.Columns["StdImage"] is DataGridViewImageColumn imgCol)
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgCol.DefaultCellStyle.NullValue = null;
            }

            // Optional: auto-size columns
            dataGridView_student.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void radioButton_all_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_all.Checked)
            {
                showData(new MySqlCommand("SELECT * FROM `student`"));
            }
        }
        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_male.Checked)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE `StdGender` = @gender");
                command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = "Male";
                showData(command);
            }
        }

        private void radioButton_female_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_female.Checked)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE `StdGender` = @gender");
                command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = "Female";
                showData(command);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM `student`";

            // Gender filter
            if (radioButton_male.Checked)
                selectQuery += " WHERE StdGender = 'Male'";
            else if (radioButton_female.Checked)
                selectQuery += " WHERE StdGender = 'Female'";

            // Optional: filter by course
            string course = comboBox_class.Text;
            if (course != "All")
            {
                if (selectQuery.Contains("WHERE"))
                    selectQuery += " AND StdCourse = @course";
                else
                    selectQuery += " WHERE StdCourse = @course";
            }

            MySqlCommand command = new MySqlCommand(selectQuery);

            if (course != "All")
            {
                command.Parameters.Add("@course", MySqlDbType.VarChar).Value = course;
            }


            showData(command);
        }



        private void button_print_Click(object sender, EventArgs e)
        {
            // Hide image column (CRITICAL)
            var imgCol = dataGridView_student.Columns["StdImage"];
            bool wasVisible = imgCol.Visible;
            imgCol.Visible = false;

            printer.Title = "Udemy Student list";
            printer.SubTitle = $"Date: {DateTime.Now:d}";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoWrap;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;

            printer.printDocument.DefaultPageSettings.Landscape = true;

            printer.PrintDataGridView(dataGridView_student);

            // Restore image column
            imgCol.Visible = wasVisible;
        }


    }
}
