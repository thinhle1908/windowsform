using C2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class frmC2B2 : Form
    {
        public frmC2B2()
        {
            InitializeComponent();
        }

        private void B2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 15;
            progressBar1.Value = 0;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 15)
            {
                progressBar1.Value++;
            }
            else 
            {
                timer1.Stop();
                frmC2B1 f1 = new frmC2B1();
                this.Visible = false;
                f1.Show();
                f1.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            frmC2B1 f1 = new frmC2B1();
            this.Visible = false;
            f1.Show();
            f1.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
           
        }
        private void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

    }
}
