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
    public partial class docEdit : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
        //SqlCommand cmd;
        SqlDataAdapter adapt;
        
        public docEdit()
        {
            InitializeComponent();
            DisplayData();
        }

        //Display Data in DataGridView
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Doctor", conn);
            adapt.Fill(dt);
            dGrid.DataSource = dt;
            conn.Close();
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
                //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "INSERT INTO dbo.Doctor values (@d_id, @d_name, @d_specialization, @d_contact, @d_salary, @d_salary_status, @d_password)";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@d_id", idBox.Text);
                comand.Parameters.AddWithValue("@d_name", nameBox.Text);
                comand.Parameters.AddWithValue("@d_specialization", specializationBox.Text);
                comand.Parameters.AddWithValue("@d_contact", contactBox.Text);
                comand.Parameters.AddWithValue("@d_salary", salaryBox.Text);
                comand.Parameters.AddWithValue("@d_salary_status", salaryStatusBox.Text);
                comand.Parameters.AddWithValue("@d_password", passwordBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Registration Successful");
                conn.Close();

                this.Hide();
                docEdit de = new docEdit();
                de.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                docEdit de = new docEdit();
                de.ShowDialog();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "UPDATE dbo.Doctor SET d_name = @d_name,d_specialization = @d_specialization,d_contact = @d_contact,d_salary = @d_salary,d_salary_status = @d_salary_status,d_password = @d_password WHERE d_id = @d_id; ";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@d_id", idBox.Text);
                comand.Parameters.AddWithValue("@d_name", nameBox.Text);
                comand.Parameters.AddWithValue("@d_specialization", specializationBox.Text);
                comand.Parameters.AddWithValue("@d_contact", contactBox.Text);
                comand.Parameters.AddWithValue("@d_salary", salaryBox.Text);
                comand.Parameters.AddWithValue("@d_salary_status", salaryStatusBox.Text);
                comand.Parameters.AddWithValue("@d_password", passwordBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Modify Successful");
                conn.Close();

                this.Hide();
                docEdit de = new docEdit();
                de.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                docEdit de = new docEdit();
                de.ShowDialog();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "DELETE FROM dbo.Doctor WHERE d_id = @d_id;";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@d_id",idBox.Text);
                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Deletion Successful");
                conn.Close();

                this.Hide();
                docEdit de = new docEdit();
                de.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                docEdit de = new docEdit();
                de.ShowDialog();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "UPDATE dbo.Doctor SET d_salary_status = 'Given' WHERE d_id = @d_id; ";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@d_id", idBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Salary Given");
                conn.Close();

                this.Hide();
                docEdit de = new docEdit();
                de.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                docEdit de = new docEdit();
                de.ShowDialog();

            }
        }
    }
}
