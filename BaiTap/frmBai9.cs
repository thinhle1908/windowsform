using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class frmBai9 : Form
    {
        public frmBai9()
        {
            InitializeComponent();
        }

        private void frmBai9_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0)
            {  
                lstGroupA.Items.Add(txtName.Text);
                txtName.Text = "";
            }
            else
            {
                txtName.Focus();
                MessageBox.Show("Ban vui long nhap ho va ten");
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnToAllB_Click(object sender, EventArgs e)
        {
            if (lstGroupA.Items.Count > 0)
            {
                for (int i = 0; i < lstGroupA.Items.Count; i++)
                {
                    lstGroupB.Items.Add(lstGroupA.Items[i]);

                }
                lstGroupA.Items.Clear();
            }
            else
            {
                MessageBox.Show("Vui long them du lieu vao A");
                txtName.Focus();
            }
        }

        private void btnToB_Click(object sender, EventArgs e)
        {
            if(lstGroupA.SelectedItems.Count > 0)
            {
                for (int i = lstGroupA.SelectedItems.Count - 1; i >= 0 ; i--)
                {
                    lstGroupB.Items.Add(lstGroupA.SelectedItems[i]);
                    lstGroupA.Items.Remove(lstGroupA.SelectedItems[i]);
                }
            }
            else
            {
                MessageBox.Show("Vui long chon vao ten o bang A");
            }
        }

        private void btnToA_Click(object sender, EventArgs e)
        {

            if (lstGroupB.SelectedItems.Count > 0)
            {
                for (int i = lstGroupB.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lstGroupA.Items.Add(lstGroupB.SelectedItems[i]);
                    lstGroupB.Items.Remove(lstGroupB.SelectedItems[i]);
                   
                }
            }
            else
            {
                MessageBox.Show("Vui long chon vao ten o bang A");
            }
        }

        private void btnToAllA_Click(object sender, EventArgs e)
        {
            if (lstGroupB.Items.Count > 0)
            {
                for (int i = 0; i < lstGroupB.Items.Count; i++)
                {
                    lstGroupA.Items.Add(lstGroupB.Items[i]);

                }
                lstGroupB.Items.Clear();
            }else
            {
                MessageBox.Show("Vui long them du lieu vao A");
                txtName.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstGroupA.SelectedItems.Count > 0)
            {
                for (int i = lstGroupA.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lstGroupA.Items.Remove(lstGroupA.SelectedItems[i]);
                }
            }else
            {
                MessageBox.Show("Vui long chon vao ten o bang A");
            }
        }
    }
}
