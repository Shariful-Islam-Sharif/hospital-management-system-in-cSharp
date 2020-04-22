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
    public partial class recLogin : Form
    {
        public recLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainFrame mf = new mainFrame();
            mf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");

                //conn.Open();
                //string query = "DELETE FROM dbo.Doctor WHERE d_id = @d_id;";
                string query = "Select * from dbo.Receptionist Where rp_id = '" + idBox.Text.Trim() + "' and rp_password = '" + passwordBox.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    //MessageBox.Show("successfully entered");

                    this.Hide();
                    recFrame rf = new recFrame();
                    rf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Check your username and password");
                }


                //comand.Parameters.AddWithValue("@d_id", d_idBox.Text);
                //comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");

            }

            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

            }




            
        }
    }
}
