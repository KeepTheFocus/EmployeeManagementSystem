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
using System.Collections;
using System.Globalization;

namespace EmployeeManagementSystem
{
    public partial class SearchAttendanceForm : Form
    {
        public SearchAttendanceForm()
        {
            InitializeComponent();
        }
        ///声明两个容器分别用来存储当月能拿全勤奖的具体日期
        ///和当月不能拿全勤奖的具体日期
        ///

        List<DateTime>  HaveBonusDate = new List<DateTime>();
        List<DateTime> HaveNoBonusDate = new List<DateTime>();






        ///定义两个int 类型的变量 用来保存当月有全勤奖的天数 和 当月无全勤奖的天数
        ///
        int HaveFullBonusDays,
            HaveNoFullBonusDays;


        /// <summary>
        /// 声明三个容器 分别用来存储07：30~08：30时间段
        /// 11：20~13：20时间段
        /// 16：50~18：20时间段内的打卡记录
        /// 
        /// </summary>
        List<DateTime> FirstStage = new List<DateTime>();
        List<DateTime> SecondStage = new List<DateTime>();
        List<DateTime> ThirdStage = new List<DateTime>();
        List<DateTime> FourthStage = new List<DateTime>();
        /// <summary>
        /// 定义几个字符串类型的变量用来保存已经确定的
        /// 上午上班打卡时间
        /// 下午下班打卡时间
        /// 下午上班打卡时间
        /// 下午下班打卡时间
        /// 晚上上班打卡时间(如果晚上没有加班,则将string.empty的值赋予给该变量)
        /// 晚上下班打卡时间(如果晚上没有加班,则将string.empty的值赋予给该变量)
        /// </summary>

        string virtualMorningCome = string.Empty,
               virtualMorningGo = string.Empty,
               virtualAfternoonCome = string.Empty,
               virtualAfternoonGo = string.Empty,
               virtualEveningCome = string.Empty,
               virtualEveningGo = string.Empty;

        private void showFirstStage()
        {
            

           

            if (FirstStage.Count==0)

            {
                //如果容器中的数目为零 说明没有完成上午上班签到
                virtualMorningCome = "您没有完成上午上班签到";

               // MessageBox.Show("你在"+virtualMorningCome+"完成了上午上班签到");
            }
            else if (FirstStage.Count==1)
            {
                //如果容器中的数目为1 说明那条记录就是上午上班签到
                virtualMorningCome = FirstStage[0].ToString("HH:mm");
                // MessageBox.Show("你在" + virtualMorningCome + "完成了上午上班签到");
            }
            else
            {
                //如果容器中的数目大于1  那么直接取最后一条记录作为上午上班签到
                virtualMorningCome = FirstStage[FirstStage.Count - 1].ToString("HH:mm");
            }
           


        }


        private void showSecondStage()
        {


            if (SecondStage.Count==0)
            {
                //如果容器中的条目数为0,说明没有完成上午下班签到和下午上班签到
                virtualMorningGo = "您没有完成上午下班签到";
                virtualAfternoonCome = "您没有完成下午上班签到";
            }
            else if (SecondStage.Count==1)
            {
                virtualMorningGo = SecondStage[0].ToString("HH:mm");
                virtualAfternoonCome = "您没有完成下午上班签到";
                //MessageBox.Show("你在" +virtualMorningGo + "完成了上午下班签到");
                // MessageBox.Show("你在" + virtualAfternoonCome + "完成了下午上班签到");
            }
            else
            {
                virtualMorningGo = SecondStage[0].ToString("HH:mm");
                virtualAfternoonCome = SecondStage[SecondStage.Count - 1].ToString("HH:mm");
                // MessageBox.Show("你在" + virtualMorningGo+ "完成了上午下班签到");
                // MessageBox.Show("你在" +virtualAfternoonCome+"完成了下午上班签到");
            }





         


        }



        private void showThirdStage()
        {



            if (ThirdStage.Count==0)
            {
                virtualAfternoonGo = "您没有完成下午下班签到";
                virtualEveningCome = "您没有完成晚上加班上班签到";
            }
            else if (ThirdStage.Count==1)
            {
                virtualAfternoonGo = ThirdStage[0].ToString("HH:mm");
                virtualEveningCome = "你没有完成晚上加班记录";
            }
            else
            {
                //"HH:mm" 代表24小时制的格式
                virtualAfternoonGo = ThirdStage[0].ToString("HH:mm");
                virtualEveningCome = ThirdStage[ThirdStage.Count - 1].ToString("HH:mm");
                // MessageBox.Show("你在" + virtualAfternoonGo + "完成了下午下班签到");
                //  MessageBox.Show("你在" + virtualEveningCome + "完成了晚上加班上班签到");
            }




        }


        private void showFourthStage()
        {


       

            if (FourthStage.Count==0)//如果容器中的条目数量为零，说明晚上没有打加班卡。不存存在加班记录
            {

                virtualEveningGo = "您没有完成晚上加班下班签到";
                // MessageBox.Show(virtualEveningGo);
              
            }
            else if (FourthStage.Count==1)
            {
                //如果容器中存在一条记录说明 存在晚上加班下班的打卡记录
                virtualEveningGo = FourthStage[0].ToString("HH:mm");
                //MessageBox.Show("你在" +  virtualEveningGo+ "完成了晚上加班下班签到");
            }
            else
            {
                //如果容器中存在超过一条的加班下班打卡记录 ，那么就取第一次记录作为实际晚上加班下班时间
                virtualEveningGo=FourthStage[0].ToString("HH:mm");
            }
          
           


        }


        string
                CurrentMonth = string.Empty,
                CurrentMonthStart = string.Empty, //用来保存当前选中的月份
               NextMonthStart = string.Empty,//用来保存下个月
               UserID = string.Empty,//用来保存At2000数据库中的UserID
               CurrentDate = string.Empty,//用来保存当前选中的日期
               TheDateAfterCurrentDate = string.Empty;//用来保存下一天的日期

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //需要查询的月份发生改变时，可以拿到全勤奖和和拿不到全勤奖的天数都要清零。重新计算
            HaveFullBonusDays = 0;
            HaveNoFullBonusDays = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //将没有加班费具体日期的容器中的每一个日期通过循环添加进列表中
            foreach (var item in  HaveNoBonusDate)
            {

                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.ToString("yyyy-MM-dd");




                listView4.Items.Add(listViewItem);
            }








        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        //用来判断当前日期是否有全勤奖
        /// <summary>
        /// 如果上午上班签到时间在规定的签到时间之前
        /// 上午下班签到时间在规定的签到时间之后
        /// 下午上班签到时间在规定的签到时间之前
        /// 下午下班签到时间在规定的签到时间之后
        /// 这四个条件同时满足时，那么当天就会有全勤奖
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            CurrentMonth = CurrentDate.Substring(0, 7);

            try
            {
                if (DateTime.Parse(virtualMorningCome).TimeOfDay <= Convert.ToDateTime("08:00").TimeOfDay
               & DateTime.Parse(virtualMorningGo).TimeOfDay >= Convert.ToDateTime("11:50").TimeOfDay
               & DateTime.Parse(virtualAfternoonCome).TimeOfDay <= Convert.ToDateTime("12:50").TimeOfDay
               & DateTime.Parse(virtualAfternoonGo).TimeOfDay >= Convert.ToDateTime("17:20").TimeOfDay)
                {
                    HaveFullBonusDays++;
                    MessageBox.Show(CurrentDate + "当日有全勤奖");
                   // MessageBox.Show(CurrentMonth + "有全勤奖的天数为"+HaveFullBonusDays+"天");
                    HaveBonusDate.Add(DateTime.Parse(CurrentDate));

                }
                else
                {
                    HaveNoFullBonusDays++;
                    MessageBox.Show(CurrentDate + "当日没有全勤奖");
                    //MessageBox.Show(CurrentMonth + "没有全勤奖的天数为" + HaveNoFullBonusDays + "天");
                    HaveNoBonusDate.Add(DateTime.Parse(CurrentDate));
                }
            }
            catch (Exception a )
            {

                MessageBox.Show(a.Message);
                HaveNoFullBonusDays++;
                MessageBox.Show(CurrentDate + "当日没有全勤奖");
                //MessageBox.Show(CurrentMonth + "没有全勤奖的天数为" + HaveNoFullBonusDays + "天");
                HaveNoBonusDate.Add(DateTime.Parse(CurrentDate));
            }

            if (listView1.FocusedItem.Index ==listView1.Items.Count-1)
            {
                MessageBox.Show(CurrentMonth + "当月可拿全勤奖的天数为" + HaveFullBonusDays+"天");
             
                MessageBox.Show(CurrentMonth+"当月拿不到全勤奖的天数为"+HaveNoFullBonusDays+"天");

                

                foreach (var item in HaveNoBonusDate)
                {
                    MessageBox.Show(CurrentMonth + "当月拿不到全勤奖的具体日期有"+item.ToString("yyyy-MM-dd"));
                }


                
            }

           
        }

        private void SearchAttendanceForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_selectFourStageTime_Click(object sender, EventArgs e)
        {
            //  清空之前的listview3列表中的内容
            listView3.Items.Clear();
            FirstStage.Clear();
            SecondStage.Clear();
            ThirdStage.Clear();
            FourthStage.Clear();
            ///用for循环去遍历列表中的每一条数据
            ///如果数据的时间离规定的第一次上班时间较近,那么就取它为上班时间
            ///如果数据的时间离规定的第一次下班时间较近那么就取它为下班时间
            ///如果数据的时间离规定的第二次上班时间较近,那么就取它为上班时间
            ///如果数据的时间离规定的第二次下班时间较近那么就取它为下班时间
            for (int i = 0; i < listView2.Items.Count; i++)
            {
               // MessageBox.Show("" + listView2.Items[i].SubItems[1].Text);

              
                if (DateTime.Parse(listView2.Items[i].SubItems[1].Text).TimeOfDay > Convert.ToDateTime("07:00").TimeOfDay & DateTime.Parse(listView2.Items[i].SubItems[1].Text).TimeOfDay <= Convert.ToDateTime("08:30").TimeOfDay)
                {
                   // MessageBox.Show(listView2.Items[i].SubItems[1].Text + "为第一阶段的打卡时间");
                    FirstStage.Add(DateTime.Parse(listView2.Items[i].SubItems[1].Text));

                }
                else if (DateTime.Parse(listView2.Items[i].SubItems[1].Text).TimeOfDay > Convert.ToDateTime("11:20").TimeOfDay & DateTime.Parse(listView2.Items[i].SubItems[1].Text).TimeOfDay <= Convert.ToDateTime("13:20").TimeOfDay)
                {
                    //MessageBox.Show(listView2.Items[i].SubItems[1].Text + "为第二阶段的打卡时间");
                    SecondStage.Add(DateTime.Parse(listView2.Items[i].SubItems[1].Text));
                }

                else if (DateTime.Parse(listView2.Items[i].SubItems[1].Text).TimeOfDay > Convert.ToDateTime("16:50").TimeOfDay & DateTime.Parse(listView2.Items[i].SubItems[1].Text).TimeOfDay <= Convert.ToDateTime("18:30").TimeOfDay)
                {
                   // MessageBox.Show(listView2.Items[i].SubItems[1].Text + "为第三阶段的打卡时间");
                    ThirdStage.Add(DateTime.Parse(listView2.Items[i].SubItems[1].Text));
                }
                else if (DateTime.Parse(listView2.Items[i].SubItems[1].Text).TimeOfDay > Convert.ToDateTime("19:30").TimeOfDay & DateTime.Parse(listView2.Items[i].SubItems[1].Text).TimeOfDay <=Convert.ToDateTime("23:59").TimeOfDay)

                {
                    //MessageBox.Show(listView2.Items[i].SubItems[1].Text + "为第四阶段的打卡时间");
                    FourthStage.Add(DateTime.Parse(listView2.Items[i].SubItems[1].Text));
                }

                //MessageBox.Show("   "+ DateTime.Parse(listView2.Items[i].SubItems[1].Text).TimeOfDay); 
            }


            showFirstStage();
            showSecondStage();
            showThirdStage();
            showFourthStage();

            //创建listviewitem条目 并将已经筛选好的实际打卡记录插入进列表中
          
                ListViewItem viewItem = new ListViewItem();
                viewItem.Text = CurrentDate;
                viewItem.SubItems.Add(virtualMorningCome);
                viewItem.SubItems.Add(virtualMorningGo);
                 viewItem.SubItems.Add(virtualAfternoonCome);
                viewItem.SubItems.Add(virtualAfternoonGo);
                viewItem.SubItems.Add(virtualEveningCome);
                viewItem.SubItems.Add(virtualEveningGo);
                listView3.Items.Add(viewItem);

           

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showFirstStage();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSecondStage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showThirdStage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showFourthStage();
        }

        //取出当天的有效打卡记录
        private void btn_selectUsefulTime_Click(object sender, EventArgs e)
        {

        }


        //给核对当天是否有全勤的按钮 设置点击事件
        private void btn_checkWhetherFull_Click(object sender, EventArgs e)
        {

            try
            {

                //获取当前选中项的日期
                CurrentDate = listView1.FocusedItem.Text;
                TheDateAfterCurrentDate = DateTime.Parse(CurrentDate).AddDays(1).ToString("yyyy-MM-dd");

               // MessageBox.Show("当前要核对的日期为   " + CurrentDate);
                //MessageBox.Show("明天的日期为   " + TheDateAfterCurrentDate);

                //清楚上一次列表中存在的打卡时间
                listView2.Items.Clear();
                listView3.Items.Clear();

                //从数据库中取出当天的所有打卡记录
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = UtilitySql.SetRemoteConnectionString();
                    connection.Open();
                    //创建要执行的sql命令
                    string sql = string.Format("select checktime from checkinout where (checktime between '{0}' and '{1}') and userid={2}", CurrentDate, TheDateAfterCurrentDate, UserID);
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //将读取器中结果集的字符串转换成Datetime类型的值并将它转换成你想要的日期格式的字符串
                       // MessageBox.Show("" + DateTime.Parse(reader[0].ToString()).ToString("yyyy-MM-dd HH:mm"));
                        ListViewItem viewItem = new ListViewItem();

                        //将当前选中的日期赋给条目的第一列
                        viewItem.Text = CurrentDate;
                        //将加班时间转换成你想要的格式后 赋给条目的第二列
                        viewItem.SubItems.Add(DateTime.Parse(reader[0].ToString()).ToString(" HH:mm"));

                        //将条目添加给列表中
                        listView2.Items.Add(viewItem);

                    }

                }

            }
            catch (Exception a )
            {

                MessageBox.Show(a.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            try
            {
                //清空之前列表中的日期数据
                listView1.Items.Clear();
                listView2.Items.Clear();
                listView3.Items.Clear();
                //获取月历上的日期和它是周几
                CurrentMonthStart = DateTime.Parse(dateTimePicker1.Text).ToString("yyyy-MM-dd");    
                NextMonthStart = DateTime.Parse(dateTimePicker1.Text).AddMonths(1).ToString("yyyy-MM-dd");
               // MessageBox.Show("本月月初" + CurrentMonth);
                //MessageBox.Show("下月月初" + NextMonth);
                //MessageBox.Show("" + DateTime.Parse(dateTimePicker1.Text).DayOfWeek);
                //if (DateTime.Parse(dateTimePicker1.Text).DayOfWeek.ToString()!="Saturday"& DateTime.Parse(dateTimePicker1.Text).DayOfWeek.ToString()!="Sunday")
                //{
                //    MessageBox.Show("当前日期为正常工作日");
                //}
                //else
                //{
                //    MessageBox.Show("当前日期为周末休息日");
                //}

                //将当月属于工作日的日期显示在列表中

                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = UtilitySql.SetRemoteConnectionString();
                    //打开数据库的连接
                    connection.Open();

                    //创建要执行的sql命令
                    string sql0 = string.Format("select userid from userinfo where badgenumber='{0}'", textBox_EmployeeNumber.Text);
                    SqlCommand command0 = new SqlCommand(sql0, connection);
                    SqlDataReader reader0 = command0.ExecuteReader();
                    while (reader0.Read())
                    {
                        //将读取器中结果集的第一列的值赋给变量 UserID
                        UserID = reader0[0].ToString();

                    }


                   // MessageBox.Show("userID为: " + UserID);
                    //关闭数据读取器的实例
                    reader0.Close();

                    string sql1 = string.Format("select distinct convert(char(10),checktime,120)  from checkinout where (checktime between '{0}' and '{1}') and userid={2} ", CurrentMonthStart, NextMonthStart, UserID);
                    SqlCommand command1 = new SqlCommand(sql1, connection);
                    SqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        //如果当天既不是周六也不是周日。那么它一定是工作日。
                        if (DateTime.Parse(reader1[0].ToString()).DayOfWeek.ToString() != "Saturday" &
                            DateTime.Parse(reader1[0].ToString()).DayOfWeek.ToString() != "Sunday")
                        {
                            //创建列表的条目
                            ListViewItem viewItem = new ListViewItem();
                            //将工作日的值赋给item的第一列
                            viewItem.Text = (reader1[0].ToString());
                            //将对应的周几的值赋给item的第二列
                            viewItem.SubItems.Add(DateTime.Parse(reader1[0].ToString()).DayOfWeek.ToString());
                            //将item添加给列表
                            listView1.Items.Add(viewItem);
                        }


                    }
                    //关闭数据读取器的实例
                    reader1.Close();

                }
            }
            catch (Exception a )
            {

                MessageBox.Show(a.Message);
            }

            //用消息对话框弹出本月有多少个正常工作日
            MessageBox.Show("本月您成功签到的正常工作日天数为"+listView1.Items.Count);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
