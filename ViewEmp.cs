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

namespace HRproject
{
    public partial class ViewEmp : Form
    {
        public ViewEmp()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MO99ME99\Documents\EMdb.mdf;Integrated Security=True;Connect Timeout=30");

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
                    id.Text = dr["id"].ToString();
                    name.Text = dr["name"].ToString();
                    address.Text = dr["address"].ToString();
                    phone.Text = dr["phone"].ToString();
                    education.Text = dr["education"].ToString();
                    gender.Text = dr["gender"].ToString();
                    position.Text = dr["position"].ToString();
                    birthDate.Text = dr["birthDate"].ToString();

                    id.Visible = true;
                    name.Visible = true;
                    address.Visible = true;
                    phone.Visible = true;
                    education.Visible = true;
                    gender.Visible = true;
                    position.Visible = true;
                    birthDate.Visible = true;

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

        private void ViewEmp_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            fetchEmpData();
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
            string str = "_____________________________Employee Summary_____________________________\n\n";
            str += "\n\tID : " + id.Text;
            str += "\n\tName : " + name.Text;
            str += "\n\tPhone : " + phone.Text;
            str += "\n\tAddress : " + address.Text;
            str += "\n\tBirth Date : " + birthDate.Text;
            str += "\n\tPosition : " + position.Text;
            str += "\n\tGender : " + gender.Text;
            str += "\n\tEducation : " + education.Text;


            // Define the font
            Font font = new Font("Century Gothic", 16, FontStyle.Bold);

            // Define the point where the text should be printed
            PointF point = new PointF(0, 0);

            // Draw the string on the graphics object
            e.Graphics.DrawString(str, font, Brushes.DarkBlue, point);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
