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
    public partial class frmC2B6 : Form
    {
        public frmC2B6()
        {
            InitializeComponent();
            lswSinhVien.GridLines = true;
            lswSinhVien.View = View.Details;
            ColumnHeader colMa = new ColumnHeader();
            colMa.Text = "Mã";
            ColumnHeader colHoTen = new ColumnHeader();
            colHoTen.Text = "Họ tên";
            ColumnHeader colDiaChi = new ColumnHeader();
            colDiaChi.Text = "Địa chỉ";
            ColumnHeader colNgaySinh = new ColumnHeader();
            colNgaySinh.Text = "Ngày sinh";
            ColumnHeader colLop = new ColumnHeader();
            colLop.Text = "Lớp";
            lswSinhVien.Columns.AddRange(new ColumnHeader[] { colMa,colHoTen,colDiaChi,colNgaySinh,colLop });
            lswSinhVien.FullRowSelect = true;
            lswSinhVien.SmallImageList = ilsNho;
            lswSinhVien.LargeImageList = ilsLon;

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtMaSV.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            cboLop.SelectedIndex = 0;

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem($"{txtMaSV.Text}",0);
            item1.SubItems.Add(txtHoTen.Text);
            item1.SubItems.Add(txtDiaChi.Text);
            item1.SubItems.Add(dtpNgaySinh.Text);
            item1.SubItems.Add(cboLop.Text);
            lswSinhVien.Items.Add(item1);
            //Tu dong dinh dang cot
            lswSinhVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnXoaItem_Click(object sender, EventArgs e)
        {
            if(lswSinhVien.SelectedItems.Count > 0)
            {
                for(int i = lswSinhVien.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lswSinhVien.Items.Remove(lswSinhVien.SelectedItems[i]);
                }
                
            }
        }

        private void lswSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Luu y khong co dong if se khogn chay duoc
            if (lswSinhVien.SelectedItems.Count > 0)
            {
                txtMaSV.Text = lswSinhVien.SelectedItems[0].SubItems[0].Text;
                txtHoTen.Text = lswSinhVien.SelectedItems[0].SubItems[1].Text;
                txtDiaChi.Text = lswSinhVien.SelectedItems[0].SubItems[2].Text;
                dtpNgaySinh.Value = DateTime.Parse(lswSinhVien.SelectedItems[0].SubItems[3].Text);
                cboLop.SelectedIndex = cboLop.FindString( lswSinhVien.SelectedItems[0].SubItems[4].Text);

            }
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lswSinhVien.View = View.LargeIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lswSinhVien.View = View.List;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lswSinhVien.View = View.SmallIcon;
        }

        private void dettailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lswSinhVien.View = View.Details;
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lswSinhVien.View = View.Tile;
        }
    }
}
