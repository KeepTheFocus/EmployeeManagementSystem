using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class PreviewOTPaperInputForm : Form
    {
        public PreviewOTPaperInputForm()
        {
            InitializeComponent();
        }
        public string getLookUpDate { get {return   lv_previewOT.Items[0].SubItems[4].Text.ToString(); }}



        //给数据表中插入对应列的默认值
        string DefaultReviewState = "未审核",
               DefaultNGCause = string.Empty,
               DefaultCurrentMonthTotal = "0",
               DefaultComment = string.Empty,
               DefaultCEOReviewState = "未审核",
               DefaultCEONGCause = string.Empty;
               

        DataTable dataTable;
        //用来保存ID值对应的GroupName

        DataRowView dataRowView;
        //用来存储从结果集中取出来的员工工号
        string STREmployeeNumber;
        //用来存储从结果集汇总取出来的组名
        string STRGroupName;
        //用来存储从结果集中取出来的加班原因
        string STROTCause;
        
        //在窗体加载过程中  执行的函数
        private void PreviewOtpInputForm_Load(object sender, EventArgs e)
        {
            //获取数据表中ID的最新状态
            CompareID();
            //禁用员工工号文本框
            tb_EmployeeNumber.Enabled = false;
            //禁用员工姓名文本框
            tb_EmployeeName.Enabled = false;
            //给列表框设置数据源
            listBox_GroupName.DataSource = GetGroupName();
            //在组名框listbox中显示 数据表中所有的组名
            listBox_GroupName.DisplayMember = "GroupName";

            //给加班原因下拉框设置 数据源
            cb_OTCause.DataSource = GetOTCause();
            //在下拉框中显示所有的原因
            cb_OTCause.DisplayMember = "CauseNumber";
            //在组成员列表中显示数据表中ID值最小的组的全部员工
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //打开连接
                sqlConnection.Open();
                //创建要执行的sql语句
                string stringZero = "select * from Community where id='"+MinID+"'";
                SqlCommand sqlCommandZero = new SqlCommand(stringZero,sqlConnection);
                //创建数据读取器的实例
                SqlDataReader sqlDataReaderZero = sqlCommandZero.ExecuteReader();
                while (sqlDataReaderZero.Read())
                {
                    //将结果集中的值取出来付给变量STRGroupName 
                    STRGroupName = sqlDataReaderZero["GroupName"].ToString();
                    
                }
                sqlDataReaderZero.Close(); //关闭数据读取器

                //创建要执行的SQL语句
                string stringFirst = "select * from CommunityFiles where GroupName='"+STRGroupName+"'";
                SqlCommand sqlCommandFirst = new SqlCommand(stringFirst,sqlConnection);
                SqlDataReader sqlDataReaderFirst = sqlCommandFirst.ExecuteReader();
                
                listView_Group.Items.Clear();//清空之前的条目 
                while (sqlDataReaderFirst.Read())
                {
                     ListViewItem listViewItem = new ListViewItem(); //新建listviewItem
                    listViewItem.SubItems.Add(sqlDataReaderFirst["EmployeeNumber"].ToString());
                   listViewItem.SubItems.Add(sqlDataReaderFirst["EmployeeName"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderFirst["SectionName"].ToString());
                    //将listviewItem添加进listView_Group容器的条目的集合中
                    listView_Group.Items.Add(listViewItem);
                }
                //关闭数据读取器
                sqlDataReaderFirst.Close();
                //创建要执行的sql语句
                string stringSecond = "select * from PreviewOverTime where OTDate='"+dtp_OTDatePreview.Text+"'";
                SqlCommand sqlCommandSecond = new SqlCommand(stringSecond,sqlConnection);
                SqlDataReader sqlDataReaderSecond = sqlCommandSecond.ExecuteReader();
                lv_previewOT.Items.Clear(); //清空之前加班列表的条目

                while (sqlDataReaderSecond.Read())
                {
                    //新建listviewitem条目
                    ListViewItem listViewItem = new ListViewItem();
                    //将结果集中的数据添加进条目中
                    listViewItem.SubItems.Add(sqlDataReaderSecond["EmployeeNumber"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderSecond["EmployeeName"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderSecond["SectionName"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderSecond["OTDate"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderSecond["OTType"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderSecond["OTLength"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderSecond["OTStart"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderSecond["OTStop"].ToString());
                    //将新建的条目添加进条目容器中
                    lv_previewOT.Items.Add(listViewItem);
                }
                //关闭数据读取器的连接
                sqlDataReaderSecond.Close();
                //关闭数据库的连接
                sqlConnection.Close();
            }
            //获取当前加班列表lv_previewOT中的总人数 并将它显示在窗体中
            label_totalCount.Text = lv_previewOT.Items.Count.ToString();
        }

            int 
            MinID,//用来保存数据中最小的ID
            MaxID;//用来保存数据表中最大的ID
        //实时刷新数据表中所有的ID
        private void CompareID()
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //打开连接
                sqlConnection.Open();
                //创建要执行的SQL语句
                string stringZero = "select min(id) from Community";
                //创建SQLCommand命令的实例语句
                SqlCommand sqlCommandZero = new SqlCommand(stringZero,sqlConnection);
                //创建数据读取器的实例
                SqlDataReader sqlDataReaderZero = sqlCommandZero.ExecuteReader();
                while (sqlDataReaderZero.Read())
                {
                    //将最小的ID取出 并赋值给MinID;
                   MinID=int.Parse(sqlDataReaderZero[0].ToString());
                }
                //关闭数据读取器
                sqlDataReaderZero.Close();

                //创建要执行的SQL语句
                string stringFirst = "select max(id) from Community";

                //创建SQLCommand命令的实例语句
                SqlCommand sqlCommandFirst = new SqlCommand(stringFirst, sqlConnection);
                //创建数据读取器的实例
                SqlDataReader sqlDataReaderFirst = sqlCommandFirst.ExecuteReader();
                while (sqlDataReaderFirst.Read())
                {
                    //将最小的ID取出 并赋值给MinID;
                    MaxID = int.Parse(sqlDataReaderFirst[0].ToString());
                }
                sqlDataReaderFirst.Close(); //关闭数据读取器
                sqlConnection.Close();//关闭数据库
            }
        }

        //创建一个辅助函数 用来给组名框配置数据表中存在的数据
        private  DataTable GetGroupName()
        {
            //获取数据表中所有的组名
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                sqlConnection.Open(); //打开连接
                //创建要执行的sql语句
                string stringZero = "select * from community";
                SqlCommand sqlCommandZero = new SqlCommand(stringZero,sqlConnection);
                //创建数据适配器的实例
                SqlDataAdapter sqlDataAdapterZero = new SqlDataAdapter(sqlCommandZero);
                //创建数据表格
                dataTable = new DataTable();
                //将表格与数据适配器连接起来
                sqlDataAdapterZero.Fill(dataTable);
            }
            return dataTable;
        }

        //创建一个辅助函数  用来给加班原因下拉框配置数据表中存在的数据
        private DataTable GetOTCause()
        {
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                //打开连接
                sqlConnection.Open();
                //获得数据表中所有的原因
                string stringZero = "select * from OverTimeCause ";
                SqlCommand sqlCommandZero = new SqlCommand(stringZero,sqlConnection);
                SqlDataAdapter sqlDataAdapterZero = new SqlDataAdapter(sqlCommandZero);
                //创建数据表格
                dataTable = new DataTable();
                sqlDataAdapterZero.Fill(dataTable);
                sqlConnection.Close();//关闭数据库连接
            }
            return dataTable;
        }

        //给全选组列表成员单选框checkBox_WholeGroupMember 设置选中事件
        private void checkBox_WholeGroupMember_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Group.Items)
            {
                //将列表中的每一个条目前面的选项框都勾上
                item.Checked = (sender as CheckBox).Checked;
            }
        }

        private void listBox_GroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView_Group.Items.Clear();//清空组列表listView_Group上一次保存的所有条目
            if (listBox_GroupName.SelectedItem!=null)//如果listbox中存在被选中的条目 执行if语句块中的语句
            {
                dataRowView = listBox_GroupName.SelectedItem as DataRowView;
                STRGroupName = dataRowView[1].ToString();//取出dataRowView对象中第二列的数据 并赋值给 STRGroupName
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                    sqlConnection.Open();//打开连接
                    //创建要执行的sql语句
                    string stringZero = "select * from CommunityFiles where GroupName='" + STRGroupName + "'";
                    //创建sqlcommand命令的实例
                    SqlCommand sqlCommandZero = new SqlCommand(stringZero, sqlConnection);
                    //创建数据读取器的实例
                    SqlDataReader sqlDataReaderZero = sqlCommandZero.ExecuteReader();
                    while (sqlDataReaderZero.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(); //创建listviewitem的实例
                        listViewItem.SubItems.Add(sqlDataReaderZero["EmployeeNumber"].ToString());
                        listViewItem.SubItems.Add(sqlDataReaderZero["EmployeeName"].ToString());
                        listViewItem.SubItems.Add(sqlDataReaderZero["SectionName"].ToString());
                        listView_Group.Items.Add(listViewItem);//将新建的条目添加进列表容器中
                    }
                    sqlDataReaderZero.Close(); //关闭数据读取器
                    sqlConnection.Close(); //关闭数据库的连接
                }
            }
        }

        //当原因下拉框的选中项发生改变时  执行的事件
        private void cb_OTCause_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataRowView = cb_OTCause.SelectedItem as DataRowView;
            STROTCause = dataRowView[2].ToString();
            rtb_OTCause.Text = STROTCause;//将数据行中第三列的值赋值给  加班原因富文本框
        }

        //在员工工号输入完成后敲击回车键后 执行的事件
        private void tb_EmployeeNumber_KeyDown(object sender, KeyEventArgs e)
        {
            STREmployeeNumber = tb_EmployeeNumber.Text;//获取输入的员工工号，并赋值给变量 STREmployeeNumber
            //建立与数据库的连接
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                sqlConnection.Open();
                //创建要执行的sql语句
                string StringZero = "select EmployeeName,SectionName  from EmployeeFiles where EmployeeNumber='" + STREmployeeNumber + "'";
                SqlCommand sqlCommandZero = new SqlCommand(StringZero,sqlConnection);
                SqlDataReader sqlDataReaderZero = sqlCommandZero.ExecuteReader();
                while (sqlDataReaderZero.Read())
                {
                    tb_EmployeeName.Text = sqlDataReaderZero["EmployeeName"].ToString();
                    tb_SectionNmae.Text = sqlDataReaderZero["SectionName"].ToString();
                }
                sqlDataReaderZero.Close();   //关闭数据读取器的实例
                sqlConnection.Close(); //关闭数据库的连接
            }

        }

        //在加班工时文本框中敲击回车键后  执行的事件
        private void tb_OTLength_KeyDown(object sender, KeyEventArgs e)
        {
            //将计算好的加班时长赋值给  加班时长文本框
           tb_OTLength.Text=""+int.Parse("" + (dtp_OTStop.Value - dtp_OTStart.Value).Hours);

        }
        //给查看预计加班人员列表中所有成员添加点击事件
        private void btn_Lookup_Click(object sender, EventArgs e)
        {
            //如果加班人员列表中的条目大于零的话，说明当天有加班记录。点击查看按钮才会有数据显示出来
            if (lv_previewOT.Items.Count>0)
            {
                //MessageBox.Show(lv_previewOT.Items[0].SubItems[4].Text.ToString());
                //弹出查看加班人员列表详情
                LookUpPreviewOTForm lookUpPreviewOTForm = new LookUpPreviewOTForm(lv_previewOT.Items[0].SubItems[4].Text.ToString());
                lookUpPreviewOTForm.Show(this);
            }
            else
            {
                MessageBox.Show("您要查询的日期无加班计划");
            }
           

        }
          //当鼠标在加班时长文本框中 点击后触发的事件
        private void tb_OTLength_Click(object sender, EventArgs e)
        {
            //将计算好的加班时长赋值给  加班时长 文本框
            tb_OTLength.Text = "" + int.Parse("" + (dtp_OTStop.Value - dtp_OTStart.Value).Hours);
        }
        //创建变量 用来存储将要保存进数据库中的数据
        string DBEmployeeNumber,
               DBEmployeeName,
              DBSectionName,
              DBOverTimeDate,
              DBOverTimeType,
              DBOverTimeLength,
              DBOverTimeStart,
              DBOverTimeStop;

        //给切换日期的操作 设置事件
        private void dtp_LookupOTHistory_CloseUp(object sender, EventArgs e)
        {
            MessageBox.Show("您选择的日期为"+dtp_LookupOTHistory.Text);
            lv_previewOT.Items.Clear(); //清空之前加班listview中所有的成员
                                        //从数据表中查询 字段为当前选中日期的所有记录

            //将查询到的选中日期的加班记录显示到listview中
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                sqlConnection.Open();//打开连接
                //创建要查询的sql语句
                string stringZero = "select * from PreviewOverTime where OTDate='"+dtp_LookupOTHistory.Text+"'";
                SqlCommand sqlCommandZero = new SqlCommand(stringZero,sqlConnection);
                //创建数据读取器
                SqlDataReader sqlDataReaderzero = sqlCommandZero.ExecuteReader();

                while (sqlDataReaderzero.Read())
                {
                    //创建listviewitem的实例
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems.Add(sqlDataReaderzero["EmployeeNumber"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderzero["EmployeeName"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderzero["SectionName"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderzero["OTDate"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderzero["OTType"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderzero["OTLength"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderzero["OTStart"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderzero["OTStop"].ToString());

                    //将新建的listviewitem的实例添加进列表的条目容器中
                    lv_previewOT.Items.Add(listViewItem);
                }
                sqlDataReaderzero.Close();//关闭数据读取器的实例
                sqlConnection.Close(); //关闭数据库的连接
            }
        }

        private void lv_previewOT_ItemActivate(object sender, EventArgs e)
        {
            MessageBox.Show("当前条目的索引值为"+lv_previewOT.FocusedItem.Index.ToString());
            if (lv_previewOT.FocusedItem != null)//如果存在已获取到焦点的条目
            {
                //获取当前持有焦点的条目的索引
               int a = lv_previewOT.FocusedItem.Index;
                //更新工号框
                tb_EmployeeNumber.Text = lv_previewOT.Items[a].SubItems[1].Text;
                //更新姓名框
             tb_EmployeeName.Text = lv_previewOT.Items[a].SubItems[2].Text;
               //更新加班起始时间
              dtp_OTStart.Text = lv_previewOT.Items[a].SubItems[7].Text;
              //更新加班结束时间
              dtp_OTStop.Text = lv_previewOT.Items[a].SubItems[8].Text;
              //更新加班工时框
              tb_OTLength.Text = lv_previewOT.Items[a].SubItems[6].Text;
            }

        }
        
        //给查找按钮 设置点击事件
        private void tsl_lookup_Click(object sender, EventArgs e)
        {
            //新建查询窗体
            QueryInWholePreviewOTForm queryInWholePreviewOTForm = new QueryInWholePreviewOTForm();
            if (queryInWholePreviewOTForm.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show("您查询的员工存在于当前表中");
                ListViewItem focusItem = lv_previewOT.FindItemWithText(queryInWholePreviewOTForm.tb_EmployeeNumber2query.Text);

                if (focusItem!=null)

                {
                    //lv_previewOT.TopItem = focusItem;

                   // focusItem.ForeColor = Color.Red;
                    //确保查询到的数据能够展示在您的视线范围内
                    focusItem.EnsureVisible();
                    //条目的背景颜色
                    focusItem.BackColor = Color.AliceBlue;
                    //条目的文字颜色
                    focusItem.ForeColor = Color.Gold;
               
                }
            }

        }

        //当预计加班人员列表的选中的索引发生改变时 触发的事件
        private void lv_previewOT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //给工具栏上的删除 添加点击事件
        private void tsl_remove_Click(object sender, EventArgs e)
        {
            if (lv_previewOT.SelectedItems.Count>0)
            {
                foreach (ListViewItem lvi in lv_previewOT.SelectedItems)
                {
                    //    //获取当前条目的工号
                    DBEmployeeNumber = lvi.SubItems[1].Text;
                    DBEmployeeName = lvi.SubItems[2].Text;
                    //    //获取当前条目的加班日期
                    DBOverTimeDate = lvi.SubItems[4].Text;
                    //    //获取当前条目的起始加班时间
                    DBOverTimeLength = lvi.SubItems[7].Text;
                    //MessageBox.Show(DBEmployeeNumber);
                   // MessageBox.Show(DBOverTimeDate);
                    lvi.Remove();
                }

                using (SqlConnection sqlConnection = new SqlConnection())
                  {
                       sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                       sqlConnection.Open();
                //        //创建要执行的sql语句
                      string stringZero = "delete from PreviewOverTime where (employeeNumber='" + DBEmployeeNumber + "' and  OTDate='" + DBOverTimeDate + "') ";

                           SqlCommand sqlCommandZero = new SqlCommand(stringZero, sqlConnection);

                           if (sqlCommandZero.ExecuteNonQuery() > 0)
                           {
                             MessageBox.Show(DBEmployeeName+"已从数据表中删除成功");
                          }
                           sqlConnection.Close();  //关闭数据的连接
                }




                    // ////判断是否选中了条目
                    //if (lv_previewOT.FocusedItem != null)
                    //{
                  

                  

                    //    // //    //重新对列表中的索引进行排序赋值
                    //    for (; a < lv_previewOT.Items.Count; a++)
                    //    {
                    //        lv_previewOT.Items[a].Text = (a + 1).ToString();
                    //    }
                    //    // //    //刷新当前加班表中的人数
                    //    label_totalCount.Text = lv_previewOT.Items.Count.ToString();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("请在预计加班列表中选择要删除的员工");
                    //}

            }
            else
            {
                MessageBox.Show("请选择要移除的员工");
            }
            //// MessageBox.Show(lv_previewOT.SelectedItems.Count.ToString());
            //刷新加班人数
            label_totalCount.Text = lv_previewOT.Items.Count.ToString();
        }

        private void lv_previewOT_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        //给加班列表每个条目前的单选框 设置事件
        private void lv_previewOT_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            e.Item.Selected = e.Item.Checked;//当选项框被选中时  使当前条目处于被选中状态
        }


        //给全选预计加班列表所有人员单选框 设置切换事件
        private void checkBox_previewOTWholeMember_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_previewOT.Items)
            {
                //将全选框的选中状态 赋值给 单个条目的选中状态
                item.Checked =(sender as CheckBox).Checked;
            }
        }

        //给向预定加班人员列表按钮 增加点击事件
        private void btn_Embed_Click(object sender, EventArgs e)
        {
            //先判断要添加的数据是否已经存在于数据库中
            //两次添加的数据中的加班起始时间 和 加班结束时间 不能存在交集
            //如果存在交集 则提示添加信息失败 ，请检查加班时间
            //如果不存在交集  则进行添加操作

            //先判断是否勾选上了  手工录入加班单的单选框
            if (checkBox_Manually.CheckState==CheckState.Checked)
            {
                //如果勾上了执行手动每次添加一名员工的操作
               // MessageBox.Show("您勾上了手动录入");
                if (tb_EmployeeName.Text!="")
                {
                    
                    DBEmployeeNumber = tb_EmployeeNumber.Text;//获取员工工号
                    
                    DBEmployeeName = tb_EmployeeName.Text;//获取员工姓名
                    
                    DBSectionName = tb_SectionNmae.Text;//获取员工部门
                    
                    DBOverTimeDate =dtp_OTDatePreview.Text;//获取加班日期
                    
                    DBOverTimeType = cb_OTType.Text;//获取加班类型
                    
                    DBOverTimeLength = tb_OTLength.Text;//获取加班工时
                    
                    DBOverTimeStart = dtp_OTStart.Text;//获取加班开始时间
                    
                    DBOverTimeStop = dtp_OTStop.Text;//获取加班结束时间

                


                        //先判断当前工号和日期存不存于 加班列表中
                        using (SqlConnection sqlConnection = new SqlConnection())
                        {
                            sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                            sqlConnection.Open();//打开数据库的连接
                                                 //创建要执行的sql语句
                            string stringzero = "select * from PreviewOverTime where employeeNumber='" + DBEmployeeNumber + "' and OTDate='" + DBOverTimeDate + "'";
                            //创建sqlcommand命令的语句
                            SqlCommand sqlCommandZero = new SqlCommand(stringzero, sqlConnection);
                            //创建数据读取器的实例
                            SqlDataReader sqlDataReaderZero = sqlCommandZero.ExecuteReader();

                            if (!sqlDataReaderZero.HasRows)//如果数据读取器中没有读取到任何数据,说明数据表中不存在要查询的数据
                            {
                            //如果勾上了全选组列表成员 单选框，执行添加所有组列表成员的操作

                            //如果输入的加班日期 小于 当前日期 将弹出消息框提示用户
                            //加班日期不能比当前日期更小
                            TimeSpan timeSpan = Convert.ToDateTime(dtp_OTDatePreview.Text) - DateTime.Today;
                            //MessageBox.Show("" + DateTime.Today);
                           // MessageBox.Show("" + timeSpan.TotalDays);
                            if (timeSpan.TotalDays < 0)
                            {
                                MessageBox.Show("今天加班的日期" + Convert.ToDateTime(dtp_OTDatePreview.Text));
                                MessageBox.Show(DateTime.Now.ToString());
                                MessageBox.Show("加班日期不能小于当前日期,请确认您要输入的加班日期");
                            }
                            else
                            {

                                //创建要执行的sql语句
                                string StringFirst = "insert into previewOverTime values ('" + DBEmployeeNumber + "','" + DBEmployeeName + "','" + DBSectionName + "','" + DBOverTimeDate + "','" + DBOverTimeType + "','" + DBOverTimeLength + "','" + DBOverTimeStart + "','" + DBOverTimeStop + "','" + DefaultReviewState + "', '" + rtb_OTCause.Text + "','" + DefaultNGCause + "','" + DefaultCurrentMonthTotal + "','" + DefaultComment + "','" + DefaultCEOReviewState + "','" + DefaultCEONGCause + "')";
                                //创建sqlcommand命令的实例
                                SqlCommand sqlCommandFirst = new SqlCommand(StringFirst, sqlConnection);
                                if (sqlCommandFirst.ExecuteNonQuery() > 0)//如果受命令影响的行数大于零,说明插入操作成功
                                {
                                    MessageBox.Show("预计加班人员插入数据表成功");
                                }

                                sqlDataReaderZero.Close(); //关闭数据读取器的实例
                                                           //清空之前listview中的所有条目  用来更新 数据表中的最新数据
                                lv_previewOT.Items.Clear();
                                string StringSecond = "select * from previewOverTime ";//创建要执行的sql语句
                                SqlCommand sqlCommandSecond = new SqlCommand(StringSecond, sqlConnection);
                                //创建数据读取器的实例
                                SqlDataReader sqlDataReaderSecond = sqlCommandSecond.ExecuteReader();

                                while (sqlDataReaderSecond.Read())
                                {
                                    ListViewItem listViewItem = new ListViewItem();
                                    listViewItem.SubItems.Add(sqlDataReaderSecond["EmployeeNumber"].ToString());
                                    listViewItem.SubItems.Add(sqlDataReaderSecond["EmployeeName"].ToString());
                                    listViewItem.SubItems.Add(sqlDataReaderSecond["SectionName"].ToString());
                                    listViewItem.SubItems.Add(sqlDataReaderSecond["OTDate"].ToString());
                                    listViewItem.SubItems.Add(sqlDataReaderSecond["OTType"].ToString());
                                    listViewItem.SubItems.Add(sqlDataReaderSecond["OTLength"].ToString());
                                    listViewItem.SubItems.Add(sqlDataReaderSecond["OTStart"].ToString());
                                    listViewItem.SubItems.Add(sqlDataReaderSecond["OTStop"].ToString());

                                    lv_previewOT.Items.Add(listViewItem);//将新创建的条目添加进列表的条目容器中去
                                }

                                sqlDataReaderSecond.Close(); //关闭数据读取器
                            }




                            }
                            else
                            {
                            sqlDataReaderZero.Close();
                                //取出读取器中的加班开始时间 和加班结束时间
                                MessageBox.Show("员工:"+tb_EmployeeName.Text+" 已存在数据表中，请勿重复添加");
                            }
                        }

                  
                    //如果不存在，那么直接执行添加操作
                    //如果存在，则判断需要录入的加班开始时间和加班结束时间是否与
                    //数据表中已经存在的相同工号的 加班开始时间和加班结束时间 存在交集
                    //如果存在交集,那么弹出消息提示框告诉用户。加班信息已存在请勿重复添加
                    //如果不存在交集，那么直接添加
                   
                }
                else
                {
                    MessageBox.Show("请输入员工工号");
                }
            }
            else
            {
                //如果没有勾上手动添加 那么判断是否勾上全选组列表成员 单选框
                if (checkBox_WholeGroupMember.CheckState==CheckState.Checked)
                {
                    //如果勾上了全选组列表成员 单选框，执行添加所有组列表成员的操作

                    //如果输入的加班日期 小于 当前日期 将弹出消息框提示用户
                    //加班日期不能比当前日期更小
                    TimeSpan timeSpan = Convert.ToDateTime(dtp_OTDatePreview.Text) - DateTime.Today;
                    //MessageBox.Show(""+DateTime.Today);
                    //MessageBox.Show(""+timeSpan.TotalDays);
                    if (timeSpan.TotalDays<0)
                    {
                        MessageBox.Show("今天加班的日期"+Convert.ToDateTime(dtp_OTDatePreview.Text));
                        MessageBox.Show(DateTime.Now.ToString());
                        MessageBox.Show("加班日期不能小于当前日期,请确认您要输入的加班日期");
                    }
                    else
                    {

                        //用for循环添加listview中所有的条目 因为已经勾上了全选框
                        for (int i = 0; i < listView_Group.Items.Count; i++)
                        {
                            //创建一个listviewitem的实例
                            ListViewItem listViewItem = new ListViewItem();

                            //将listView_Group列表中的数据取出来 添加进新建的条目中
                            listViewItem.SubItems.Add(listView_Group.Items[i].SubItems[1].Text);
                            listViewItem.SubItems.Add(listView_Group.Items[i].SubItems[2].Text);
                            listViewItem.SubItems.Add(listView_Group.Items[i].SubItems[3].Text);
                            //将面板上的必要信息 添加进新建的条目中
                            listViewItem.SubItems.Add(dtp_OTDatePreview.Text);
                            listViewItem.SubItems.Add(cb_OTType.Text);
                            listViewItem.SubItems.Add(tb_OTLength.Text);
                            listViewItem.SubItems.Add(dtp_OTStart.Text);
                            listViewItem.SubItems.Add(dtp_OTStop.Text);

                            //创建要连接的数据库
                            using (SqlConnection sqlConnection = new SqlConnection())
                            {
                                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                                sqlConnection.Open(); //打开数据库的连接
                                                      //判断数据表中是否 存在当前要添加的工号的加班日期
                                                      //如果不存在，那么直接添加
                                                      //如果存在，弹出消息框提示用户数据已存在，请勿重复添加
                                string stringZero = "select * from PreviewOverTime where EmployeeNumber='" + listView_Group.Items[i].SubItems[1].Text + "' and OTDate='" + dtp_OTDatePreview.Text + "'";
                                SqlCommand sqlCommandZero = new SqlCommand(stringZero, sqlConnection);
                                //创建数据读取器的实例
                                SqlDataReader sqlDataReaderZero = sqlCommandZero.ExecuteReader();
                                if (!sqlDataReaderZero.HasRows)
                                {
                                    //直接向加班列表中添加刚刚创建好的条目
                                    lv_previewOT.Items.Add(listViewItem);
                                    sqlDataReaderZero.Close();//关闭数据读取器的实例
                                                              //直接向数据库中添加
                                                              //创建要执行的sql语句
                                    string stringFirst = "insert into PreviewOverTime Values ('" + listView_Group.Items[i].SubItems[1].Text + "','" + listView_Group.Items[i].SubItems[2].Text + "','" + listView_Group.Items[i].SubItems[3].Text + "','" + dtp_OTDatePreview.Text + "','" + cb_OTType.Text + "','" + tb_OTLength.Text + "','" + dtp_OTStart.Text + "','" + dtp_OTStop.Text + "','" + DefaultReviewState + "','" + rtb_OTCause.Text + "','" + DefaultNGCause + "','" + DefaultCurrentMonthTotal + "' ,'" + DefaultComment + "','" + DefaultCEOReviewState + "','" + DefaultCEONGCause + "')";
                                    SqlCommand sqlCommandFirst = new SqlCommand(stringFirst, sqlConnection);
                                    //创建数据读取器类的实例
                                    // SqlDataReader sqlDataReaderFirst = sqlCommandFirst.ExecuteReader();
                                    if (sqlCommandFirst.ExecuteNonQuery() > 0)
                                    {
                                        MessageBox.Show("数据插入数据表成功");
                                    }
                                }
                                else
                                {
                                    sqlDataReaderZero.Close(); //关闭数据读取器的实例
                                                               //弹出消息框已存在 请勿重复添加
                                    MessageBox.Show("工号:" + listView_Group.Items[i].SubItems[1].Text +"姓名:"+listView_Group.Items[i].SubItems[2].Text+ "的员工已存在加班列表中。请勿重复添加");
                                }
                                //关闭数据库的连接
                                sqlConnection.Close();
                            }
                        }

                    }


                  
                }
                else
                {
                    //如果没有勾上全选组列表成员 单选框，判断是否有勾上列表中的单个项 ，如果有则执行添加操作
                    if (listView_Group.SelectedItems.Count>0)
                    {
                        //如果输入的加班日期 小于 当前日期 将弹出消息框提示用户
                        //加班日期不能比当前日期更小
                        if (DateTime.Compare(Convert.ToDateTime(dtp_OTDatePreview.Text), DateTime.Now) < 0)
                        {
                            MessageBox.Show(DateTime.Now.ToString());
                            MessageBox.Show("加班日期不能小于当前日期,请确认您要输入的加班日期");
                        }
                        else
                        {


                            //循环遍历每一个被选中的条目 
                            for (int i = 0; i < listView_Group.SelectedItems.Count; i++)
                            {
                                //创建一个listviewitem的实例
                                ListViewItem listViewItem = new ListViewItem();

                                //将listView_Group列表中的数据取出来 添加进新建的条目中
                                listViewItem.SubItems.Add(listView_Group.SelectedItems[i].SubItems[1].Text);
                                listViewItem.SubItems.Add(listView_Group.SelectedItems[i].SubItems[2].Text);
                                listViewItem.SubItems.Add(listView_Group.SelectedItems[i].SubItems[3].Text);
                                //将面板上的必要信息 添加进新建的条目中
                                listViewItem.SubItems.Add(dtp_OTDatePreview.Text);
                                listViewItem.SubItems.Add(cb_OTType.Text);
                                listViewItem.SubItems.Add(tb_OTLength.Text);
                                listViewItem.SubItems.Add(dtp_OTStart.Text);
                                listViewItem.SubItems.Add(dtp_OTStop.Text);
                                //创建要连接的数据库
                                using (SqlConnection sqlConnection = new SqlConnection())
                                {
                                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                                    sqlConnection.Open();//打开数据库的连接
                                                         //判断数据表中是否 存在当前要添加的工号的加班日期
                                                         //如果不存在，那么直接添加
                                                         //如果存在，弹出消息框提示用户数据已存在，请勿重复添加


                                    string stringZero = "select * from PreviewOverTime where EmployeeNumber='" + listView_Group.SelectedItems[i].SubItems[1].Text + "' and OTDate='" + dtp_OTDatePreview.Text + "'";
                                    SqlCommand sqlCommandZero = new SqlCommand(stringZero, sqlConnection);
                                    //创建数据读取器的实例
                                    SqlDataReader sqlDataReaderZero = sqlCommandZero.ExecuteReader();
                                    if (!sqlDataReaderZero.HasRows)//如果数据读取器中没有包含查询记录，说明数据表中不存在你要添加的信息
                                    {
                                        lv_previewOT.Items.Add(listViewItem);//直接向加班列表中添加刚刚创建好的条目
                                        sqlDataReaderZero.Close();//关闭数据读取器的实例
                                                                  //直接向数据库中添加
                                                                  //创建要执行的sql语句
                                        string stringFirst = "insert into PreviewOverTime Values ('" + listView_Group.SelectedItems[i].SubItems[1].Text + "','" + listView_Group.SelectedItems[i].SubItems[2].Text + "','" + listView_Group.SelectedItems[i].SubItems[3].Text + "','" + dtp_OTDatePreview.Text + "','" + cb_OTType.Text + "','" + tb_OTLength.Text + "','" + dtp_OTStart.Text + "','" + dtp_OTStop.Text + "','" + DefaultReviewState + "','" + rtb_OTCause.Text + "','" + DefaultNGCause + "', '" + DefaultCurrentMonthTotal + "','" + DefaultComment + "','" + DefaultCEOReviewState + "','" + DefaultCEONGCause + "')";
                                        SqlCommand sqlCommandFirst = new SqlCommand(stringFirst, sqlConnection);
                                        //如果受该sql语句的记录行数大于0行，即等同于记录插入表格成功
                                        if (sqlCommandFirst.ExecuteNonQuery() > 0)
                                        {
                                            MessageBox.Show("数据插入数据表成功");
                                        }
                                    }
                                    else
                                    {

                                        //关闭数据读取器的实例
                                        sqlDataReaderZero.Close();
                                        //如果工号和日期存在，那么继续进行加班开始时间与加班结束时间的判断
                                        string FirstAddBeginTime,
                                               FirstAddEndTime,
                                               SecondAddBeginTime,
                                               SecondAddEndTime;



                                        SecondAddBeginTime = dtp_OTStart.Text; //将开始加班控件上的值赋给SecondAddBeginTime
                                        SecondAddEndTime = dtp_OTStop.Text;//将开始加班控件上的值赋给SecondAddEndTime
                                                                           //取出数据表中已存在的同一日期 同一工号的员工的开始加班时间约结束时间 
                                                                           //并将它们的值赋值给变量 FirstAddBeginTime,FirstAddBeginTime,

                                        //创建执行的sql语句取出数据表中的开始加班时间和结束加班时间
                                        string stringSecond = "select * from PreviewOverTime where EmployeeNumber='" + listView_Group.SelectedItems[i].SubItems[1].Text + "' and OTDate='" + dtp_OTDatePreview.Text + "'";
                                        SqlCommand sqlCommandSecond = new SqlCommand(stringSecond, sqlConnection);
                                        SqlDataReader sqlDataReaderSecond = sqlCommandSecond.ExecuteReader();//创建数据读取器的实例
                                        if (sqlDataReaderSecond.Read())
                                        {
                                            FirstAddBeginTime = sqlDataReaderSecond["OTStart"].ToString();
                                            FirstAddEndTime = sqlDataReaderSecond["OTStop"].ToString();
                                            sqlDataReaderSecond.Close();//关闭数据读取器
                                                                        //将字符串格式的时间 转换成date格式的时间。然后再进行比较
                                            int compareValue1 = DateTime.Compare(Convert.ToDateTime(SecondAddBeginTime), Convert.ToDateTime(FirstAddEndTime));

                                            if (compareValue1 > 0) //如果大于零  说明两次加班时间无交集。则执行插入操作 如果小于零 则告知用户。记录已存在请勿重复插入
                                            {
                                                //创建要执行的sql语句
                                                string sqlThird = "insert into PreviewOverTime values ('" + listView_Group.SelectedItems[i].SubItems[1].Text + "','" + listView_Group.SelectedItems[i].SubItems[2].Text + "','" + listView_Group.SelectedItems[i].SubItems[3].Text + "','" + dtp_OTDatePreview.Text + "','" + cb_OTType.Text + "','" + tb_OTLength.Text + "','" + dtp_OTStart.Text + "','" + dtp_OTStop.Text + "','" + DefaultReviewState + "','" + rtb_OTCause.Text + "','" + DefaultNGCause + "' ,'" + DefaultCurrentMonthTotal + "' ,'" + DefaultComment + "','" + DefaultCEOReviewState + "','" + DefaultCEONGCause + "')";
                                                SqlCommand sqlCommandThird = new SqlCommand(sqlThird, sqlConnection);//创建sqlCommand命令的实例
                                                if (sqlCommandThird.ExecuteNonQuery() > 0)
                                                {
                                                    MessageBox.Show("数据添加成功");
                                                    UpdateOTlistview();  //调用刷新列表函数
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("两次加班时间出现重叠,请核实后在再进行添加");
                                            }
                                        }
                                    }
                                    sqlConnection.Close();//关闭数据库的连接
                                }
                            }

                        }
                    }
                    else
                    {
                        //如果没有勾上列表中的任何一个项 那么弹出消息框提示用户请勾上要添加的员工
                        MessageBox.Show("请勾上您将要添加的员工");
                    }
                }
            }
            //获取当前加班人员列表lv_previewOT中的总人数
            label_totalCount.Text =lv_previewOT.Items.Count.ToString();
        }

        //给组列表listView_Group的每个条目的单选框设置 选中事件
        private void listView_Group_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            e.Item.Selected=e.Item.Checked;//当条目前面的单选框被勾上时 也就等同于当前条目被选中
        }


        //给手工录入加班单的单选框 设置切换事件
        private void checkBox_Manually_CheckedChanged(object sender, EventArgs e)
        {
            //当手工录入加班单的单选框为打钩状态时 执行 if语句块里的逻辑
            if (checkBox_Manually.CheckState==CheckState.Checked)
            {
                
                tb_EmployeeNumber.Enabled =true;//激活员工工号文本框
               
                tb_EmployeeName.Enabled = true; //激活员工姓名文本框
                
                listBox_GroupName.Enabled = false;//禁用组名框
               
                listView_Group.Enabled = false; //禁用组成员列表
                
                checkBox_WholeGroupMember.Enabled = false;//禁用全选组列表成员 单选框
            }
            else//当手工录入加班单的单选框为不打钩状态时 执行else语句块里的逻辑
            {//禁用员工工号文本框
                tb_EmployeeNumber.Enabled = false;
                //禁用员工姓名文本框
                tb_EmployeeName.Enabled = false;
                //激活组名框
                listBox_GroupName.Enabled =true;
                //激活组成员列表
                listView_Group.Enabled = true;
                //激活全选组列表成员 单选框
                checkBox_WholeGroupMember.Enabled = true;
            }
        }


        //创建一个辅助函数 用来刷新最新的加班人员列表
        private void UpdateOTlistview()
        {
            lv_previewOT.Items.Clear(); //清空列表之前所有的条目
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                sqlConnection.Open();//打开数据库连接
                string stringZero = "select * from PreviewOverTime";//创建要执行的sql语句
                SqlCommand sqlCommand = new SqlCommand(stringZero,sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();//创建数据读取器

                while (sqlDataReader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();//创建listviewitem
                    //将结果集中的数据添加进条目中
                    listViewItem.SubItems.Add(sqlDataReader["EmployeeNumber"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["EmployeeName"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["SectionName"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["OTDate"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["OTType"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["OTLength"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["OTStart"].ToString());
                    listViewItem.SubItems.Add(sqlDataReader["OTStop"].ToString());
                    lv_previewOT.Items.Add(listViewItem);//将新建的条目添加进条目容器中
                }
                sqlDataReader.Close();//关闭数据读取器
                sqlConnection.Close();//关闭数据库
            }
           
        }
    }
}
