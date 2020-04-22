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
    public partial class staffEdit : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
        //SqlCommand cmd;
        SqlDataAdapter adapt;

        //Display Data in DataGridView
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Staff2", conn);
            adapt.Fill(dt);
            rpGrid.DataSource = dt;
            conn.Close();
        }


        public staffEdit()
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
                string query = "INSERT INTO dbo.Staff2 values (@s_id, @s_name, @s_contact, @s_salary, @s_salary_status)";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@s_id", sIdBox.Text);
                comand.Parameters.AddWithValue("@s_name", sNameBox.Text);
                comand.Parameters.AddWithValue("@s_contact", sContactBox.Text);
                comand.Parameters.AddWithValue("@s_salary", sSalaryBox.Text);
                comand.Parameters.AddWithValue("@s_salary_status", sSSBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Registration Successful");
                conn.Close();

                this.Hide();
                staffEdit se = new staffEdit();
                se.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                staffEdit se = new staffEdit();
                se.ShowDialog();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "UPDATE Staff2 SET s_name=@s_name, s_contact=@s_contact, s_salary=@s_salary, s_salary_status=@s_salary_status WHERE  s_id=@s_id";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@s_id", sIdBox.Text);
                comand.Parameters.AddWithValue("@s_name", sNameBox.Text);
                comand.Parameters.AddWithValue("@s_contact", sContactBox.Text);
                comand.Parameters.AddWithValue("@s_salary", sSalaryBox.Text);
                comand.Parameters.AddWithValue("@s_salary_status", sSSBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Modified Successful");
                conn.Close();

                this.Hide();
                staffEdit se = new staffEdit();
                se.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                staffEdit se = new staffEdit();
                se.ShowDialog();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "DELETE FROM Staff2 WHERE s_id=@s_id";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@s_id", sIdBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Removed Successful");
                conn.Close();

                this.Hide();
                staffEdit se = new staffEdit();
                se.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                staffEdit se = new staffEdit();
                se.ShowDialog();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "Update Staff2 set s_salary_status= 'Given' WHERE s_id=@s_id";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@s_id", sIdBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Salary Given");
                conn.Close();

                this.Hide();
                staffEdit se = new staffEdit();
                se.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                staffEdit se = new staffEdit();
                se.ShowDialog();

            }
        }
    }
}
