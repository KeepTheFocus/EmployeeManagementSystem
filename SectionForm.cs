using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class SectionForm : Form
    {
        public SectionForm()
        {
            InitializeComponent();
        }
        //新建部门窗口中的保存按钮点击事件
        private void button_save_Click(object sender, EventArgs e)
        {
            //获取在textBox中输入的部门名称
            string StrSectionName = textBox_SectionName.Text,
            //获取在textBox中输入的部门代码
             StrSectionCode =textBox_SectionCode.Text;

            //声明将textBox中内容导入到数据库中的SQL语句          sql语句中 文本内容用''包裹
            string strSql = "insert into Section values"+"('"+StrSectionCode+"','"+StrSectionName+"')";
           
            //创建数据库连接
            SqlConnection sqlConnection = new SqlConnection(UtilitySql.SetConnectionString());
            //创建数据库命令
            SqlCommand sqlCommand = new SqlCommand(strSql,sqlConnection);
            //打开连接
            sqlConnection.Open();
            //返回受sql命令影响的行数
            int count = sqlCommand.ExecuteNonQuery();
            //如果受影响的行数大于零 说明有记录被添加
            if (count>0)
            {
                MessageBox.Show("部门信息添加成功");
            }
            //关闭数据库连接
            sqlConnection.Close();
        }

        //给退出按钮添加点击事件
        private void button_Esc_Click(object sender, EventArgs e)
        {
            //关闭当前部门信息窗体
          Close();
        }

        //窗体加载 函数
        private void SectionForm_Load(object sender, EventArgs e)
        {

            //将数据库中所有的字段显示到  窗体的listview控件中
            SqlConnection connection;
            SqlCommand cmd;
          

            //创建数据库连接的实例
            connection = new SqlConnection(UtilitySql.SetConnectionString());
            //打开数据库
            connection.Open();
            //创建数据库命令的实例
            cmd = connection.CreateCommand();
            //把要执行的sql语句 传递给cmd实例
            cmd.CommandText = "select * from Section order by SectionCode desc";
            //创建一个数据读取器
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                //创建listviewItem实例
                ListViewItem lvi = new ListViewItem();
                //将SQL结果集中的SectionCode列的值转化成字符串 并赋值给文本框
                lvi.Text = sdr["SectionCode"].ToString();
                lvi.SubItems.Add(sdr["SectionName"].ToString());
               
                //将数据添加进listview控件中
               listView_section.Items.Add(lvi);

            }
            //关闭流
            connection.Close();
        }
    }
}
