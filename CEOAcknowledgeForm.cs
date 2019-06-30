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
    public partial class CEOAcknowledgeForm : Form
    {
        public CEOAcknowledgeForm()
        {
            InitializeComponent();
        }


        string StringPassResult = "OK";
        string StringRefuseResult = "NG";


        private void label2_Click(object sender, EventArgs e)
        {

        }

        //窗体加载过程中执行的  函数
        private void CEOAcknowledgeForm_Load(object sender, EventArgs e)
        {
            //给部门下拉框设置数据源
            cb_SectionName.DataSource = SelectSection();
            //给部门下拉框设置要展示出来的字段
            cb_SectionName.DisplayMember = "SectionName";

            UpdateOTlistview();
        }






        //返回数据表中设置的 部门名称
        public DataTable SelectSection()
        {

            //创建数据库连接
            SqlConnection connection = new SqlConnection(UtilitySql.SetConnectionString());
            //打开连接
            connection.Open();

            //创建sql语句    选中预计加班列表中指定日期的所有加班部门
            string strSql = "select distinct sectionName from PreviewOverTime where OTDate='" + dtp_date.Text + "'";
            //创建一个SqlCommand类的实例
            SqlCommand command = new SqlCommand(strSql, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            //创建数据表
            DataTable table = new DataTable();

            adapter.Fill(table);
            //关闭连接
            connection.Close();
            //释放所有资源
            command.Dispose();
            //返回数据表
            return table;

        }


        //切换日历中的日期时  加班列表中的内容也要随着变化
        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            //清空之前列表中所有的项
            lv_OTEmployee.Items.Clear();

            //给部门下拉框设置数据源
            cb_SectionName.DataSource = SelectSection();
            //给部门下拉框设置要展示出来的字段
            cb_SectionName.DisplayMember = "SectionName";
            //使下拉框的文本框中的内容为清空状态
            cb_SectionName.Text = "";
            //从数据表中查找所有的数据 并显示在listview中
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                sqlConnection.Open();

                //创建要执行的sql语句
                string StringSql = "select * from PreviewOverTime where OTDate='" + dtp_date.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(StringSql, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())

                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems.Add(sqlDataReader["EmployeeNumber"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["EmployeeName"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["SectionName"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["OTDate"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["OTType"].ToString());

                    listViewItem.SubItems.Add(sqlDataReader["OTLength"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["OTStart"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["OTStop"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["ReviewState"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["OTCause"].ToString());

                    listViewItem.SubItems.Add(sqlDataReader["NGCause"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["CurrentMonthTotal"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["Comment"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["CEOReviewState"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["CEONGCause"].ToString());

                    //将新建的条目添加进列表里的条目容器中
                    lv_OTEmployee.Items.Add(listViewItem);
                }
                label_TotalEmployee.Text = lv_OTEmployee.Items.Count.ToString();
                //关闭数据读取器
                sqlDataReader.Close();
                //关闭数据库的连接
                sqlConnection.Close();

            }

            UpdateOTlistview();
        }

        //全部打钩并通过审核 按钮设置点击事件
        private void btn_AllPass_Click(object sender, EventArgs e)
        {
            //如果没有选中，那么使它全部选中

            if (lv_OTEmployee.SelectedItems.Count < lv_OTEmployee.Items.Count)
            {

                for (int i = 0; i < lv_OTEmployee.Items.Count; i++)
                {
                    lv_OTEmployee.Items[i].Checked = true;

                }
            }

            //显示选中的条目的个数
            MessageBox.Show(lv_OTEmployee.CheckedItems.Count.ToString());

            //将列表中每个员工的审核状态的字段值更新成OK
            lv_OTEmployee.Items.Clear();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                sqlConnection.Open();
                string StringZero = "update PreviewOverTime set  CEOReviewState='" + StringPassResult + "',NGCause='" + cb_RefuseCause.Text + "' where OTDate='" + dtp_date.Text + "' ";
                SqlCommand sqlCommandZero = new SqlCommand(StringZero, sqlConnection);
                if (sqlCommandZero.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("已经批准所有人员的加班申请");
                }


                string StringFirst = "select * from PreviewOverTime where OTDate='" + dtp_date.Text + "'";
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
                    item.SubItems.Add(sqlDataReaderFirst["CEOReviewState"].ToString());
                    item.SubItems.Add(sqlDataReaderFirst["CEONGCause"].ToString());
                    lv_OTEmployee.Items.Add(item);
                }

                sqlDataReaderFirst.Close();//关闭数据读取器的实例
                sqlConnection.Close();//关闭数据库的连接
            }
            //获取需要加班的总人数
            label_TotalEmployee.Text = lv_OTEmployee.Items.Count.ToString();

        }


        //打√的员工通过审核 按钮设置点击事件
        private void btn_TheCheckedPass_Click(object sender, EventArgs e)
        {

            //将审核状态从未审核 变成拒绝（NG） 并赋值给数据表中的审核状态的字段
            //将不通过审核原因下拉框的值取出来 并赋值给数据表中的拒绝原因的状态
            //打开数据库的实例
            for (int i = 0; i < lv_OTEmployee.SelectedItems.Count; i++)
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                    //打开数据库的连接
                    sqlConnection.Open();
                    //创建要执行的sql语句
                    string StringZero = "update PreviewOverTime set CEOReviewState='" + StringPassResult + "',CEONGCause='" + cb_RefuseCause.Text + "' where OTDate='" + dtp_date.Text + "' and EmployeeNumber='" + lv_OTEmployee.SelectedItems[i].SubItems[1].Text + "'";
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

                        viewItem.SubItems.Add(dataReaderZero["CEOReviewState"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["CEONGCause"].ToString());
                        lv_OTEmployee.Items.Add(viewItem);
                    }
                    //关闭数据读取器的实例
                    dataReaderZero.Close();
                    //关闭数据库的实例
                    sqlConnection.Close();
                }
            }
            //显示加班申请通过的人数
            label_TotalEmployee.Text = lv_OTEmployee.SelectedItems.Count.ToString();

            UpdateOTlistview();
        }

        //当单选框被勾选上时 使当前条目处于被选中状态
        private void lv_OTEmployee_ItemChecked(object sender, ItemCheckedEventArgs e)
        {


            e.Item.Selected = e.Item.Checked;
        }

        //打√的拒绝通过审核 按钮设置点击事件
        private void btn_TheCheckedRefuse_Click(object sender, EventArgs e)
        {


            //将审核状态从未审核 变成拒绝（NG） 并赋值给数据表中的审核状态的字段
            //将不通过审核原因下拉框的值取出来 并赋值给数据表中的拒绝原因的状态
            //打开数据库的实例

            for (int i = 0; i < lv_OTEmployee.SelectedItems.Count; i++)
            {


                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                    //打开数据库的连接
                    sqlConnection.Open();
                    //创建要执行的sql语句
                    string StringZero = "update PreviewOverTime set CEOReviewState='" + StringRefuseResult + "',CEONGCause='" + cb_RefuseCause.Text + "' where OTDate='" + dtp_date.Text + "' and EmployeeNumber='" + lv_OTEmployee.SelectedItems[i].SubItems[1].Text + "'";
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

                        viewItem.SubItems.Add(dataReaderZero["CEOReviewState"].ToString());
                        viewItem.SubItems.Add(dataReaderZero["CEONGCause"].ToString());
                        lv_OTEmployee.Items.Add(viewItem);

                    }

                    //关闭数据读取器的实例
                    dataReaderZero.Close();
                    //关闭数据库的实例
                    sqlConnection.Close();
                }

            }




            //获取需要加班的总人数
            label_TotalEmployee.Text = (lv_OTEmployee.Items.Count - lv_OTEmployee.SelectedItems.Count).ToString();

            UpdateOTlistview();



        }





        //创建一个辅助函数 用来刷新加班人员列表
        private void UpdateOTlistview()
        {
            lv_OTEmployee.Items.Clear();//清空列表上一次存在的所有数据

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                sqlConnection.Open();//打开数据库额连接
                string stringZero = "select * from PreviewOverTime where OTDate='" + dtp_date.Text + "' ";//创建要执行的语句
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


                    viewItem.SubItems.Add(sqlDataReaderZero["CEOReviewState"].ToString());

                    viewItem.SubItems.Add(sqlDataReaderZero["CEONGCause"].ToString());
                    //判断item中的审核状态是否为 未审核。
                    if (sqlDataReaderZero["ReviewState"].ToString() != "未审核")
                    {
                        //如果不是未审核状态 那么将其选中
                        viewItem.Selected = true;
                    }

                    lv_OTEmployee.Items.Add(viewItem);//将新建的条目添加进列表条目的容器中
                }
                //弹出消息框 显示已经被审核或被拒绝的item
                MessageBox.Show("被审核的数目为" + lv_OTEmployee.SelectedItems.Count);

                //使用foreach循环 将每个被选中状态的item的背景颜色变成蓝色
                foreach (ListViewItem item in lv_OTEmployee.SelectedItems)
                {
                    item.BackColor = Color.AliceBlue;
                    item.ForeColor = Color.Green;
                }




                sqlDataReaderZero.Close();//关闭读取器
                sqlConnection.Close();//关闭数据库
            }
            //获取需要加班的总人数
            label_TotalEmployee.Text = lv_OTEmployee.Items.Count.ToString();
            //判断。如果当前列表的审核状态不再是未审核时。那么直接禁用列表 

        }

        private void cb_SectionName_TextChanged(object sender, EventArgs e)
        {
            //当部门下拉框中最顶上的文本框中的Text发生改变时 触发的事件

            //清除列表中所有的条目
            lv_OTEmployee.Items.Clear();

            //打开数据库
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = UtilitySql.SetConnectionString();
                connection.Open();

                string sqlquery = "select * from previewovertime where (otdate='" + dtp_date.Text + "' and sectionname='" + cb_SectionName.Text + "') ";

                SqlCommand sqlcommand = new SqlCommand(sqlquery, connection);
                SqlDataReader datareader = sqlcommand.ExecuteReader();

                while (datareader.Read())
                {

                    ListViewItem viewitem = new ListViewItem();

                    viewitem.SubItems.Add(datareader["EmployeeNumber"].ToString());
                    viewitem.SubItems.Add(datareader["EmployeeName"].ToString());
                    viewitem.SubItems.Add(datareader["SectionName"].ToString());
                    viewitem.SubItems.Add(datareader["OTDate"].ToString());
                    viewitem.SubItems.Add(datareader["OTType"].ToString());

                    viewitem.SubItems.Add(datareader["OTLength"].ToString());
                    viewitem.SubItems.Add(datareader["OTStart"].ToString());
                    viewitem.SubItems.Add(datareader["OTStop"].ToString());
                    viewitem.SubItems.Add(datareader["ReviewState"].ToString());
                    viewitem.SubItems.Add(datareader["OTCause"].ToString());

                    viewitem.SubItems.Add(datareader["NGCause"].ToString());
                    viewitem.SubItems.Add(datareader["CurrentMonthTotal"].ToString());
                    viewitem.SubItems.Add(datareader["Comment"].ToString());
                    viewitem.SubItems.Add(datareader["CEOReviewState"].ToString());
                    viewitem.SubItems.Add(datareader["CEONGCause"].ToString());
                    lv_OTEmployee.Items.Add(viewitem);
                }

                datareader.Close();

                connection.Close();

                //定义一个sql语句
                //用来查找当前指定日期中指定部门的所有加班人员
                //清空列表中之前显示的所有条目

                //创建新的条目 然后将从数据库中检索到的数据填充进条目中

                //将刚刚创建好的条目 添加进列表的条目容器中来

            }

            //显示该部门的加班人数
            label_TotalEmployee.Text = lv_OTEmployee.Items.Count.ToString();



        }
    }
}
