namespace StudentManager
{
    partial class RegistationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView_student = new DataGridView();
            label1 = new Label();
            textBox_firstName = new TextBox();
            textBox_lastName = new TextBox();
            label2 = new Label();
            textBox_address = new TextBox();
            label5 = new Label();
            button_add = new Button();
            button_clear = new Button();
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            textBox_phoneNumber = new TextBox();
            button_upload = new Button();
            radioButton_female = new RadioButton();
            pictureBox_student = new PictureBox();
            radioButton_male = new RadioButton();
            label4 = new Label();
            dateTimePicker_DOB = new DateTimePicker();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_student
            // 
            dataGridView_student.AllowUserToAddRows = false;
            dataGridView_student.AllowUserToDeleteRows = false;
            dataGridView_student.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_student.BackgroundColor = Color.Gainsboro;
            dataGridView_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_student.Location = new Point(0, 57);
            dataGridView_student.Name = "dataGridView_student";
            dataGridView_student.Size = new Size(934, 302);
            dataGridView_student.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(35, 31);
            label1.Name = "label1";
            label1.Size = new Size(101, 18);
            label1.TabIndex = 1;
            label1.Text = "First Name :";
            // 
            // textBox_firstName
            // 
            textBox_firstName.Location = new Point(142, 29);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(130, 23);
            textBox_firstName.TabIndex = 2;
            // 
            // textBox_lastName
            // 
            textBox_lastName.Location = new Point(395, 29);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(130, 23);
            textBox_lastName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(284, 31);
            label2.Name = "label2";
            label2.Size = new Size(99, 18);
            label2.TabIndex = 4;
            label2.Text = "Last Name :";
            // 
            // textBox_address
            // 
            textBox_address.Location = new Point(142, 130);
            textBox_address.Multiline = true;
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(626, 71);
            textBox_address.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(57, 132);
            label5.Name = "label5";
            label5.Size = new Size(79, 18);
            label5.TabIndex = 11;
            label5.Text = "Address :";
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.Green;
            button_add.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(812, 219);
            button_add.Name = "button_add";
            button_add.Size = new Size(109, 28);
            button_add.TabIndex = 17;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Silver;
            button_clear.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(697, 219);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(109, 28);
            button_clear.TabIndex = 18;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 58);
            panel1.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(381, 9);
            label7.Name = "label7";
            label7.Size = new Size(108, 24);
            label7.TabIndex = 20;
            label7.Text = "Registaion";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 10);
            panel2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(textBox_lastName);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBox_firstName);
            panel3.Controls.Add(button_clear);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button_add);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox_phoneNumber);
            panel3.Controls.Add(dateTimePicker_DOB);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(button_upload);
            panel3.Controls.Add(radioButton_male);
            panel3.Controls.Add(pictureBox_student);
            panel3.Controls.Add(radioButton_female);
            panel3.Controls.Add(textBox_address);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(0, 352);
            panel3.Name = "panel3";
            panel3.Size = new Size(934, 261);
            panel3.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 71, 160);
            label6.Location = new Point(534, 31);
            label6.Name = "label6";
            label6.Size = new Size(66, 18);
            label6.TabIndex = 15;
            label6.Text = "Phone :";
            // 
            // textBox_phoneNumber
            // 
            textBox_phoneNumber.Location = new Point(610, 29);
            textBox_phoneNumber.Name = "textBox_phoneNumber";
            textBox_phoneNumber.Size = new Size(158, 23);
            textBox_phoneNumber.TabIndex = 16;
            // 
            // button_upload
            // 
            button_upload.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_upload.BackColor = Color.FromArgb(0, 71, 160);
            button_upload.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(812, 164);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(109, 28);
            button_upload.TabIndex = 14;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click;
            // 
            // radioButton_female
            // 
            radioButton_female.AutoSize = true;
            radioButton_female.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_female.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_female.Location = new Point(691, 83);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(77, 20);
            radioButton_female.TabIndex = 10;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // pictureBox_student
            // 
            pictureBox_student.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox_student.BackColor = Color.Gainsboro;
            pictureBox_student.Location = new Point(812, 29);
            pictureBox_student.Name = "pictureBox_student";
            pictureBox_student.Size = new Size(109, 121);
            pictureBox_student.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_student.TabIndex = 13;
            pictureBox_student.TabStop = false;
            // 
            // radioButton_male
            // 
            radioButton_male.AutoSize = true;
            radioButton_male.Checked = true;
            radioButton_male.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_male.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_male.Location = new Point(626, 83);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(59, 20);
            radioButton_male.TabIndex = 9;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(547, 83);
            label4.Name = "label4";
            label4.Size = new Size(73, 18);
            label4.TabIndex = 8;
            label4.Text = "Gender :";
            // 
            // dateTimePicker_DOB
            // 
            dateTimePicker_DOB.Location = new Point(142, 81);
            dateTimePicker_DOB.Name = "dateTimePicker_DOB";
            dateTimePicker_DOB.Size = new Size(206, 23);
            dateTimePicker_DOB.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(20, 83);
            label3.Name = "label3";
            label3.Size = new Size(116, 18);
            label3.TabIndex = 6;
            label3.Text = "Date Of Birth :";
            // 
            // RegistationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 613);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridView_student);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegistationForm";
            Text = "RegistationForm";
            Load += RegistationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_student;
        private Label label1;
        private TextBox textBox_firstName;
        private TextBox textBox_lastName;
        private Label label2;
        private TextBox textBox_address;
        private Label label5;
        private Button button_add;
        private Button button_clear;
        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private TextBox textBox_phoneNumber;
        private DateTimePicker dateTimePicker_DOB;
        private Label label6;
        private Label label4;
        private Button button_upload;
        private RadioButton radioButton_male;
        private PictureBox pictureBox_student;
        private RadioButton radioButton_female;
    }
}