using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaiTap
{
    public partial class frmC2B5 : Form
    {
        public frmC2B5()
        {
            InitializeComponent();
            lswName.GridLines = true;
            lswName.View = View.Details;
            ColumnHeader colLN = new ColumnHeader();
            colLN.Text = "Last Name";
            ColumnHeader colFN = new ColumnHeader();
            colFN.Text = "First Name";
            ColumnHeader colP = new ColumnHeader();
            colP.Text = "Phone";
            lswName.Columns.AddRange(new ColumnHeader[] { colLN, colFN, colP });
            
           Image pc1 = Image.FromFile(@"..\..\..\Hinh\Vietnam.jpg");
            ImageList lpc = new ImageList();
            lpc.Images.Add(pc1);
            lswName.SmallImageList = lpc;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            ListViewItem item1 = new ListViewItem($"{txtLastName.Text}",0);
            item1.SubItems.Add(txtFirstName.Text);
            item1.SubItems.Add(txtPhone.Text);
            
            lswName.Items.Add(item1);

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lswName.View = View.List;
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lswName.View = View.Tile;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lswName.View = View.Details;
        }

        private void formatListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                lswName.BackColor = cd.Color;
            }
        }

        private void lswName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
