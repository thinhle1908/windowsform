using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C2
{
    public partial class frmC2B1 : Form
    {
        public frmC2B1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mskDoB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            Process.Start("http://www.tdc.edu.vn");
            linkLabel1.ActiveLinkColor = Color.Olive;
            linkLabel1.VisitedLinkColor = Color.Blue;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Khong duoc de trong o name");
                txtName.Focus();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = $"Employee:"+txtName.Text+"\n"+ "Date of Birth:" + mskDoB.Text + "\n" + "Adrress:" + txtAdrress.Text + "\n" + "City:" + lstCity.Text + "\n" + "Phone:" + makPhone.Text + "\n" + "Date of Joining:" + dateTimePicker1.Text + "\n";
            MessageBox.Show(message);
        }
    }
}
