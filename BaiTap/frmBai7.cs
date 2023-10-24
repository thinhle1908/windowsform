using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class frmBai7 : Form
    {
        public frmBai7()
        {
            InitializeComponent();
            btnCapNhat.Enabled = false;
            btnTongUoc.Enabled = false;
            btnSoLuongSoChan.Enabled = false;
            btnSoLuongUocNguyenTo.Enabled = false;  

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           if(txtNhapSo.Text != null)
            {
                cboNumber.Items.Add(txtNhapSo.Text);
                txtNhapSo.Text = null;
                txtNhapSo.Focus();
                btnCapNhat.Enabled = false; 
            }
        }

        private void txtNhapSo_TextChanged(object sender, EventArgs e)
        {
            if (txtNhapSo.Text != null)
            {
                btnCapNhat.Enabled = true;
            }
           
        }

        private void cboNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsUocSo.Items.Clear();
            List<string> danhSachCacUoc = Numberic.uocCuaSo(cboNumber.SelectedItem.ToString());
            string[] arr = danhSachCacUoc.ToArray();
            lsUocSo.Items.AddRange(arr);
            btnTongUoc.Enabled = true;
            btnSoLuongSoChan.Enabled = true;
            btnSoLuongUocNguyenTo.Enabled = true;
        }

        private void btnTongUoc_Click(object sender, EventArgs e)
        {
            string message = Numberic.tongUocCacSo(lsUocSo.Items.OfType<string>().ToArray());
            MessageBox.Show(message);
        }

        private void btnSoLuongSoChan_Click(object sender, EventArgs e)
        {
            string message = Numberic.soLuongSoChan(lsUocSo.Items.OfType<string>().ToArray());
            MessageBox.Show(message);
        }

        private void btnSoLuongUocNguyenTo_Click(object sender, EventArgs e)
        {
            string message = Numberic.soLuongUocCacSoNguyenTo(lsUocSo.Items.OfType<string>().ToArray());
            MessageBox.Show(message);
        }

        private void lsUocSo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
