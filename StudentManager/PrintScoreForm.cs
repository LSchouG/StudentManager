using DGVPrinterHelper;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace StudentManager
{
    public partial class PrintScoreForm : Form
    {
        ScoreClass score = new ScoreClass();
        CourseClass course = new CourseClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintScoreForm()
        {
            InitializeComponent();
        }

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT score.StudentID, student.StdFirstName, score.CourseName, score.Score, score.Description " +
                                      "FROM score INNER JOIN student ON score.StudentID = student.StdId"));
            showCombobox();
            radioButton_all.Checked = true;
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

            comboBox_score.DataSource = table;
            comboBox_score.DisplayMember = "CourseName";
            comboBox_score.ValueMember = "CourseId";

            // Select "All" by default
            comboBox_score.SelectedIndex = 0;

        }
        // function to display the datagridview
        public void showData(MySqlCommand command)
        {
            DataTable table = score.getScoreList(command);

            // Bind data
            dataGridView_score.ReadOnly = true;
            dataGridView_score.AutoGenerateColumns = true;
            dataGridView_score.DataSource = table;

            // Optional: auto-size columns
            dataGridView_score.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }




        private void button_searchPrintScore_Click(object sender, EventArgs e)
        {
            string query =
                "SELECT score.StudentID, student.StdFirstName, score.CourseName, score.Score, score.Description " +
                "FROM score " +
                "INNER JOIN student ON score.StudentID = student.StdId";

            MySqlCommand command = new MySqlCommand();
            bool hasWhere = false;

            // Gender filter
            string gender = "";
            if (radioButton_printSearchMale.Checked)
                gender = "Male";
            else if (radioButton_printSearchFemale.Checked)
                gender = "Female";

            if (!radioButton_printSearchAll.Checked)
            {
                query += " WHERE student.StdGender = @gender";
                command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                hasWhere = true;
            }

            // Course filter
            int courseId = Convert.ToInt32(comboBox_score.SelectedValue);
            if (courseId != 0) // 0 = All
            {
                if (hasWhere)
                    query += " AND score.CourseName = @course";
                else
                    query += " WHERE score.CourseName = @course";

                command.Parameters.Add("@course", MySqlDbType.VarChar).Value = comboBox_score.Text;
            }

            command.CommandText = query;
            showData(command);
        }

        private void button_printScore_Click(object sender, EventArgs e)
        {
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

            printer.PrintDataGridView(dataGridView_score);

        }
    }
}
