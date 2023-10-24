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

namespace BaiTap
{
    public partial class frmC2B7 : Form
    {
        public frmC2B7()
        {
            InitializeComponent();
           
        }

        private void frmC2B7_Load(object sender, EventArgs e)
        {
            lswTienDien.FullRowSelect = true;
            lswTienDien.MultiSelect = true;
            lswTienDien.GridLines = true;
            lswTienDien.View = View.Details;
            ColumnHeader colMa = new ColumnHeader();
            colMa.Text = "Họ tên";
            ColumnHeader colHoTen = new ColumnHeader();
            colHoTen.Text = "Khu vực";
            ColumnHeader colDiaChi = new ColumnHeader();
            colDiaChi.Text = "Định mức";
            ColumnHeader colNgaySinh = new ColumnHeader();
            colNgaySinh.Text = "Tiêu thụ";
            ColumnHeader colLop = new ColumnHeader();
            colLop.Text = "Thành tiền";
            lswTienDien.Columns.AddRange(new ColumnHeader[] { colMa, colHoTen, colDiaChi, colNgaySinh, colLop });
            lswTienDien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if(txtSoCu.Text.Trim().Length <= 0 && txtSoMoi.Text.Trim().Length <= 0 &&  handlecls.checkNumber(txtSoCu.Text)==true && handlecls.checkNumber(txtSoMoi.Text) == true)
            {
                return;
            }
            if(int.Parse(txtSoMoi.Text) < int.Parse(txtSoCu.Text))
            {
                MessageBox.Show("Nhap so moi phai lon hon so cu");
                return;
            }
            int tieuthu = int.Parse(txtSoMoi.Text) - int.Parse(txtSoCu.Text);
            txtTieuThu.Text = tieuthu.ToString();
            if( tieuthu <= int.Parse(txtDinhMuc.Text))
            {
                txtThanhTien.Text = (tieuthu * 500).ToString();
            }
            else
            {
                txtThanhTien.Text = (tieuthu * 1000).ToString();
            }
            ListViewItem item1 = new ListViewItem($"{txtHoTen.Text}", 0);
            item1.SubItems.Add(cboKhuVuc.Text);
            item1.SubItems.Add(txtDinhMuc.Text);
            item1.SubItems.Add(txtTieuThu.Text);
            item1.SubItems.Add(txtThanhTien.Text);
            lswTienDien.Items.Add(item1);

            lswTienDien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            int tongtien = int.Parse(txtTongTien.Text.Trim()) + int.Parse(txtThanhTien.Text.Trim());
            txtTongTien.Text = tongtien.ToString();

        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter){
                btnTinhTien_Click(sender, e);
            }
        }

        private void cboKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboKhuVuc.SelectedIndex == 0)
            {
                txtDinhMuc.Text = "50";
            }
            else if (cboKhuVuc.SelectedIndex == 1)
            {
                txtDinhMuc.Text = "100";
            }
            else
            {
                txtDinhMuc.Text = "150";
            }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {

            

            txtHoTen.Text = string.Empty;
            txtSoCu.Text = string.Empty;
            txtSoMoi.Text = string.Empty;
            txtTieuThu.Text = string.Empty;
            txtThanhTien.Text= string.Empty;
            txtDinhMuc.Text= string.Empty;
            cboKhuVuc.Text = string.Empty;
            
            txtHoTen.Focus();
        }
    }
}
