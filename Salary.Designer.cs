namespace HRproject
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            label1 = new Label();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            calculate = new Button();
            position = new TextBox();
            name = new TextBox();
            textBox3 = new TextBox();
            SalarySlip = new RichTextBox();
            workedDays = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            fetch = new Button();
            empIDsearch = new TextBox();
            textBox8 = new TextBox();
            printBtn = new Button();
            pictureBox1 = new PictureBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mitra", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(117, 45);
            label1.Name = "label1";
            label1.Size = new Size(112, 51);
            label1.TabIndex = 7;
            label1.Text = "Salary";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(22, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(89, 84);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(calculate);
            panel1.Controls.Add(position);
            panel1.Controls.Add(name);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(SalarySlip);
            panel1.Controls.Add(workedDays);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(fetch);
            panel1.Controls.Add(empIDsearch);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(printBtn);
            panel1.Location = new Point(0, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(1445, 593);
            panel1.TabIndex = 10;
            // 
            // calculate
            // 
            calculate.BackColor = SystemColors.InactiveCaption;
            calculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculate.ForeColor = Color.DarkTurquoise;
            calculate.Location = new Point(32, 388);
            calculate.Name = "calculate";
            calculate.Size = new Size(115, 45);
            calculate.TabIndex = 45;
            calculate.Text = "calculate";
            calculate.UseVisualStyleBackColor = false;
            calculate.Click += calculate_Click;
            // 
            // position
            // 
            position.BackColor = Color.White;
            position.BorderStyle = BorderStyle.None;
            position.Font = new Font("B Nazanin", 13.8F);
            position.ForeColor = Color.DarkGreen;
            position.Location = new Point(163, 196);
            position.Name = "position";
            position.ReadOnly = true;
            position.Size = new Size(423, 35);
            position.TabIndex = 44;
            position.Text = "Position";
            position.Visible = false;
            // 
            // name
            // 
            name.BackColor = Color.White;
            name.BorderStyle = BorderStyle.None;
            name.Font = new Font("B Nazanin", 13.8F);
            name.ForeColor = Color.DarkGreen;
            name.Location = new Point(163, 106);
            name.Name = "name";
            name.ReadOnly = true;
            name.Size = new Size(423, 35);
            name.TabIndex = 43;
            name.Text = "name";
            name.Visible = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("B Nazanin", 13.8F);
            textBox3.ForeColor = Color.MediumSeaGreen;
            textBox3.Location = new Point(22, 205);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 35);
            textBox3.TabIndex = 42;
            textBox3.Text = "position";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // SalarySlip
            // 
            SalarySlip.BackColor = Color.AliceBlue;
            SalarySlip.Font = new Font("Ebrima", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SalarySlip.ForeColor = Color.DarkGreen;
            SalarySlip.Location = new Point(598, 20);
            SalarySlip.Name = "SalarySlip";
            SalarySlip.Size = new Size(763, 484);
            SalarySlip.TabIndex = 41;
            SalarySlip.Text = "";
            // 
            // workedDays
            // 
            workedDays.Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            workedDays.Location = new Point(163, 289);
            workedDays.Name = "workedDays";
            workedDays.Size = new Size(125, 33);
            workedDays.TabIndex = 40;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("B Nazanin", 13.8F);
            textBox4.ForeColor = Color.MediumSeaGreen;
            textBox4.Location = new Point(22, 287);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(125, 35);
            textBox4.TabIndex = 39;
            textBox4.Text = "worked days";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("B Nazanin", 13.8F);
            textBox2.ForeColor = Color.MediumSeaGreen;
            textBox2.Location = new Point(22, 115);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 35);
            textBox2.TabIndex = 37;
            textBox2.Text = "Name";
            // 
            // fetch
            // 
            fetch.BackColor = SystemColors.InactiveCaption;
            fetch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fetch.ForeColor = Color.DarkTurquoise;
            fetch.Location = new Point(360, 20);
            fetch.Name = "fetch";
            fetch.Size = new Size(115, 45);
            fetch.TabIndex = 36;
            fetch.Text = "fetch";
            fetch.UseVisualStyleBackColor = false;
            fetch.Click += RefreshBtn_Click;
            // 
            // empIDsearch
            // 
            empIDsearch.Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            empIDsearch.Location = new Point(153, 20);
            empIDsearch.Name = "empIDsearch";
            empIDsearch.Size = new Size(125, 33);
            empIDsearch.TabIndex = 26;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.White;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            textBox8.ForeColor = Color.MediumSeaGreen;
            textBox8.Location = new Point(22, 27);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(125, 26);
            textBox8.TabIndex = 25;
            textBox8.Text = "Employee ID";
            // 
            // printBtn
            // 
            printBtn.BackColor = SystemColors.InactiveCaption;
            printBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            printBtn.ForeColor = Color.DarkTurquoise;
            printBtn.Location = new Point(946, 531);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(115, 45);
            printBtn.TabIndex = 22;
            printBtn.Text = "Print";
            printBtn.UseVisualStyleBackColor = false;
            printBtn.Click += printBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1277, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1391, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1445, 755);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Salary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary";
            Load += Salary_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Button fetch;
        private TextBox empIDsearch;
        private TextBox textBox8;
        private Button printBtn;
        private RichTextBox SalarySlip;
        private TextBox workedDays;
        private TextBox textBox4;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private TextBox position;
        private TextBox name;
        private Button calculate;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PictureBox pictureBox2;
    }
}