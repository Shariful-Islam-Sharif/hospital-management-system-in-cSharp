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
    public partial class Release : Form
    {
        public Release()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            recFrame rf = new recFrame();
            rf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                //string query = "UPDATE dbo.patient SET p_name = @p_name,p_sex = @p_sex,p_address = @p_address,p_contact = @p_contact,d_type = @d_type WHERE p_id = @p_id; ";
                //string query = "insert into Admit (p_id,d_id) values (@p_id,@d_id); ";
                string query = "delete from Admit where a_id=@a_id; ";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@a_id", rBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Successfully Released");
                conn.Close();

                this.Hide();
                Release r = new Release();
                r.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

            }
        }
    }
}
