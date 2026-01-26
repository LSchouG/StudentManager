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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox_firstName = new TextBox();
            textBox_lastName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker_DOB = new DateTimePicker();
            label4 = new Label();
            radioButton_male = new RadioButton();
            radioButton_female = new RadioButton();
            textBox_address = new TextBox();
            label5 = new Label();
            pictureBox_student = new PictureBox();
            button_upload = new Button();
            textBox_phoneNumber = new TextBox();
            label6 = new Label();
            button_add = new Button();
            button_clear = new Button();
            panel1 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(928, 305);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(36, 385);
            label1.Name = "label1";
            label1.Size = new Size(101, 18);
            label1.TabIndex = 1;
            label1.Text = "First Name :";
            // 
            // textBox_firstName
            // 
            textBox_firstName.Location = new Point(143, 383);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(130, 23);
            textBox_firstName.TabIndex = 2;
            // 
            // textBox_lastName
            // 
            textBox_lastName.Location = new Point(396, 383);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(130, 23);
            textBox_lastName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(285, 385);
            label2.Name = "label2";
            label2.Size = new Size(99, 18);
            label2.TabIndex = 4;
            label2.Text = "Last Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(21, 437);
            label3.Name = "label3";
            label3.Size = new Size(116, 18);
            label3.TabIndex = 6;
            label3.Text = "Date Of Birth :";
            // 
            // dateTimePicker_DOB
            // 
            dateTimePicker_DOB.Location = new Point(143, 435);
            dateTimePicker_DOB.Name = "dateTimePicker_DOB";
            dateTimePicker_DOB.Size = new Size(206, 23);
            dateTimePicker_DOB.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(548, 437);
            label4.Name = "label4";
            label4.Size = new Size(73, 18);
            label4.TabIndex = 8;
            label4.Text = "Gender :";
            // 
            // radioButton_male
            // 
            radioButton_male.AutoSize = true;
            radioButton_male.Checked = true;
            radioButton_male.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_male.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_male.Location = new Point(627, 437);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(59, 20);
            radioButton_male.TabIndex = 9;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            radioButton_female.AutoSize = true;
            radioButton_female.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            radioButton_female.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_female.Location = new Point(692, 437);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(77, 20);
            radioButton_female.TabIndex = 10;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // textBox_address
            // 
            textBox_address.Location = new Point(143, 484);
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
            label5.Location = new Point(58, 486);
            label5.Name = "label5";
            label5.Size = new Size(79, 18);
            label5.TabIndex = 11;
            label5.Text = "Address :";
            // 
            // pictureBox_student
            // 
            pictureBox_student.BackColor = Color.Gainsboro;
            pictureBox_student.Location = new Point(813, 383);
            pictureBox_student.Name = "pictureBox_student";
            pictureBox_student.Size = new Size(109, 121);
            pictureBox_student.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_student.TabIndex = 13;
            pictureBox_student.TabStop = false;
            // 
            // button_upload
            // 
            button_upload.BackColor = Color.FromArgb(0, 71, 160);
            button_upload.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(813, 518);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(109, 28);
            button_upload.TabIndex = 14;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click;
            // 
            // textBox_phoneNumber
            // 
            textBox_phoneNumber.Location = new Point(611, 383);
            textBox_phoneNumber.Name = "textBox_phoneNumber";
            textBox_phoneNumber.Size = new Size(158, 23);
            textBox_phoneNumber.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 71, 160);
            label6.Location = new Point(535, 385);
            label6.Name = "label6";
            label6.Size = new Size(66, 18);
            label6.TabIndex = 15;
            label6.Text = "Phone :";
            // 
            // button_add
            // 
            button_add.BackColor = Color.Green;
            button_add.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(813, 573);
            button_add.Name = "button_add";
            button_add.Size = new Size(109, 28);
            button_add.TabIndex = 17;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // button_clear
            // 
            button_clear.BackColor = Color.Silver;
            button_clear.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(698, 573);
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
            // RegistationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 613);
            Controls.Add(panel1);
            Controls.Add(button_clear);
            Controls.Add(button_add);
            Controls.Add(textBox_phoneNumber);
            Controls.Add(label6);
            Controls.Add(button_upload);
            Controls.Add(pictureBox_student);
            Controls.Add(textBox_address);
            Controls.Add(label5);
            Controls.Add(radioButton_female);
            Controls.Add(radioButton_male);
            Controls.Add(label4);
            Controls.Add(dateTimePicker_DOB);
            Controls.Add(label3);
            Controls.Add(textBox_lastName);
            Controls.Add(label2);
            Controls.Add(textBox_firstName);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegistationForm";
            Text = "RegistationForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox_firstName;
        private TextBox textBox_lastName;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker_DOB;
        private Label label4;
        private RadioButton radioButton_male;
        private RadioButton radioButton_female;
        private TextBox textBox_address;
        private Label label5;
        private PictureBox pictureBox_student;
        private Button button_upload;
        private TextBox textBox_phoneNumber;
        private Label label6;
        private Button button_add;
        private Button button_clear;
        private Panel panel1;
        private Label label7;
    }
}