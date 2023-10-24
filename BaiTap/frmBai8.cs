using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class frmBai8 : Form
    {
        public frmBai8()
        {
            InitializeComponent();
            btnNhap.Enabled = false;
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8","9","10" };

            lsNumber.Items.AddRange(numbers);
           
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            lsNumber.Items.Add(txtNhap.Text);
           
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNhap.Text != "")
                {
                    int.Parse(txtNhap.Text);
                    btnNhap.Enabled = true;
                }
                else
                {
                    btnNhap.Enabled = false;
                }
            }
            catch
            {

                btnNhap.Enabled = false;
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            string str = Numberic.tongUocCacSo(lsNumber.Items.OfType<string>().ToArray());
            MessageBox.Show(str);
        }

        private void btnXoaPhanTuDauCuoi_Click(object sender, EventArgs e)
        {
            if (lsNumber.Items.Count > 1)
            {
                lsNumber.Items.RemoveAt(0);
                lsNumber.Items.RemoveAt(lsNumber.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Khong du phan tu trong mang");
            }
        }

        private void btnXoaPhanTuDangChon_Click(object sender, EventArgs e)
        {
            if(lsNumber.SelectedItem != null)
            {
                lsNumber.Items.Remove(lsNumber.SelectedItem);
            }
            else
            {
                MessageBox.Show("Ban phai them phan tu vao listbox");
            }
        }

        private void btnTangGiaTriPhanTu_Click(object sender, EventArgs e)
        {
            string[] str = Numberic.tang2DonViChoMoiPhanTu(lsNumber.Items.OfType<string>().ToArray());
            lsNumber.Items.Clear();
            lsNumber.Items.AddRange(str);
        }

        private void btnThayBangBinhPhuong_Click(object sender, EventArgs e)
        {
            string[] str = Numberic.binhPhuong(lsNumber.Items.OfType<string>().ToArray());
            lsNumber.Items.Clear();
            lsNumber.Items.AddRange(str);
        }

        private void btnChonSoChan_Click(object sender, EventArgs e)
        {
            /* lsNumber.SetSelected(1, true);
            lsNumber.SetSelected(2, true); */

   
            for (int i = 0; i < lsNumber.Items.Count; i++)
            {

                 if (lsNumber.GetSelected(i) == false)
                   {
                       if (int.Parse(lsNumber.Items[i].ToString()) % 2 == 0)
                       {
                           lsNumber.SetSelected(i, true);
                       }
                   }
                   else
                   {
                       lsNumber.SetSelected(i, false);
                   }
                
              /*  if (int.Parse(lsNumber.Items[i].ToString()) % 2 == 0)
                {
                    if (lsNumber.GetSelected(i) == false)
                    {
                        lsNumber.SetSelected(i, true);
                    }
                    else
                    {
                        lsNumber.SetSelected(i, false);
                    }
                }
              */
            }
             
        }

        private void btnChonSoLe_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsNumber.Items.Count; i++)
            {
                if (lsNumber.GetSelected(i) == false)
                {
                    if (int.Parse(lsNumber.Items[i].ToString()) % 2 != 0)
                    {
                        lsNumber.SetSelected(i, true);
                    }
                }
                else
                {
                    lsNumber.SetSelected(i, false);
                }
                /*
                       if (int.Parse(lsNumber.Items[i].ToString()) % 2 != 0)
                       {
                           if (lsNumber.GetSelected(i) == false)
                           {
                               lsNumber.SetSelected(i, true);
                           }
                           else
                           {
                               lsNumber.SetSelected(i, false);
                           }
                       }
                   */

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

