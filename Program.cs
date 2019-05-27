using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //是风格显示在 应用程序上 
            Application.EnableVisualStyles();
            //设置是否启用兼容性文本渲染
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            //  Application.Run(new MainForm());
            //创建登录窗口的的实例

            LoginForm lf = new LoginForm();
            //用对话框的形式展示出来
            lf.ShowDialog();
            //如果对话框返回的结果是OK 
            if (lf.DialogResult==DialogResult.OK)
            {
                //那么就启动主窗体
                Application.Run(new MainForm());
            }
            else
            {
                //否则就退出
                return;
            }
        }
    }
}
