namespace HRproject
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            label1 = new Label();
            panel1 = new Panel();
            EmpDGV = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            addBtn = new Button();
            gender = new ComboBox();
            textBox13 = new TextBox();
            phone = new TextBox();
            name = new TextBox();
            address = new TextBox();
            id = new TextBox();
            education = new ComboBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBD = new TextBox();
            birthDate = new DateTimePicker();
            position = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mitra", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(110, 33);
            label1.Name = "label1";
            label1.Size = new Size(282, 51);
            label1.TabIndex = 3;
            label1.Text = "Manage Employee";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(EmpDGV);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(gender);
            panel1.Controls.Add(textBox13);
            panel1.Controls.Add(phone);
            panel1.Controls.Add(name);
            panel1.Controls.Add(address);
            panel1.Controls.Add(id);
            panel1.Controls.Add(education);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBD);
            panel1.Controls.Add(birthDate);
            panel1.Controls.Add(position);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(-4, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(1612, 621);
            panel1.TabIndex = 4;
            // 
            // EmpDGV
            // 
            EmpDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmpDGV.Location = new Point(449, 25);
            EmpDGV.Name = "EmpDGV";
            EmpDGV.RowHeadersWidth = 51;
            EmpDGV.Size = new Size(1079, 576);
            EmpDGV.TabIndex = 26;
            EmpDGV.CellContentClick += EmpDGV_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.InactiveCaption;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.DarkTurquoise;
            button3.Location = new Point(290, 523);
            button3.Name = "button3";
            button3.Size = new Size(115, 45);
            button3.TabIndex = 24;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkTurquoise;
            button2.Location = new Point(161, 523);
            button2.Name = "button2";
            button2.Size = new Size(115, 45);
            button2.TabIndex = 23;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.InactiveCaption;
            addBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.DarkTurquoise;
            addBtn.Location = new Point(30, 523);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(115, 45);
            addBtn.TabIndex = 22;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += button1_Click;
            // 
            // gender
            // 
            gender.Font = new Font("B Nazanin", 10.2F);
            gender.ForeColor = Color.MediumSeaGreen;
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Man", "Women" });
            gender.Location = new Point(30, 469);
            gender.Name = "gender";
            gender.Size = new Size(125, 34);
            gender.TabIndex = 21;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.White;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            textBox13.ForeColor = Color.MediumSeaGreen;
            textBox13.Location = new Point(30, 437);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(125, 26);
            textBox13.TabIndex = 19;
            textBox13.Text = "Gender";
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // phone
            // 
            phone.Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            phone.Location = new Point(30, 167);
            phone.Name = "phone";
            phone.Size = new Size(125, 33);
            phone.TabIndex = 18;
            // 
            // name
            // 
            name.Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            name.Location = new Point(187, 78);
            name.Name = "name";
            name.Size = new Size(237, 33);
            name.TabIndex = 17;
            // 
            // address
            // 
            address.Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            address.Location = new Point(30, 278);
            address.Name = "address";
            address.Size = new Size(394, 33);
            address.TabIndex = 16;
            // 
            // id
            // 
            id.Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            id.Location = new Point(30, 78);
            id.Name = "id";
            id.Size = new Size(125, 33);
            id.TabIndex = 15;
            // 
            // education
            // 
            education.Font = new Font("B Nazanin", 10.2F);
            education.ForeColor = Color.MediumSeaGreen;
            education.FormattingEnabled = true;
            education.Items.AddRange(new object[] { "BTech", "MTech", "BBA", "BCA", "MBA", "BCom", "MCom" });
            education.Location = new Point(187, 377);
            education.Name = "education";
            education.Size = new Size(151, 34);
            education.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.White;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            textBox7.ForeColor = Color.MediumSeaGreen;
            textBox7.Location = new Point(201, 351);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(111, 26);
            textBox7.TabIndex = 13;
            textBox7.Text = "Education";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            textBox6.ForeColor = Color.MediumSeaGreen;
            textBox6.Location = new Point(30, 135);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(125, 26);
            textBox6.TabIndex = 12;
            textBox6.Text = "Phone";
            // 
            // textBD
            // 
            textBD.BackColor = Color.White;
            textBD.BorderStyle = BorderStyle.None;
            textBD.Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            textBD.ForeColor = Color.MediumSeaGreen;
            textBD.Location = new Point(201, 135);
            textBD.Name = "textBD";
            textBD.ReadOnly = true;
            textBD.Size = new Size(151, 26);
            textBD.TabIndex = 11;
            textBD.Text = "Birth Date";
            textBD.TextChanged += textBox5_TextChanged;
            // 
            // birthDate
            // 
            birthDate.Location = new Point(187, 173);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(237, 27);
            birthDate.TabIndex = 10;
            // 
            // position
            // 
            position.Font = new Font("B Nazanin", 10.2F);
            position.ForeColor = Color.MediumSeaGreen;
            position.FormattingEnabled = true;
            position.Items.AddRange(new object[] { "Manager", "Senior Developer", "Junior Developer", "Accountant", "Receptionist" });
            position.Location = new Point(30, 377);
            position.Name = "position";
            position.Size = new Size(125, 34);
            position.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            textBox4.ForeColor = Color.MediumSeaGreen;
            textBox4.Location = new Point(30, 351);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(125, 26);
            textBox4.TabIndex = 8;
            textBox4.Text = "Position";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            textBox3.ForeColor = Color.MediumSeaGreen;
            textBox3.Location = new Point(30, 246);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 26);
            textBox3.TabIndex = 7;
            textBox3.Text = "Address";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            textBox1.ForeColor = Color.MediumSeaGreen;
            textBox1.Location = new Point(201, 46);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(163, 26);
            textBox1.TabIndex = 6;
            textBox1.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            textBox2.ForeColor = Color.MediumSeaGreen;
            textBox2.Location = new Point(30, 46);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 26);
            textBox2.TabIndex = 5;
            textBox2.Text = "Employee ID";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1427, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(26, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1530, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1577, 768);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Employee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBD;
        private DateTimePicker birthDate;
        private ComboBox position;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox textBox7;
        private TextBox textBox6;
        private ComboBox education;
        private TextBox textBox13;
        private TextBox phone;
        private TextBox name;
        private TextBox address;
        private TextBox id;
        private ComboBox gender;
        private Button addBtn;
        private DataGridView EmpDGV;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}