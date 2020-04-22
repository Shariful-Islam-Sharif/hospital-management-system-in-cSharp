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
    public partial class managementForm : Form
    {
        public managementForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
        //C:\Users\Sharif\Documents\Visual Studio 2015\Projects\HMS\HMS\Form2.cs
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegDoc f1 = new RegDoc();
            f1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Del_Doc dd = new Del_Doc();
            dd.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            modifyDoc dd = new modifyDoc();
            dd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            regStaff rs = new regStaff();
            rs.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Hide();
            DelStaff ds = new DelStaff();
            ds.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            modifyStaff ms = new modifyStaff();
            ms.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            managementLogin ml = new managementLogin();
            ml.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewDoctor vd = new viewDoctor();
            vd.ShowDialog();

            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewStaff vs = new viewStaff();
            vs.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                //conn.Open();
                //string query = "DELETE FROM dbo.Doctor WHERE d_id = @d_id;";
                string query =(" UPDATE Doctor SET d_salary_status='not given'; ");
                SqlCommand comand = new SqlCommand(query, conn);

                ////comand.Parameters.AddWithValue("@p_id", p_idBox.Text);
                comand.ExecuteNonQuery();
                MessageBox.Show("Reset Successful");
                conn.Close();

                this.Hide();
                managementForm mf = new managementForm();
                mf.ShowDialog();
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

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            recEdit ch = new recEdit();
            ch.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            staffEdit se = new staffEdit();
            se.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            docEdit de = new docEdit();
            de.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                //conn.Open();
                //string query = "DELETE FROM dbo.Doctor WHERE d_id = @d_id;";
                string query = (" UPDATE Staff2 SET s_salary_status='not given'; ");
                SqlCommand comand = new SqlCommand(query, conn);

                ////comand.Parameters.AddWithValue("@p_id", p_idBox.Text);
                comand.ExecuteNonQuery();
                MessageBox.Show("Reset Successful");
                conn.Close();

                this.Hide();
                managementForm mf = new managementForm();
                mf.ShowDialog();
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

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                //conn.Open();
                //string query = "DELETE FROM dbo.Doctor WHERE d_id = @d_id;";
                string query = (" UPDATE Receptionist SET rp_salary_status='not given'; ");
                SqlCommand comand = new SqlCommand(query, conn);

                ////comand.Parameters.AddWithValue("@p_id", p_idBox.Text);
                comand.ExecuteNonQuery();
                MessageBox.Show("Reset Successful");
                conn.Close();

                this.Hide();
                managementForm mf = new managementForm();
                mf.ShowDialog();
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
