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
    public partial class EmployeeGroupForm : Form
    {
        public EmployeeGroupForm()
        {
            InitializeComponent();
        }
        //创建一个名为dataRowView的 实例
        DataRowView dataRowView;
        //被选中的部门
        string strSection;

        string 
            strGroupName,//组名
            strEmployeeNumber,//员工工号
            strEmployeeName,//员工姓名
            strSectionName;//部门名称
                

        //窗体加载过程中调用的函数
        private void EmployeeGroupForm_Load(object sender, EventArgs e)
        {
            CompareID();
            //每次窗体重新加载时，默认显示第一小组的所有信息(即在数据表中ID最小值所在的那一行)
            //获取community表中ID的最小值

            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //打开与数据库的连接
                sqlConnection.Open();

                //创建要执行的sql语句
                string MinIDString = "select min(id) from community";
                //创建sqlcommand命令的实例
                SqlCommand command = new SqlCommand(MinIDString, sqlConnection);
                //创建数据读取器的实例
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    MiniID=int.Parse(reader[0].ToString());
                }
                //关闭数据读取器的实例
                reader.Close();

                //从数据表Community中查找该ID 所对应的组名称 
                //从数据表Community中查找该ID 所对应的组说明
                //创建要执行的sql语句
                string GroupINFOString = "select * from Community where ID='"+MiniID.ToString()+"'";
                //创建要执行的Sqlcommand命令的实例
                SqlCommand sqlCommand = new SqlCommand(GroupINFOString,sqlConnection);
                //创建数据读取器的实例
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    tb_GruopName.Text=dataReader["GroupName"].ToString();
                    rtb_description.Text = dataReader["GroupScription"].ToString();
                }
                //关闭数据库读取器的实例
                dataReader.Close();



                //然后通过组名称从CommunityFiles中查找到对应的消息
                //创建要执行的sql语句
                string GroupListString = "select * from CommunityFiles where GroupName='" + tb_GruopName.Text + "'";
                //创建要执行的qlcommand命令的实例
                SqlCommand commandListGroup = new SqlCommand(GroupListString,sqlConnection);
                //创建数据读取器的实例
                SqlDataReader readerListGroup = commandListGroup.ExecuteReader();

                while (readerListGroup.Read())
                {
                    //创建一个listviewitem条目
                    ListViewItem viewItem = new ListViewItem();
                    viewItem.Text = readerListGroup["EmployeeNumber"].ToString();
                    viewItem.SubItems.Add(readerListGroup["EmployeeName"].ToString());
                    viewItem.SubItems.Add(readerListGroup["SectionName"].ToString());
                    //将viewItem 添加lv_Group
                    lv_Group.Items.Add(viewItem);
                }

                //关闭数据读取器
                readerListGroup.Close();
                //关闭数据库的连接
                sqlConnection.Close();

            }

            //给部门下拉框设置数据源
           lbx_SectionName.DataSource = GetSectionName();
            //设置下拉框显示哪一列
           lbx_SectionName.DisplayMember = "SectionName";
            //读取Community表中的数据
            //using (SqlConnection sqlConnection = new SqlConnection())
            //{
            //    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
            //    打开连接
            //     sqlConnection.Open();
            //    创建要执行strSQL语句
            //     string strSQL = "select * from Community";
            //    创建sqlCommand类的实例
            //    SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection);
            //    创建一个数据读取器的实例
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        将组名赋值给tb_GroupName
            //        tb_GruopName.Text = sqlDataReader["GroupName"].ToString();
            //        将组的描述赋值给tb_description
            //        rtb_description.Text = sqlDataReader["GroupScription"].ToString();
            //    }
            //    sqlDataReader.Close();
            //    / 将组成员列表中所有的成员显示在列表lv_Group中
            //     创建要执行的strSql语句
            //     string strLVGROUP = "select * from CommunityFiles";
            //    创建Sqlcommand类的实例
            //    SqlCommand sqlCommandGroup = new SqlCommand(strLVGROUP, sqlConnection);
            //    创建数据读取器类的实例
            //    SqlDataReader readerGroup = sqlCommandGroup.ExecuteReader();
            //    while (readerGroup.Read())
            //    {
            //        创建一个listviewitem条目
            //        ListViewItem viewItem = new ListViewItem();
            //        viewItem.Text = readerGroup["EmployeeNumber"].ToString();
            //        viewItem.SubItems.Add(readerGroup["EmployeeName"].ToString());
            //        viewItem.SubItems.Add(readerGroup["SectionName"].ToString());
            //        将viewItem 添加lv_Group
            //        lv_Group.Items.Add(viewItem);
            //    }
            //    sqlConnection.Close();
            //}
            //将组名赋值给变量 strGroupName
            strGroupName = tb_GruopName.Text;
            //组名文本框禁止输入
            tb_GruopName.ReadOnly = true;
            //说明文本框禁止输入
            rtb_description.ReadOnly = true;
            //禁用手动添加按钮
            btn_AddManually.Enabled = false;
          
            //禁用工具栏上的保存功能
            tsl_store.Enabled = false;
            //禁用工具栏上的取消功能
            tsl_Cancel.Enabled = false;

            //执行辅助函数CompareID后,随时可以使用ID的最大值和最小值
            CompareID();
        }



        public DataTable GetSectionName()
        {
            using (SqlConnection sqlConnection =new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
             
                //创建sql语句
                string strSql = "select * from Section";
                //创建一个SqlCommand类的实例
                SqlCommand command = new SqlCommand(strSql, sqlConnection);
                //创建数据读取器的实例
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                //创建数据表
                DataTable table = new DataTable();

                adapter.Fill(table);
                sqlConnection.Close();
                return table;
            }
        }

     

        //当敲击了回车键后要做的事情
        private void tb_EmployeeName_KeyDown(object sender, KeyEventArgs e)
        {
            //1.将输入的工号赋值给变量strNumber
            string strNumber = tb_EmployeeNumber.Text;
            //2.建立与数据库实例的连接
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                //创建与实例连接的 字符串
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //打开连接
                sqlConnection.Open();
                //创建将要执行的 SQL语句
                string strSql = "select * from EmployeeFiles where EmployeeNumber='" + strNumber + "'";
                //创建SQLcommand的实例
                SqlCommand sqlCommand = new SqlCommand(strSql, sqlConnection);
                //创建一个sqldataReader实例
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                //如果能读取到行记录 将会返还true值
                while (sqlDataReader.Read())
                {
                    //将EmployeeName列的值取出来  赋值给窗体中的name文本框
                    tb_EmployeeName.Text = sqlDataReader["EmployeeName"].ToString();
                    //获取员工所属部门
                    //将SectionName列的值取出来 赋值给定义的变量strSectionName
                    strSectionName = sqlDataReader["SectionName"].ToString();
                }
                //关闭连接
                sqlConnection.Close();
            }
            //获取员工工号
            //获取员姓名
            //将文本框中的工号赋值给strEmployeeNumber变量
            strEmployeeNumber = tb_EmployeeNumber.Text;
            //将文本框中的员工姓名赋值给strEmployeeName 变量
            strEmployeeName = tb_EmployeeName.Text;
            //激活手动添加人员 按钮
            btn_AddManually.Enabled = true;
        }






        //给查看部门人员按钮  设置点击事件
        private void btn_peek_Click(object sender, EventArgs e)
        {
            //将列表中上一次查询的数据清空
            lv_Section.Items.Clear();
            //将上一次勾上的全选框取消
            cb_All.Checked = false;
          dataRowView=lbx_SectionName.SelectedItem as DataRowView;
            MessageBox.Show(""+dataRowView[1]);
           strSection = dataRowView[1].ToString();
            //从数据库中查询该部门所有的人
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();

                sqlConnection.Open();
                //创建查询的Sql语句
                string strSQLQuery = "select EmployeeNumber,EmployeeName from EmployeeFiles where SectionName='"+strSection+"'";

                //创建sqlcommand的实例
                SqlCommand sqlCommand = new SqlCommand(strSQLQuery,sqlConnection);
                //创建数据读取器的实例
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                //如果数据读取器能够读取到下一条记录，就执行while循环中的语句
                while (sqlDataReader.Read())
                {
                    //创建一个条目
                    ListViewItem listViewItem = new ListViewItem();
                    //取出数据读取器中EmployeeNumber列的数据添加进条目中
                    listViewItem.SubItems.Add(sqlDataReader["EmployeeNumber"].ToString());
                    //取出数据读取器中EmployeeName列的数据添加进条目中
                    listViewItem.SubItems.Add(sqlDataReader["EmployeeName"].ToString());
                    //将创建好的条目添加进条目容器中
                    lv_Section.Items.Add(listViewItem);
                }
                //关闭数据库的连接
                sqlConnection.Close();
            }
        }




        //给全选按钮框添加 事件
        private void cb_All_CheckedChanged(object sender, EventArgs e)
        {
            //循环遍历部门列表中的每一个条目
            foreach (ListViewItem item in lv_Section.Items)
            {
                //将每一个条目的选项框勾上
                item.Checked = (sender as CheckBox).Checked;
            }
        }


        //给工具栏上的新建选项添加点击事件
        private void tsl_Create_Click(object sender, EventArgs e)
        {
            //清空分组名称框中的内容
            tb_GruopName.Text = "";
            //清空说明富文本框中的内容
            rtb_description.Text = "";

            //使 分组名称文本框变为可接受编辑的状态
            tb_GruopName.ReadOnly = false;
            //使 组说明富文本框
            rtb_description.ReadOnly = false;

            ///使手工输入部分的控件变成只读状态 按钮变成不可点击状态

            //员工工号  文本框禁止输入
            tb_EmployeeNumber.ReadOnly = true;
            //员工姓名 文本框禁止输入
            tb_EmployeeName.ReadOnly = true;
            //添加按钮禁用
            btn_Add.Enabled = false;
            //手动添加按钮 禁用
            btn_AddManually.Enabled = false;
            //删除按钮 禁用
            btn_Remove.Enabled = false;
            //禁用查看部门人员 按钮
            btn_peek.Enabled = false;
            //全选框禁用
            cb_All.Enabled = false;


            //部门listbox禁用
            lbx_SectionName.Enabled = false;
            //部门人员listview禁用
            lv_Section.Enabled = false;
            //清空部门列表
            lv_Section.Items.Clear();

            //禁用新建功能
            tsl_Create.Enabled = false;
            //禁用查找功能
            tsl_Query.Enabled = false;
            //禁用删除功能
            tsl_remove.Enabled = false;
            ////禁用第一条记录功能
            //tsl_FirstRecord.Enabled = false;
            ////禁用上一条记录功能
            //tsl_previousRecord.Enabled = false;
            ////禁用下一条记录功能
            //tsl_NextRecord.Enabled = false;
            ////禁用最后一条记录功能
            //tsl_EndRecord.Enabled = false;


            //激活保存功能
            tsl_store.Enabled = true;
            //激活取消功能
            tsl_Cancel.Enabled = true;
           
          
        }

        //给工具栏上的查找选项添加点击事件
        private void tsl_Query_Click(object sender, EventArgs e)
        {
            //弹出一个查找功能的窗体窗体
            QueryInGroupForm queryInGroupForm = new QueryInGroupForm();
            ////给该窗体设置父窗体
            //queryInGroupForm.MdiParent = this;
            queryInGroupForm.ShowDialog();
        }

        //给窗体中删除组列表成员 按钮设置点击事件
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            ///先从数据库中删除 然后再从列表中删除

            //获取列表中已经捕获焦点的条目的索引
            int a = lv_Group.FocusedItem.Index;
            //获取被选中条目的工号
            string strEpNumber=lv_Group.Items[a].SubItems[0].Text;
            //与数据库建立连接
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //打开连接
                sqlConnection.Open();
                //创建要执行的sql语句
                string sqlDelete = "delete from CommunityFiles where EmployeeNumber='" + strEpNumber + "'";
                //创建sqlCommand类的实例
                SqlCommand sqlCommand = new SqlCommand(sqlDelete, sqlConnection);

                if(sqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("员工记录删除成功");
                }
                //关闭数据库的连接
                sqlConnection.Close();
            }
            //在列表中删除某一个已获取焦点的条目
            lv_Group.Items.RemoveAt(a);
        }


        //给窗体中添加  按钮设置点击事件
        private void btn_Add_Click(object sender, EventArgs e)
        {
            ///1先判断全选框有没有被勾选上,如果被勾选上。执行全部添加
            ///如果没有勾选上，则添加列表中被勾选上的条目

            if (cb_All.Checked==true)
            {
                //先判断有没有创建组，如果没有创建组。
                //提示用户先创建组，再进行添加操作

                if (tb_GruopName.Text=="")
                {
                    MessageBox.Show("您还没有创建组,请先创建组再进行添加操作");
                }
                else
                {
                    ///1.先添加进列表LV_Group中
                    //创建listviewItem类的实例
                    for (int i = 0; i < lv_Section.Items.Count; i++)
                    {
                        ListViewItem listViewItem = new ListViewItem();

                        strEmployeeNumber = lv_Section.Items[i].SubItems[1].Text;
                        strEmployeeName = lv_Section.Items[i].SubItems[2].Text;
                        strSectionName = dataRowView[1].ToString();
                        listViewItem.Text = strEmployeeNumber;
                        listViewItem.SubItems.Add(strEmployeeName);
                        listViewItem.SubItems.Add(strSectionName);

                        //创建要连接的数据库实例
                        using (SqlConnection sqlConnection = new SqlConnection())
                        {
                            sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                            //打开连接
                            sqlConnection.Open();
                            //创建要执行的sql语句
                            string strWhetherExist = "select * from CommunityFiles where GroupName='" +tb_GruopName.Text + "'and EmployeeNumber='" + strEmployeeNumber + "' ";
                            //创建Sqlcommand类的实例
                            SqlCommand sqlCommand = new SqlCommand(strWhetherExist, sqlConnection);
                            //创建数据读取器的实例
                            SqlDataReader dataReader = sqlCommand.ExecuteReader();

                            //如果读取器能够读取到记录那么执行 紧跟if后面的语句块
                            if (dataReader.Read())
                            {
                                MessageBox.Show(strEmployeeName + "已存在组中,请勿重复添加");
                            }
                            else
                            {
                                //将新建的条目listViewItem添加给条目容器lv_Group.Items中
                                lv_Group.Items.Add(listViewItem);
                                //将数据添加进数据表中
                                //创建要执行的Sql语句
                                //关闭数据读取器对象
                                dataReader.Close();
                                string str = "insert into communityfiles values" + "('" + tb_GruopName.Text + "','" + strEmployeeNumber + "','" + strEmployeeName + "','" + strSectionName + "')";
                                //创建SQLCommand的实例
                                SqlCommand command = new SqlCommand(str, sqlConnection);
                                if (command.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("员工插入组数据表成功");
                                }
                                else
                                {
                                    MessageBox.Show("数据插入失败");
                                }
                            }
                            //关闭数据库的连接
                            sqlConnection.Close();
                        }
                    }
                }
            }
            else
            {
                //先判断是否创建了组,如果没有创建组
                //那么提示用户先创建组再进行添加的操作
                if (tb_GruopName.Text=="")
                {
                    MessageBox.Show("您还没有创建组，请先创建组后再进行添加操作");
                }
                else
                {
                    //判断部门列表中有没有条目被勾选上
                    if (lv_Section.SelectedItems.Count==0)
                    {
                        MessageBox.Show("请勾选上你要添加的员工");
                    }
                    else
                    {
                        //MessageBox.Show("你没有勾上全选");
                        for (int i = 0; i < lv_Section.SelectedItems.Count; i++)
                        {
                            //创建listviewitem类的实例
                            ListViewItem viewItem = new ListViewItem();
                            //将部门列表第二列的值取出来 并赋值给变量strEmployeeNumber
                            strEmployeeNumber = lv_Section.SelectedItems[i].SubItems[1].Text;
                            //将部门列表第三列的值取出来 并赋值给变量strEmployeeName
                            strEmployeeName = lv_Section.SelectedItems[i].SubItems[2].Text;
                            //将数据表返回的结果集中的第二列的值取出来 赋值给变量 strSectionName
                            strSectionName = dataRowView[1].ToString();

                            //将变量strEmployeeNumber的值赋值给新建条目viewItem的第一列
                            viewItem.Text = strEmployeeNumber;
                            //将变量strEmployeeNumber的值添加给新建条目viewItem的第二列
                            viewItem.SubItems.Add(strEmployeeName);
                            //将变量strEmployeeNumber的值添加给新建条目viewItem的第三列
                            viewItem.SubItems.Add(strSectionName);


                            //创建要连接的数据库实例
                            using (SqlConnection sqlConnection = new SqlConnection())
                            {
                                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                                //打开连接
                                sqlConnection.Open();
                                //创建要执行的sql语句
                                string strWhetherExist = "select * from CommunityFiles where GroupName='" +tb_GruopName.Text+ "'and EmployeeNumber='" + strEmployeeNumber + "' ";
                                //创建Sqlcommand类的实例
                                SqlCommand sqlCommand = new SqlCommand(strWhetherExist, sqlConnection);
                                //创建数据读取器的实例
                                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                                if (dataReader.Read())
                                {
                                    MessageBox.Show(strEmployeeName + "已存在组中,请勿重复添加");
                                }
                                else
                                {
                                    //将新建的条目viewItem添加给组列表的条目容器中
                                    lv_Group.Items.Add(viewItem);
                                    //将数据添加进数据表中
                                    //创建要执行的Sql语句

                                    //关闭数据读取器对象
                                    dataReader.Close();
                                    string str = "insert into communityfiles values" + "('" + tb_GruopName.Text + "','" + strEmployeeNumber + "','" + strEmployeeName + "','" + strSectionName + "')";
                                    //创建SQLCommand的实例
                                    SqlCommand command = new SqlCommand(str, sqlConnection);
                                    if (command.ExecuteNonQuery() > 0)
                                    {
                                        MessageBox.Show("员工插入组数据表成功");
                                    }
                                    else
                                    {
                                        MessageBox.Show("数据插入失败");
                                    }
                                }
                                //关闭数据库的连接
                                sqlConnection.Close();
                            }
                        }
                    }
                   
                }
            }
        }

        //当目前选中的部门名称发生改变的时候 设置的响应事件
        private void lbx_SectionName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //清空部门人员列表
            lv_Section.Items.Clear();
        }


        //定义一个变量 用来存储当前组的ID
        int CurrentID = 0,
               MiniID = 0,
               MaxID = 0;

        //给工具栏第一条记录  设置点击事件
        private void tsl_FirstRecord_Click(object sender, EventArgs e)
        {
            //清空之前组的列表的全部条目
            lv_Group.Items.Clear();
            ///当点击第一条记录的时候，跳转到community数据表中ID最小值所代表的那行记录
            using (SqlConnection  connection=new SqlConnection())
            {
                connection.ConnectionString = UtilitySql.SetConnectionString();
                //打开数据库连接
                connection.Open();
                //创建要执行的sql语句
                string sqlstrFirst = "select * from community where id='"+MiniID.ToString()+"'";
                //创建sqlCommand的实例
                SqlCommand command = new SqlCommand(sqlstrFirst,connection);
                //创建数据读取器的实例
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    tb_GruopName.Text = reader["GroupName"].ToString();
                    rtb_description.Text = reader["GroupScription"].ToString();

                }
                //关闭数据读取器的实例
                reader.Close();


                //创建要执行的sql语句 获取当前组名的对应组的所有人员信息
                string strsqlmore = "select * from CommunityFiles where GroupName='" + tb_GruopName.Text + "'";
                //创建sqlcommand命令的实例
                SqlCommand sqlCommand = new SqlCommand(strsqlmore, connection);
                //创建数据读取器的实例
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    //创建listviewitem类的实例
                    ListViewItem viewItem = new ListViewItem();
                    viewItem.Text = dataReader["EmployeeNumber"].ToString();
                    viewItem.SubItems.Add(dataReader["EmployeeName"].ToString());
                    viewItem.SubItems.Add(dataReader["SectionName"].ToString());

                    lv_Group.Items.Add(viewItem);
                }
                //关闭数据读取器
                dataReader.Close();
                //关闭数据库的连接
                connection.Close();

            }

            //所以就禁用上一条记录和第一条记录
            // MessageBox.Show("第一条记录");
            //CompareID();
            CompareID();
        }

        //给工具栏上一条记录  设置点击事件
        private void tsl_previousRecord_Click(object sender, EventArgs e)
        {
            //清空之前组列表中的所有条目
            lv_Group.Items.Clear();

            //刷新获取最新的MAXID和MINID值
            CompareID();
            //获取当前记录的ID值 如果ID值在数据表中为最小。说明是第一条记录
            //所以就禁用上一条记录和第一条记录
            // MessageBox.Show("上一个小组");
            //跳转到数据表中上一个ID所代表的行
            // CompareID();
            using (SqlConnection connection=new SqlConnection())
            {
                connection.ConnectionString = UtilitySql.SetConnectionString();
                //打开数据库的连接
                connection.Open();
                //创建要执行的sql语句  获取上一个小组的ID值
                string sqlStringFirst = "select top 1 id from Community where id<'"+CurrentID+"' order by id desc ";
                //创建sqlcommand命令的实例
                SqlCommand sqlCommand = new SqlCommand(sqlStringFirst,connection);
                //创建数据读取器的实例
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                   CurrentID =int.Parse(dataReader["id"].ToString());
                }
                //关闭数据读取器的实例
                dataReader.Close();

                //创建要执行的Sql语句
                string sqlStringSecond = "select * from Community where id='" + CurrentID.ToString() + "'";
                //创建要执行的sqlCommand命令的实例
                SqlCommand command = new SqlCommand(sqlStringSecond,connection);
                //创建数据读取器的实例
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //从数据中读取出GroupName列中的值 并将其赋值给组名文本框
                    tb_GruopName.Text = reader["GroupName"].ToString();
                    //从数据中读取出GroupScription列中的值 并将其赋值给组描述富文本框
                    rtb_description.Text = reader["GroupScription"].ToString();

                }
                //关闭数据读取器的实例
                reader.Close();
                //创建要执行的sql语句
                string sqlStringThird = "select * from CommunityFiles where GroupName='"+tb_GruopName.Text+"'";
                //创建要执行的SqlCommand命令的实例
                SqlCommand sqlCommandThird = new SqlCommand(sqlStringThird,connection);
                //创建数据读取器的实例
                SqlDataReader dataReaderThird = sqlCommandThird.ExecuteReader();
                while (dataReaderThird.Read())
                {
                    //创建listviewitem类的实例
                    ListViewItem viewItem = new ListViewItem();

                    //从数据中读取出EmployeeNumber列中的值 并将其赋值给lv_Group表的第一列
                    viewItem.Text = dataReaderThird["EmployeeNumber"].ToString();

                    //从数据中读取出EmployeeName列中的值 并将其赋值给lv_Group表的第二列
                    viewItem.SubItems.Add(dataReaderThird["EmployeeName"].ToString());

                    //从数据中读取出SectionName列中的值 并将其赋值给lv_Group表的第三列
                    viewItem.SubItems.Add(dataReaderThird["SectionName"].ToString());

                    //将新建的条目添加给列表中的条目的集合中
                    lv_Group.Items.Add(viewItem);
                }
                //关闭数据读取器的实例
                dataReaderThird.Close();
                //关闭数据库的连接
                connection.Close();
            }

            CompareID();

        }

        //给工具栏下一条记录 设置点击事件
        private void tsl_NextRecord_Click(object sender, EventArgs e)
        {
            //清空当前组列表中所有的条目
            lv_Group.Items.Clear();
            //刷新获取最新的MAXID和MINID值
            CompareID();
            //获取当前记录的ID值 如果ID值在数据表中为最大。说明是最后一条记录

            //所有就禁用下一条记录和最后一条记录
            // MessageBox.Show("下一个小组");
            //CompareID();
            //跳转到数据表中下一个ID所代表的行



            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = UtilitySql.SetConnectionString();
                //打开数据库的连接
                connection.Open();
                //创建要执行的sql语句  获取下一个小组的ID值
                string sqlStringFirst = "select top 1 id from Community where id>'" + CurrentID + "' order by id asc ";
                //创建sqlcommand命令的实例
                SqlCommand sqlCommand = new SqlCommand(sqlStringFirst, connection);
                //创建数据读取器的实例
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    CurrentID = int.Parse(dataReader["id"].ToString());
                }
                //关闭数据读取器的实例
                dataReader.Close();

                //创建要执行的Sql语句
                string sqlStringSecond = "select * from Community where id='" + CurrentID.ToString() + "'";
                //创建要执行的sqlCommand命令的实例
                SqlCommand command = new SqlCommand(sqlStringSecond, connection);
                //创建数据读取器的实例
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {


                    tb_GruopName.Text = reader["GroupName"].ToString();
                    rtb_description.Text = reader["GroupScription"].ToString();

                }
                //关闭数据读取器的实例
                reader.Close();
                //创建要执行的sql语句
                string sqlStringThird = "select * from CommunityFiles where GroupName='" + tb_GruopName.Text + "'";
                //创建要执行的SqlCommand命令的实例
                SqlCommand sqlCommandThird = new SqlCommand(sqlStringThird, connection);
                //创建数据读取器的实例
                SqlDataReader dataReaderThird = sqlCommandThird.ExecuteReader();
                while (dataReaderThird.Read())
                {


                    //创建listviewitem类的实例
                    ListViewItem viewItem = new ListViewItem();
                    viewItem.Text = dataReaderThird["EmployeeNumber"].ToString();
                    viewItem.SubItems.Add(dataReaderThird["EmployeeName"].ToString());
                    viewItem.SubItems.Add(dataReaderThird["SectionName"].ToString());

                    lv_Group.Items.Add(viewItem);




                }
                //关闭数据读取器的实例
                dataReaderThird.Close();
                //关闭数据库的连接
                connection.Close();
            }
            CompareID();

        }


        //给工具栏最后一条记录  设置点击事件
        private void tsl_EndRecord_Click(object sender, EventArgs e)
        {
            //清空之前组列表中所有的条目
            lv_Group.Items.Clear();
            //获取当前记录的ID值 如果ID值在数据表中为最大。说明是最后一条记录
            //所有就禁用下一条记录和最后一条记录
            //MessageBox.Show("最后一个小组");
            //CompareID();
            //跳转到数据表中最后一个ID所代表的行
            using (SqlConnection connection=new SqlConnection())
            {
                connection.ConnectionString = UtilitySql.SetConnectionString();
                //打开连接
                connection.Open();
                //创建要执行的sql语句 获取最大ID值所在的那行的数据
                string strsql = "select * from Community where ID='"+MaxID.ToString()+"'";
                //创建command命令的实例
                SqlCommand command = new SqlCommand(strsql,connection);
                //创建数据读取器的实例
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())

                {
                    tb_GruopName.Text=reader["GroupName"].ToString();
                    rtb_description.Text=reader["GroupScription"].ToString();
                }
                //关闭数据读取器的实例
                reader.Close();

                //创建要执行的sql语句 获取当前组名的对应组的所有人员信息
                string strsqlmore = "select * from CommunityFiles where GroupName='"+tb_GruopName.Text+"'";
                //创建sqlcommand命令的实例
                SqlCommand sqlCommand = new SqlCommand(strsqlmore,connection);
                //创建数据读取器的实例
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    //创建listviewitem类的实例
                    ListViewItem viewItem = new ListViewItem();
                    viewItem.Text=dataReader["EmployeeNumber"].ToString();
                    viewItem.SubItems.Add(dataReader["EmployeeName"].ToString());
                    viewItem.SubItems.Add(dataReader["SectionName"].ToString());

                    lv_Group.Items.Add(viewItem);
                }
                //关闭数据读取器
                dataReader.Close();
                //关闭数据库的连接
                connection.Close();
            }
            CompareID();
        }

        //辅助函数 用来切换记录时 清空列表
        private void ClearSectionViewAndGroupView()
        {
            //清空部门列表
            lv_Section.Items.Clear();
            //清空组列表
            lv_Group.Items.Clear();
        }

        //给删除组功能 设置点击事件
        private void tsl_remove_Click(object sender, EventArgs e)
        {
            //=MessageBoxButtons.YesNo;
           var result =MessageBox.Show("你确定要删除吗","",MessageBoxButtons.YesNo);
            if (DialogResult.Yes==result)
            {
                //执行从数据表中删除该组的操作
                using (SqlConnection sqlConnection=new SqlConnection())
                {
                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                    //打开连接
                    sqlConnection.Open();
                    //创建要执行的sql语句
                    string strSQL = "delete from Community where GroupName='"+tb_GruopName.Text+"'";
                    //创建sqlcommand类的实例
                    SqlCommand sqlCommand = new SqlCommand(strSQL,sqlConnection);
                    if (sqlCommand.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("组"+tb_GruopName.Text+"已经成数据表中删除成功");
                    }

                    //创建要执行的sql语句
                    string strSQL2 = "delete from CommunityFiles where GroupName='"+tb_GruopName.Text+"'";
                    //创建sqlCommand类的实例
                    SqlCommand command = new SqlCommand(strSQL2,sqlConnection);
                    if (command.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("组"+tb_GruopName.Text+"中所有的成员已经从数据表中删除成功");
                    }
                    //关闭连接
                    sqlConnection.Close();
                }
                //清空部门列表
                lv_Section.Items.Clear();
                //清空组名称
                tb_GruopName.Text = "";
                //清空组说明
                rtb_description.Text = "";
                //清空组人员列表
                lv_Group.Items.Clear();
            }
        }

        //定义变量用来保存输入的组名称
        string GroupName,
        //定义变量用来保存输入的组说明
               GroupScription;

        //实现当勾选中了 listview中第一列的单选框时，当前条目也会被选中
        private void lv_Section_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            e.Item.Selected=e.Item.Checked;
        }



        //给窗体中手动添加人员  按钮设置点击事件
        private void btn_AddManually_Click(object sender, EventArgs e)
        {
            //先判断是否创建了组名
            //如果没有创建组名则提示用户你还没有创建一个组名

            if (tb_GruopName.Text== "")
            {
                MessageBox.Show("您还没有创建组，请先创建组再进行添加操作");
            }
            else
            {
                ///将添加进组里的员工 显示在列表lv_Group中
                //创建listviewItem类的实例
                ListViewItem listViewItem = new ListViewItem();
                //将工号设置为列表的第一列
                listViewItem.Text = strEmployeeNumber;
                //姓名设置为第二列
                listViewItem.SubItems.Add(strEmployeeName);
                //部门设置为第三列
                listViewItem.SubItems.Add(strSectionName);


                //将listviewItem添加进listview中
                lv_Group.Items.Add(listViewItem);

                //清空工号文本框中的内容
                tb_EmployeeNumber.Text = "";
                //清空姓名框中的内容
                tb_EmployeeName.Text = "";


                ///将列表 lv_Group中的数据添加进数据表CommunityFiles中
                //创建要连接的数据库的实例
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    //设置要连接的目标数据库字符串
                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                    sqlConnection.Open();
                    //创建要执行的SQL语句
                    string strSQL = "insert into CommunityFiles values" + "('" + tb_GruopName.Text + "','" + strEmployeeNumber + "','" + strEmployeeName + "','" + strSectionName + "')";
                    //创建SqlCommand类的实例
                    SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection);
                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("数据已成功添加进数据表中");
                    }
                    else
                    {
                        MessageBox.Show("数据添加失败");
                    }
                    //关闭数据库的连接
                    sqlConnection.Close();
                }
            }
        }


        //给工具栏上的保存功能  设置点击事件
        private void tsl_store_Click(object sender, EventArgs e)
        {
            //获取输入的分组名称
            GroupName = tb_GruopName.Text;
            //获取输入的分组说明
            GroupScription = rtb_description.Text;
            //消息框弹出组名
            MessageBox.Show(GroupName);
            //消息框弹出组的说明
            MessageBox.Show(GroupScription);
            //将输入的数据保存进Group数据表中

            //创建个数据库连接实例
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //打开连接
                sqlConnection.Open();
                //创建要执行的sql字符串
                string sqlStr = "insert into Community(GroupName,GroupScription) values"+"('"+GroupName+"','"+GroupScription+"')";
                //创建sqlCommand类的实例
                SqlCommand sqlCommand = new SqlCommand(sqlStr, sqlConnection);
                if (sqlCommand.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("组名"+GroupName+"创建成功");
                }
                //关闭数据库的连接
                sqlConnection.Close();
            }

            //禁用工具栏上的保存功能
            tsl_store.Enabled = false;
            //禁用工具栏上的取消功能
            tsl_Cancel.Enabled = false;
            //激活工具栏上的新建
            tsl_Create.Enabled = true;
            //激活工具栏上的查找
            tsl_Query.Enabled = true;
            //激活工具栏上的删除
            tsl_remove.Enabled = true;

            //激活工具栏上的第一条
            tsl_FirstRecord.Enabled = true;
            //激活工具栏上的上一条
            tsl_previousRecord.Enabled = true;
            //激活工具栏上的下一条
            tsl_NextRecord.Enabled = true;
            //激活工具栏上的最后一条
            tsl_EndRecord.Enabled = true;

            //激活全选框
            cb_All.Enabled = true;

            //激活查看部门人员按钮
            btn_peek.Enabled = true;
            //激活添加按钮
            btn_Add.Enabled = true;
            //激活删除按钮
            btn_Remove.Enabled = true;
            //激活部门listbox框
            lbx_SectionName.Enabled = true;
            //激活部门人员列表
            lv_Section.Enabled = true;

            //清空小组成员列表
            lv_Group.Items.Clear();
           
        }

        //刷新当前组的函数 
        private void RefreshRecord()
        {
        }

        //辅助函数 用来判断当前组的ID是不是ID的最大值，或ID的最小值
        private void CompareID()
        {

            //获取当前记录的ID值 如果ID值在数据表中为最小。说明是第一条记录
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //打开数据库的连接
                sqlConnection.Open();
                //创建要执行的sql语句
                string sqlString = "select ID from Community where GroupName='" + tb_GruopName.Text + "'";
                //创建sqlCommand类的实例
                SqlCommand command = new SqlCommand(sqlString, sqlConnection);
                //创建数据库读取器
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {      //将返回的结果集中的ID列中的的值取出，然后将其转化成int类型的值
                    CurrentID = int.Parse(reader["ID"].ToString());

                }
                //弹出消息框输出   当前组名在数据表Community中的对应ID值
                //MessageBox.Show(CurrentID.ToString());

                //关闭数据读取器
                reader.Close();
                //创建要执行的sql语句  取出当前数据表中最小的ID值
                string getMinString = "select min(ID) from community";
                SqlCommand sqlCommand = new SqlCommand(getMinString, sqlConnection);
                //创建数据读取器的实例
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    //将返回结果集中的第一列的值取出来，并将其转化成int类型的值
                    MiniID = int.Parse(sqlDataReader[0].ToString());
                }
                //消息提示框弹出 Community表中最小的ID值
               // MessageBox.Show("数据表中最小的id值为"+MiniID.ToString());
                //关闭数据读取器
                sqlDataReader.Close();

                //创建要执行的sql语句  取出当前数据表中最大的ID值
                string getMaxString = "select max(ID) from community";

                SqlCommand sqlCommandMax = new SqlCommand(getMaxString,sqlConnection);
                //创建数据读取器的实例
                SqlDataReader readerMax = sqlCommandMax.ExecuteReader();
                while (readerMax.Read())
                {
                    MaxID = int.Parse(readerMax[0].ToString());
                }

                //弹出消息框提示 community表中最大的值
                //MessageBox.Show("数据表中最大的id值为"+MaxID.ToString());

                if (CurrentID == MiniID)
                {
                    //MessageBox.Show("我是第一个小组");
                    //禁用第一个小组
                    tsl_FirstRecord.Enabled = false;
                    //禁用上一个小组
                    tsl_previousRecord.Enabled = false;

                    //激活下一一个小组
                    tsl_NextRecord.Enabled = true;
                    //激活最后一个小组
                    tsl_EndRecord.Enabled = true;
                }
                else if (CurrentID == MaxID)
                {
                    //MessageBox.Show("我是最后一个小组");
                    //禁用下一个小组
                    tsl_NextRecord.Enabled = false;
                    //禁用最后一个小组
                    tsl_EndRecord.Enabled = false;

                    //激活第一个小组
                    tsl_FirstRecord.Enabled =true;
                    //激活上一个小组
                    tsl_previousRecord.Enabled =true;
                }
                else if (CurrentID!=MaxID&CurrentID!=MiniID)
                {
                    //激活下一个小组
                    tsl_NextRecord.Enabled = true;
                    //激活最后一个小组
                    tsl_EndRecord.Enabled = true;

                    //激活第一个小组
                    tsl_FirstRecord.Enabled = true;
                    //激活上一个小组
                    tsl_previousRecord.Enabled = true;

                }
               

            }

        }
    }
}
