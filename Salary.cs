using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Xml.Linq;
using System.Numerics;

namespace HRproject
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        int total;
        int DailyBase;


        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MO99ME99\Documents\EMdb.mdf;Integrated Security=True;Connect Timeout=30");


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }
        private void fetchEmpData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Employee WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", empIDsearch.Text);

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    name.Text = dr["name"].ToString();
                    position.Text = dr["position"].ToString();

                    name.Visible = true;
                    position.Visible = true;

                }
                else
                {
                    MessageBox.Show("Employee not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            fetchEmpData();

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            fetchEmpData();
            if (empIDsearch.Text == "")
            {
                MessageBox.Show("Missing ID.");
            }
            else if (workedDays.Text == "" || Convert.ToInt32(workedDays.Text) < 1)
            {
                MessageBox.Show("Enter valid number!");
            }
            else
            {
                DailyBase = dailyBase(position.Text);
                total = DailyBase * Convert.ToInt16(workedDays.Text);
                SalarySlip.Text = "id : " + empIDsearch.Text + "\n" +
                    "Name : " + name.Text + "\n" +
                    "Position : " + position.Text + "\n" +
                    "Worked Days : " + workedDays.Text + "\n" +
                    "Daily Salary Base : " + DailyBase + "\n" +
                    "Total Salary : " + total;

            }
        }
        private int dailyBase(string position)
        {
            switch (position.ToLower())
            {
                case "manager":
                    return 150;
                case "senior developer":
                    return 110;
                case "junior developer":
                    return 90;
                default:
                    return 80;

            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            calculate_Click(sender, e);
            string str = "_____________________________ Employee Salary _____________________________\n\n";
            str += "\n\tID : " + empIDsearch.Text;
            str += "\n\tName : " + name.Text;
            str += "\n\tPosition : " + position.Text;
            str += "\n\tWorked Days : " + workedDays.Text;
            str += "\n\tDaily Salary Base : " + dailyBase(position.Text);
            str += "\n\tTotal Salary : " + total;



            // Define the font
            Font font = new Font("Century Gothic", 16, FontStyle.Bold);

            // Define the point where the text should be printed
            PointF point = new PointF(0, 0);

            // Draw the string on the graphics object
            e.Graphics.DrawString(str, font, Brushes.DarkBlue, point);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
