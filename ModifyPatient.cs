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
    public partial class ModifyPatient : Form
    {
        public ModifyPatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "UPDATE dbo.patient SET p_name = @p_name,p_sex = @p_sex,p_address = @p_address,p_contact = @p_contact,d_type = @d_type WHERE p_id = @p_id; ";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@p_id", idBox.Text);
                comand.Parameters.AddWithValue("@p_name", nameBox.Text);
                comand.Parameters.AddWithValue("@p_sex", sexBox.Text);
                comand.Parameters.AddWithValue("@p_address", addressBox.Text);
                comand.Parameters.AddWithValue("@p_contact", contactBox.Text);
                comand.Parameters.AddWithValue("@d_type", dTypeBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Modify Successful");
                conn.Close();

                this.Hide();
                ModifyPatient mf = new ModifyPatient();
                mf.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            recFrame rf = new recFrame();
            rf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
