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
    public partial class modifyStaff : Form
    {
        public modifyStaff()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            managementForm mf = new managementForm();
            mf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();

                //string query = "INSERT INTO dbo.Staff2 values (@s_id, @s_name, @s_contact, @s_salary, @s_salary_salary)";
                string query = "UPDATE dbo.Staff2 SET s_name = @s_name,s_contact = @s_contact,s_salary = @s_salary,s_salary_status = @s_salary_status WHERE s_id = @s_id; ";
              //string query = "UPDATE dbo.patient SET p_name = @p_name,p_sex = @p_sex,p_address = @p_address,p_contact = @p_contact,d_type = @d_type WHERE p_id = @p_id; ";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@s_id", s_idBox.Text);
                comand.Parameters.AddWithValue("@s_name", s_nameBox.Text);
                comand.Parameters.AddWithValue("@s_contact", s_contactBox.Text);
                comand.Parameters.AddWithValue("@s_salary", s_salaryBox.Text);
                comand.Parameters.AddWithValue("@s_salary_status", s_salaryStatusBox.Text);
                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Modify Successful");
                conn.Close();

                this.Hide();
                modifyStaff ms = new modifyStaff();
                ms.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

            }
        }
    }
}
