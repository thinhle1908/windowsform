using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (handlecls.checkNumber(txtYear.Text) == true)
            {
                errorProvider1.SetError(txtYear, null);
            }
            else
            {
                errorProvider1.SetError(txtYear, "Only number");

            }
           
        }

        private void frmMain_Leave(object sender, EventArgs e)
        {
          
        }

        private void txtYourName_Leave(object sender, EventArgs e)
        {
            if (txtYourName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtYourName, "Please enter your name");
            }
            else
            {
                errorProvider1.SetError(txtYourName,null);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
          
            String message = "";
            int age = DateTime.Now.Year - Int32.Parse(txtYear.Text);
            message = "Your name is " + txtYourName.Text + "\n" + "Age" + age;
            MessageBox.Show(message);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYear.Clear();
            txtYourName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to close ","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if(r == DialogResult.No) 
            {
                e.Cancel = true;
            }
        }
    }
}
