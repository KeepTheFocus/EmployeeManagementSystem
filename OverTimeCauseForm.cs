using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class OverTimeCauseForm : Form
    {
       

        public OverTimeCauseForm()
        {
            InitializeComponent();
        }

        //创建字符串变量用来保存文本框中输入的原因编号
        string strCauseNumber;

        //创建字符串变量用来保存文本框中输入的原因说明
        string strCauseScription;

        //给工具栏上的新建   设置点击事件
        private void tsl_create_Click(object sender, EventArgs e)
        {
            //禁用新建
            tsl_create.Enabled = false;
            //禁用查找
            tsl_search.Enabled = false;
            //禁用删除
            tsl_remove.Enabled = false;
            //禁用第一个原因
            tsl_FirstCause.Enabled = false;

            //禁用上一个原因
            tsl_previousCause.Enabled = false;
            //禁用下一个原因
            tsl_nextCause.Enabled = false;
            //禁用最后一个原因
            tsl_EndCause.Enabled = false;

            //激活工具栏上的 保存 
            tsl_store.Enabled = true;
            //激活工具栏上的 取消
            tsl_Cancel.Enabled = true;

            //激活原因文本框
            tb_CauseNumber.Enabled = true;
            //激活说明富文本框
            rtb_CauseScription.Enabled = true;

            //激活原因文本框的读写属性
            tb_CauseNumber.ReadOnly = false;
            //激活说明富文本框的读写属性
            rtb_CauseScription.ReadOnly = false;
            ////清空原因文本框
            tb_CauseNumber.Text = "";
            ////清空说明富文本框
            rtb_CauseScription.Text = "";

            

            

        }

        //给工具栏的保存 设置点击事件
        private void tsl_store_Click(object sender, EventArgs e)
        {
            //激活新建、
            tsl_create.Enabled = true;

            //禁用保存
           // tsl_store.Enabled = false;
            //激活查找
            tsl_search.Enabled = true;
            //激活删除
            tsl_remove.Enabled = true;
            //禁用取消
            tsl_Cancel.Enabled = false;
            //激活第一个原因
            tsl_FirstCause.Enabled = true;
            //激活上一个原因
            tsl_previousCause.Enabled = true;
            //激活下一个原因
            tsl_nextCause.Enabled = true;
            //激活最后一个原因
            tsl_EndCause.Enabled = true;

            //tb_CauseNumber.Text =strCauseNumber;
            //rtb_CauseScription.Text =strCauseScription;
            

            strCauseNumber = tb_CauseNumber.Text;
            strCauseScription = rtb_CauseScription.Text;


            MessageBox.Show("原因代码是   " + strCauseNumber);

            MessageBox.Show("原因说明是   " + strCauseScription);
            //tb_CauseNumber.Enabled = false;
            //rtb_CauseScription.Enabled = false;

            //将文本框和富文本框中输入的内容保存到数据表OverTimeCause
            //打开数据库的连接
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();

                //打开数据库连接
                sqlConnection.Open();

                //创建要执行的sql语句
                string sqlStringFirst = "insert into OvertimeCause values('"+strCauseNumber+"','"+strCauseScription+"')";
                //创建sqlcommand命令的实例
                SqlCommand sqlCommand = new SqlCommand(sqlStringFirst,sqlConnection);
                if (sqlCommand.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("加班代码以及加班原因   已经保存进数据表中");
                }

                //关闭数据库的连接
                sqlConnection.Close();
            }

            CompareID();
        }

        //在窗体加载过程中 执行的函数
        private void OverTimeCauseForm_Load(object sender, EventArgs e)
        {
            //显示数据表overtimecause中第一个原因 (原因代码 以及 原因说明)
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //连接数据库
                sqlConnection.Open();
                //创建要执行的sql语句
                string strFirst = "select top 1 * from overtimeCause";
                //创建sqlcommand命令的实例
                SqlCommand sqlCommand = new SqlCommand(strFirst,sqlConnection);
                //创建数据读取器
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    //将数据读取器中结果集的列数据读取处理 赋值给文本框和富文本框中 
                    tb_CauseNumber.Text=sqlDataReader["CauseNumber"].ToString();
                    rtb_CauseScription.Text=sqlDataReader["CauseScription"].ToString();
                }
            }

            //禁用工具栏上的保存
            tsl_store.Enabled = false;
            //禁用工具栏上的取消
            tsl_Cancel.Enabled = false;

            //禁用原因编号文本框、
            tb_CauseNumber.ReadOnly = true;
            //禁用原因描述富文本框
            rtb_CauseScription.ReadOnly =true;

            CompareID();

        }

        //给工具栏上的删除 设置点击事件
        private void tsl_remove_Click(object sender, EventArgs e)
        {
           
            //弹出消息框 是否删除该原因
            //=MessageBoxButtons.YesNo;
            var result = MessageBox.Show("你确定要删除小组" +tb_CauseNumber.Text+ "吗", "", MessageBoxButtons.YesNo);
            CompareID();
            if (DialogResult.Yes == result)
            {
                //执行从数据表中删除该组的操作
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                    //打开连接
                    sqlConnection.Open();
                    //创建要执行的sql语句
                    string strSQL = "delete from OverTimeCause where CauseNumber='" +tb_CauseNumber.Text+ "'";
                    //创建sqlcommand类的实例
                    SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection);
                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("原因编号" +tb_CauseNumber.Text+ "已经成数据表中删除成功");
                    }

                    //创建要执行的sql语句
                    string strSQL2 = "delete from OverTimeCause where CauseNumber='" +tb_CauseNumber.Text+ "'";
                    //创建sqlCommand类的实例
                    SqlCommand command = new SqlCommand(strSQL2, sqlConnection);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("原因编号" +tb_CauseNumber.Text+ "已经从数据表中删除成功");
                    }
                    //将原因编码框清空
                    // tb_CauseNumber.Text = "";
                    //将原因说明富文本框清空
                    // rtb_CauseScription.Text = "";

                    CompareID();
                    //将最大的ID所代表的原因编码和原因说明显示到文本框和富文本框中
                    //创建要执行的sql语句
                    string strSQL3 = "select * from OverTimeCause where id='"+MaxID.ToString()+"'";
                    //创建要执行的sqlcommand命令的实例
                    SqlCommand sqlCommand3 = new SqlCommand(strSQL3,sqlConnection);
                    //创建一个数据读取器
                    SqlDataReader sqlDataReader = sqlCommand3.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        tb_CauseNumber.Text = sqlDataReader["CauseNumber"].ToString();
                        rtb_CauseScription.Text = sqlDataReader["CauseScription"].ToString();

                    }

                    //关闭数据读取器
                    sqlDataReader.Close();
                    //关闭连接
                    sqlConnection.Close();
                }

                CompareID();
            }
        }

        //给工具栏上的取消 设置点击事件
        private void tsl_Cancel_Click(object sender, EventArgs e)
        {
            //刷新获取当的ID值
            CompareID();

            //清空原因编号文本框、
            tb_CauseNumber.Text = "";
            //清空原因描述富文本框
            rtb_CauseScription.Text = "";

            //还原文本框中之前显示的原因编号

            //还原富文本之前显示的原因描述
        }



        //声明三个string 类型的变量 分别用来保存当前ID 数据表中最大ID 数据表中最小ID
        int CurrentID,
               MaxID,
               MinID;

        //给上一个原因  设置点击事件
        private void tsl_previousCause_Click(object sender, EventArgs e)
        {
            //拿到当前原因的ID 即CurrentID （通过调用CompareID函数）
            CompareID();
            //通过CurrentID 得到上一个比CurrentID更小的ID
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //连接数据库
                sqlConnection.Open();
                //创建要执行的sql语句
                string stringfirst = "select top 1 id from OverTimeCause where id <'"+CurrentID+"' order by id desc ";
                SqlCommand sqlCommand = new SqlCommand(stringfirst,sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    CurrentID = int.Parse(sqlDataReader["id"].ToString());
                  
                }

                //关闭读取器
                sqlDataReader.Close();

                //创建要执行的sql语句
                string stringSecond = "select * from OverTimeCause where id='"+CurrentID.ToString()+"'";

                SqlCommand sqlCommandSecond = new SqlCommand(stringSecond, sqlConnection);
                SqlDataReader sqlDataReaderSecond = sqlCommandSecond.ExecuteReader();
                while (sqlDataReaderSecond.Read())
                {
                    
                    tb_CauseNumber.Text = sqlDataReaderSecond["CauseNumber"].ToString();
                    rtb_CauseScription.Text = sqlDataReaderSecond["CauseScription"].ToString();
                }

                //关闭读取器
                sqlDataReaderSecond.Close();


                //关闭连接

                sqlConnection.Close();
            }
            //调用CompareID()进行ID更新操作
            CompareID();

        }

        //给下一个原因  设置点击事件
        private void tsl_nextCause_Click(object sender, EventArgs e)
        {
           
            //通过CurrentID 得到下一个比CurrentID更大的ID
            //拿到当前原因的ID 即CurrentID （通过调用CompareID函数）
            CompareID();
            //通过CurrentID 得到上一个比CurrentID更小的ID
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //连接数据库
                sqlConnection.Open();
                //创建要执行的sql语句
                string stringfirst = "select top 1 id from OverTimeCause where id >'" + CurrentID.ToString() + "' order by id asc ";
                SqlCommand sqlCommand = new SqlCommand(stringfirst, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    CurrentID = int.Parse(sqlDataReader["id"].ToString());
                 
                }
                MessageBox.Show("当前ID是"+CurrentID.ToString());
                //关闭读取器
                sqlDataReader.Close();
                //创建要执行的sql语句
                string stringSecond = "select * from OverTimeCause where id ='"+CurrentID+"'";
                SqlCommand sqlCommandSecond = new SqlCommand(stringSecond, sqlConnection);
                SqlDataReader sqlDataReaderSecond = sqlCommandSecond.ExecuteReader();
            
                while (sqlDataReaderSecond.Read())
                {
                   
                    tb_CauseNumber.Text = sqlDataReaderSecond["CauseNumber"].ToString();
                    rtb_CauseScription.Text = sqlDataReaderSecond["CauseScription"].ToString();
                }

             

                //关闭读取器
                sqlDataReaderSecond.Close();
                //关闭连接

                sqlConnection.Close();
            }
            //调用CompareID()进行ID更新操作
            CompareID();


        }

        //给最后一个原因  设置点击事件
        private void tsl_EndCause_Click(object sender, EventArgs e)
        {
            //获取到数据表中的MaxID  （通过调用CompareID函数）
            CompareID();
            //通过MaxID进行查询
            //获取到数据表中的MinID （通过调用CompareID函数）


            //通过MinID进行查询
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //打开连接
                sqlConnection.Open();
                //创建要执行的sql语句
                string stringFirst = "select * from OverTimeCause where id ='" + MaxID + "'";
                SqlCommand sqlCommand = new SqlCommand(stringFirst, sqlConnection);
                //创建数据读取器
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    //将从结果集中取出来的值 赋值给文本框 和富文本框
                    tb_CauseNumber.Text = sqlDataReader["CauseNumber"].ToString();
                    rtb_CauseScription.Text = sqlDataReader["CauseScription"].ToString();
                }

                //关闭数据读取器
                sqlDataReader.Close();
                //关闭数据库的连接
                sqlConnection.Close();



            }
            CompareID();
        }

        //给工具栏上的查找 设置点击事件
        private void tsl_search_Click(object sender, EventArgs e)
        {

            
            //激活文本框
            // tb_CauseNumber.ReadOnly = false;
            //激活富文本框
            //rtb_CauseScription.ReadOnly = false;

            //创建查询加班原因的 窗体
            LookupOTCauseCodeForm causeCodeForm = new LookupOTCauseCodeForm();
            //使窗体显示出来
           // causeCodeForm.ShowDialog();

            if (causeCodeForm.ShowDialog()==DialogResult.OK)
            {
                tb_CauseNumber.Text = causeCodeForm.tb_code.Text;
                rtb_CauseScription.Text = causeCodeForm.tb_scription.Text;
            }

            causeCodeForm.Dispose();
        }

        //给第一个原因  设置点击事件
        private void tsl_FirstCause_Click(object sender, EventArgs e)
        {
            //获取到数据表中的MinID （通过调用CompareID函数）
            CompareID();

            //通过MinID进行查询
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //打开连接
                sqlConnection.Open();
                //创建要执行的sql语句
                string stringFirst = "select * from OverTimeCause where id ='"+MinID+"'";
                SqlCommand sqlCommand = new SqlCommand(stringFirst, sqlConnection);
                //创建数据读取器
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    //将从结果集中取出来的值 赋值给文本框 和富文本框
                    tb_CauseNumber.Text=sqlDataReader["CauseNumber"].ToString();
                    rtb_CauseScription.Text = sqlDataReader["CauseScription"].ToString();
                }

                //关闭数据读取器
                sqlDataReader.Close();
                //关闭数据库的连接
                sqlConnection.Close();



            }

            CompareID();

        }

        //辅助函数 用来判断当前组的ID是不是ID的最大值，或ID的最小值
        private void CompareID()
        {
            //获取当前记录的ID值 如果ID值在数据表中为最小。说明是第一条记录
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                //设置数据库的连接字符串
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //打开数据库的连接
                sqlConnection.Open();

                //创建要执行的sql语句
                string sqlStringZero = "select * from OverTimeCause";
                //创建sqlCommand的实例
                SqlCommand sqlCommandZero = new SqlCommand(sqlStringZero,sqlConnection);
                //创建数据读取器的实例
                SqlDataReader sqlDataReaderZero = sqlCommandZero.ExecuteReader();
                //做个判断 如果数据表中存在数据 
                //当数据表中有数据存在时 执行语句块中的逻辑
                if (sqlDataReaderZero.HasRows)
                {

                    //创建要执行的sql语句
                    string sqlString = "select ID from OverTimeCause where CauseNumber='" + tb_CauseNumber.Text + "'";
                    //创建sqlCommand类的实例
                    SqlCommand command = new SqlCommand(sqlString, sqlConnection);
                    sqlDataReaderZero.Close();
                    //创建数据库读取器
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {      //将返回的结果集中的ID列中的的值取出，然后将其转化成int类型的值
                        CurrentID = int.Parse(reader["ID"].ToString());


                    }
                    //弹出消息框输出   当前组名在数据表Community中的对应ID值
                    //MessageBox.Show(CurrentID.ToString());

                    //关闭数据读取器
                    reader.Close();
                    //创建要执行的sql语句  取出当前数据表中最小的ID值
                    string getMinString = "select min(ID) from OverTimeCause";
                    SqlCommand sqlCommand = new SqlCommand(getMinString, sqlConnection);
                    //创建数据读取器的实例
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        //将返回结果集中的第一列的值取出来，并将其转化成int类型的值
                        MinID = int.Parse(sqlDataReader[0].ToString());
                    }
                    //消息提示框弹出 Community表中最小的ID值
                    // MessageBox.Show("数据表中最小的id值为"+MiniID.ToString());
                    //关闭数据读取器
                    sqlDataReader.Close();

                    //创建要执行的sql语句  取出当前数据表中最大的ID值
                    string getMaxString = "select max(ID) from OverTimeCause";

                    SqlCommand sqlCommandMax = new SqlCommand(getMaxString, sqlConnection);
                    //创建数据读取器的实例
                    SqlDataReader readerMax = sqlCommandMax.ExecuteReader();
                    while (readerMax.Read())
                    {
                        MaxID = int.Parse(readerMax[0].ToString());
                    }

                    //弹出消息框提示 community表中最大的值
                    //MessageBox.Show("数据表中最大的id值为"+MaxID.ToString());

                    if (CurrentID == MinID)
                    {
                        //MessageBox.Show("我是第一个小组");
                        //禁用第一个原因
                        tsl_FirstCause.Enabled = false;
                        //禁用上一个原因
                        tsl_previousCause.Enabled = false;

                        //激活下一一个原因
                        tsl_nextCause.Enabled = true;
                        //激活最后一个原因
                        tsl_EndCause.Enabled = true;
                    }
                    else if (CurrentID == MaxID)
                    {
                        //MessageBox.Show("我是最后一个小组");
                        //禁用下一个原因
                        tsl_nextCause.Enabled = false;
                        //禁用最后一个原因
                        tsl_EndCause.Enabled = false;

                        //激活第一个原因
                        tsl_FirstCause.Enabled = true;
                        //激活上一个原因
                        tsl_previousCause.Enabled = true;
                    }
                    else if (CurrentID != MaxID & CurrentID != MinID)
                    {
                        //激活下一个原因
                        tsl_nextCause.Enabled = true;
                        //激活最后一个原因
                        tsl_EndCause.Enabled = true;

                        //激活第一个原因
                        tsl_FirstCause.Enabled = true;
                        //激活上一个原因
                        tsl_previousCause.Enabled = true;

                    }
                    else if (CurrentID.ToString() == string.Empty | MaxID.ToString() == string.Empty | MinID.ToString() == string.Empty)
                    {
                        MessageBox.Show("数据表中已经没有原因组了");
                    }

                }
                else
                {
                    MessageBox.Show("数据表中已经没有数据了");
                    //清空文本框和富文本框
                    tb_CauseNumber.Text = "";
                    rtb_CauseScription.Text = "";
                    //禁用文本框和富文本框
                    tb_CauseNumber.Enabled = false;
                    rtb_CauseScription.Enabled = false;


                }
            }
        }
    }
}
