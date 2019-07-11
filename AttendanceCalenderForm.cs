using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class AttendanceCalenderForm : Form
    {
        public AttendanceCalenderForm()
        {
            InitializeComponent();
        }

        //给保存按钮 添加点击事件
        private void btn_save_Click(object sender, EventArgs e)
        {
            //创建一个数据库连接实例
            using (SqlConnection sqlConnectionDecide = new SqlConnection())
            {
                sqlConnectionDecide.ConnectionString = UtilitySql.SetConnectionString();
                sqlConnectionDecide.Open();
                //创建要执行的SQL语句
                string strSQLDecide = "select * from Calender where YearMonth='" +tb_YearMonth.Text+ "'";
                //创建SQLCommand实例
                SqlCommand sqlCommandDecide = new SqlCommand(strSQLDecide, sqlConnectionDecide);
                //创建SqlDataReader实例
                SqlDataReader sqlDataReader = sqlCommandDecide.ExecuteReader();


                //获取三个文本框中输入的内容
                string strYearMonth =tb_YearMonth.Text,
                       strDay = tb_Day.Text,
                       strHour = tb_Hour.Text;


                if (sqlDataReader.HasRows)
                {
                    //关闭数据读取器 实例
                    sqlDataReader.Close();
                    //如果在数据表中能查到 文本框中的数据
                    //那么执行update语句 进行更新操作
                    string strSQLUpdate = "update Calender set WorkDay='" + strDay + "',WorkHour='" + strHour + "'where YearMonth='" + strYearMonth + "'";
                    //创建要执行的SqlCommand实例
                    SqlCommand sqlCommandUpdate = new SqlCommand(strSQLUpdate, sqlConnectionDecide);
                    //如果数据表中受命令影响的行数大于零 说明数据更新成功 反则失败
                    if (sqlCommandUpdate.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("数据更新成功");
                    }
                    else
                    {
                        MessageBox.Show("数据更新失败");
                    }
                    //关闭数据读取器 实例
                    sqlDataReader.Close();
                }
                else
                {
                    //关闭 数据读取器的实例
                    sqlDataReader.Close();
                    //如果在数据库中查不到 文本框中国的数据
                    //那么执行insert语句 进行添加操作
                    string strSQLInsert = "insert into Calender values('" + strYearMonth + "','" + strDay + "','" + strHour + "')";
                    //创建要执行的SqlCommand实例
                    SqlCommand sqlCommandInsert = new SqlCommand(strSQLInsert, sqlConnectionDecide);
                    //如果数据表中受命令影响的行数大于零 说明数据更新成功 反则失败
                    if (sqlCommandInsert.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("数据添加成功");
                    }
                    else
                    {
                        MessageBox.Show("数据添加失败");
                    }

                }

                //调用刷新列表的函数
                UpdateListview();
                //清空所有文本框的信息
                ClearTextBox();
                //关闭数据库的连接
                sqlConnectionDecide.Close();
            }
        }


        //清空文本框中消息的  函数
        public void ClearTextBox()
        {
            tb_YearMonth.Text = "";
            tb_Day.Text = "";
            tb_Hour.Text = "";
        }

        //点击保存按钮后 刷新listview实时显示数据表中最新的信息
        public void UpdateListview()
        {
            //移除listview中所有的已显示的信息
            listView_Calender.Items.Clear();
            //创建数据库连接的实例
           SqlConnection connection = new SqlConnection(UtilitySql.SetConnectionString());
            //打开数据库
            connection.Open();
            //创建数据库命令的实例
           SqlCommand cmd = connection.CreateCommand();
            //把要执行的sql语句 传递给cmd实例
            cmd.CommandText = "select * from Calender";
            //创建一个数据读取器
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                /*创建一个ListViewItem实例 
                 从数据读取器中取出对应列名的数据  并将其赋值给ListviewItem实例的属性
                 */
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sdr["YearMonth"].ToString();
                lvi.SubItems.Add(sdr["WorkDay"].ToString());
                lvi.SubItems.Add(sdr["WorkHour"].ToString());
                //将数据库中所有的字段显示到  窗体的listview控件中
                //将数据添加进listview控件中
                listView_Calender.Items.Add(lvi);

            }
            //关闭流
            connection.Close();
        }




        //定义一个长度为3的数组用来保存  要传递进来的字符串
        public string[] str = new string[3];

        //给修改按钮 添加点击事件
        private void btn_alter_Click(object sender, EventArgs e)
        {
            //获取当前被选中条目的索引
            int a = listView_Calender.FocusedItem.Index;

            for (int i = 0; i < 3; i++)
            {
                str[i] = listView_Calender.Items[a].SubItems[i].Text;
            }

        tb_YearMonth.Text= str[0];
            tb_Day.Text = str[1];
            tb_Hour.Text = str[2];


        }



        //给退出按钮 添加点击事件
        private void btn_esc_Click(object sender, EventArgs e)
        {
            //关闭当前窗体
            Close();
        }

        //窗体加载的时候做的事情
        private void AttendanceCalenderForm_Load(object sender, EventArgs e)
        {
            //将日历控件上显示的文本值赋值给自定义的年月文本框中
            tb_YearMonth.Text = dtp_YearMonth.Text;

            MessageBox.Show(dtp_YearMonth.Text);
            //创建数据库连接的实例
           SqlConnection connection = new SqlConnection(UtilitySql.SetConnectionString());
            //打开数据库
            connection.Open();
            //创建数据库命令的实例
           SqlCommand cmd = connection.CreateCommand();
            //把要执行的sql语句 传递给cmd实例
            cmd.CommandText = "select * from Calender";
            //创建一个数据读取器
            SqlDataReader sdr = cmd.ExecuteReader();

            //如果数据读取器能够读取到下一条记录 的布尔表达式值为真 那么执行循环体内的语句
            while (sdr.Read())
            {
                //创建listviewitem的实例
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sdr["YearMonth"].ToString();
                lvi.SubItems.Add(sdr["WorkDay"].ToString());
                lvi.SubItems.Add(sdr["WorkHour"].ToString());
                //将数据库中所有的字段显示到  窗体的listview控件中
                //将数据添加进listview控件中
                listView_Calender.Items.Add(lvi);

            }
            //关闭流
            connection.Close();

        }

        //给工作时长（天） 文本框增加  回车事件
        private void tb_Day_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //获取工作时长（天） 并将其转化成int类型
                int dayValue = Convert.ToInt32(tb_Day.Text);
                //获取工作时长（小时） 并将其转化成string类型 然后赋值给文本框的Text属性
                tb_Hour.Text = Convert.ToString(DayConvert2Hour(dayValue));

            }
        }


        //新建一个工作时长（小时） 的计算函数
        private int DayConvert2Hour(int dayValue)
        {
            //初始化工作时长 变量值为零 
            int hourValue = 0;
            //工作时长 等于 工作天数* 8
            hourValue = 8 * dayValue;
            //返回工作时长
            return hourValue;
        }

        private void dtp_YearMonth_ValueChanged(object sender, EventArgs e)
        {
            //获取日历控件上的值 并显示到下方的年月文本框中
            tb_YearMonth.Text = dtp_YearMonth.Text;
        }
    }
}
