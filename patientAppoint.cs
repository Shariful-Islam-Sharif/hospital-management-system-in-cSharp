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
    public partial class patientAppoint : Form
    {
        public patientAppoint()
        {
            InitializeComponent();
            DisplayData();
        }

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
            pSwapGrid.DataSource = dt;
            conn.Close();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            recFrame rf = new recFrame();
            rf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Apointment
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "INSERT INTO dbo.Appointment (p_id, d_id) values (@p_id, @d_id)";
                SqlCommand comand = new SqlCommand(query, conn);
                
                comand.Parameters.AddWithValue("@p_id", pIdBox.Text);
                comand.Parameters.AddWithValue("@d_id", dIdBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Appointed Successfully");
                conn.Close();

                this.Hide();
                patientAppoint pa = new patientAppoint();
                pa.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                patientAppoint pa = new patientAppoint();
                pa.ShowDialog();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "DELETE FROM dbo.Appointment WHERE visit_id=@visit_id;" ;
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@visit_id", visitIdBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Dismissed Successfully");
                conn.Close();

                this.Hide();
                patientAppoint pa = new patientAppoint();
                pa.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                patientAppoint pa = new patientAppoint();
                pa.ShowDialog();

            }
        }

        private void patientAppoint_Load(object sender, EventArgs e)
        {

        }

        //Update
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "UPDATE dbo.Appointment SET p_id=@p_id, d_id@d_id WHERE visit_id=@visit_id";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@p_id", pIdBox.Text);
                comand.Parameters.AddWithValue("@d_id", dIdBox.Text);
                comand.Parameters.AddWithValue("@visit_id", visitIdBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Modified Successfully");
                conn.Close();

                this.Hide();
                patientAppoint pa = new patientAppoint();
                pa.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                patientAppoint pa = new patientAppoint();
                pa.ShowDialog();

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                
                //delete top row
                string query2 = "DELETE TOP (1) FROM Appointment";
                SqlCommand comand2 = new SqlCommand(query2, conn);
                comand2.ExecuteNonQuery();
                //MessageBox.Show("Successfully Deleted");


                string query = "INSERT INTO dbo.Appointment (p_id, d_id) values (@p_id2, @d_id2)";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@p_id2", pIdBox2.Text);
                comand.Parameters.AddWithValue("@d_id2", dIdBox2.Text);
                

                
                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Swapped Successfully");
                conn.Close();

                this.Hide();
                patientAppoint pa = new patientAppoint();
                pa.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                patientAppoint pa = new patientAppoint();
                pa.ShowDialog();

            }
        }
    }
}
