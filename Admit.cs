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
    public partial class Admit : Form
    {
        public Admit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            recFrame rf = new recFrame();
            rf.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
              //string query = "UPDATE dbo.patient SET p_name = @p_name,p_sex = @p_sex,p_address = @p_address,p_contact = @p_contact,d_type = @d_type WHERE p_id = @p_id; ";
                string query = "insert into Admit (p_id,d_id) values (@p_id,@d_id); ";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@p_id", pIdBox.Text);
                comand.Parameters.AddWithValue("@d_id", docIdBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Successfully Admitted");
                conn.Close();

                this.Hide();
                Admit a = new Admit();
                a.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

            }



            /*this.Hide();
            prescription p = new prescription();
            p.ShowDialog();*/
        }
    }
}
