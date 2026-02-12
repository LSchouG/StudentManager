using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace StudentManager
{
    public partial class ManageScoreForm : Form
    {
        CourseClass course = new CourseClass();
        StudentClass student = new StudentClass();
        ScoreClass score = new ScoreClass();
        public ManageScoreForm()
        {
            InitializeComponent();
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {

            // populate the combobox with courses name
            DataTable table = course.getCourseList();

            comboBox_Course.DataSource = table;
            comboBox_Course.DisplayMember = "CourseName";
            comboBox_Course.ValueMember = "CourseId";

            // Display the Score list on the datagridview
            showDataScore(new MySqlCommand("SELECT score.StudentID, student.StdFirstName,  score.CourseName, score.Score, score.Description " +
                                           "FROM score INNER JOIN student ON score.StudentID = student.StdId;"));
        }
        // function to display the datagridview
        public void showDataScore(MySqlCommand command)
        {
            // dipslay data for Score
            DataTable tableScore = score.getScoreList(command);

            // Bind data
            dataGridView_MaganeScore.ReadOnly = true;
            dataGridView_MaganeScore.AutoGenerateColumns = true;
            dataGridView_MaganeScore.DataSource = tableScore;

        }
        private void button_searchScore_Click(object sender, EventArgs e)
        {
            string searchText = textBox_scoreSearchBox.Text.Trim();
            MySqlCommand command = null;

            if (radioButton_StudentId.Checked)
            {
                if (!int.TryParse(searchText, out int id))
                {
                    MessageBox.Show("Please enter a valid Student ID.");
                    return;
                }

                command = new MySqlCommand(
                    "SELECT student.StdFirstName, score.StudentID, score.CourseName, score.Score, score.Description " +
                    "FROM score INNER JOIN student ON score.StudentID = student.StdId " +
                    "WHERE score.StudentID = @id;"
                );

                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            }
            if (radioButton_name.Checked)
            {
                command = new MySqlCommand(
                    "SELECT student.StdFirstName, score.StudentID, score.CourseName, score.Score, score.Description " +
                    "FROM score INNER JOIN student ON score.StudentID = student.StdId " +
                    "WHERE student.StdFirstName LIKE @sName;"
                );

                command.Parameters.Add("@sName", MySqlDbType.VarChar).Value = "%" + searchText + "%";
            }
            if (radioButton_courseName.Checked)
            {
                command = new MySqlCommand(
                    "SELECT student.StdFirstName, score.StudentID, score.CourseName, score.Score, score.Description " +
                    "FROM score INNER JOIN student ON score.StudentID = student.StdId " +
                    "WHERE score.CourseName LIKE @cName;"
                );

                command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = "%" + searchText + "%";
            }

            if (command != null)
            {
                showDataScore(command);
            }
        }
        private void dataGridView_MaganeScore_Click(object sender, EventArgs e)
        {
            if (dataGridView_MaganeScore.CurrentRow == null) return;

            textBox_studentScoreId.Text = dataGridView_MaganeScore.CurrentRow.Cells[0].Value?.ToString();
            comboBox_Course.Text = dataGridView_MaganeScore.CurrentRow.Cells[2].Value?.ToString();
            textBox_Score.Text = dataGridView_MaganeScore.CurrentRow.Cells[3].Value?.ToString();
            textBox_description.Text = dataGridView_MaganeScore.CurrentRow.Cells[4].Value?.ToString();
        }

        private void button_clear_MangeStudent_Click(object sender, EventArgs e)
        {
            textBox_studentScoreId.Clear();
            textBox_Score.Clear();
            textBox_description.Clear();

            // populate the combobox with courses name
            DataTable table = course.getCourseList();

            comboBox_Course.DataSource = table;
            comboBox_Course.DisplayMember = "CourseName";
            comboBox_Course.ValueMember = "CourseId";

            // Display the Score list on the datagridview
            showDataScore(new MySqlCommand("SELECT score.StudentID, student.StdFirstName,  score.CourseName, score.Score, score.Description " +
                                           "FROM score INNER JOIN student ON score.StudentID = student.StdId;"));
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (!verify())
            {
                MessageBox.Show("Select a valid score.", "Delete Score",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox_studentScoreId.Text, out int studentId))
            {
                MessageBox.Show("Invalid Student ID.", "Delete Score",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get student first name safely
            MySqlCommand cmd = new MySqlCommand("SELECT StdFirstName FROM student WHERE StdId = @id");
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = studentId;

            string firstName = student.exeQuery(cmd);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete Score for: " + firstName + "?",
                "Delete Score",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (score.DeleteScore(studentId))
                    {

                        showDataScore(new MySqlCommand("SELECT score.StudentID, student.StdFirstName,  score.CourseName, score.Score, score.Description " +
                                                       "FROM score INNER JOIN student ON score.StudentID = student.StdId;"));
                        MessageBox.Show("Score Deleted Successfully",
                            "Delete Score",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Score could not be deleted.",
                            "Delete Score",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Delete Score",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
       
        }
        private void button_Update_Click(object sender, EventArgs e)
        {


            if (!verify())
            {
                MessageBox.Show("Select a valid score.", "Update Score",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox_studentScoreId.Text, out int studentId))
            {
                MessageBox.Show("Invalid Student ID.", "Update Score",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get student first name safely
            MySqlCommand cmd = new MySqlCommand("SELECT StdFirstName FROM student WHERE StdId = @id");
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = studentId;

            string firstName = student.exeQuery(cmd);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to update Score for: " + firstName + "?",
                "Update Score",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );


            if (result == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(textBox_studentScoreId.Text);
                    String courseName = comboBox_Course.Text;
                    int scoreValue = Convert.ToInt32(textBox_Score.Text);
                    String description = textBox_description.Text;

                    if (score.UpdateScore(id, courseName, scoreValue, description))
                    {


                        showDataScore(new MySqlCommand("SELECT score.StudentID, student.StdFirstName,  score.CourseName, score.Score, score.Description " +
                                                       "FROM score INNER JOIN student ON score.StudentID = student.StdId;"));
                        MessageBox.Show("Score Updated Successfully",
                            "Updated Score",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Score could not be Updated.",
                            "Updated Score",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Updated Score",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }


        }

        // function to verify data
        bool verify()
        {
            if (string.IsNullOrWhiteSpace(textBox_description.Text) ||
                string.IsNullOrWhiteSpace(textBox_Score.Text) ||
                string.IsNullOrWhiteSpace(textBox_studentScoreId.Text))
            {
                Debug.WriteLine("Faild verify() in ManagerStudentForm");
                return false;

            }
            else
            {
                return true;
            }
        }

    }
}
