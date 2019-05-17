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
            cmd.CommandText = "select * from AttendanceReport";
            //创建一个数据读取器
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                //创建listviewitem实例
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
        //当工号输入框的内容发生改变时  执行的函数
        private void tb_Number_TextChanged(object sender, EventArgs e)
        {
            
           
            //声明查询语句
           // select employeename from employee where employeenumber = 'strnumber'
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
            string Number = tb_Number.Text;
            string Name = tb_Name.Text;
            string YearMonth=tb_YearMonth.Text;
            string Attendance = tb_AttendanceHour.Text;
            string Absence = tb_AbsenceHour.Text;
            string Leave = tb_LeaveHour.Text;
            string Normal = tb_normal.Text;
            string Week = tb_Week.Text;
            string Festival = tb_Festival.Text;
            

            using (SqlConnection sqlConnection = new SqlConnection())
            {

                //建立与数据库的连接

                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //打开连接
                sqlConnection.Open();
                //创建要执行的Sql命令
                string strSql = "insert into AttendanceReport values('" + Number + "','" + Name + "','"+YearMonth+"','" + Attendance + "','" + Absence + "','" + Leave + "','" + Normal + "','" + Week+ "','" + Festival + "')";
                //创建SQLCommand实例

                SqlCommand sqlCommand = new SqlCommand(strSql, sqlConnection);

                //返回数据库中受影响的行数
                int count = sqlCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("数据添加成功");
                }
                //关闭连接
                sqlConnection.Close();
                //调用刷新列表的 函数
                UpdateListview();
            }

       

    }

        //定义一个长度为8的数组用来保存  要传递进来的字符串
        public string[] str = new string[8];

        //给修改按钮 添加点击事件
        private void btn_Alter_Click(object sender, EventArgs e)
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
            tb_YearMonth.Text = str[2];
            tb_AttendanceHour.Text = str[3];
           tb_AbsenceHour.Text = str[4];
            tb_LeaveHour.Text = str[5];
            tb_normal.Text = str[6];
            tb_Week.Text= str[7];
            tb_Festival.Text = str[8];
            
        }

       

        //给修改后保存按钮 添加点击事件
        private void btn_SaveAfterAlter_Click(object sender, EventArgs e)
        {
            //保存员工编号
            string strNumber = tb_Number.Text;
            //保存员工姓名
            string strName = tb_Name.Text;
            //保存年月编号
            string strYearMonth = tb_YearMonth.Text;


            //保存 出勤时间
            string strAttendance = tb_AttendanceHour.Text;
            //保存 缺勤时间
            string strAbsence = tb_AbsenceHour.Text;
            //保存 请假时间
            string strLeave = tb_LeaveHour.Text;
            //保存 正常加班时间
            string strNormal = tb_normal.Text;
            //保存 周末加班时间
            string strWeek = tb_Week.Text;
            //保存 法定节假日加班时间
            string strFestival = tb_Festival.Text;
         
            //声明将文本编辑框中的文本内容导入到数据库中的sql语句
            string strSql = " update AttendanceReport set EmployeeName='" + strName + "',YearMonth='"+strYearMonth+"',AttendanceHour='" + strAttendance + "',AbsenceHour='" + strAbsence + "',LeaveHour='" + strLeave + "',NormalOvertimeHour='" + strNormal + "',WeekOvertimeHour='" + strWeek + "',FestivalOvertimeHour='" + strFestival + "' where EmployeeNumber='" + strNumber + "'";

          
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
            //调用刷新Listview的函数
            UpdateListview();
            //调用清空TextBox的函数
            ClearTextBox();
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
            SqlConnection connection;
            SqlCommand cmd;
            

            //创建数据库连接的实例
            connection = new SqlConnection(UtilitySql.SetConnectionString());
            //打开数据库
            connection.Open();
            //创建数据库命令的实例
            cmd = connection.CreateCommand();
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
            tb_YearMonth.Text = "";
            tb_AttendanceHour.Text = "";
            tb_AbsenceHour.Text = "";
            tb_LeaveHour.Text = "";
            tb_normal.Text = "";
            tb_Week.Text = "";
            tb_Festival.Text = "";
        }
    }
}
