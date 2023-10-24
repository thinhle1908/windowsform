using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class frmBai5 : Form
    {
        public frmBai5()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            FontFamily f = new FontFamily("Times New Roman");
            txtNhap.Font = new Font(f, txtNhap.Font.Size);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            FontFamily f = new FontFamily("Arial");
            txtNhap.Font = new Font(f, txtNhap.Font.Size);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            FontFamily f = new FontFamily("Tahoma");
            txtNhap.Font = new Font(f, txtNhap.Font.Size);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            FontFamily f = new FontFamily("Courier New");
            txtNhap.Font = new Font(f, txtNhap.Font.Size);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
