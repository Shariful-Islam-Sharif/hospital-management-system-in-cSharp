using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class recFrame : Form
    {
        public recFrame()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            recLogin rl = new recLogin();
            rl.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegPatient pr = new RegPatient();
            pr.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            DelPatient dp = new DelPatient();
            dp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyPatient mp = new ModifyPatient();
            mp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewPatient vp = new viewPatient();
            vp.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admit a = new Admit();
            a.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientAppoint ps = new patientAppoint();
            ps.ShowDialog();
 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Release r = new Release();
            r.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewAdmitPatient vap = new viewAdmitPatient();
            vap.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            bill b = new bill();
            b.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientEdit pe = new patientEdit();
            pe.ShowDialog();
        }
    }
}
