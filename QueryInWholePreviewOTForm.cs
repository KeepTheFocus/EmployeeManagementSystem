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
    public partial class QueryInWholePreviewOTForm : Form
    {
        public QueryInWholePreviewOTForm()
        {
            InitializeComponent();
        }

        OverTimeCauseForm causeForm;


        //给查询按钮设置 点击事件
        private void btn_queryInGroup_Click(object sender, EventArgs e)
        {
            //先判断是否存在组
            //if (true)
            //{

            //}
            //如果存在组就获取输入框中的工号进行查询

            //判断是否有输入工号
            //如果是否有输入工号 判断是否存在于预计加班数据表中
            //如果存在 则弹出消息框显示工号信息
            //如果不存在 则弹出消息框提示用户 该工号不存在
            if (tb_EmployeeNumber2query.Text!=string.Empty)
            {
                //打开数据库进行查询操作 
                using (SqlConnection sqlConnection=new SqlConnection())
                {
                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();

                    sqlConnection.Open();

                    //创建要执行的sql语句
                    string stringZero = "select * from PreviewOverTime where EmployeeNumber='" + tb_EmployeeNumber2query.Text + "'  ";
                    SqlCommand sqlCommandZero = new SqlCommand(stringZero, sqlConnection);
                    //创建数据读取器
                    SqlDataReader sqlDataReaderZero = sqlCommandZero.ExecuteReader();
                    if (sqlDataReaderZero.Read())
                    {
                        DialogResult = DialogResult.OK;



                    }
                    else
                    {
                        MessageBox.Show("在预计加班人员列表中查询工号为"+tb_EmployeeNumber2query.Text+"的员工");
                    }

                }
            }
            else
            {
                MessageBox.Show("请输入要查询的工号");
            }
        }
    }
}
