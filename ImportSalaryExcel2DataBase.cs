using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace EmployeeManagementSystem
{
    class ImportSalaryExcel2DataBase
    {
        //声明一个返回DataTable数据表的函数          文件路径           文件名
        public DataTable getExcelData(string filePath, string fileName)
        {

            //建立字符串
            string cmdText = "Provider=Microsoft.Ace.OleDb.12.0;Data Source={0};Extended Properties='Excel 12.0; HDR=Yes; IMEX=1'";
            //建立数据表对象
            DataTable dataTable = null;

            //建立和Excel的连接 

            OleDbConnection connection = new OleDbConnection(string.Format(cmdText, filePath));
            try
            {

                //打开连接
                connection.Open();
                //创建数据表的实例 schemaTable
                DataTable schemaTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);


                //获取Excel中第一个sheet的名称
                string sheetName = schemaTable.Rows[0]["TABLE_NAME"].ToString(),

                //查询sheet中的数据
                 strSql = "select * from [" + sheetName + "]";
                //实例化OleDbDataAdapter类的实例
                OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(strSql, connection);

                //创建DataSet实例
                DataSet dataSet = new DataSet();

                dbDataAdapter.Fill(dataSet, fileName);

                //从数据集合中取出数据表
                dataTable = dataSet.Tables[0];

                //将数据表返回 回去
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw e;
            }
            finally
            {
                //关闭流
                connection.Close();

            }
        }


        //将数据从dataTable中导入到SQL数据库中 
        public int InsertInToDatabase(DataTable dataTable)
        {
            //声明变量Count 用来记录被添加进数据库中 记录的条数
            int Count = 0;
      string EmployeeNumber = "",
             EmployeeName = "",
             YearMonth="",
             BasicPay = "",
             FullAttendanceBonus = "",
             DutyAllowance = "",
             StayOutSideAllowance = "",
             MealAllowance = "",
             NormalOverTimeRate = "",
             WeekOverTimeRate = "",
             FestivalOverTimeRate = "";

           foreach (DataRow dataRow in dataTable.Rows)
            {
                //Excel表格中的列名  如员工编号 员工姓名

                EmployeeNumber = dataRow["员工编号"].ToString();
                EmployeeName = dataRow["员工姓名"].ToString();
                YearMonth = dataRow["年月编号"].ToString();
                BasicPay = dataRow["基本工资"].ToString();
                FullAttendanceBonus = dataRow["全勤奖"].ToString();
                DutyAllowance = dataRow["职务津贴"].ToString();
                StayOutSideAllowance = dataRow["住宿补贴"].ToString();
                MealAllowance = dataRow["餐费补贴"].ToString();
                NormalOverTimeRate = dataRow["工作日加班费率"].ToString();
                WeekOverTimeRate = dataRow["节假日加班费率"].ToString();
                FestivalOverTimeRate = dataRow["法定节假日加班费率"].ToString();

                while (EmployeeNumber.Length!=5|YearMonth.Length!=6)
                {
                    MessageBox.Show("员工编号或年月编号格式有误,请核实后再进行导入");
                    break;
                }
                


                //创建SqlConnection类的实例  此类是密封类 不能被继承

                SqlConnection sqlConnection = new SqlConnection(UtilitySql.SetConnectionString());
                Count++;
                try
                {
                    //打开连接
                    sqlConnection.Open();
                    //创建要执行的SQL语句
                    string strSQLInsert = "insert into UpholdSalaryFiles values('" + EmployeeNumber + "','"+EmployeeName+"','" + YearMonth + "','" + BasicPay + "','" + FullAttendanceBonus + "','" + DutyAllowance + "','" + StayOutSideAllowance + "','" + MealAllowance + "','" + NormalOverTimeRate + "','" + WeekOverTimeRate + "','" + FestivalOverTimeRate + "')";
                    //创建SQLcommand实例 
                    //使用带接受string类型参数 和SqlConnection类型参数的构造函数
                    SqlCommand command = new SqlCommand(strSQLInsert, sqlConnection);
                    //创建SQLdataReader实例
                    SqlDataReader dataReader = command.ExecuteReader();
                    //关闭dataReader对象
                    dataReader.Close();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw ex;
                }
                finally
                {
                    //关闭连接
                    sqlConnection.Close();
                }
            }

            MessageBox.Show("已成功导入" + Count + "条数据");
            return Count;

        }
    }
}


