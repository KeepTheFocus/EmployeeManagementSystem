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


            //给部门下拉框设置数据源
           lbx_SectionName.DataSource = GetSectionName();
            //设置下拉框显示哪一列
           lbx_SectionName.DisplayMember = "SectionName";

            //读取Community表中的数据
            using ( SqlConnection  sqlConnection =new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //打开连接
                sqlConnection.Open();

                //创建要执行strSQL语句
                string strSQL = "select * from Community";
                //创建sqlCommand类的实例
                SqlCommand sqlCommand = new SqlCommand(strSQL,sqlConnection);
                //创建一个数据读取器的实例

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {

                    //将组名赋值给tb_GroupName
                    tb_GruopName.Text = sqlDataReader["GroupName"].ToString();
                    //将组的描述赋值给tb_description
                    rtb_description.Text=sqlDataReader["GroupScription"].ToString();
                }

                sqlDataReader.Close();

                ///将组成员列表中所有的成员显示在列表lv_Group中

                //创建要执行的strSql语句
                string strLVGROUP = "select * from CommunityFiles";
                //创建Sqlcommand类的实例
                SqlCommand sqlCommandGroup = new SqlCommand(strLVGROUP, sqlConnection);
                //创建数据读取器类的实例
                SqlDataReader readerGroup = sqlCommandGroup.ExecuteReader();
                while (readerGroup.Read())
                {
                    //创建一个listviewitem条目
                    ListViewItem viewItem = new ListViewItem();
                    viewItem.Text = readerGroup["EmployeeNumber"].ToString();
                    viewItem.SubItems.Add(readerGroup["EmployeeName"].ToString());
                    viewItem.SubItems.Add(readerGroup["SectionName"].ToString());
                    

                    //将viewItem 添加lv_Group
                    lv_Group.Items.Add(viewItem);

                }

                sqlConnection.Close();
            }
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

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

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
            //循环遍历每一个条目
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

            //使分组名称、说明文本框变为可接受编辑的状态
            tb_GruopName.ReadOnly = false;

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
            //全选框禁用
            cb_All.Enabled = false;


            //部门listbox禁用
            lbx_SectionName.Enabled = false;
            //部门人员listview禁用
            lv_Section.Enabled = false;


            //禁用新建功能
            tsl_Create.Enabled = false;
            //禁用查找功能
            tsl_Query.Enabled = false;
            //禁用删除功能
            tsl_remove.Enabled = false;
            //禁用第一条记录功能
            tsl_FirstRecord.Enabled = false;
            //禁用上一条记录功能
            tsl_previousRecord.Enabled = false;
            //禁用下一条记录功能
            tsl_NextRecord.Enabled = false;
            //禁用最后一条记录功能
            tsl_EndRecord.Enabled = false;


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

            //在列表中删除某一个条目
            lv_Group.Items.RemoveAt(a);

           



        }


        //给窗体中添加  按钮设置点击事件
        private void btn_Add_Click(object sender, EventArgs e)
        {
            ///1先判断全选框有没有被勾选上,如果被勾选上。执行全部添加
            ///如果没有勾选上，则添加列表中被勾选上的条目

            if (cb_All.Checked==true)
            {

                ///1.先添加进列表LV_Group中
                //创建listviewItem类的实例
                for (int i = 0; i < lv_Section.Items.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem();
                   
                    strEmployeeNumber= lv_Section.Items[i].SubItems[1].Text;
                    strEmployeeName = lv_Section.Items[i].SubItems[2].Text;
                    strSectionName = dataRowView[1].ToString();
                    listViewItem.Text = strEmployeeNumber;
                    listViewItem.SubItems.Add(strEmployeeName);
                    listViewItem.SubItems.Add(strSectionName);

                    //创建要连接的数据库实例
                    using (SqlConnection sqlConnection=new SqlConnection())
                    {
                        sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                        //打开连接
                        sqlConnection.Open();
                        //创建要执行的sql语句
                        string strWhetherExist ="select * from CommunityFiles where GroupName='"+strGroupName+"'and EmployeeNumber='"+strEmployeeNumber+"' ";
                        //创建Sqlcommand类的实例
                        SqlCommand sqlCommand = new SqlCommand(strWhetherExist,sqlConnection);
                        //创建数据读取器的实例
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();

                        if (dataReader.Read())
                        {
                            MessageBox.Show(strEmployeeName+"已存在组中,请勿重复添加");
                        }
                        else
                        {
                            lv_Group.Items.Add(listViewItem);
                            //将数据添加进数据表中
                            //创建要执行的Sql语句
                            //关闭数据读取器对象
                            dataReader.Close();
                            string str = "insert into communityfiles values" + "('" + strGroupName + "','" + strEmployeeNumber + "','" + strEmployeeName + "','" + strSectionName + "')";
                            //创建SQLCommand的实例
                            SqlCommand command = new SqlCommand(str,sqlConnection);
                            if (command.ExecuteNonQuery()>0)
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
            else
            {
               MessageBox.Show("请确认是够勾上了全选框");
                for (int i = 0; i < lv_Section.SelectedItems.Count; i++)
                {
                    //创建listviewitem类的实例
                    ListViewItem viewItem = new ListViewItem();
                    strEmployeeNumber=lv_Section.SelectedItems[i].SubItems[1].Text;
                    strEmployeeName=lv_Section.SelectedItems[i].SubItems[2].Text;
                    strSectionName = dataRowView[1].ToString();

                    viewItem.Text = strEmployeeNumber;
                    viewItem.SubItems.Add(strEmployeeName);
                    viewItem.SubItems.Add(strSectionName);


                    //创建要连接的数据库实例
                    using (SqlConnection sqlConnection = new SqlConnection())
                    {
                        sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                        //打开连接
                        sqlConnection.Open();
                        //创建要执行的sql语句
                        string strWhetherExist = "select * from CommunityFiles where GroupName='" + strGroupName + "'and EmployeeNumber='" + strEmployeeNumber + "' ";
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
                            lv_Group.Items.Add(viewItem);
                            //将数据添加进数据表中
                            //创建要执行的Sql语句
                            //关闭数据读取器对象
                            dataReader.Close();
                            string str = "insert into communityfiles values" + "('" + strGroupName + "','" + strEmployeeNumber + "','" + strEmployeeName + "','" + strSectionName + "')";
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

        //当目前选中的部门名称发生改变的时候 设置的响应事件
        private void lbx_SectionName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //清空部门人员列表

            lv_Section.Items.Clear();
        }

        //给工具栏第一条记录  设置点击事件
        private void tsl_FirstRecord_Click(object sender, EventArgs e)
        {
            MessageBox.Show("第一条记录");
          
        }

        //给工具栏上一条记录  设置点击事件
        private void tsl_previousRecord_Click(object sender, EventArgs e)
        {
            MessageBox.Show("上一条记录");
        }

        //给工具栏下一条记录 设置点击事件
        private void tsl_NextRecord_Click(object sender, EventArgs e)
        {
            MessageBox.Show("下一条记录");
        }


        //给工具栏最后一条记录  设置点击事件
        private void tsl_EndRecord_Click(object sender, EventArgs e)
        {
            MessageBox.Show("最后一条记录");
        }

        //辅助函数 用来切换记录时 清空列表
        private void ClearSectionViewAndGroupView()
        {
            //清空部门列表
            lv_Section.Items.Clear();
            //清空组列表
            lv_Group.Items.Clear();

        }



        //定义变量用来保存输入的组名称和组说明
        string GroupName,
               GroupScription;

        

        //给窗体中手动添加人员  按钮设置点击事件
        private void btn_AddManually_Click(object sender, EventArgs e)
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
            using (SqlConnection sqlConnection =new SqlConnection())
            {
                //设置要连接的目标数据库字符串
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                sqlConnection.Open();

                //创建要执行的SQL语句
                string strSQL = "insert into CommunityFiles values"+"('"+strGroupName+"','"+strEmployeeNumber+"','"+strEmployeeName+"','"+strSectionName+"')";

                //创建SqlCommand类的实例
                SqlCommand sqlCommand = new SqlCommand(strSQL,sqlConnection);

                if (sqlCommand.ExecuteNonQuery()>0)
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


        //给工具栏上的保存功能  设置点击事件
        private void tsl_store_Click(object sender, EventArgs e)
        {
            //获取输入的分组名称
            GroupName = tb_GruopName.Text;
            //获取输入的分组说明
            GroupScription = rtb_description.Text;

            MessageBox.Show(GroupName);
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

            //禁用保存功能
            tsl_store.Enabled = false;
            //禁用取消功能
            tsl_Cancel.Enabled = false;

            //激活全选框
            cb_All.Enabled = true;

            //激活添加按钮
            btn_Add.Enabled = true;

            //激活新建
            tsl_Create.Enabled = true;
            //激活查找
            tsl_Query.Enabled = true;
            //激活删除
            tsl_remove.Enabled = true;

            //激活第一条
            tsl_FirstRecord.Enabled = true;
            //激活上一条
            tsl_previousRecord.Enabled = true;
            //激活下一条
            tsl_NextRecord.Enabled = true;
            //激活最后一条
            tsl_EndRecord.Enabled = true;

        }


       

    }
}
