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
        public PrintStudent()
        {
            InitializeComponent();
        }

        private void PrintStudent_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM `student`"));
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


    }
}
