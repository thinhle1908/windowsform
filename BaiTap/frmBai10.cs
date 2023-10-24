using System;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class frmBai10 : Form
    {
        public frmBai10()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Trim().Length <= 0 || txtName.Text.Trim().Length <= 0 || txtYear.Text.Trim().Length <= 0 || txtClass.Text.Trim().Length <= 0 || chkMonHoc.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Ban vui long nhap day du thong tin");
                return;
            }
            string hk = "";
            if (radHK1.Checked == true)
            {
                hk = "1";
            }
            else if (radHK2.Checked == true)
            {
                hk = "2";
            }
            else if (radHK3.Checked == true)
            {
                hk = "3";
            }
            else
            {
                hk = "4";
            }
            string message = $"Sinh viên:{txtName.Text}\n" + $"Lớp:{txtClass.Text}\n" + $"Niên khóa:{txtYear.Text}\n" + $"Đã đăng ký học Học Kỳ:{hk}\n";
            for (int i = 0; i < chkMonHoc.CheckedItems.Count; i++)
            {
                message += chkMonHoc.CheckedItems[i].ToString() + "\n";
            }
            MessageBox.Show(message);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtNumber.Text = string.Empty;
            txtClass.Text = string.Empty;
            txtYear.Text = string.Empty;
            radHK1.Checked = false;
            radHK2.Checked = false;
            radHK3.Checked = false;
            radHK4.Checked = false;
            for (int i = 0; i < chkMonHoc.Items.Count; i++)
            {
                chkMonHoc.SetItemChecked(i, false);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
