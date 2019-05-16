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
    public partial class DutyForm : Form
    {
        public DutyForm()
        {
            InitializeComponent();
        }





        //给保存按钮添加点击事件
        private void button_saveDuty_Click(object sender, EventArgs e)
        {
            //保存职务代码
            string strDutyCode = textBox_dutyCode.Text;
            //保存职务名称
            string strDutyName = textBox_dutyName.Text;

            //声明将文本编辑框中的数据保存到数据库中
            string strSql = "insert into Duty values" +
                "('" + strDutyCode + "','" + strDutyName + "')";



            //创建数据库连接
            SqlConnection connection = new SqlConnection(UtilitySql.SetConnectionString());
            //创建数据库命令
            SqlCommand command = new SqlCommand(strSql, connection);

            //打开连接
            connection.Open();



            //返回受Sql命令影响的行数
            int count = command.ExecuteNonQuery();
            //如果受影响的行数大于零 说明有记录被成功添加
            if (count > 0)
            {
                MessageBox.Show("职员信息添加成功");
            }

            //关闭连接
            connection.Close();
        }





        //给退出按钮添加点击事件
        private void button_escDuty_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        //窗体加载函数
        private void DutyForm_Load(object sender, EventArgs e)
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
            cmd.CommandText = "select * from Duty order by DutyCode desc";
            //创建一个数据读取器
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sdr["DutyCode"].ToString();
                lvi.SubItems.Add(sdr["DutyName"].ToString());

                //将数据添加进listview控件中
                listView_Duty.Items.Add(lvi);

            }
            //关闭流
            connection.Close();
        }
    }
}
