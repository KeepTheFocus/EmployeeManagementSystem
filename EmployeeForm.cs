using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace EmployeeManagementSystem
{
    public partial class EmployeeForm : Form
    {
        //窗体的构造函数  禁止修改InitialzeComponent()函数
        public EmployeeForm()
        {
            InitializeComponent();
        }



        //保存输入的信息
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //先判断一下工号和身份证号码是否不等于5位和18位
            //如果不等于工号不等于5位或者身份不等于18位
            //提醒用户核查输入的工号或身份证号是否有误
            if (tb_EmployeeNumber.TextLength!=5|tb_IdentityCardNumber.TextLength!=18)
            {
                MessageBox.Show("请核实输入的工号或身份证号");
            }
            else
            { //保存员工编号
                string strEmployeeNumber = tb_EmployeeNumber.Text,
                //保存员工姓名
                 strEmployeeName = tb_EmployeeName.Text,
                //保存员工性别
                 strSex = string.Empty;

                if (rb_male.Checked)
                {
                    strSex = "男";
                }
                else
                {
                    strSex = "女";
                }
               


                //创建一个数据库连接实例
                using (SqlConnection sqlConnectionDR=new SqlConnection())
                {
                    sqlConnectionDR.ConnectionString = UtilitySql.SetConnectionString();
                    //开启连接
                    sqlConnectionDR.Open();
                    //创建要执行的sql语句
                    string strSqlDr = "select *from EmployeeFiles where EmployeeNumber='"+tb_EmployeeNumber.Text+"'";
                    //创建要SqlCommand实例
                    SqlCommand sqlCommand = new SqlCommand(strSqlDr,sqlConnectionDR);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Close();

                        //先判断文本框中的内容 是否存在于数据表中
                        //如果存在 则调用Update语句进行更新
                        //如果返回值大于零 说明数据表中已经存在你要保存的数据

                        //创建要执行的sql语句
                        string strSqlUpdate = "update EmployeeFiles set EmployeeName='"+tb_EmployeeName.Text+"',Sex='"+strSex+"',IndentityCardNumber='"+tb_IdentityCardNumber.Text+"',DateOfBirth='"+ DateTime.Parse(dtp_BirthDate.Text) +"',Nation='"+cb_Nation.SelectedItem.ToString()+"',Academic='"+cb_Academic.SelectedItem.ToString()+"',SectionName='"+cb_SectionName.Text+"',DutyName='"+cb_DutyName.Text+"',HomeAddress='"+tb_HomeAddress.Text+"'where EmployeeNumber='"+tb_EmployeeNumber.Text+"'";
                   

                        //创建SqlCommand实例
                        SqlCommand sqlCommandUR = new SqlCommand(strSqlUpdate,sqlConnectionDR);
                        
                        if (sqlCommandUR.ExecuteNonQuery()>0)
                        {
                            MessageBox.Show("员工信息更新成功");
                        }
                        else
                        {
                            MessageBox.Show("员工信息更新失败");
                        }

                        //关闭数据读取器对象
                        sqlDataReader.Close();

                    }
                    else
                    {

                        //关闭数据读取器对象
                        sqlDataReader.Close();
                        //如果不存在  则调用Insert语句进行插入
                        //创建sql插入语句
                        string strSqlInsert ="insert into EmployeeFiles values" +
                     "('" +tb_EmployeeNumber.Text+ "','" +tb_EmployeeName.Text + "'," +
                     "'" + strSex + "','" +tb_IdentityCardNumber.Text + "'," +
                     "'" +DateTime.Parse(dtp_BirthDate.Text) + "','" +cb_Nation.SelectedItem.ToString() + "'," +
                     "'" +cb_Academic.SelectedItem.ToString() + "','" + cb_SectionName.Text + "'," +
                     "'" +cb_DutyName.Text + "','" +tb_HomeAddress.Text+ "')";
                        //创建sqlcommand命令对象
                        SqlCommand sqlCommandIT = new SqlCommand(strSqlInsert,sqlConnectionDR);

                        if (sqlCommandIT.ExecuteNonQuery()>0)
                        {
                            MessageBox.Show("信息保存成功");
                        }
                        else
                        {
                            MessageBox.Show("信息保存失败");
                        }
                    }
                    //关闭连接
                    sqlConnectionDR.Close();
                    //调用刷新Listview的函数
                    UpdateListview();
                    //调用清空文本框TextBOX的函数
                    ClearTextBox();
                }
            }
        }

        //点击保存按钮后 刷新listview实时显示数据表中最新的信息
        public void UpdateListview()
        {
            //移除listview中所有的已显示的信息
            listView_employee.Items.Clear();

            //将数据库中所有的字段显示到  窗体的listview控件中
           
            //创建数据库连接的实例
          SqlConnection  connection = new SqlConnection(UtilitySql.SetConnectionString());
            //打开数据库
            connection.Open();
            //创建数据库命令的实例
          SqlCommand  cmd = connection.CreateCommand();
            //把要执行的sql语句 传递给cmd实例
            cmd.CommandText = "select * from EmployeeFiles";
            //创建一个数据读取器
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                //创建一个listviewItem对象
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sdr["EmployeeNumber"].ToString();
                lvi.SubItems.Add(sdr["EmployeeName"].ToString());
                lvi.SubItems.Add(sdr["Sex"].ToString());
                lvi.SubItems.Add(sdr["IndentityCardNumber"].ToString());
                lvi.SubItems.Add(sdr["DateOfBirth"].ToString());
                lvi.SubItems.Add(sdr["Nation"].ToString());
                lvi.SubItems.Add(sdr["Academic"].ToString());
                lvi.SubItems.Add(sdr["SectionName"].ToString());
                lvi.SubItems.Add(sdr["DutyName"].ToString());
                lvi.SubItems.Add(sdr["HomeAddress"].ToString());
                //将数据添加进listview控件中
                listView_employee.Items.Add(lvi);
            }
            //关闭流
            connection.Close();
        }

        //清空所有TextBox的内容

        public void ClearTextBox()
        {
            //清空所有 输入框和下拉框中的内容
            tb_EmployeeNumber.Text = "";
            tb_EmployeeName.Text = "";
            tb_IdentityCardNumber.Text = "";
            tb_HomeAddress.Text = "";
            rb_female.Checked = false;
            rb_male.Checked = false;
            dtp_BirthDate.Text = "";
            cb_Nation.Text = "";
            cb_Academic.Text = "";
            cb_DutyName.Text = "";
            cb_SectionName.Text = "";
        }

        //返回数据表中设置的 部门名称
        public DataTable SelectSection()
        {

            //创建数据库连接
            SqlConnection connection = new SqlConnection(UtilitySql.SetConnectionString());

            //创建sql语句
            string strSql = "select * from Section";
            //创建一个SqlCommand类的实例
            SqlCommand command = new SqlCommand(strSql, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //打开连接
            connection.Open();
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

        //返回数据表中设置的  职务名称
        public DataTable SelectDuty()
        {

            //创建数据库连接
            SqlConnection connection = new SqlConnection(UtilitySql.SetConnectionString());

            //创建sql语句
            string strSql = "select * from Duty";

            SqlCommand command = new SqlCommand(strSql, connection);
            //创建数据适配器 的实例
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //打开连接
            connection.Open();
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

        //窗体加载 函数
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            //给部门下拉框 设置数据源
            cb_SectionName.DataSource = SelectSection();
            //选定表中的哪一列作为  下拉框中显示的字段
            cb_SectionName.DisplayMember = "SectionName";
            //给职务下拉框 设置数据源
            cb_DutyName.DataSource = SelectDuty();
            //选定表中的哪一列作为  下拉框中显示的字段
            cb_DutyName.DisplayMember = "DutyName";

            //将数据库中所有的字段显示到  窗体的listview控件中
            //创建数据库连接的实例
         SqlConnection   connection = new SqlConnection(UtilitySql.SetConnectionString());
            //打开数据库
            connection.Open();
            //创建数据库命令的实例
          SqlCommand  cmd = connection.CreateCommand();
            //把要执行的sql语句 传递给cmd实例
            cmd.CommandText = "select * from EmployeeFiles";
            //创建一个数据读取器
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sdr["EmployeeNumber"].ToString();
                lvi.SubItems.Add(sdr["EmployeeName"].ToString());
                lvi.SubItems.Add(sdr["Sex"].ToString());
                lvi.SubItems.Add(sdr["IndentityCardNumber"].ToString());
                lvi.SubItems.Add(sdr["DateOfBirth"].ToString());
                lvi.SubItems.Add(sdr["Nation"].ToString());
                lvi.SubItems.Add(sdr["Academic"].ToString());
                lvi.SubItems.Add(sdr["SectionName"].ToString());
                lvi.SubItems.Add(sdr["DutyName"].ToString());
                lvi.SubItems.Add(sdr["HomeAddress"].ToString());
                //将数据添加进listview控件中
                listView_employee.Items.Add(lvi);
            }
            //关闭流
            connection.Close();
        }
        //定义一个长度为10的数组用来保存  要传递进来的字符串
        public string[] str = new string[10];

        //点击修改按钮后 将列表中的数据显示到文本框中
        private void btn_alter_Click(object sender, EventArgs e)
        {
            //创建修改窗体的  实例
            //  AlterEmployeeForm aef = new AlterEmployeeForm();
            //获取当前被选中项的 索引
            int a = listView_employee.FocusedItem.Index;

            for (int i = 0; i < 10; i++)
            {
                str[i] = listView_employee.Items[a].SubItems[i].Text;
            }

            tb_EmployeeNumber.Text = str[0];
            tb_EmployeeName.Text = str[1];
            tb_IdentityCardNumber.Text = str[3];
            dtp_BirthDate.Text = str[4];
            cb_Nation.Text = str[5];
            cb_Academic.Text = str[6];
            cb_SectionName.Text = str[7];
            cb_DutyName.Text = str[8];
            tb_HomeAddress.Text = str[9];
            //aef.Show();
        }
        //将数据表中的所有数据导出到Excel文件中
        private void btn_export_Click(object sender, EventArgs e)
        {
            //创建一个对话框实例
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = "xlsx";
            dialog.Filter = "Excel文件|*.xlsx";
            //使对话框显示出来
            dialog.ShowDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Export2Excel export2Excel = new Export2Excel();
                export2Excel.Export(listView_employee, dialog.FileName);
            }
        }
        //给查询按钮设置点击事件
        private void btn_seek_Click(object sender, EventArgs e)
        {
            //清空列表中所有的旧数据 （只是清空listview中的数据 表中的数据还在）
            listView_employee.Items.Clear();
            //获取到输入框中的 工号
            string StrEmployeeNumber = tb_EmployeeNumber.Text;
            //如果输入的工号 不等于""且长度等于5时  执行if包含的语句块
            if (StrEmployeeNumber != ""&StrEmployeeNumber.Length==5)
            {
                //创建数据库连接的实例
              SqlConnection  connection = new SqlConnection(UtilitySql.SetConnectionString());
                //打开数据库
                connection.Open();
                //创建数据库命令的实例
              SqlCommand  cmd = connection.CreateCommand();
                //把要执行的sql语句 传递给cmd实例
                cmd.CommandText = "select * from EmployeeFiles where  EmployeeNumber ='" + StrEmployeeNumber + "' ";
                //创建一个数据读取器
                SqlDataReader sdr = cmd.ExecuteReader();
                //如果数据表中有记录 那么执行while循环读取数据表中的内容，并填充到listview中
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = sdr["EmployeeNumber"].ToString();
                        lvi.SubItems.Add(sdr["EmployeeName"].ToString());
                        lvi.SubItems.Add(sdr["Sex"].ToString());
                        lvi.SubItems.Add(sdr["IndentityCardNumber"].ToString());
                        lvi.SubItems.Add(sdr["DateOfBirth"].ToString());
                        lvi.SubItems.Add(sdr["Nation"].ToString());
                        lvi.SubItems.Add(sdr["Academic"].ToString());
                        lvi.SubItems.Add(sdr["SectionName"].ToString());
                        lvi.SubItems.Add(sdr["DutyName"].ToString());
                        lvi.SubItems.Add(sdr["HomeAddress"].ToString());
                        //将数据添加进listview控件中
                        listView_employee.Items.Add(lvi);
                    }
                }
                //如果数据表中没有记录当前要查询的工号，则弹出信息框提示用户核对工号
                else
                {
                    MessageBox.Show("您输入的工号不存在，请核对后再输入");
                }
                //关闭流
                connection.Close();
            }
            //如果没有输入工号或者输入的工号的长度不等于5
            //则提示用户核对后再输入
            else
            {
                MessageBox.Show("您输入的工号不存在，请核对后再输入");
            }
        }

        //给退出按钮 添加点击事件
        private void btn_esc_Click(object sender, EventArgs e)
        {
            //退出当前窗体
            Close();
        }
    }
}

