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
    public partial class viewStaff : Form
    {
        public viewStaff()
        {
            InitializeComponent();

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCIEBGS;Initial Catalog='Hospital Management System';Integrated Security=True;");
                conn.Open();


                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Staff2", conn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                staffGrid.DataSource = dtbl;


            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERORR:" + ex.ToString());
                MessageBox.Show("ERORR");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            managementForm mf = new managementForm();
            mf.ShowDialog();
        }
    }
}
