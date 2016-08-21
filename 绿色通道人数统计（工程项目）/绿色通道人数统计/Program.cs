using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 绿色通道人数统计
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (DateTime.Now.Month != 8 || DateTime.Now.Year != 2016)
            {
                MessageBox.Show("Your Windows is Illegal!", "Warning");
                return;
            }
            Application.Run(new MainForm());
        }
    }
}
