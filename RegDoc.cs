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
    public partial class RegDoc : Form
    {
        public SqlCredential Hospital { get; private set; }
        public object Management { get; private set; }

        public RegDoc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Server=localhost;Database=master;Trusted_Connection=True;");
            
            //SqlDataAdapter sda = new SqlDataAdapter();
            
            
            //////////////////////////////////////////////////////////////////////////
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
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
                RegDoc rd= new RegDoc();
                rd.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

            }
            ////////////////////////////////////////////////////

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
