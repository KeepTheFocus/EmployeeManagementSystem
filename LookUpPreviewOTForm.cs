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
    public partial class LookUpPreviewOTForm : Form
    {
        public LookUpPreviewOTForm()
        {
            InitializeComponent();
        }

        //窗体加载过程中执行的 加载函数
        private void LookUpPreviewOTForm_Load(object sender, EventArgs e)
        {
            //清空列表中的所有条目
            lv_OTDetail.Items.Clear();

            //从数据库中获取最新的所有预计加班人员的数据
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = UtilitySql.SetConnectionString();
                sqlConnection.Open();
                //创建要执行的sql语句
                string stringZero = "select * from PreviewOverTime";
                SqlCommand sqlCommandZero = new SqlCommand(stringZero,sqlConnection);
                SqlDataReader sqlDataReaderZero = sqlCommandZero.ExecuteReader();

                while (sqlDataReaderZero.Read())
                {
                    //新建一个listViewItem条目
                    ListViewItem listViewItem = new ListViewItem();

                    listViewItem.Text = sqlDataReaderZero["EmployeeNumber"].ToString();
                    listViewItem.SubItems.Add(sqlDataReaderZero["EmployeeName"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderZero["SectionName"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderZero["OTDate"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderZero["OTType"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderZero["OTLength"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderZero["OTStart"].ToString());
                    listViewItem.SubItems.Add(sqlDataReaderZero["OTStop"].ToString());
                    //将新建的条目 添加进条目容器中
                    lv_OTDetail.Items.Add(listViewItem);
                }
                //关闭数据读取器
                sqlDataReaderZero.Close();

                //关闭数据库的连接
                sqlConnection.Close();
            }

        }
    }
}
