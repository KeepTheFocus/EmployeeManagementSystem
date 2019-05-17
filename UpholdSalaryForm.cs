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
    public partial class UpholdSalaryForm : Form
    {
        public UpholdSalaryForm()
        {
            InitializeComponent();
        }

        //当敲击了回车键 后要处理的事件
        private void tb_Number_KeyDown(object sender, KeyEventArgs e)
        {
            //1.将输入的工号赋值给变量strNumber
            string strNumber = tb_Number.Text;
            //2.建立与数据库实例的连接
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                //创建与实例连接的 字符串
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();

                //创建将要执行的 SQL语句
                string strSql = "select EmployeeName from EmployeeFiles where EmployeeNumber='" + strNumber + "'";
                //创建SQLcommand的实例
                SqlCommand sqlCommand = new SqlCommand(strSql, sqlConnection);
                //打开数据库连接
                sqlConnection.Open();
                //创建一个sqldataReader实例
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                //如果能读取到行记录 将会返还true值
                while (sqlDataReader.Read())
                {
                    //将EmployeeName列的值取出来  赋值给窗体中的name文本框
                    tb_Name.Text = sqlDataReader["EmployeeName"].ToString();
                }
                //关闭连接
                sqlConnection.Close();
            }
        }

        //给退出按钮   添加点击事件
        private void btn_Esc_Click(object sender, EventArgs e)
        {
            //关闭窗体
            Close();
        }
        //给保存按钮  添加点击事件
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //获取所有文本框中已输入的值
            string Number = tb_Number.Text;
            string Name = tb_Name.Text;
            string YearMonth = tb_YearMonth.Text;
            string BasicPay = tb_BasicPay.Text;
            string FullAttendance = tb_FullAttendance.Text;
            string DutyBonus = tb_DutyBonus.Text;
            string OutBonus = tb_OutBonus.Text;
            string MealBonus = tb_MealBonus.Text;
            string NormalRate = tb_NormalRate.Text;
            string WeekRate = tb_WeekRate.Text;
            string FestivalRate = tb_FestivalRate.Text;

            using (SqlConnection sqlConnection = new SqlConnection())
            {

                //建立与数据库的连接

                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //打开连接
                sqlConnection.Open();
                //创建要执行的Sql命令
                string strSql = "insert into UpholdSalaryFiles values('" + Number + "','" + Name + "','"+YearMonth+"','" + BasicPay + "','" + FullAttendance + "','" + DutyBonus + "','" + OutBonus + "','" + MealBonus + "','" + NormalRate + "','" + WeekRate + "','" + FestivalRate + "')";
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
                UpdateListview();
                ClearTextBox();
            }

        }




        //点击保存按钮后 刷新listview实时显示数据表中最新的信息
        public void UpdateListview()
        {
            //移除listview中所有的已显示的信息
            listView_UpholdSalaryFiles.Items.Clear();

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
            cmd.CommandText = "select * from UpholdSalaryFiles";
            //创建一个数据读取器
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sdr["EmployeeNumber"].ToString();
                lvi.SubItems.Add(sdr["EmployeeName"].ToString());
                lvi.SubItems.Add(sdr["YearMonth"].ToString());
                lvi.SubItems.Add(sdr["BasicPay"].ToString());
                lvi.SubItems.Add(sdr["FullAttendanceBonus"].ToString());
                lvi.SubItems.Add(sdr["DutyAllowance"].ToString());
                lvi.SubItems.Add(sdr["StayOutSideAllowance"].ToString());
                lvi.SubItems.Add(sdr["MealAllowance"].ToString());
                lvi.SubItems.Add(sdr["NormalRate"].ToString());
                lvi.SubItems.Add(sdr["WeekRate"].ToString());
                lvi.SubItems.Add(sdr["FestivalRate"].ToString());
                //将数据添加进listview控件中
                listView_UpholdSalaryFiles.Items.Add(lvi);

            }
            //关闭流
            connection.Close();


        }


        //清空所有 输入框的内容  的函数

        public void ClearTextBox()
        {

            //清空所有 输入框的内容
            tb_Number.Text = "";
            tb_Name.Text = "";
            tb_YearMonth.Text = "";
            tb_BasicPay.Text = "";
            tb_FullAttendance.Text = "";

            tb_DutyBonus.Text = "";
            tb_OutBonus.Text = "";
            tb_MealBonus.Text = "";
            tb_NormalRate.Text = "";
            tb_WeekRate.Text = "";
            tb_FestivalRate.Text = "";


        }


        //在窗体加载时 的函数
        private void UpholdSalaryForm_Load(object sender, EventArgs e)
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
            cmd.CommandText = "select * from UpholdSalaryFiles";
            //创建一个数据读取器
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sdr["EmployeeNumber"].ToString();
                lvi.SubItems.Add(sdr["EmployeeName"].ToString());
                lvi.SubItems.Add(sdr["YearMonth"].ToString());
                lvi.SubItems.Add(sdr["BasicPay"].ToString());
                lvi.SubItems.Add(sdr["FullAttendanceBonus"].ToString());
                lvi.SubItems.Add(sdr["DutyAllowance"].ToString());
                lvi.SubItems.Add(sdr["StayOutSideAllowance"].ToString());
                lvi.SubItems.Add(sdr["MealAllowance"].ToString());
                lvi.SubItems.Add(sdr["NormalRate"].ToString());
                lvi.SubItems.Add(sdr["WeekRate"].ToString());
                lvi.SubItems.Add(sdr["FestivalRate"].ToString());
                //将数据添加进listview控件中
                listView_UpholdSalaryFiles.Items.Add(lvi);

            }
            //关闭流
            connection.Close();
        }

        //定义一个长度为10的数组用来保存  要传递进来的字符串
        public string[] str = new string[11];

        //给修改按钮 添加 点击事件
        private void btn_Alter_Click(object sender, EventArgs e)
        {
            //获取当前被选中项的 索引
            int a = listView_UpholdSalaryFiles.FocusedItem.Index;

            for (int i = 0; i < 11; i++)
            {
                str[i] = listView_UpholdSalaryFiles.Items[a].SubItems[i].Text;
            }

            tb_Number.Text = str[0];
            tb_Name.Text = str[1];
            tb_YearMonth.Text = str[2];
            tb_BasicPay.Text = str[3];
            tb_FullAttendance.Text = str[4];
            tb_DutyBonus.Text = str[5];
            tb_OutBonus.Text = str[6];
            tb_MealBonus.Text = str[7];
            tb_NormalRate.Text = str[8];
            tb_WeekRate.Text = str[9];
            tb_FestivalRate.Text = str[10];

        }

        //给修改后保存添加  点击事件
        private void btn_SaveAfterAlter_Click(object sender, EventArgs e)
        {

            //保存员工编号
            string strNumber = tb_Number.Text;
            //保存员工姓名
            string strName = tb_Name.Text;
            //保存年月信息
            string strYearMonth = tb_YearMonth.Text;

            //保存基本工资
            string strBasic = tb_BasicPay.Text;
            //保存全勤奖
            string strFull = tb_FullAttendance.Text;
            //保存职务津贴
            string strDutyBonus = tb_DutyBonus.Text;
            //保存外宿补贴
            string strOutBonus = tb_OutBonus.Text;
            //保存餐食补贴
            string strMealBonus = tb_MealBonus.Text;
            //保存正常加班 费率
            string strNormal = tb_NormalRate.Text;
            //保存周末加班 费率
            string strWeek = tb_WeekRate.Text;
            //保存法定节假日加班 费率
            string strFestival = tb_FestivalRate.Text;
            //声明将文本编辑框中的文本内容导入到数据库中的sql语句
            string strSql = " update UpholdSalaryFiles set EmployeeName='" + strName + "',YearMonth='"+strYearMonth+"',BasicPay='" + strBasic + "',FullAttendanceBonus='" + strFull + "',DutyAllowance='" + strDutyBonus + "',StayOutSideAllowance='" + strOutBonus + "',MealAllowance='" + strMealBonus + "',NormalRate='" + strNormal + "',WeekRate='" + strWeek + "',FestivalRate='" + strFestival + "' where EmployeeNumber='" + strNumber + "'";


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
            ClearTextBox();
        }

        //给查找按钮添加 点击事件
        private void btn_Search_Click(object sender, EventArgs e)
        {

            //清空列表中所有的旧数据 （只是清空listview中的数据 表中的数据还在）
            listView_UpholdSalaryFiles.Items.Clear();
            //获取到输入框中的 工号
            string StrEmployeeNumber = tb_Number.Text;
            //如果输入的工号 不为空
            if (StrEmployeeNumber != "")
            {
                SqlConnection connection;
                SqlCommand cmd;


                //创建数据库连接的实例
                connection = new SqlConnection(UtilitySql.SetConnectionString());
                //打开数据库
                connection.Open();
                //创建数据库命令的实例
                cmd = connection.CreateCommand();
                //把要执行的sql语句 传递给cmd实例
                cmd.CommandText = "select * from UpholdSalaryFiles where  EmployeeNumber ='" + StrEmployeeNumber + "' ";
                //创建一个数据读取器
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = sdr["EmployeeNumber"].ToString();
                    lvi.SubItems.Add(sdr["EmployeeName"].ToString());
                    lvi.SubItems.Add(sdr["YearMonth"].ToString());
                    lvi.SubItems.Add(sdr["BasicPay"].ToString());
                    lvi.SubItems.Add(sdr["FullAttendanceBonus"].ToString());
                    lvi.SubItems.Add(sdr["DutyAllowance"].ToString());
                    lvi.SubItems.Add(sdr["StayOutSideAllowance"].ToString());
                    lvi.SubItems.Add(sdr["MealAllowance"].ToString());
                    lvi.SubItems.Add(sdr["NormalRate"].ToString());
                    lvi.SubItems.Add(sdr["WeekRate"].ToString());
                    lvi.SubItems.Add(sdr["FestivalRate"].ToString());
                    //将数据添加进listview控件中
                    listView_UpholdSalaryFiles.Items.Add(lvi);

                }
                //关闭流
                connection.Close();
            }
            else
            {
                MessageBox.Show("查询条件不能为空");
            }


        }

        //给导出按钮添加点击事件
        private void btn_Export_Click(object sender, EventArgs e)
        {




            //创建一个对话框实例
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = "xlsx";
            dialog.Filter = "Excel文件|*.xlsx";
            dialog.ShowDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Export2Excel export2Excel = new Export2Excel();
                export2Excel.Export(listView_UpholdSalaryFiles, dialog.FileName);
            }
        }
    }
}
