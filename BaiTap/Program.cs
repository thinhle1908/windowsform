using Bai5;
using Bai6;
using Bai7;
using C2;
using demo;
using giaiphuongtrinhbac2;
using QLSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;
using WindowsFormsApp4;

namespace BaiTap
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmC2B7());
        }
    }
}
