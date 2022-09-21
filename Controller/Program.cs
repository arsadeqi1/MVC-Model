using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1
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

            UserInfo info = new UserInfo();

            var f1 = new Form1();
            f1.UserInfoxxx = info;
            f1.ShowDialog();

            var f2 = new Form2();
            f2.UserInfowww = info;
            f2.ShowDialog();
        }
    }
}
