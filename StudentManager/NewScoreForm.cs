using Guna.UI2.WinForms.Suite;
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
    public partial class NewScoreForm : Form
    {
        CourseClass course = new CourseClass();
        StudentClass student = new StudentClass();
        ScoreClass score = new ScoreClass();
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

            // Display the student list on the datagridview
            showDatastudent(new MySqlCommand("SELECT `StdId`,`StdFirstName`, `StdLastName` FROM `student`"));
            // Display the Score list on the datagridview
            showDataScore(new MySqlCommand("SELECT * FROM `score`"));


        }

        // function to display the datagridview
        public void showDatastudent(MySqlCommand command)
        {
            // dipslay data for student
            DataTable tableStudent = student.GetList(command);


            // Bind data
            dataGridView_StudentList.ReadOnly = true;
            dataGridView_StudentList.AutoGenerateColumns = true;
            dataGridView_StudentList.DataSource = tableStudent;
        }
        // function to display the datagridview
        public void showDataScore(MySqlCommand command)
        {
            // dipslay data for Score
            DataTable tableScore = score.getScoreList(command);

            // Bind data
            dataGridView_ScoreList.ReadOnly = true;
            dataGridView_ScoreList.AutoGenerateColumns = true;
            dataGridView_ScoreList.DataSource = tableScore;


        }

        private void dataGridView_StudentList_Click(object sender, EventArgs e)
        {
            if (dataGridView_StudentList.CurrentRow == null) return;
            textBox_studentScoreId.Text = dataGridView_StudentList.CurrentRow.Cells[0].Value?.ToString();

            if (!int.TryParse(textBox_studentScoreId.Text.Trim(), out int studentId))
            {
                MessageBox.Show("Invalid Student ID");
                return;
            }
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE StudentID = @id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = studentId;

            showDataScore(command);
        }

        private void button_addScore_Click(object sender, EventArgs e)
        {
            //add student
            if (!int.TryParse(textBox_studentScoreId.Text.Trim(), out int studentId))
            {
                MessageBox.Show("Invalid Student ID");
                return;
            }
            string courseName = comboBox_Course.Text.Trim();
            if (!double.TryParse(textBox_Score.Text.Trim(), out double scoreValue))
            {
                MessageBox.Show("Invalid Score");
                return;
            }
            string description = textBox_description.Text.Trim();


            if (verify())
            {
                try

                {
                    if (score.insertScore(studentId, courseName, scoreValue, description))
                    {
                        showDatastudent(new MySqlCommand("SELECT `StdId`,`StdFirstName`, `StdLastName` FROM `student`"));
                        MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE StudentID = @id");
                        command.Parameters.Add("@id", MySqlDbType.Int32).Value = studentId;

                        showDataScore(command);
                        MessageBox.Show("New Score Added", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verify()
        {
            if (string.IsNullOrWhiteSpace(textBox_studentScoreId.Text) ||
                string.IsNullOrWhiteSpace(comboBox_Course.Text) ||
                string.IsNullOrWhiteSpace(textBox_Score.Text) ||
                string.IsNullOrWhiteSpace(textBox_description.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_clearScore_Click(object sender, EventArgs e)
        {
            textBox_studentScoreId.Clear();
            textBox_Score.Clear();
            textBox_description.Clear();
            // Display the student list on the datagridview
            showDatastudent(new MySqlCommand("SELECT `StdId`,`StdFirstName`, `StdLastName` FROM `student`"));
            // Display the Score list on the datagridview
            showDataScore(new MySqlCommand("SELECT * FROM `score`"));
        }
    }
}
