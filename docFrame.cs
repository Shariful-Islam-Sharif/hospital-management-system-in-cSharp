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
    public partial class docFrame : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
        //SqlCommand cmd;
        SqlDataAdapter adapt;

       
        //Display Data in DataGridView
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Appointment", conn);
            adapt.Fill(dt);
            docGrid.DataSource = dt;
            conn.Close();
        }



        public docFrame()
        {
            InitializeComponent();
            DisplayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            docLogin dl = new docLogin();
            dl.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "DELETE FROM dbo.Appointment WHERE visit_id=@visit_id;";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@visit_id", pSBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Dismissed Successfully");
                conn.Close();

                this.Hide();
                docFrame df = new docFrame();
                df.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                docFrame df = new docFrame();
                df.ShowDialog();

            }
        }
    }
}
