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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MO99ME99\Documents\EMdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Employee_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SaveEmployee()
        {
            try
            {

                connection.Open();
                string query = "INSERT INTO Employee (id, name, address, phone, education, gender, position, birthDate) VALUES (@id, @name, @address, @phone, @education, @gender, @position, @birthDate)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id.Text);
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@address", address.Text);
                    cmd.Parameters.AddWithValue("@phone", phone.Text);
                    cmd.Parameters.AddWithValue("@education", education.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@gender", gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@position", position.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@birthDate", birthDate.Value.Date);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Employee Successfully Added.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
        }
        private void UpdateEmployee()
        {
            try
            {
                connection.Open();
                string query = "UPDATE Employee SET name = @name, address = @address, phone = @phone, education = @education, gender = @gender, position = @position, birthDate = @birthDate WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id.Text);
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@address", address.Text);
                    cmd.Parameters.AddWithValue("@phone", phone.Text);
                    cmd.Parameters.AddWithValue("@education", education.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@gender", gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@position", position.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@birthDate", birthDate.Value.Date);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Employee Successfully Updated.");
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

        private void populate()
        {
            connection.Open();
            string query = "select * from Employee";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || name.Text == "" ||
                phone.Text == "" || address.Text == "" ||
                textBD.Text == "" || gender.Text == "" ||
                education.Text == "" || birthDate.Text == ""
                )
            {
                MessageBox.Show("Missing Information.");

            }
            else
            {
                try
                {
                    SaveEmployee();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || name.Text == "" ||
               phone.Text == "" || address.Text == "" ||
               textBD.Text == "" || gender.Text == "" ||
               education.Text == "" || birthDate.Text == ""
               )
            {
                MessageBox.Show("Missing Information.");

            }
            else
            {
                try
                {
                    UpdateEmployee();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                MessageBox.Show("Enter the employee ID.");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "delete from Employee where id='" + id.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted Successfully");
                    connection.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally { connection.Close(); }
            }
        }

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < EmpDGV.Rows.Count)
            {
                DataGridViewRow selectedRow = EmpDGV.Rows[e.RowIndex];

                // Populate the text boxes with the cell values
                id.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                name.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                address.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                phone.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                education.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                gender.SelectedItem = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;
                position.SelectedItem = selectedRow.Cells[6].Value?.ToString() ?? string.Empty;
                birthDate.Text = selectedRow.Cells[7].Value?.ToString() ?? string.Empty;
            }
            else
            {
                // Handle the case where no row is selected, if needed
                MessageBox.Show("Please select a valid row.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
