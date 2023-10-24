using C2;
using giaiphuongtrinhbac2;
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
using WindowsFormsApp3;
using WindowsFormsApp4;

namespace demo
{
    public partial class frmC2B3 : Form
    {
        public frmC2B3()
        {
            InitializeComponent();
            
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai2 f1 = new frmBai2();
          
            f1.MdiParent = this;
            f1.Show();
            
        }
        private void bai1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai1 f1 = new frmBai1();
            f1.MdiParent = this;
            
            f1.Show();
            
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai3 f1 = new frmBai3();
            f1.MdiParent = this;
          
            f1.Show();
        
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai4 f1 = new frmBai4();
            f1.MdiParent = this;
           
            f1.Show();

        }

        private void trợGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
