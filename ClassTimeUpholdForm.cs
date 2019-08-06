using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;

namespace EmployeeManagementSystem
{
    public partial class ClassTimeUpholdForm : Form
    {
        public ClassTimeUpholdForm()
        {
            InitializeComponent();
        }

        //定义行号
        int rowNumber = 0;

        //窗体在加载的时候 应该处理的一些事件
        private void ClassTimeUpholdForm_Load(object sender, EventArgs e)
        {

            //检索数据表中存在的  班次时间段数据，并显示在窗体的列表中去

            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                sqlConnection.Open();
                //创建要执行的sql命令语句

                string SQLSelect = "select * from UpholdClassTimePeriod";

                SqlCommand sqlCommand = new SqlCommand(SQLSelect,sqlConnection);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                //使用while循环去从数据读取器中遍历查询到的数据

                while (sqlDataReader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems.Add(sqlDataReader["TimePeriodName"].ToString());
                    listViewItem.SubItems.Add(DateTime.Parse(sqlDataReader["FirstPeriodSartTime"].ToString()).ToString("HH:mm",DateTimeFormatInfo.InvariantInfo) );
                    listViewItem.SubItems.Add(DateTime.Parse(sqlDataReader["FirstPeriodStopTime"].ToString()).ToString("HH:mm",DateTimeFormatInfo.InvariantInfo) );
                    listViewItem.SubItems.Add(DateTime.Parse(sqlDataReader["SignInStartTime"].ToString()).ToString("HH:mm", DateTimeFormatInfo.InvariantInfo) );
                    listViewItem.SubItems.Add(DateTime.Parse(sqlDataReader["SignInStopTime"].ToString()).ToString("HH:mm", DateTimeFormatInfo.InvariantInfo) );
                    listViewItem.SubItems.Add(DateTime.Parse(sqlDataReader["SecondPeriodStartTime"].ToString()).ToString("HH:mm", DateTimeFormatInfo.InvariantInfo) );
                    listViewItem.SubItems.Add(DateTime.Parse(sqlDataReader["SecondPeriodStopTime"].ToString()).ToString("HH:mm", DateTimeFormatInfo.InvariantInfo) );


                    listViewItem.SubItems.Add(DateTime.Parse(sqlDataReader["SignOffStartTime"].ToString()).ToString("HH:mm", DateTimeFormatInfo.InvariantInfo) );
                    listViewItem.SubItems.Add(DateTime.Parse(sqlDataReader["SignOffStopTime"].ToString()).ToString("HH:mm", DateTimeFormatInfo.InvariantInfo) );
                    listViewItem.SubItems.Add(sqlDataReader["ShowColour"].ToString()  );
                    listViewItem.SubItems.Add(sqlDataReader["WriteDownWorkDay"].ToString());


                    


                    
                    listViewItem.SubItems.Add(DateTime.Parse(sqlDataReader["OverTimeStartTime"].ToString()).ToString("HH:mm", DateTimeFormatInfo.InvariantInfo));
                    listViewItem.SubItems.Add(DateTime.Parse(sqlDataReader["OverTimeStopTime"].ToString()).ToString("HH:mm", DateTimeFormatInfo.InvariantInfo) );


                    lv_ClassTimeUphold.Items.Add(listViewItem);

                   

                }

                MessageBox.Show(lv_ClassTimeUphold.Items.Count.ToString());
                rowNumber = lv_ClassTimeUphold.Items.Count;
            }

            tb_TimeName.Enabled = false;
            textBox_Comelate.Enabled = false;
            textBox_leaveEarly.Enabled = false;
            textBox_WorkDays.Enabled = false;
            textBox_WorkMinutes.Enabled = false;
            maskedTextBox_startOT.Enabled = false;
            maskedTextBox_stopOT.Enabled = false;
            mtbStartSignOff.Enabled = false;
            mtbStopSignff.Enabled = false;
            mtb_AfternoonStart.Enabled = false;
            mtb_AfternoonStop.Enabled = false;
            mtb_MorningStart.Enabled = false;
            mtb_MorningStop.Enabled = false;
            mtb_startSignIn.Enabled = false;
            mtb_StopSignIn.Enabled = false;

        }


//给上午上班时间 面具文本框设置回车事件
        private void mtb_MorningStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                //将上午上班时间的值 赋予到列表条目的对应的列上
                lv_ClassTimeUphold.Items[rowNumber-1].SubItems[2].Text = mtb_MorningStart.Text;
            }
        }

        //给增加按钮设置点击事件
        private void btn_AddClass_Click(object sender, EventArgs e)
        {

            tb_TimeName.Enabled = true;
            textBox_Comelate.Enabled = true;
            textBox_leaveEarly.Enabled = true;
            textBox_WorkDays.Enabled = true;
            textBox_WorkMinutes.Enabled = true;
            maskedTextBox_startOT.Enabled = true;
            maskedTextBox_stopOT.Enabled = true;
            mtbStartSignOff.Enabled = true;
            mtbStopSignff.Enabled = true;
            mtb_AfternoonStart.Enabled = true;
            mtb_AfternoonStop.Enabled = true;
            mtb_MorningStart.Enabled = true;
            mtb_MorningStop.Enabled = true;
            mtb_startSignIn.Enabled = true;
            mtb_StopSignIn.Enabled = true;





            //每点击一次增加按钮 便向列表中添加新的条目
            rowNumber++;
          
            lv_ClassTimeUphold.BeginUpdate();

            //创建listviewItem类的实例
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.SubItems.Add("hello world");
            listViewItem.SubItems.Add(string.Empty);
            listViewItem.SubItems.Add(string.Empty);
            listViewItem.SubItems.Add(string.Empty);
            listViewItem.SubItems.Add(string.Empty);
            listViewItem.SubItems.Add(string.Empty);
            listViewItem.SubItems.Add(string.Empty);



            listViewItem.SubItems.Add(string.Empty);
            listViewItem.SubItems.Add(string.Empty);
            listViewItem.SubItems.Add(string.Empty);
            listViewItem.SubItems.Add(textBox_WorkDays.Text);
            listViewItem.SubItems.Add(string.Empty);
            listViewItem.SubItems.Add(string.Empty);


            lv_ClassTimeUphold.Items.Add(listViewItem);
            MessageBox.Show(rowNumber.ToString());
            lv_ClassTimeUphold.EndUpdate();
        }

        //给时间段文本框设置回车事件
        private void tb_TimeName_KeyDown(object sender, KeyEventArgs e)
        {
            //当敲击的键时回车键时
            if (e.KeyCode==Keys.Enter)
            {
                lv_ClassTimeUphold.Items[rowNumber-1].SubItems[1].Text = tb_TimeName.Text;
                lv_ClassTimeUphold.Items[rowNumber-1].SubItems[11].Text = 1.ToString();
                //创建一个新的条目 并给新条目的每个子条目进行赋初始值的操作
                //ListViewItem viewItem = new ListViewItem();
                //viewItem.SubItems.Add(tb_TimeName.Text);
                //viewItem.SubItems.Add(string.Empty);
                //viewItem.SubItems.Add(string.Empty);
                //viewItem.SubItems.Add(string.Empty);
                //viewItem.SubItems.Add(string.Empty);
                //viewItem.SubItems.Add(string.Empty);
                //viewItem.SubItems.Add(string.Empty);
                //viewItem.SubItems.Add(string.Empty);
                //viewItem.SubItems.Add(string.Empty);
                //viewItem.SubItems.Add(string.Empty);
                //viewItem.SubItems.Add(textBox_WorkDays.Text);
                //viewItem.SubItems.Add(string.Empty);
                //viewItem.SubItems.Add(string.Empty);
                ////将新创建好的条目添加进列表中
                //lv_ClassTimeUphold.Items.Add(viewItem);
            }
        }

        private void mtb_MorningStop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                //将上午下班时间的值 赋予到列表条目的对应的列上
                lv_ClassTimeUphold.Items[rowNumber-1].SubItems[3].Text = mtb_MorningStop.Text;
            }
        }

        private void mtb_startSignIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                //将开始签到时间的值 赋予到列表条目的对应的列上
                lv_ClassTimeUphold.Items[rowNumber-1].SubItems[4].Text = mtb_startSignIn.Text;
            }
        }

        private void mtb_StopSignIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                //将结束签到时间的值 赋予到列表条目的对应的列上
                lv_ClassTimeUphold.Items[rowNumber-1].SubItems[5].Text = mtb_StopSignIn.Text;
            }
        }

        private void mtb_AfternoonStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)

            {
                //将下午上班时间的值 赋予到列表条目的对应的列上
                lv_ClassTimeUphold.Items[rowNumber-1].SubItems[6].Text = mtb_AfternoonStart.Text;
            }
        }

        private void mtb_AfternoonStop_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode==Keys.Enter)
            {
                //将下午下班时间的值 赋予到列表条目的对应的列上
                lv_ClassTimeUphold.Items[rowNumber-1].SubItems[7].Text = mtb_AfternoonStop.Text;
            }
            
        }

        //给开始签退  面具文本框设置回车事件
        private void mtbStartSignOff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                //将开始签退时间的值 赋予到列表条目的对应的列上
                lv_ClassTimeUphold.Items[rowNumber-1].SubItems[8].Text = mtbStartSignOff.Text;
            }
        }
        //给结束签退 面具文本框设置回车事件
        private void mtbStopSignff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                //将结束签退时间的值 赋予到列表条目的对应列上
                lv_ClassTimeUphold.Items[rowNumber-1].SubItems[9].Text = mtbStopSignff.Text;
            }
        }


        //给时间段名称 文本框设置文本变更事件
        private void tb_TimeName_TextChanged(object sender, EventArgs e)
        {
            //if (tb_TimeName.Text.Length!=0)
           // {
               // textBox_WorkDays.Text = 1.ToString();
               // textBox_WorkMinutes.Text = 0.ToString();
                //将工作日文本框的值赋予到条目的对应子条目上去
                //lv_ClassTimeUphold.Items[0].SubItems[11].Text = textBox_WorkDays.Text;
            //}
        }

        private void textBox_WorkMinutes_TextChanged(object sender, EventArgs e)
        {
         
        }

        //给多少工作日文本框设置文本变更事件
        private void textBox_WorkDays_TextChanged(object sender, EventArgs e)
        {
            //将工作日文本框的值赋予到条目的对应子条目上去
            // lv_ClassTimeUphold.Items[0].SubItems[11].Text = textBox_WorkDays.Text;
            try
            {
                if (textBox_WorkDays.Text!=1.ToString())
                {
                    lv_ClassTimeUphold.Items[rowNumber-1].SubItems[11].Text = textBox_WorkDays.Text;
                }
            }
            catch (Exception a )
            {
                MessageBox.Show(a.Message);
               
            }
            
        }

        //当链接文本被点击后 要执行的事件
        private void linkLabel_openColourSelection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //弹出颜色选择器这个控件

            ColorDialog colorDialog = new ColorDialog();

            //如果点击了ok按钮
            if (colorDialog.ShowDialog()==DialogResult.OK)
            {
                  //就将颜色选择器中被选中的颜色赋给图片框
                pictureBox_showColour.BackColor = colorDialog.Color;
                //将颜色选择器中被选中的颜色赋给条目的子条目上
                if (lv_ClassTimeUphold.Items.Count>0)
                {
                    lv_ClassTimeUphold.Items[rowNumber-1].UseItemStyleForSubItems = false;
                    //将颜色选择器中被选中的颜色赋给被指定的子条目上
                    lv_ClassTimeUphold.Items[rowNumber-1].SubItems[10].BackColor = colorDialog.Color;
                }
                    
                
             
                
            }
            //colorDialog.ShowDialog();


        }

        private void pictureBox_showColour_Click(object sender, EventArgs e)
        {
            //弹出颜色选择器这个控件
            ColorDialog colorDialog = new ColorDialog();

            //如果点击了ok按钮
            if (colorDialog.ShowDialog()==DialogResult.OK)
            {
                //就将颜色选择器中被选中的颜色赋给图片框
                pictureBox_showColour.BackColor = colorDialog.Color;
                //将颜色选择器中被选中的颜色赋给条目的子条目上
                if (lv_ClassTimeUphold.Items.Count>0)
                {
                    lv_ClassTimeUphold.Items[rowNumber-1].UseItemStyleForSubItems = false;
                    //将颜色选择器中被选中的颜色赋给指定的字条目上
                    lv_ClassTimeUphold.Items[rowNumber-1].SubItems[10].BackColor = colorDialog.Color;
                }
               
            }
            //colorDialog.ShowDialog();
        }

        private void lv_ClassTimeUphold_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //给开始加班时间 面具文本框设置回车事件
        private void maskedTextBox_startOT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                lv_ClassTimeUphold.Items[rowNumber-1].SubItems[12].Text = maskedTextBox_startOT.Text;
            }
        }

        //给结束加班时间 面具文本框设置回车事件
        private void maskedTextBox_stopOT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                lv_ClassTimeUphold.Items[rowNumber-1].SubItems[13].Text = maskedTextBox_stopOT.Text;
            }
        }


        //给保存按钮增加点击事件
        private void btn_SaveClass_Click(object sender, EventArgs e)
        {

            try
            {

                //创建与数据库的连接
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                    //打开与数据库的连接
                    sqlConnection.Open();
                    //创建sql命令将数据插入到数据库中
                    string SQLInsert = "insert into UpholdClassTimePeriod values('" + tb_TimeName.Text + "','" +DateTime.Parse(mtb_MorningStart.Text)  + "','" + DateTime.Parse(mtb_MorningStop.Text)  + "','" + textBox_Comelate.Text + "','" + textBox_leaveEarly.Text + "','" +DateTime.Parse(mtb_startSignIn.Text) + "'," +
                        "'" +DateTime.Parse(mtb_StopSignIn.Text)  + "','" +DateTime.Parse(mtb_AfternoonStart.Text)  + "','" +DateTime.Parse(mtb_AfternoonStop.Text)  + "','" +DateTime.Parse(mtbStartSignOff.Text)  + "','" +DateTime.Parse(mtbStopSignff.Text)  + "'," +
                        "'" + textBox_WorkDays.Text + "','" + textBox_WorkMinutes.Text + "','" +DateTime.Parse(maskedTextBox_startOT.Text)  + "','" +DateTime.Parse(maskedTextBox_stopOT.Text) + "','" +ColorTranslator.ToHtml(pictureBox_showColour.BackColor).ToString() + "')";


                    //创建sqlCommand命令的实例
                    SqlCommand sqlCommand = new SqlCommand(SQLInsert, sqlConnection);

                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(tb_TimeName.Text + "班次插入数据库成功");
                    }
                }

            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }

        }

        //给删除按钮设置 点击事件
        private void btn_DeleteClass_Click(object sender, EventArgs e)
        {
            //取出当前持有焦点的条目的索引 并将其赋值给int类型的变量
            int a = lv_ClassTimeUphold.FocusedItem.Index;
            MessageBox.Show(a.ToString());
            MessageBox.Show(lv_ClassTimeUphold.Items[a].SubItems[1].Text);
            //删除该条目在数据表中的数据
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = UtilitySql.SetConnectionString();
                connection.Open();

                //创建要执行的命令语句
                string sql = string.Format("delete from UpholdClassTimePeriod where TimePeriodName='{0}'", lv_ClassTimeUphold.Items[a].SubItems[1].Text);
              
                SqlCommand command = new SqlCommand(sql, connection);

                if (command.ExecuteNonQuery()>0)
                {
                    MessageBox.Show(lv_ClassTimeUphold.Items[a].SubItems[1].Text+"已经删除成功");
                }

            }




            //删除该条目在列表中的显示
            lv_ClassTimeUphold.Items.RemoveAt(a);
        }
    }
}
