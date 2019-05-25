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

        //转化成字符串的形式进行存储
        string StrResultSumSalary,
        //转化成字符串的形式进行存储
         StrResultOvertimePay;
        

   /****** 本月应该计算的加班费******/
        //本月应发的 工作日加班费
        double ResultNormalSalay;
        //本月应发的 周末加班费
        double ResultWeekSalary;
        //本月应发的 法定节假日加班费
        double ResultFestivalSalary;
        //本月应发的 实际工资
        double ResultSumSalary;
        //本月应发的 全部加班费
        double ResultOvertimePay;


     /******存储维护薪资档案表中的数据******/

        //存储薪资档案表中的工作日加班费率
        string UhNormalRate,
        //存储薪资档案表中的周末加班费率
        UhWeekRate,
        //存储薪资档案表中的节假日加班费率
        UhFestivalRate,
        //存储薪资档案表中的全勤奖
         UhFull,
        //存储薪资档案表中的职务补贴
        UhDuty,
        //存储薪资档案表中的外宿补贴
         UhOutside,
        //存储薪资档案表中的餐费补贴
         UhMeal,
        //存储薪资档案表中的基本工资
         UhBasicPay;

        //给导出按钮设置点击事件
        private void btn_2Excel_Click(object sender, EventArgs e)
        {


            //创建一个保存文件的对话框
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            //设置文件的默认扩展名
            saveFileDialog.DefaultExt = "xlsx";
            //设置可选择保存的文件类型
            saveFileDialog.Filter = "Excel文件|*.xlsx";

            //是对话框显示出来
            saveFileDialog.ShowDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Export2Excel export2Excel = new Export2Excel();
                export2Excel.Export(listView_CountResult, saveFileDialog.FileName);
            }
        }



        /******存储考勤汇总表中的数据******/

        //存储考勤汇总表中的 实际出勤小时
        string ARAttendancedHour,
        //存储考勤汇总表中的 实际缺勤小时
         ARAbsencedHour,
        //存储考勤汇总表中的 实际请假小时
        ARLeavedHour,
        //存储考勤汇总表中的 实际正常加班小时
         ARNormaledHour,
        //存储考勤汇总表中的 实际周末加班小时
         ARWeekedHour,
        //存储考勤汇总表中的 实际节假日加班小时
         ARFestivaledHour,
        //存储考勤汇总表中的 职员名称
        ARName,
        //存储从数据库中读取年月
       ARYearMonth;

 /*****存储考勤日历表中的当月应该工作的小时数******/


        /*存储考勤日历表中当月应该出勤的小时数*/
        string CRHour,

        /*
         * 存储输入框中的内容
         */

        //获取 在窗体输入框中的 员工编号  
         strEN,
        //获取 在窗体输入框中的 年月编码
         strYearMonth,
        //获取 在窗体输入框中的 部门名称
          strSN;


        private void button5_Click(object sender, EventArgs e)
        {
            //退出窗体
            Close();
        }

        //创建两个布尔类型的标记
        Boolean booleanEM = false;
        Boolean booleanYM = false;


        //给计算按钮添加 点击事件
        private void btn_count_Click(object sender, EventArgs e)
        {
            //获取 在输入框中的 员工编号  
            strEN = tb_EmployeeNumber.Text;
            //获取 在输入框中的 月份编码
            strYearMonth = tb_YearMonth.Text;
            //获取 在输入框中的 部门名称
            //strSN = tb_SectionName.Text;

            //进行工资计算前 
            //应该判断员工编号 存在于职员表中
            // 月份编码存在于 考勤日历表中 


            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //打开数据库连接
                sqlConnection.Open();
                //创建要执行的sql语句
                string SQLQueryER = "select EmployeeNumber from EmployeeFiles where EmployeeNumber='" + strEN + "'";
                //创建SqlCommand命令的实例
                SqlCommand CommandER = new SqlCommand(SQLQueryER,sqlConnection);
                //创建数据读取器的实例
                SqlDataReader sqlDataReaderER = CommandER.ExecuteReader();
                if (sqlDataReaderER.HasRows)
                {
                    MessageBox.Show("工号存在");
                    //将true赋值给booleanEM变量
                    booleanEM = true;
                }
                else
                {
                    MessageBox.Show("工号不存在,请输入正确格式的工号");
                }

                //关闭读取器对象
                sqlDataReaderER.Close();

                //创建要执行的sql语句
                string SQLQueryYM = "select YearMonth from Calender where YearMonth='"+strYearMonth+"'";
                //创建sqlCommand命令的实例
                SqlCommand CommandYM = new SqlCommand(SQLQueryYM,sqlConnection);
                //创建数据读取器的实例
                SqlDataReader sqlDataReaderYM = CommandYM.ExecuteReader();
                if (sqlDataReaderYM.HasRows)
                {
                    MessageBox.Show("考勤月份存在");
                    //将true变量赋值给booleanYM变量
                    booleanYM = true;

                }
                else
                {
                    MessageBox.Show("考勤月份不存在,请输入正确格式的考勤月份");
                }
                //关闭数据读取器对象
                sqlDataReaderYM.Close();

                //当员工工号和年月编码都为正确的值时
                //进行正确的计算操作

                if (booleanEM==true&booleanYM==true)
                {
                    //从考勤日历表中查看当月工作时长为多少个小时
                    //创建要执行的查询语句
                    string SQLCalender = "select WorkHour from Calender where YearMonth='"+strYearMonth+"'";
                    
                    //创建SqlCommand命令的实例
                    SqlCommand sqlCommandCalender = new SqlCommand(SQLCalender,sqlConnection);
                    //创建数据读取器的实例
                    SqlDataReader sdrCalender = sqlCommandCalender.ExecuteReader();
                    while (sdrCalender.Read())
                    {
                        CRHour=sdrCalender.GetString(0);
                        MessageBox.Show("yesCalender");
                    }

                    
                    //关闭数据读取器的实例
                    sdrCalender.Close();
                    //从考勤汇总表中查看职员当月考勤的全部信息
                    //创建要执行的查询语句
                    string SQLAttendanceReport = "select *  from AttendanceReport where EmployeeNumber='" + strEN+"' and YearMonth='"+strYearMonth+"'";
                   
                    //创建SQLCommand命令的实例
                    SqlCommand sqlCommandAttendanceReport = new SqlCommand(SQLAttendanceReport,sqlConnection);
                    //创建数据读取器的实例
                    SqlDataReader sdrAttendanceReport = sqlCommandAttendanceReport.ExecuteReader();
                    while (sdrAttendanceReport.Read())
                    {
                        //获取sql结果集中  索引为1的列的数据
                        ARName = sdrAttendanceReport.GetString(1);
                        //年月编号 
                        ARYearMonth = sdrAttendanceReport.GetString(2);
                        //实际出勤小时
                        ARAttendancedHour = sdrAttendanceReport.GetString(3);
                        //实际缺勤小时
                        ARAbsencedHour = sdrAttendanceReport.GetString(4);
                        //实际请假小时
                        ARLeavedHour = sdrAttendanceReport.GetString(5);
                        //实际正常加班小时
                        ARNormaledHour = sdrAttendanceReport.GetString(6);
                        //实际周末加班小时
                        ARWeekedHour = sdrAttendanceReport.GetString(7);
                        //实际节假日加班小时
                        ARFestivaledHour = sdrAttendanceReport.GetString(8);
                        MessageBox.Show("yesAttendanceReport");
                    }
                    //关闭数据读取器的实例
                    sdrAttendanceReport.Close();
                    //从薪资档案表中取出职员的当月基本工资和加班费率等等的全部信息
                    //创建要执行的查询语句
                    string SQLUpholdSalaryFiles = "select * from UpholdSalaryFiles where EmployeeNumber='"+strEN+"' and YearMonth='"+strYearMonth+"'";
                
                    //创建SqlCommand类的实例
                    SqlCommand sqlCommandSalaryFile = new SqlCommand(SQLUpholdSalaryFiles,sqlConnection);
                    //创建数据读取器的实例
                    SqlDataReader sdrSalaryFiles = sqlCommandSalaryFile.ExecuteReader();

                    while (sdrSalaryFiles.Read())
                    {
                        //获取基本工资
                        UhBasicPay = sdrSalaryFiles.GetString(3);
                        //获取全勤奖
                        UhFull = sdrSalaryFiles.GetString(4);
                        //获取职务补贴
                        UhDuty = sdrSalaryFiles.GetString(5);
                        //获取外宿补贴
                        UhOutside = sdrSalaryFiles.GetString(6);
                        //获取餐费补贴
                        UhMeal = sdrSalaryFiles.GetString(7);
                        //获取数据库中存入的工作日加班费率
                        UhNormalRate = sdrSalaryFiles.GetString(8);
                        //获取数据库中存入的周末加班费率
                        UhWeekRate = sdrSalaryFiles.GetString(9);
                        //获取数据库中存入的节假日加班费率
                        UhFestivalRate = sdrSalaryFiles.GetString(10);
                        MessageBox.Show("yesUpholdSalaryFiles ");
                    }

                    //关闭数据读取器的实例
                    sdrSalaryFiles.Close();
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
                if (ARAbsencedHour!=null&CRHour!=null&ARAttendancedHour!=null
                    &ARNormaledHour!=null&ARWeekedHour!=null&ARFestivaledHour!=null
                    &UhNormalRate!=null&UhWeekRate!=null&UhFestivalRate!=null
                    &UhBasicPay!=null&UhFull!=null&UhDuty!=null&UhOutside!=null
                    & UhMeal !=null) { 
                    
                
                    int n = 0;
                    //本月实际出勤小时    等于     出勤日历中的小时
                    if (int.Parse(ARAttendancedHour) == int.Parse(CRHour))
                    {
                        n = 1;
                    }            //本月实际出勤小时    小于     出勤日历中的小时
                    else if (int.Parse(ARAttendancedHour) < int.Parse(CRHour))
                    {
                        n = 2;
                    }           //本月实际出勤小时    大于     出勤日历中的小时
                    else if (int.Parse(ARAttendancedHour) > int.Parse(CRHour))
                    {
                        n = 3;
                    }

                    switch (n)
                    {
                        case 1:

                            //计算本月 正常工作日加班费
                            ResultNormalSalay = Convert.ToDouble(UhNormalRate) * Convert.ToDouble(ARNormaledHour);
                            //计算本月  周末加班费
                            ResultWeekSalary = Convert.ToDouble(UhWeekRate) * Convert.ToDouble(ARWeekedHour);
                            //计算本月  法定节假日加班费
                            ResultFestivalSalary = Convert.ToDouble(UhFestivalRate) * Convert.ToDouble(ARFestivaledHour);
                            //本月应发工资 
                            ResultSumSalary = double.Parse(UhBasicPay) + double.Parse(UhFull) + double.Parse(UhDuty) + double.Parse(UhOutside)
                                + double.Parse(UhMeal) + ResultNormalSalay + ResultWeekSalary + ResultFestivalSalary;

                            //本月应发的所有加班工资
                            ResultOvertimePay = (ResultNormalSalay + ResultWeekSalary + ResultFestivalSalary);

                            StrResultOvertimePay = ResultOvertimePay.ToString();
                            StrResultSumSalary = ResultSumSalary.ToString();

                            MessageBox.Show("本月应发工资为" + StrResultSumSalary + "元！！！"
                                + "本月加班费为" + StrResultOvertimePay + "元"
                                + "本月工作日加班费" + ResultNormalSalay.ToString() + "元！"
                                + "本月周末加班费" + ResultWeekSalary.ToString() + "元！"
                                + "本月法定节假日加班费" + ResultFestivalSalary.ToString() + "元");

                            //将值写入对应的数据库表中  SalaryCalculator
                            string sqlInsertSC = "insert into SalaryCalculator values ('" + strEN + "','" + ARName + "','" + strYearMonth + "'," +
                                "'" + UhBasicPay + "','" + UhFull + "','" + UhDuty + "','" + UhOutside + "','" + UhMeal + "','" + StrResultOvertimePay + "','" + StrResultSumSalary + "')";

                            //创建SQLCommand命令的实例
                            SqlCommand sqlCommand = new SqlCommand(sqlInsertSC, sqlConnection);
                            if (sqlCommand.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("工资计算成功");
                                //刷新窗体中的列表
                                UpdateListview();
                            }

                            break;
                        case 2:

                            //由于没有全勤 所有取消全勤奖 即将全勤奖重置为零
                            UhFull = 0.ToString();
                            //计算本月 正常工作日加班费
                            ResultNormalSalay = Convert.ToDouble(UhNormalRate) * Convert.ToDouble(ARNormaledHour);
                            //计算本月  周末加班费
                            ResultWeekSalary = Convert.ToDouble(UhWeekRate) * Convert.ToDouble(ARWeekedHour);
                            //计算本月  法定节假日加班费
                            ResultFestivalSalary = Convert.ToDouble(UhFestivalRate) * Convert.ToDouble(ARFestivaledHour);
                            //本月应发工资 
                            ResultSumSalary = double.Parse(UhBasicPay) + double.Parse(UhFull) + double.Parse(UhDuty) + double.Parse(UhOutside)
                                + double.Parse(UhMeal) + ResultNormalSalay + ResultWeekSalary + ResultFestivalSalary;

                            //本月应发的所有加班工资
                            ResultOvertimePay = (ResultNormalSalay + ResultWeekSalary + ResultFestivalSalary);

                            //将double类型的值 转换成string类型
                            StrResultOvertimePay = ResultOvertimePay.ToString();
                            StrResultSumSalary = ResultSumSalary.ToString();

                            MessageBox.Show("本月由于没有满全勤 ,所以无全勤奖" +
                                "本月应发工资为" + StrResultSumSalary + "元   "
                                + "本月加班费为" + StrResultOvertimePay + "元  "
                                + "本月工作日加班费" + ResultNormalSalay.ToString() + "元  "
                                + "本月周末加班费" + ResultWeekSalary.ToString() + "元  "
                                + "本月法定节假日加班费" + ResultFestivalSalary.ToString() + "元  ");




                            //将值写入对应的数据库表中  SalaryCalculator
                            string sqlInsertSCNOFull = "insert into SalaryCalculator values ('" + strEN + "','" + ARName + "','" + strYearMonth + "'," +
                                "'" + UhBasicPay + "','" + UhFull + "','" + UhDuty + "','" + UhOutside + "','" + UhMeal + "','" + StrResultOvertimePay + "','" + StrResultSumSalary + "')";
                            //创建Sqlcommand类的实例
                            SqlCommand sqlCommandNOFull = new SqlCommand(sqlInsertSCNOFull, sqlConnection);
                            if (sqlCommandNOFull.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("工资计算成功");

                                //刷新窗体中的列表
                                UpdateListview();
                            }
                            break;

                        case 3:
                            MessageBox.Show("您本月实际出勤小时数超标 请联系财务计算薪资");
                            break;

                        //default语句用来处理无效的选择
                        default:
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("计算失败 请核实对应的表中的参数是否存在");
                }




              
                //关闭数据库的连接
                sqlConnection.Close();
            }
        }


        //点击保存按钮后 刷新listview实时显示数据表中最新的信息
        public void UpdateListview()
        {
            //移除listview中所有的已显示的信息
            listView_CountResult.Items.Clear();
            
          
            //创建数据库连接的实例
        SqlConnection    connection = new SqlConnection(UtilitySql.SetConnectionString());
            //打开数据库
            connection.Open();
            //创建数据库命令的实例
          SqlCommand  cmd = connection.CreateCommand();
            //把要执行的sql语句 传递给cmd实例
            cmd.CommandText = "select * from SalaryCalculator";
            //创建一个数据读取器
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                //将数据库中所有的字段显示到  窗体的listview控件中
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sdr["EmployeeNumber"].ToString();
                lvi.SubItems.Add(sdr["EmployeeName"].ToString());
                lvi.SubItems.Add(sdr["YearMonth"].ToString());
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
            tb_YearMonth.Text = "";
            tb_SectionName.Text = "";
        }

        //给查找按钮 增加点击事件
        private void btn_Search_Click(object sender, EventArgs e)
        {
            //清空列表中显示的内容
            listView_CountResult.Items.Clear();
            //如果输入框中没有输入工号 则弹出消息框提示用户
            if (tb_EmployeeNumber.Text == "" || tb_YearMonth.Text == "")
            {
                MessageBox.Show("请输入要查询的工号和月份");
            }
            {
                //创建sql查询语句
                string sqlString = "select * from SalaryCalculator where EmployeeNumber='" + tb_EmployeeNumber.Text + "' and YearMonth='" + tb_YearMonth.Text + "'";
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
                        listViewItem.SubItems.Add(sqlDataReader["YearMonth"].ToString());
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
            int a = listView_CountResult.FocusedItem.Index;
            //获取被选中条目的工号
            string strNumber = listView_CountResult.Items[a].SubItems[0].Text;
            //获取被选中条目的月份
            string strYearMonth = listView_CountResult.Items[a].SubItems[2].Text;
            //创建与数据库的连接
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                //将连接字符串赋值给connectionString
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //创建要执行的sql语句
                string sqlString = "delete from SalaryCalculator where EmployeeNumber='" + strNumber + "' and YearMonth='" + strYearMonth + "'";
                //创建SqlCommand实例
                SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);
                //打开数据库连接
                sqlConnection.Open();
                //调用executedno函数进行判断 如果大于零 提示删除成功
                if (sqlCommand.ExecuteNonQuery() > 0)
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
