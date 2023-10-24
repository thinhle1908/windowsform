using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class frmBai6 : Form
    {
        public frmBai6()
        {
            InitializeComponent();
            pcbimage.Image = Image.FromFile(@"..\..\..\Hinh\Vietnam.jpg");
            pcbimage.SizeMode = PictureBoxSizeMode.StretchImage;
            rdoVietNam.Checked = true;
            foreach(RadioButton item in grCountry.Controls)
            {
                item.CheckedChanged += radioButton_CheckedChanged;
            }
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)sender;
            pcbimage.Image = Image.FromFile(@"..\..\..\Hinh\" + rad.Text + ".jpg");
            pcbimage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
