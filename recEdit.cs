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

namespace HMS
{
    public partial class recEdit : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
        //SqlCommand cmd;
        SqlDataAdapter adapt;

        //Display Data in DataGridView
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Receptionist", conn);
            adapt.Fill(dt);
            rpGrid.DataSource = dt;
            conn.Close();
        }
        public recEdit()
        {
            InitializeComponent();
            DisplayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            managementForm mf = new managementForm();
            mf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "INSERT INTO dbo.Receptionist values (@rp_id, @rp_name, @rp_contact, @rp_salary, @rp_salary_status, @rp_password)";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@rp_id", rpIdBox.Text);
                comand.Parameters.AddWithValue("@rp_name", rpNameBox.Text);
                comand.Parameters.AddWithValue("@rp_contact", rpContactBox.Text);
                comand.Parameters.AddWithValue("@rp_salary", rpSalaryBox.Text);
                comand.Parameters.AddWithValue("@rp_salary_status", rpSSBox.Text);
                comand.Parameters.AddWithValue("@rp_password", rpPasswordBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Registration Successful");
                conn.Close();

                this.Hide();
                recEdit rh = new recEdit();
                rh.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                recEdit rh = new recEdit();
                rh.ShowDialog();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "UPDATE Receptionist SET rp_name=@rp_name, rp_contact=@rp_contact, rp_salary=@rp_salary, rp_salary_status=@rp_salary_status, rp_password=@rp_password WHERE  rp_id=@rp_id";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@rp_id", rpIdBox.Text);
                comand.Parameters.AddWithValue("@rp_name", rpNameBox.Text);
                comand.Parameters.AddWithValue("@rp_contact", rpContactBox.Text);
                comand.Parameters.AddWithValue("@rp_salary", rpSalaryBox.Text);
                comand.Parameters.AddWithValue("@rp_salary_status", rpSSBox.Text);
                comand.Parameters.AddWithValue("@rp_password", rpPasswordBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Modified Successful");
                conn.Close();

                this.Hide();
                recEdit rh = new recEdit();
                rh.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                recEdit rh = new recEdit();
                rh.ShowDialog();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "DELETE FROM Receptionist WHERE  rp_id=@rp_id";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@rp_id", rpIdBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Removed Successful");
                conn.Close();

                this.Hide();
                recEdit rh = new recEdit();
                rh.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                recEdit rh = new recEdit();
                rh.ShowDialog();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "Update Receptionist set rp_salary_status= 'Given' WHERE rp_id=@rp_id";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@rp_id", rpIdBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Salary Given");
                conn.Close();

                this.Hide();
                recEdit re = new recEdit();
                re.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");


                this.Hide();
                recEdit rh = new recEdit();
                rh.ShowDialog();
            }
        }
    }
}
