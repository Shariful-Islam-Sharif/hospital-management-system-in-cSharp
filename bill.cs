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
    public partial class bill : Form
    {
        
        

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
        //SqlCommand cmd;
        SqlDataAdapter adapt;

        //int ID = 0;

        public bill()
        {
            InitializeComponent();
            DisplayData();
        }


        //Insert Data
        private void button5_Click(object sender, EventArgs e)
        {
            
        }
        

        //Display Data in DataGridView
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Bill", conn);
            adapt.Fill(dt);
            billGrid.DataSource = dt;
            conn.Close();
        }
        //Clear Data 
        private void ClearData()
        {
            bIdBox.Text = "1";
            pIdBox.Text = "";
            dIdBox.Text = "";
            bAmBox.Text = "";
            bStBox.Text = "";
            //ID = 0;
        }

        //dataGridView1 RowHeaderMouseClick Event

            

        //Update Record
        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        //Delete Record
        


        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            recFrame cf = new recFrame();
            cf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        
        //del//
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                //if (ID != 0)
                //{
                string query = "delete from Bill where b_id=@b_id; ";
                SqlCommand comand = new SqlCommand(query, conn);
                conn.Open();
                comand.Parameters.AddWithValue("@b_id", bIdBox.Text);
                comand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                //ClearData();

                this.Hide();
                bill b = new bill();
                b.ShowDialog();


                //}
                //else
                // {
                //MessageBox.Show("Please Select Record to Delete");
                //}
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                bill b = new bill();
                b.ShowDialog();

            }

        }

        //modify//
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                //if (bIdBox.Text != "" && pIdBox.Text != "" && dIdBox.Text != "" && bAmBox.Text != "" && bStBox.Text != "")
                // {
                string query = "update Bill set  p_id=@p_id, d_id=@d_id, b_amount=@b_amount, b_status=@b_status where b_id=@b_id; ";
                SqlCommand comand = new SqlCommand(query, conn);
                conn.Open();
                comand.Parameters.AddWithValue("@b_id", bIdBox.Text);
                comand.Parameters.AddWithValue("@p_id", pIdBox.Text);
                comand.Parameters.AddWithValue("@d_id", dIdBox.Text);
                comand.Parameters.AddWithValue("@b_amount", bAmBox.Text);
                comand.Parameters.AddWithValue("@b_status", bStBox.Text);
                comand.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();
                DisplayData();
                //ClearData();
                this.Hide();
                bill b = new bill();
                b.ShowDialog();




                // }
                //else
                // {
                //MessageBox.Show("Please Select Record to Update");
                // }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                bill b = new bill();
                b.ShowDialog();

            }
        }

        //insert//
        private void button6_Click_1(object sender, EventArgs e)
        {

            try
            {
                //if (bIdBox.Text != "0" && pIdBox.Text != "" && dIdBox.Text != "" && bAmBox.Text != "" && bStBox.Text != "")
                // { 
                string query = "insert into Bill values (@b_id,@p_id,@d_id,@b_amount,@b_status); ";
                SqlCommand comand = new SqlCommand(query, conn);

                conn.Open();
                comand.Parameters.AddWithValue("@b_id", bIdBox.Text);
                comand.Parameters.AddWithValue("@p_id", pIdBox.Text);
                comand.Parameters.AddWithValue("@d_id", dIdBox.Text);
                comand.Parameters.AddWithValue("@b_amount", bAmBox.Text);
                comand.Parameters.AddWithValue("@b_status", bStBox.Text);
                comand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                //ClearData();
                this.Hide();
                bill b = new bill();
                b.ShowDialog();


                //}
                //else
                // {
                //MessageBox.Show("Please Provide Details!");
                //}
            }

            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                bill b = new bill();
                b.ShowDialog();

            }





        }


        private void billGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) ///////////////////
        {

            //it checks if the row index of the cell is greater than or equal to zero
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.billGrid.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                bIdBox.Text = row.Cells[0].Value.ToString();
                pIdBox.Text = row.Cells[1].Value.ToString();
                dIdBox.Text = row.Cells[2].Value.ToString();
                bAmBox.Text = row.Cells[3].Value.ToString();
                bStBox.Text = row.Cells[4].Value.ToString();

            }




            /*



            ID = Convert.ToInt32(billGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            //bIdBox.Text = billGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            pIdBox.Text = billGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            dIdBox.Text = billGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            bAmBox.Text = billGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            bStBox.Text = billGrid.Rows[e.RowIndex].Cells[5].Value.ToString();              */
        }

        private void billGrid_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                //if (bIdBox.Text != "" && pIdBox.Text != "" && dIdBox.Text != "" && bAmBox.Text != "" && bStBox.Text != "")
                // {
              //string query = "update Bill set b_amount=@b_amount where b_id=@b_id; ";
                string query = "UPDATE Bill SET b_amount += @b_amount WHERE b_id=@b_id; ";
                SqlCommand comand = new SqlCommand(query, conn);
                conn.Open();
                comand.Parameters.AddWithValue("@b_id", bIdBox.Text);
                comand.Parameters.AddWithValue("@b_amount", bAmBox.Text);
                comand.ExecuteNonQuery();
                MessageBox.Show("Bill Updated Successfully");
                conn.Close();
                DisplayData();
                //ClearData();
                this.Hide();
                bill b = new bill();
                b.ShowDialog();


                // }
                //else
                // {
                //MessageBox.Show("Please Select Record to Update");
                // }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

                this.Hide();
                bill b = new bill();
                b.ShowDialog();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();
                string query = "Update Bill set b_status= 'Given' WHERE b_id=@b_id";
                SqlCommand comand = new SqlCommand(query, conn);

                comand.Parameters.AddWithValue("@b_id", bIdBox.Text);

                comand.ExecuteNonQuery();
                //Response.Redirect("manegar.aspx");
                MessageBox.Show("Bill Given");
                conn.Close();

                this.Hide();
                bill b = new bill();
                b.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");


                this.Hide();
                bill b = new bill();
                b.ShowDialog();
            }
        }







        ////////////////////
        /*
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }  */

        /*
        try
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
            conn.Open();
            //string query = "UPDATE dbo.patient SET p_name = @p_name,p_sex = @p_sex,p_address = @p_address,p_contact = @p_contact,d_type = @d_type WHERE p_id = @p_id; ";
            string query = "insert into Bill values (@b_id,@p_id,@d_id,@b_amount,@b_status); ";
            SqlCommand comand = new SqlCommand(query, conn);

            comand.Parameters.AddWithValue("@b_id", bIdBox.Text);
            comand.Parameters.AddWithValue("@p_id", pIdBox.Text);
            comand.Parameters.AddWithValue("@d_id", dIdBox.Text);
            comand.Parameters.AddWithValue("@b_amount", bAmBox.Text);
            comand.Parameters.AddWithValue("@b_status", bStBox.Text);

            comand.ExecuteNonQuery();
            //Response.Redirect("manegar.aspx");
            MessageBox.Show("Successfully Billed");
            conn.Close();

            this.Hide();
            bill b = new bill();
            b.ShowDialog();
        }
        catch (Exception ex)
        {
            //MessageBox.Show("ERORR:" + ex.ToString());
            MessageBox.Show("ERORR");

        } */

    }
}
