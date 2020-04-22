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
    public partial class Del_Doc : Form
    {
        public Del_Doc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "DELETE FROM dbo.Doctor WHERE d_id = @d_id;";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@d_id", d_idBox.Text);
                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("deletion Successful");
                conn.Close();

                this.Hide();
                Del_Doc dd = new Del_Doc();
                dd.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            managementForm mf = new managementForm();
            mf.ShowDialog();
        }

        private void d_idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
