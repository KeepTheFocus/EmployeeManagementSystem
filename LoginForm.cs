using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace EmployeeManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //登录界面的登录按钮事件 
        private void btn_Login(object sender, EventArgs e)
        {
            //获取输入的用户名
            string name = textBox1.Text,
                 //获取输入的密码
                 password = textBox2.Text;
                //创建SqlConnection的实例
            using (SqlConnection cn = new SqlConnection())
            {
                //创建数据库连接字符串
                cn.ConnectionString = UtilitySql.SetConnectionString();
                //打开与数据库实例 HarvestRhythmZero的连接
                cn.Open();

                //创建一个要执行的 SQL语句
                string strSQL = string.Format("Select * From Admin where Account='" + name + "'and Password='" + password + "'");
                //创建一个SQL命令实例
                SqlCommand sc = new SqlCommand(strSQL, cn);
                //创建一个数据读取器 对象
                SqlDataReader sdr = sc.ExecuteReader();
                //如果不存在查询结果 则弹出消息框提示 输入的用户不存在
                if (!sdr.HasRows)
                {
                    MessageBox.Show("该用户不存在或密码有误,请核对后再输入");
                }
                else
                {
                   // MessageBox.Show("登录成功");
                    DialogResult = DialogResult.OK;

                    //关闭登录窗口
                    Close();
                }
            }
        }
        //给退出按钮 添加点击事件
        private void btn_quit(object sender, EventArgs e)
        {
            //关闭所有窗体
            Close();
        }

        //取消按钮
        private void btn_cancel(object sender, EventArgs e)
        {
            //清空用户框
            textBox1.Text = "";
            //清空密码框
            textBox2.Text = "";
        }
    }
}
