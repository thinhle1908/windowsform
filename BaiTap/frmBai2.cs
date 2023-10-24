using QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaiphuongtrinhbac2
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
        }

        private void txtNhapA_Leave(object sender, EventArgs e)
        {
            if(txtNhapA.Text == String.Empty)
            {
                errorProvider1.SetError(txtNhapA, "Vui long nhap A");
                btnXoa.Enabled = false;
            }
        }

        private void txtNhapB_Leave(object sender, EventArgs e)
        {
            if (txtNhapB.Text == String.Empty)
            {
                errorProvider1.SetError(txtNhapB, "Vui long nhap B");
                     btnXoa.Enabled = false;
            }
         
        }



        private void txtNhapA_TextChanged(object sender, EventArgs e)
        {
            if(handlecls.checkNumber(txtNhapA.Text) == true)
            {
                errorProvider1.SetError(txtNhapA, null);
                btnXoa.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtNhapA, "Only Number");
                btnXoa.Enabled = false;
            }

        }

        private void txtNhapB_TextChanged(object sender, EventArgs e)
        {
            if (handlecls.checkNumber(txtNhapB.Text) == true)
            {
                errorProvider1.SetError(txtNhapB, null);
                btnXoa.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtNhapB, "Only Number");
                btnXoa.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapA.Text = "";
            txtNhapB.Text = "";
            txtNghiem.Text = "";
            txtNhapA.Focus();
            btnXoa.Enabled = false;
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            txtNghiem.Text = handlecls.GiaiPT(int.Parse(txtNhapA.Text), int.Parse(txtNhapB.Text));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
