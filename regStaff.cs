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
    public partial class regStaff : Form
    {
        public regStaff()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            managementForm mf = new managementForm();
            mf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();

                string query = "INSERT INTO dbo.Staff2 values (@s_id, @s_name, @s_contact, @s_salary, @s_salary_salary)";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@s_id", s_idBox.Text);
                comand.Parameters.AddWithValue("@s_name", s_nameBox.Text);
                comand.Parameters.AddWithValue("@s_contact", s_contactBox.Text);
                comand.Parameters.AddWithValue("@s_salary", s_salaryBox.Text);
                comand.Parameters.AddWithValue("@s_salary_salary", s_salaryStatusBox.Text);
                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Registration Successful");
                conn.Close();

                this.Hide();
                regStaff rs = new regStaff();
                rs.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

            }
        }
    }
}
