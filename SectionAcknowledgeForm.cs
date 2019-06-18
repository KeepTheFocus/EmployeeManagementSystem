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
    public partial class SectionAcknowledgeForm : Form
    {
        public SectionAcknowledgeForm()
        {
            InitializeComponent();
        }


        //获取刷新后的日期
        string NewestDate ;
        string PassResult = "OK";
        string RefuseResult = "NG";


        //创建一个辅助函数 用来刷新加班人员列表
        private void UpdateOTlistview()
        {
            lv_OTStaff.Items.Clear();//清空列表上一次存在的所有数据
            NewestDate = dtp_date.Text;
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                sqlConnection.Open();//打开数据库额连接
                string stringZero = "select * from PreviewOverTime where OTDate='"+NewestDate+"' ";//创建要执行的语句
                SqlCommand sqlCommandZero = new SqlCommand(stringZero, sqlConnection);
                //创建数据读取器的实例
                SqlDataReader sqlDataReaderZero = sqlCommandZero.ExecuteReader();
                while (sqlDataReaderZero.Read())
                {
                    ListViewItem viewItem = new ListViewItem();
                    viewItem.SubItems.Add(sqlDataReaderZero["EmployeeNumber"].ToString());
                    viewItem.SubItems.Add(sqlDataReaderZero["EmployeeName"].ToString());
                    viewItem.SubItems.Add(sqlDataReaderZero["SectionName"].ToString());
                    viewItem.SubItems.Add(sqlDataReaderZero["OTDate"].ToString());
                    viewItem.SubItems.Add(sqlDataReaderZero["OTType"].ToString());
                    viewItem.SubItems.Add(sqlDataReaderZero["OTLength"].ToString());
                    viewItem.SubItems.Add(sqlDataReaderZero["OTStart"].ToString());
                    viewItem.SubItems.Add(sqlDataReaderZero["OTStop"].ToString());
                    viewItem.SubItems.Add(sqlDataReaderZero["ReviewState"].ToString());
                    viewItem.SubItems.Add(sqlDataReaderZero["OTCause"].ToString());
                    viewItem.SubItems.Add(sqlDataReaderZero["NGCause"].ToString());
                    viewItem.SubItems.Add(sqlDataReaderZero["CurrentMonthTotal"].ToString());
                    viewItem.SubItems.Add(sqlDataReaderZero["Comment"].ToString());
                    //判断item中的审核状态是否为 未审核。
                    if (sqlDataReaderZero["ReviewState"].ToString()!="未审核")
                    {
                        //如果不是未审核状态 那么将其选中
                        viewItem.Selected = true;
                    }

                    lv_OTStaff.Items.Add(viewItem);//将新建的条目添加进列表条目的容器中
                }
                //弹出消息框 显示已经被审核或被拒绝的item
                MessageBox.Show("被审核的数目为"+lv_OTStaff.SelectedItems.Count);

                //使用foreach循环 将每个被选中状态的item的背景颜色变成蓝色
                foreach (ListViewItem item in lv_OTStaff.SelectedItems)
                {
                    item.BackColor = Color.AliceBlue;
                    item.ForeColor = Color.Green;
                }

             


                sqlDataReaderZero.Close();//关闭读取器
                sqlConnection.Close();//关闭数据库
            }
            //获取需要加班的总人数
            label_EmployeeTotal.Text = lv_OTStaff.Items.Count.ToString();
            //判断。如果当前列表的审核状态不再是未审核时。那么直接禁用列表 

        }

        //窗体加载时调用的函数
        private void SectionAcknowledgeForm_Load(object sender, EventArgs e)
        {
            //调用刷新列表的函数
            UpdateOTlistview();

        }


        //给日历控件 设置切换事件 当日期被切换时,要实时更新对应日期的表中的加班数据
        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            lv_OTStaff.Items.Clear();//清空列表中上一次的所有条目

            NewestDate = dtp_date.Text;
            MessageBox.Show(NewestDate);
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                sqlConnection.Open();
                //
                string stringzero = "select * from PreviewOverTime where OTDate='" + NewestDate + "'";
                SqlCommand sqlCommandZero = new SqlCommand(stringzero, sqlConnection);
                //
                SqlDataReader sqlDataReaderZero = sqlCommandZero.ExecuteReader();
                while (sqlDataReaderZero.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(sqlDataReaderZero["EmployeeNumber"].ToString());
                    item.SubItems.Add(sqlDataReaderZero["EmployeeName"].ToString());
                    item.SubItems.Add(sqlDataReaderZero["SectionName"].ToString());
                    item.SubItems.Add(sqlDataReaderZero["OTDate"].ToString());
                    item.SubItems.Add(sqlDataReaderZero["OTType"].ToString());
                    item.SubItems.Add(sqlDataReaderZero["OTLength"].ToString());

                    item.SubItems.Add(sqlDataReaderZero["OTStart"].ToString());
                    item.SubItems.Add(sqlDataReaderZero["OTStop"].ToString());
                    item.SubItems.Add(sqlDataReaderZero["ReviewState"].ToString());
                    item.SubItems.Add(sqlDataReaderZero["OTCause"].ToString());
                    item.SubItems.Add(sqlDataReaderZero["NGCause"].ToString());
                    item.SubItems.Add(sqlDataReaderZero["CurrentMonthTotal"].ToString());
                    item.SubItems.Add(sqlDataReaderZero["Comment"].ToString());

                    if (sqlDataReaderZero["ReviewState"].ToString() != "未审核")
                    {
                        item.Selected = true;
                    }

                    lv_OTStaff.Items.Add(item);
                }
                //
                MessageBox.Show("被审核的数目为" + lv_OTStaff.SelectedItems.Count);
                foreach (ListViewItem item in lv_OTStaff.SelectedItems)
                {
                    item.BackColor = Color.AliceBlue;
                    item.ForeColor = Color.Green;
                }
             

                sqlDataReaderZero.Close();//关闭数据读取器的实例
                sqlConnection.Close();//关闭数据库的连接
            }

            //获取需要加班的总人数
            label_EmployeeTotal.Text = lv_OTStaff.Items.Count.ToString();

        }

        //给全部选中并审核的按钮 设置点击事件
        private void btn_CheckAllAndOK_Click(object sender, EventArgs e)
        {
            //如果没有选中，那么使它全部选中
         
            if (lv_OTStaff.SelectedItems.Count<lv_OTStaff.Items.Count)
            {

                for (int i = 0; i < lv_OTStaff.Items.Count; i++)
                {
                    lv_OTStaff.Items[i].Checked = true;
                   
                }
            }

            //显示选中的条目的个数
            MessageBox.Show(lv_OTStaff.CheckedItems.Count.ToString());

            //将列表中每个员工的审核状态的字段值更新成OK
            lv_OTStaff.Items.Clear();

            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                sqlConnection.Open();
                string StringZero = "update PreviewOverTime set  ReviewState='"+PassResult+"',NGCause='"+cb_NGCause.Text+"' where OTDate='"+NewestDate+"' ";
                SqlCommand sqlCommandZero = new SqlCommand(StringZero, sqlConnection);
                if (sqlCommandZero.ExecuteNonQuery()>0)
                { 
                    MessageBox.Show("已经批准所有人员的加班申请");
                }


                string StringFirst = "select * from PreviewOverTime where OTDate='"+NewestDate+"'";
                SqlCommand sqlCommandFirst = new SqlCommand(StringFirst, sqlConnection);
                //
                SqlDataReader sqlDataReaderFirst = sqlCommandFirst.ExecuteReader();
                while (sqlDataReaderFirst.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(sqlDataReaderFirst["EmployeeNumber"].ToString());
                    item.SubItems.Add(sqlDataReaderFirst["EmployeeName"].ToString());
                    item.SubItems.Add(sqlDataReaderFirst["SectionName"].ToString());
                    item.SubItems.Add(sqlDataReaderFirst["OTDate"].ToString());
                    item.SubItems.Add(sqlDataReaderFirst["OTType"].ToString());
                    item.SubItems.Add(sqlDataReaderFirst["OTLength"].ToString());

                    item.SubItems.Add(sqlDataReaderFirst["OTStart"].ToString());
                    item.SubItems.Add(sqlDataReaderFirst["OTStop"].ToString());
                    item.SubItems.Add(sqlDataReaderFirst["ReviewState"].ToString());
                    item.SubItems.Add(sqlDataReaderFirst["OTCause"].ToString());
                    item.SubItems.Add(sqlDataReaderFirst["NGCause"].ToString());
                    item.SubItems.Add(sqlDataReaderFirst["CurrentMonthTotal"].ToString());
                    item.SubItems.Add(sqlDataReaderFirst["Comment"].ToString());
                    lv_OTStaff.Items.Add(item);
                }
             
                sqlDataReaderFirst.Close();//关闭数据读取器的实例
                sqlConnection.Close();//关闭数据库的连接
            }
            //获取需要加班的总人数
            label_EmployeeTotal.Text = lv_OTStaff.Items.Count.ToString();
        }



        //给打钩的不通过审核的按钮 设置点击事件
        private void button3_Click(object sender, EventArgs e)
        {
            //将审核状态从未审核 变成拒绝（NG） 并赋值给数据表中的审核状态的字段
            //将不通过审核原因下拉框的值取出来 并赋值给数据表中的拒绝原因的状态
            //打开数据库的实例

            for (int i = 0; i < lv_OTStaff.SelectedItems.Count; i++)
            {


                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                    //打开数据库的连接
                    sqlConnection.Open();
                    //创建要执行的sql语句
                    string StringZero = "update PreviewOverTime set ReviewState='" + RefuseResult + "',NGCause='" + cb_NGCause.Text + "' where OTDate='" + NewestDate + "' and EmployeeNumber='" + lv_OTStaff.SelectedItems[i].SubItems[1].Text + "'";
                    SqlCommand sqlCommandZero = new SqlCommand(StringZero, sqlConnection);
                    //创建数据读取器的实例
                    SqlDataReader dataReaderZero = sqlCommandZero.ExecuteReader();
                    while (dataReaderZero.Read())
                    {
                        //创建listviewItem类的实例
                        ListViewItem viewItem = new ListViewItem();
                        viewItem.SubItems.Add(dataReaderZero["EmployeeNumber"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["EmployeeName"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["SectionName"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["OTDate"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["OTType"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["OTLength"].ToString());

                        viewItem.SubItems.Add(dataReaderZero["OTStart"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["OTStop"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["ReviewState"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["OTCause"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["NGCause"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["CurrentMonthTotal"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["Comment"].ToString());
                        lv_OTStaff.Items.Add(viewItem);

                    }

                    //关闭数据读取器的实例
                    dataReaderZero.Close();
                    //关闭数据库的实例
                    sqlConnection.Close();
                }

            }


               

            //获取需要加班的总人数
            label_EmployeeTotal.Text =(lv_OTStaff.Items.Count-lv_OTStaff.SelectedItems.Count).ToString();

            UpdateOTlistview();
        }




        //设置单选框与条目之前的关联
        private void lv_OTStaff_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            e.Item.Selected=e.Item.Checked;//当勾上单选框时意味着当前条目被选中
        }



        //给打钩的通过审核按钮 设置点击事件
        private void button2_Click(object sender, EventArgs e)
        {
            //将审核状态从未审核 变成拒绝（NG） 并赋值给数据表中的审核状态的字段
            //将不通过审核原因下拉框的值取出来 并赋值给数据表中的拒绝原因的状态
            //打开数据库的实例
            for (int i = 0; i < lv_OTStaff.SelectedItems.Count; i++)
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                    //打开数据库的连接
                    sqlConnection.Open();
                    //创建要执行的sql语句
                    string StringZero = "update PreviewOverTime set ReviewState='" + PassResult + "',NGCause='" + cb_NGCause.Text + "' where OTDate='" + NewestDate + "' and EmployeeNumber='" + lv_OTStaff.SelectedItems[i].SubItems[1].Text + "'";
                    SqlCommand sqlCommandZero = new SqlCommand(StringZero, sqlConnection);
                    //创建数据读取器的实例
                    SqlDataReader dataReaderZero = sqlCommandZero.ExecuteReader();
                    while (dataReaderZero.Read())
                    {
                        //创建listviewItem类的实例
                        ListViewItem viewItem = new ListViewItem();
                        viewItem.SubItems.Add(dataReaderZero["EmployeeNumber"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["EmployeeName"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["SectionName"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["OTDate"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["OTType"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["OTLength"].ToString());

                        viewItem.SubItems.Add(dataReaderZero["OTStart"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["OTStop"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["ReviewState"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["OTCause"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["NGCause"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["CurrentMonthTotal"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["Comment"].ToString());
                        lv_OTStaff.Items.Add(viewItem);
                    }
                    //关闭数据读取器的实例
                    dataReaderZero.Close();
                    //关闭数据库的实例
                    sqlConnection.Close();
                }
            }
            //显示加班申请通过的人数
            label_EmployeeTotal.Text = lv_OTStaff.SelectedItems.Count.ToString();
            //刷新列表
            UpdateOTlistview();
        }
    }
}


