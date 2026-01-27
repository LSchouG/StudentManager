using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace StudentManager
{
    public partial class RegistationForm : Form
    {
        StudentClass student = new StudentClass();
        public RegistationForm()
        {
            InitializeComponent();
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            // upload and brows images
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_student.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //add student
            string firstname = textBox_firstName.Text;
            string lastname = textBox_lastName.Text;
            DateTime dob = dateTimePicker_DOB.Value;
            string phone = textBox_phoneNumber.Text;
            string address = textBox_address.Text;
            string gender = "";
            if (radioButton_male.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "female";
            }
            MemoryStream image = new MemoryStream();
            pictureBox_student.Image.Save(image, pictureBox_student.Image.RawFormat);
            byte[] img = image.ToArray();

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
                    if (student.insertStudent(firstname, lastname, dob, phone, gender, address, img))
                    {
                        showTable();
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // function to verify data
        bool verify()
        {
            if (string.IsNullOrWhiteSpace(textBox_firstName.Text) ||
                string.IsNullOrWhiteSpace(textBox_lastName.Text) ||
                string.IsNullOrWhiteSpace(textBox_address.Text) ||
                string.IsNullOrWhiteSpace(textBox_phoneNumber.Text) ||
               (pictureBox_student.Image == null) ||
                !(radioButton_female.Checked || radioButton_male.Checked))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_firstName.Clear();
            textBox_lastName.Clear();
            textBox_address.Clear();
            textBox_phoneNumber.Clear();
            pictureBox_student.Image = null;

        }

        private void RegistationForm_Load(object sender, EventArgs e)
        {
            showTable();

        }
        // Show student list in Datagridview
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

    }
}
