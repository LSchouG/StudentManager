using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class ManageStudentForm : Form
    {
        StudentClass student = new StudentClass();
        public ManageStudentForm()
        {
            InitializeComponent();
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            DataTable table = student.getStudentList();

            // Fix invalid image data BEFORE binding
            foreach (DataRow row in table.Rows)
            {
                if (row["StdImage"] == DBNull.Value ||
                    ((byte[])row["StdImage"]).Length == 0)
                {
                    row["StdImage"] = DBNull.Value;
                }
            }

            // Set the row height to 24
            dataGridView_student.RowTemplate.Height = 80;

            dataGridView_student.AutoGenerateColumns = true;
            dataGridView_student.DataSource = table;

            if (dataGridView_student.Columns["StdImage"] is DataGridViewImageColumn imgCol)
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgCol.DefaultCellStyle.NullValue = null;
            }
        }

        // Display student data 
        private void dataGridView_student_Click(object sender, EventArgs e)
        {
            if (dataGridView_student.CurrentRow == null) return;


            textBox_id.Text = dataGridView_student.CurrentRow.Cells[0].Value?.ToString();
            textBox_firstName.Text = dataGridView_student.CurrentRow.Cells[1].Value?.ToString();
            textBox_lastName.Text = dataGridView_student.CurrentRow.Cells[2].Value?.ToString();
            textBox_phoneNumber.Text = dataGridView_student.CurrentRow.Cells[5].Value?.ToString();
            textBox_address.Text = dataGridView_student.CurrentRow.Cells[6].Value?.ToString();

            // Gender radio buttons
            if (dataGridView_student.CurrentRow.Cells[4].Value?.ToString() == "Male")
            {
                radioButton_male.Checked = true;
                radioButton_female.Checked = false;
            }
            else
            {
                radioButton_male.Checked = false;
                radioButton_female.Checked = true;
            }


            // Date of birth
            dateTimePicker_DOB.Value = (DateTime)dataGridView_student.CurrentRow.Cells[3].Value;


            // Image
            byte[] img = (byte[])dataGridView_student.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_studentMG.Image = Image.FromStream(ms);
        }

        private void button_clear_MangeStudent_Click(object sender, EventArgs e)
        {

            textBox_id.Text = "";
            textBox_firstName.Text = "";
            textBox_lastName.Text = "";
            textBox_phoneNumber.Text = "";
            textBox_address.Text = "";
            radioButton_male.Checked = true;
            radioButton_female.Checked = false;
            dateTimePicker_DOB.Value = DateTime.Today;
            pictureBox_studentMG.Image = null;
        }

        private void button_uploadMG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_id.Text))
            {
                MessageBox.Show("Select a student to upload", "Upload Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // upload and brows images
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_studentMG.Image = Image.FromFile(opf.FileName);
            }
        }

        private void bottom_search_Click(object sender, EventArgs e)
        {
            String textToSearch = textBox_Search.Text;

            DataTable table = student.SearchStudent(textToSearch);

            // Fix invalid image data BEFORE binding
            foreach (DataRow row in table.Rows)
            {
                if (row["StdImage"] == DBNull.Value ||
                    ((byte[])row["StdImage"]).Length == 0)
                {
                    row["StdImage"] = DBNull.Value;
                }
            }

            // Set the row height to 24
            dataGridView_student.RowTemplate.Height = 80;

            dataGridView_student.AutoGenerateColumns = true;
            dataGridView_student.DataSource = table;

            if (dataGridView_student.Columns["StdImage"] is DataGridViewImageColumn imgCol)
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgCol.DefaultCellStyle.NullValue = null;
            }
        }

        private void button_Update_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_id.Text))
            {
                MessageBox.Show("Select a student to update", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(textBox_id.Text);
            String firstName = textBox_firstName.Text;
            String lastName = textBox_lastName.Text;
            String phone = textBox_phoneNumber.Text;
            String address = textBox_address.Text;
            DateTime dob = dateTimePicker_DOB.Value;
            string gender = "";
            if (radioButton_male.Checked) { gender = "Male"; }
            else { gender = "female"; }
            MemoryStream imageMG = new MemoryStream();
            pictureBox_studentMG.Image.Save(imageMG, pictureBox_studentMG.Image.RawFormat);
            byte[] img = imageMG.ToArray();


            // age verification between  10 and 100
            int born_year = dateTimePicker_DOB.Value.Year;
            int this_year = DateTime.Now.Year;

            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The student age must be between 10 and 100 years", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    if (student.UpdateStudent(id, firstName, lastName, dob, phone, gender, address, img))
                    {
                        showTable();
                        MessageBox.Show("Updated Student" + firstName, "Updated Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Updated Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Updated Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        // function to verify data
        bool verify()
        {
            if (string.IsNullOrWhiteSpace(textBox_firstName.Text) ||
                string.IsNullOrWhiteSpace(textBox_lastName.Text) ||
                string.IsNullOrWhiteSpace(textBox_address.Text) ||
                string.IsNullOrWhiteSpace(textBox_phoneNumber.Text) ||
               (pictureBox_studentMG.Image == null) ||
                !(radioButton_female.Checked || radioButton_male.Checked))
            {
                Debug.WriteLine("Faild verify() in ManagerStudentForm");
                return false;

            }
            else
            {
                return true;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string firstName = textBox_firstName.Text;
            if (string.IsNullOrWhiteSpace(textBox_id.Text))
            {
                MessageBox.Show("Select a student to delete", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete student: " + firstName, "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(textBox_id.Text);

                try
                {
                    if (student.DeleteStudent(id))
                    {
                        showTable();
                        MessageBox.Show($"Deleted student: {firstName}", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student could not be deleted.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
