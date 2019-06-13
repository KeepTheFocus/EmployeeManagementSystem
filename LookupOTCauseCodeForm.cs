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
    public partial class LookupOTCauseCodeForm : Form
    {
        public LookupOTCauseCodeForm()
        {
            InitializeComponent();
        }
        string DBCauseNumber,
               DBCauseScription;


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }





        //给查询按钮设置  点击事件

        private void btn_Search_Click(object sender, EventArgs e)
        {

           
            //先判断文本框中是否输入了内容

            //如果没有输入内容，则提示用户输入内容

            //如果输入了内容 那么先获取文本框中的内容
            //然后打开数据库连接

            //调用查询的sql语句

            //如果没有查询到该原因代码 那么就弹出消息框提示用户，该原因代码不存在
            //如果查到了该原因代码
            //那么就更新加班原因文本框 和 加班原因描述富文本框中的内容

            if (tb_CauseCode.Text!=string.Empty)
            {
                using (SqlConnection sqlConnection=new SqlConnection())
                {
                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                    //打开数据库的连接
                    sqlConnection.Open();
                    //创建要执行的sql语句
                    string stringZero = "select * from OverTimeCause where CauseNumber='"+tb_CauseCode.Text+"'";

                    SqlCommand sqlCommandZero = new SqlCommand(stringZero,sqlConnection);
                    //创建数据读取器的实例
                    SqlDataReader sqlDataReaderzero = sqlCommandZero.ExecuteReader();
                    if (sqlDataReaderzero.Read())
                    {
                        //从数据表中取出原因代码
                        //从数据表中取出原因描述
                        DBCauseNumber = sqlDataReaderzero["CauseNumber"].ToString();
                        DBCauseScription = sqlDataReaderzero["CauseScription"].ToString();
                        //使用\r\n来实现在消息提示框中进行换行操作


                        tb_code.Text = DBCauseNumber;
                        tb_scription.Text = DBCauseScription;
                       
                            //overTimeCauseForm = new OverTimeCauseForm();
                            //overTimeCauseForm.tb_CauseNumber.Text = DBCauseNumber;
                            //overTimeCauseForm.rtb_CauseScription.Text = DBCauseScription;
                        //将DBCauseNumber 和 DBCauseScription 的值传回给OverTimeCauseForm窗体
                    }
                    else
                    {
                        MessageBox.Show("找不到您要查找的原因代码,\r\n请核实您输入的代码");
                    }

                    //关闭数据读取器
                    sqlDataReaderzero.Close();
                    //关闭数据库的连接
                    sqlConnection.Close();
                }
            }
            else
            {
                
                MessageBox.Show("请输入要查找的原因代码");
            }

        }
    }
}
