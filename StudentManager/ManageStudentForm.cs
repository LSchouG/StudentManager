using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
