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
                MessageBox.Show("DotNetBar试用期已过，请登录官方网站进行注册", "提示");
                System.Diagnostics.Process.Start("http://www.devcomponents.com/");
                return;
            }
            Application.Run(new MainForm());
        }
    }
}
