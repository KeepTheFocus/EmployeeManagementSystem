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
    public partial class UpholdAttendanceForm : Form
    {
        public UpholdAttendanceForm()
        {
            InitializeComponent();
        }



        //当窗体加载时 执行的函数
        private void UpholdAttendanceForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(dtp_YearMonth.Text);
            //创建数据库连接的实例
           SqlConnection connection = new SqlConnection(UtilitySql.SetConnectionString());
            //打开数据库
            connection.Open();
            //创建数据库命令的实例
           SqlCommand cmd = connection.CreateCommand();
            //把要执行的sql语句 传递给cmd实例
            cmd.CommandText = "select * from AttendanceReport";
            //创建一个数据读取器
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                //创建listviewitem实例
                //将数据库中所有的字段显示到  窗体的listview控件中
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sdr["EmployeeNumber"].ToString();
                lvi.SubItems.Add(sdr["EmployeeName"].ToString());
                lvi.SubItems.Add(sdr["YearMonth"].ToString());
                lvi.SubItems.Add(sdr["AttendanceHour"].ToString());
                lvi.SubItems.Add(sdr["AbsenceHour"].ToString());
                lvi.SubItems.Add(sdr["LeaveHour"].ToString());
                
                lvi.SubItems.Add(sdr["NormalOvertimeHour"].ToString());
                lvi.SubItems.Add(sdr["WeekOvertimeHour"].ToString());
                lvi.SubItems.Add(sdr["FestivalOvertimeHour"].ToString());
                //将数据添加进listview控件中
                listview_AttendanceReport.Items.Add(lvi);

            }
            //关闭流
            connection.Close();
        }
        //给回车键添加点击事件
        private void tb_Number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                //MessageBox.Show("你刚才敲击了回车键");
                //当工号输入完后  将输入的工号取出来 保存在变量strNumber中
                string strNumber = tb_Number.Text;
               // tb_Name.Text = strNumber;
                //打开数据库连接
            using (SqlConnection sqlConnection=new SqlConnection())
                {
                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                    //打开连接
                    sqlConnection.Open();

                    string strsql = "select EmployeeName from EmployeeFiles where EmployeeNumber='"+strNumber+"'";
                    SqlCommand sqlcommand = new SqlCommand(strsql, sqlConnection);
                    SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
                    //当数据读取器可以移动到下一条记录的布尔表达式 返回值为真时 执行循环体内的语句
                    while (sqlDataReader.Read())
                    {
                        //读取sql结果集中 EmployeeName列中的数据 并将其转化成字符串
                        tb_Name.Text = sqlDataReader["EmployeeName"].ToString();
                    }

                    //关闭连接
                    sqlConnection.Close();
                }
            }
        }

        //给保存按钮 添加点击事件
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //获取所有文本框中已输入的值
            string Number = tb_Number.Text,
             Name = tb_Name.Text,
             YearMonth=dtp_YearMonth.Text,
             Attendance = tb_AttendanceHour.Text,
             Absence = tb_AbsenceHour.Text,
             Leave = tb_LeaveHour.Text,
             Normal = tb_normal.Text,
             Week = tb_Week.Text,
             Festival = tb_Festival.Text;
            //先判断输入框中的内容是否存在于数据表中
            //如果存在 执行Update函数
            //如果不存在 则执行Insert函数
            //创建数据库连接的对象


            using (SqlConnection sqlConnectionDR=new SqlConnection())
            {
                sqlConnectionDR.ConnectionString = UtilitySql.SetConnectionString();
                //打开连接
                sqlConnectionDR.Open();
                //创建要执行的sql命令语句
                string strSQL = "select * from AttendanceReport where YearMonth='"+dtp_YearMonth.Text+"'";
                //创建SqlCommand类的实例
                SqlCommand sqlCommandDR = new SqlCommand(strSQL,sqlConnectionDR);
                //创建数据读取器类的实例
                SqlDataReader sqlDataReader = sqlCommandDR.ExecuteReader();

                //如果数据表中存在记录
                if (sqlDataReader.Read())
                {
                    //关闭sqlDataReader对象
                    sqlDataReader.Close();
                    //那么执行Update语句

                    //创建要执行的sqlUpdate语句
                    string strUpdate = " update AttendanceReport set EmployeeNumber = '" + tb_Number.Text + "',EmployeeName= '" +tb_Name.Text+ "', AttendanceHour = '" +tb_AttendanceHour.Text+ "', AbsenceHour = '" +tb_AbsenceHour.Text+ "', LeaveHour = '" +tb_LeaveHour.Text+ "', NormalOvertimeHour = '" +tb_normal.Text+ "', WeekOvertimeHour = '" +tb_Week.Text+ "', FestivalOvertimeHour = '" +tb_Festival.Text+ "' where YearMonth = '" +dtp_YearMonth.Text+ "'";
                    //创建SqlCommand命令的实例
                    SqlCommand sqlCommandUE = new SqlCommand(strUpdate, sqlConnectionDR);
                    //如果被SqlCommand命令影响的行数 大于零的话 则弹出消息记录更新成功
                    if (sqlCommandUE.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("记录更新成功");
                    }
                  

                }
                else
                {
                    //关闭数据读取器对象
                    sqlDataReader.Close();
                    //如果数据表中不存在记录
                    //那么执行Insert语句
                    //创建要执行的Insert语句
                    string strInsert = "insert into AttendanceReport values('" + Number + "','" + Name + "','" + YearMonth + "','" + Attendance + "','" + Absence + "','" + Leave + "','" + Normal + "','" + Week + "','" + Festival + "')";
                    //创建sqlCommand命令的实例
                    SqlCommand sqlCommandIT = new SqlCommand(strInsert,sqlConnectionDR);
                    //如果受命令影响的行数大于零 则提示用户记录插入成功
                    if (sqlCommandIT.ExecuteNonQuery()>0)

                    {
                        MessageBox.Show("记录插入成功");
                    }
                    else
                    {
                        MessageBox.Show("记录插入失败");
                    }
                }

                //关闭连接
                sqlConnectionDR.Close();
                //调用刷新列表的 函数
                UpdateListview();

            }

            ClearTextBox();
        }

        //定义一个长度为8的数组用来保存  要传递进来的字符串
        public string[] str = new string[9];

        //给修改按钮 添加点击事件
        private void btn_Alter_Click(object sender, EventArgs e)
        {
            try
            {
                //获取当前被选中项的 索引
                int a = listview_AttendanceReport.FocusedItem.Index;

                for (int i = 0; i < 9; i++)
                {
                    //将列表中对应的第几行 第几列数据  所代表的文本值传入到数组对象中 
                    str[i] = listview_AttendanceReport.Items[a].SubItems[i].Text;
                }

                //将数组中对应索引位置的值  赋值给文本框中
                tb_Number.Text = str[0];
                tb_Name.Text = str[1];
               
                MessageBox.Show(str[2]);
                MessageBox.Show(str[2].Substring(0, 4));
                MessageBox.Show(str[2].Substring(4));
       
                // dtp_YearMonth.Text=dtp_YearMonth.Value.ToString(str[2]);
                //tb_YearMonth.Text = str[2];
                //dtp_YearMonth.Value = Convert.ToDateTime(str[2]);
                tb_AttendanceHour.Text = str[3];
                tb_AbsenceHour.Text = str[4];
                tb_LeaveHour.Text = str[5];
                tb_normal.Text = str[6];
                tb_Week.Text = str[7];
                tb_Festival.Text = str[8];
            }
            catch (Exception  ba )
            {
                MessageBox.Show(ba.Message);
            }
        
        }

        //给删除按钮 添加点击事件
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //从listview中删除  获取 捕获焦点的条目
            int a=listview_AttendanceReport.FocusedItem.Index;
            //  获取到被选中项的工号
           string strNumber= listview_AttendanceReport.Items[a].SubItems[0].Text;
            //与数据库建立连接
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //打开连接
                sqlConnection.Open();
                //创建要执行的数据库命令                                     SQL中 文本用 ' ' 号包裹
                string strSQL = "delete from AttendanceReport where EmployeeNumber='"+strNumber+"'";
                //创建SQLcommand实例
                SqlCommand sqlCommand = new SqlCommand(strSQL,sqlConnection);

                //如果受sql命令影响的条数大于零 那么弹出消息提示框
                if (sqlCommand.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("记录删除成功");
                }
                //从列表中删除指定的条目
                listview_AttendanceReport.Items.RemoveAt(a);
                //关闭连接
                sqlConnection.Close();
            }
        }


        //给退出按钮 添加点击事件
        private void btn_Esc_Click(object sender, EventArgs e)
        {
            //退出窗体
            Close();
        }

        //点击保存按钮后 刷新listview实时显示数据表中最新的信息
        public void UpdateListview()
        {
            //移除listview中所有的已显示的信息
            listview_AttendanceReport.Items.Clear();

            //将数据库中所有的字段显示到  窗体的listview控件中

            //创建数据库连接的实例
           SqlConnection connection = new SqlConnection(UtilitySql.SetConnectionString());
            //打开数据库
            connection.Open();
            //创建数据库命令的实例
          SqlCommand  cmd = connection.CreateCommand();
            //把要执行的sql语句 传递给cmd实例
            cmd.CommandText = "select * from AttendanceReport";
            //创建一个数据读取器
            SqlDataReader sdr = cmd.ExecuteReader();

            //当数据读取器可以移动到下一条记录的布尔表达式 返回值为真时 执行循环体内的语句
            while (sdr.Read())
            {
                //创建listviewitem实例
                ListViewItem lvi = new ListViewItem();
                //读取Sql结果集中 EmoployeeNumber列中的数据 并将其转成字符串
                lvi.Text = sdr["EmployeeNumber"].ToString();
                lvi.SubItems.Add(sdr["EmployeeName"].ToString());
                lvi.SubItems.Add(sdr["YearMonth"].ToString());
                lvi.SubItems.Add(sdr["AttendanceHour"].ToString());
                lvi.SubItems.Add(sdr["AbsenceHour"].ToString());
                lvi.SubItems.Add(sdr["LeaveHour"].ToString());
                lvi.SubItems.Add(sdr["NormalOvertimeHour"].ToString());
                lvi.SubItems.Add(sdr["WeekOvertimeHour"].ToString());
                lvi.SubItems.Add(sdr["FestivalOvertimeHour"].ToString());
               
                //将数据添加进listview控件中
                listview_AttendanceReport.Items.Add(lvi);

            }
            //关闭流
            connection.Close();
        }
        //清空所有 输入框的内容
        public void ClearTextBox()
        {
            tb_Number.Text = "";
            tb_Name.Text = "";
           // tb_YearMonth.Text = "";
            tb_AttendanceHour.Text = "";
            tb_AbsenceHour.Text = "";
            tb_LeaveHour.Text = "";
            tb_normal.Text = "";
            tb_Week.Text = "";
            tb_Festival.Text = "";
        }

        //当日历中的年月发生变动时 文本框中的年月也要随之改变
        private void dtp_YearMonth_ValueChanged(object sender, EventArgs e)
        {

        }

        //给从att2000数据库中提取数据设置 点击事件
        private void btn_RetrieveFromAtt2000_Click(object sender, EventArgs e)
        {
            checkBox_Manually.CheckState = CheckState.Unchecked;
            //让出勤、工昨日加班 节假日加班 法定节假日加班 文本框变成只读状态
            tb_AttendanceHour.ReadOnly = true;
            tb_normal.ReadOnly = true;
            tb_Week.ReadOnly = true;
            tb_Festival.ReadOnly = true;

            //获取当前的系统月份 如果是8月，那么就从数据库中读取出7月份的考勤数据  
        }

        private void checkBox_Manually_CheckStateChanged(object sender, EventArgs e)
        {
               
        }

        private void checkBox_Manually_CheckedChanged(object sender, EventArgs e)
        {
            //当手动录入考勤数据被激活时
            if ((sender as CheckBox).Checked)
            {
                //激活出勤 工作日加班 节假日加班 法定节假日加班
                tb_AttendanceHour.ReadOnly = false;
                tb_normal.ReadOnly = false;
                tb_Week.ReadOnly = false;
                tb_Festival.ReadOnly = false;
            } 
        }
    }
}
