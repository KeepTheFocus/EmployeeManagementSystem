using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace EmployeeManagementSystem
{
    public partial class SalaryCalculatorForm : Form
    {
        public SalaryCalculatorForm()
        {
            InitializeComponent();
        }

        //工作日加班费
        double normalSalay;
        //周末加班费
        double weekSalary;

        //法定节假日加班费
        double festivalSalary;

        //本月应发工资
        double SumSalary;

        string OvertimePay;

        //工作日加班费率
        string strNormalRate;
        //周末加班费率
        string strWeekRate;
        //节假日加班费率
        string strFestivalRate;



        //获取全勤奖
        string full;

        //获取职务补贴
        string duty;

        //获取外宿补贴
        string outside;

        //获取餐费补贴
        string meal;


        //实际出勤小时
        string AttendancedHour;
        //实际缺勤小时
        string AbsencedHour;
        //实际请假小时
        string LeavedHour;
        //实际正常加班小时
        string NormaledHour;
        //实际周末加班小时
        string WeekedHour;
        //实际节假日加班小时
        string FestivaledHour;

        //返回得到当月 应该出勤的总小时数
        string workedHour;

        string FinalSalary;
        string Name;
        string strBasicPay;

        //获取 在输入框中的员工编号 月份编码 部门名称
        string strEN;
        string strMonth;
        string strSN;


        private void button5_Click(object sender, EventArgs e)
        {
            //退出窗体
            Close();
        }

        //给计算按钮添加 点击事件
        private void btn_count_Click(object sender, EventArgs e)
        {
            //获取 在输入框中的员工编号 月份编码 部门名称
            strEN = tb_EmployeeNumber.Text;
            strMonth = tb_Month.Text;
            strSN = tb_SectionName.Text;

            if (strEN == "" || strSN == "")
            {
                MessageBox.Show("请输入员工工号和月份");
            }
            else
            {



                //创建数据库的连接
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                    //打开数据库的连接
                    sqlConnection.Open();

                    //创建要执行的Sql语句
                    string sqlFirst = "select WorkHour from Calender where YearMonth='" + strMonth + "'";

                    //创建SqlCommand对象
                    SqlCommand sqlCommand = new SqlCommand(sqlFirst, sqlConnection);
                    //创建sqlDataReader对象
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        //返回得到当月 应该工作的总小时数
                        workedHour = sqlDataReader.GetString(0);
                    }






                    //关闭对象
                    sqlDataReader.Close();
                    //关闭连接
                    sqlConnection.Close();

                }

                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();


                    //打开数据库的连接
                    sqlConnection.Open();

                    //创建要执行的Sql语句
                    string sqlSecond = "select * from AttendanceReport where EmployeeNumber='" + strEN + "'";
                    //创建SqlCommand对象
                    SqlCommand sqlCommand = new SqlCommand(sqlSecond, sqlConnection);
                    //创建sqlDataReader对象
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    //当数据读取器可以移动到下一条记录  布尔表达式为真时  执行循环体内的语句
                    while (sqlDataReader.Read())
                    {
                        //获取sql结果集中  索引为1的列的数据
                        Name = sqlDataReader.GetString(1);
                        //实际出勤小时
                        AttendancedHour = sqlDataReader.GetString(2);
                        //实际缺勤小时
                        AbsencedHour = sqlDataReader.GetString(3);
                        //实际请假小时
                        LeavedHour = sqlDataReader.GetString(4);
                        //实际正常加班小时
                        NormaledHour = sqlDataReader.GetString(5);
                        //实际周末加班小时
                        WeekedHour = sqlDataReader.GetString(6);
                        //实际节假日加班小时
                        FestivaledHour = sqlDataReader.GetString(7);
                    }








                    //关闭对象
                    sqlDataReader.Close();
                    //关闭连接
                    sqlConnection.Close();
                }



                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();

                    //打开数据库的连接
                    sqlConnection.Open();
                    //创建要执行的Sql语句
                    string sqlThird = "select * from UpholdSalaryFiles where EmployeeNumber='" + strEN + "'";

                    //创建SqlCommand对象
                    SqlCommand sqlCommand = new SqlCommand(sqlThird, sqlConnection);
                    //创建sqlDataReader对象
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();



                    while (sqlDataReader.Read())
                    {
                        //获取基本工资
                        strBasicPay = sqlDataReader.GetString(2);
                        //获取全勤奖
                        full = sqlDataReader.GetString(3);
                        //获取职务补贴
                        duty = sqlDataReader.GetString(4);
                        //获取外宿补贴
                        outside = sqlDataReader.GetString(5);
                        //获取餐费补贴
                        meal = sqlDataReader.GetString(6);
                        //获取数据库中存入的工作日加班费率
                        strNormalRate = sqlDataReader.GetString(7);
                        //获取数据库中存入的周末加班费率
                        strWeekRate = sqlDataReader.GetString(8);
                        //获取数据库中存入的节假日加班费率
                        strFestivalRate = sqlDataReader.GetString(9);
                    }



                    //关闭对象
                    sqlDataReader.Close();
                    //关闭连接
                    sqlConnection.Close();
                }

                /* 
                 * (1).如果本月实际出勤小时数==出勤日历中的小时数
                 * 
                那么应发工资==基本工资+全勤奖+职务补贴+外宿补贴
                +餐食补贴+加班费


                   (2).如果本月实际出勤小时<出勤日历中的小时数

                那么应发工资==每小时工作费率*实际出勤小时+职务补贴+外宿补贴
                +餐食补贴+加班费


                  (3).如果本月出勤小时>出勤日历中的小时数

                  弹出消息框提示用户 “本月出勤小时数超出额定范围 请联系财务修正
                  出勤详情”
                   */
                int n = 0;
                             //本月实际出勤小时    等于     出勤日历中的小时
                if (int.Parse(AttendancedHour)==int.Parse(workedHour))
                {
                    n = 1;
                }            //本月实际出勤小时    小于     出勤日历中的小时
                else if (int.Parse(AttendancedHour)<int.Parse(workedHour))
                {
                    n = 2;
                }           //本月实际出勤小时    大于     出勤日历中的小时
                else if(int.Parse(AttendancedHour)>int.Parse(workedHour))
                {
                    n = 3; 
                }
         
                switch (n)
                {
                    case 1:

                        //计算本月 正常工作日加班费
                        normalSalay = Convert.ToDouble(strNormalRate) * Convert.ToDouble(NormaledHour);
                        //计算本月  周末加班费
                        weekSalary = Convert.ToDouble(strWeekRate) * Convert.ToDouble(WeekedHour);

                        //计算本月  法定节假日加班费
                        festivalSalary = Convert.ToDouble(strFestivalRate) * Convert.ToDouble(FestivaledHour);


                        //本月应发工资 
                        SumSalary = double.Parse(strBasicPay) + double.Parse(duty) + double.Parse(outside)
                            + double.Parse(meal) + normalSalay + weekSalary + festivalSalary;
                        // MessageBox.Show(strEN+"***千里之行***"+strMonth+"***始于足下***"+strSN);

                        //本月应发的所有加班工资
                        OvertimePay = (normalSalay + weekSalary + festivalSalary).ToString();
                        //应发工资
                        FinalSalary = SumSalary.ToString();


                        MessageBox.Show("本月应发工资为" + SumSalary.ToString() + "元！！！" + "本月工作日加班费总计" + normalSalay.ToString() + "元！" + "本月周末加班费总计" + weekSalary.ToString() + "元！" + "本月法定节假日加班费总计" + festivalSalary.ToString() + "元");

                        //将值写入对应的数据库表中  SalaryCalculator
                        string sqlString = "insert into SalaryCalculator values ('" + strEN + "','" + Name + "','" + strMonth + "'," +
                            "'" + strBasicPay + "','" + full + "','" + duty + "','" + outside + "','" + meal + "','" + OvertimePay + "','" + FinalSalary + "')";

                        //创建数据库连接 
                        using (SqlConnection sqlConnection = new SqlConnection())
                        {

                            //将连接数据库的字符串赋值给ConnectionString
                            sqlConnection.ConnectionString = UtilitySql.SetConnectionString();

                            //创建SQLCommand类的实例
                            SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);

                            //打开连接
                            sqlConnection.Open();
                            //如果受Sql命令影响的行数 大于0 那么弹出消息对话框提示 工资计算成功
                            if (sqlCommand.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("工资计算成功");
                            }

                            //关闭连接 
                            sqlConnection.Close();

                            UpdateListview();







                        }

                        break;
                    case 2:

                        MessageBox.Show("你本月无全勤奖");
                        break;
                    case 3:
                        MessageBox.Show("您本月实际出勤小时数超标 请联系财务计算薪资");

                        break;

                    //default语句用来处理无效的选择
                    default:
                        break;
                }















            }
        }









        //点击保存按钮后 刷新listview实时显示数据表中最新的信息
        public void UpdateListview()
        {
            //移除listview中所有的已显示的信息
            listView_CountResult.Items.Clear();

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
            cmd.CommandText = "select * from SalaryCalculator";
            //创建一个数据读取器
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sdr["EmployeeNumber"].ToString();
                lvi.SubItems.Add(sdr["EmployeeName"].ToString());
                lvi.SubItems.Add(sdr["Month"].ToString());
                lvi.SubItems.Add(sdr["BasicPay"].ToString());
                lvi.SubItems.Add(sdr["FullAttendanceBonus"].ToString());
                lvi.SubItems.Add(sdr["DutyAllowance"].ToString());
                lvi.SubItems.Add(sdr["StayOutSideAllowance"].ToString());
                lvi.SubItems.Add(sdr["MealAllowance"].ToString());
                lvi.SubItems.Add(sdr["OvertimePay"].ToString());
                lvi.SubItems.Add(sdr["FinalPay"].ToString());
                //将数据添加进listview控件中
                listView_CountResult.Items.Add(lvi);

            }
            //关闭流
            connection.Close();



        }


        //清空所有 输入框和下拉框中的内容
        public void ClearTextBox()
        {
            tb_EmployeeNumber.Text = "";
            tb_Month.Text = "";
            tb_SectionName.Text = "";
        }



        //给查找按钮 增加点击事件
        private void btn_Search_Click(object sender, EventArgs e)
        {

            //清空列表中显示的内容
            listView_CountResult.Items.Clear();
            //如果输入框中没有输入工号 则弹出消息框提示用户
            if (tb_EmployeeNumber.Text == "" || tb_Month.Text == "")
            {
                MessageBox.Show("请输入要查询的工号和月份");
            }
            {
                //创建sql查询语句
                string sqlString = "select * from SalaryCalculator where EmployeeNumber='" + tb_EmployeeNumber.Text + "' and Month='" + tb_Month.Text + "'";

                //建立与数据库的连接
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    //把连接数据库的字符串 赋值给ConnectionString
                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();

                    //创建SqlCommand实例

                    SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);

                    //打开连接
                    sqlConnection.Open();

                    //创建数据读取器
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        //创建一个listviewitem的实例
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.Text = sqlDataReader["EmployeeNumber"].ToString();
                        listViewItem.SubItems.Add(sqlDataReader["EmployeeName"].ToString());
                        listViewItem.SubItems.Add(sqlDataReader["Month"].ToString());
                        listViewItem.SubItems.Add(sqlDataReader["BasicPay"].ToString());
                        listViewItem.SubItems.Add(sqlDataReader["FullAttendanceBonus"].ToString());
                        listViewItem.SubItems.Add(sqlDataReader["DutyAllowance"].ToString());
                        listViewItem.SubItems.Add(sqlDataReader["StayOutSideAllowance"].ToString());
                        listViewItem.SubItems.Add(sqlDataReader["MealAllowance"].ToString());
                        listViewItem.SubItems.Add(sqlDataReader["OverTimePay"].ToString());
                        listViewItem.SubItems.Add(sqlDataReader["FinalPay"].ToString());

                        //把新建的行 添加到列表中
                        listView_CountResult.Items.Add(listViewItem);

                    }

                    if (!sqlDataReader.HasRows)
                    {
                        MessageBox.Show("不好意思 ，查询不到您要找的工资记录 请核实工号和月份 谢谢！！");
                    }
                    //释放资源
                    sqlDataReader.Close();
                    //关闭连接
                    sqlConnection.Close();
                    //清空消息
                    ClearTextBox();
                }




            }
        }

        //给删除按钮添加点击事件
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //1 获取当前持有焦点的条目的索引

            int a=listView_CountResult.FocusedItem.Index;
            //获取被选中条目的工号

            string strNumber=listView_CountResult.Items[a].SubItems[0].Text;
            //获取被选中条目的月份
            string strMonth = listView_CountResult.Items[a].SubItems[2].Text;

            //创建与数据库的连接
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                //将连接字符串赋值给connectionString
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();

                //创建要执行的sql语句
                string sqlString = "delete from SalaryCalculator where EmployeeNumber='"+strNumber+"' and Month='"+strMonth+"'";

                //创建SqlCommand实例
                SqlCommand sqlCommand = new SqlCommand(sqlString,sqlConnection);
                //打开数据库连接

                sqlConnection.Open();
                //调用executedno函数进行判断 如果大于零 提示删除成功

                if (sqlCommand.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("记录删除成功");
                }


                //关闭数据库连接
                sqlConnection.Close();
                //刷新列表
                UpdateListview();

            }
        }
    }
}
