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
using Microsoft.Reporting.WinForms;

namespace EmployeeManagementSystem
{
    public partial class SalaryReportForm : Form
    {
        public SalaryReportForm()
        {
            InitializeComponent();
          
        }

        private void dtp_YearMonth_ValueChanged(object sender, EventArgs e)
        {
            //清空之前报表控件中的内容 

            //获取日历框中的值并显示出来
            //MessageBox.Show(dtp_YearMonth.Text);
            //如果部门下拉框中文本框部门的值不为空

            //用消息框显示当前的月份和部门信息
            //MessageBox.Show(dtp_YearMonth.Text+combox_SectionName.Text);


            


        }

        private void SalaryReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HarvestRhythmZeroDataSet.SalaryCalculator' table. You can move, or remove it, as needed.
            //this.SalaryCalculatorTableAdapter.Fill(this.HarvestRhythmZeroDataSet.SalaryCalculator);
            //给部门下拉框设置数据源
            combox_SectionName.DataSource = GetSectionName();
            combox_SectionName.DisplayMember = "SectionName";
            combox_SectionName.Text = "";
            this.reportViewer1.RefreshReport();
            
        }




        //定义一个辅助函数 用来获取数据表中所有的部门的名称
        private DataTable GetSectionName()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                sqlConnection.Open();

                string QueryStr = "select * from Section ";
                SqlCommand sqlCommand = new SqlCommand(QueryStr, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                dataTable.Load(sqlDataReader);

                sqlDataReader.Close();
                sqlConnection.Close();

            }


            return dataTable;
        }


        
       

        //给生成报表控件按钮 设置点击事件
        private void btn_CreateReportViewer_Click(object sender, EventArgs e)
        {
            //如果部门下拉框中文本框部门的值不为空
            if (combox_SectionName.Text!=string.Empty)
            {
                //用消息框显示当前的月份和部门信息
                //MessageBox.Show(dtp_YearMonth.Text+combox_SectionName.Text);

               
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetSalary", GetOutPutData()));
                reportViewer1.RefreshReport();
            }
            
        }

        //报表控件在加载过程中执行的一些操作
        private void reportViewer1_Load(object sender, EventArgs e)
        {
         
        }


        //定义一个辅助函数 用来获取数据表中所有的部门的名称
        private DataTable GetOutPutData()

        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                sqlConnection.Open();

                string sqlString = "select * from SalaryCalculator where YearMonth='" + dtp_YearMonth.Text + "' and SectionName='" + combox_SectionName.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    dataTable.Load(sqlDataReader);
                }
                else
                {
                    MessageBox.Show("数据表中不存在查询月份的工资记录");
                }
                

                sqlDataReader.Close();
                sqlConnection.Close();

            }


            return dataTable;
        }


    }
}
