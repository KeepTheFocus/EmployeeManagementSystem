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
            //获取三个文本框中输入的内容
            string strYearMonth = tb_YearMonth.Text;
            string strDay = tb_Day.Text;
            string strHour = tb_Hour.Text;

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                //给连接数据库实例的字符串赋值
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();

                sqlConnection.Open();
                //定义一个要执行的SQL语句
                string strSQL = "insert into Calender values('" + strYearMonth + "','" + strDay + "','" + strHour + "')";
                //创建一个sqlcommand命令的实例
                SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection);

                //如果受命令执行影响的行数 大于零
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("考勤日历信息添加成功");
                }
                //关闭连接
                sqlConnection.Close();
            }
            //调用刷新列表的函数
            UpdateListview();
            //清空所有文本框的信息
            ClearTextBox();

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
            cmd.CommandText = "select * from Calender";
            //创建一个数据读取器
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sdr["YearMonth"].ToString();
                lvi.SubItems.Add(sdr["WorkDay"].ToString());
                lvi.SubItems.Add(sdr["WorkHour"].ToString());

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

            tb_YearMonth.Text = str[0];
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

            int endValue = 0;
            //工作时长 等于 工作天数* 8
            endValue = 8 * dayValue;

            return endValue;
        }


        //修改后保存  按钮的点击事件
        private void btn_SaveAfterAlter_Click(object sender, EventArgs e)
        {



            //保存月份编码
            string strYearMonth = tb_YearMonth.Text;
            //保存工作时长（天）
            string strDay = tb_Day.Text;



            //保存工作时长（小时）
            string strHour = tb_Hour.Text;

            //声明将文本编辑框中的文本内容导入到数据库中的sql语句
            string strSql = " update Calender set YearMonth='" + strYearMonth + "',WorkDay='" + strDay + "',WorkHour='" + strHour + "'  where YearMonth='" + strYearMonth + "'";


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
           
        }
    }
}
