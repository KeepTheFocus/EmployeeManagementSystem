using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace EmployeeManagementSystem
{
    class ImportAttendanceReportExcel2DataBase
    {

        //声明一个返回DataTable数据表的函数          文件路径           文件名
        public DataTable getExcelData(string filePath, string fileName)
        {

            //建立字符串
            string cmdText = "Provider=Microsoft.Ace.OleDb.12.0;" +
                "Data Source={0};Extended Properties='Excel 12.0; HDR=Yes; IMEX=1'";
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
                MessageBox.Show(e.Message);
                throw e;
            }
            finally
            {
                //关闭流
                connection.Close();

            }
        }
        //声明一个容器 用来存储从表格中 取出的员工编号
        List<string> eeNumber = new List<string>();

        //声明一个容器 用来存储从表格中 取出来的年月编号
        List<string> eeYearMonth = new List<string>();

        //声明一个布尔型的标记
        Boolean booleanNumber = false;

        //声明一个布尔型的标记

        Boolean booleanYearMonth = false;


        //将数据从dataTable中导入到SQL数据库中 
        public int InsertInToDatabase(DataTable dataTable)
        {
            //声明变量Count 用来记录被添加进数据库中 记录的条数
            int Count = 0;
            string EmployeeNumber = "",
              EmployeeName = "",
              YearMonth = "",
              AttendanceHour = "",
              AbsenceHour = "",
              LeaveHour = "",
            
             NormalOverTimeHour = "",
             WeekOverTimeHour = "",
             FestivalOverTimeHour = "";



            /*1.先获取Excel表格中某一列的所有行 （先获取表格中有多少行）
             * 
              2.弄一个容器 用来存储某一列所有行的值
              3.循环判断每一个值得长度是否不等于5
              4.如果存在一个或者多个值的长度不能于5
              5.那么弹出消息框告诉用户数据格式错误 
              6.请核对后再进行导入操作
              */
            /*
          1.如果所有值长度都等于5 
          2.那么执行将Excel中的数据插入进数据库中的操作
           */

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                //取出表格中的编号 并添加进编号容器中
               eeNumber.Add(dataTable.Rows[i][0].ToString()) ;
                MessageBox.Show(dataTable.Rows[i][0].ToString());
                //取出表格中的年月编号 并添加进编号容器中
                eeYearMonth.Add(dataTable.Rows[i][2].ToString());
                MessageBox.Show(dataTable.Rows[i][2].ToString());

            }

            //用foreach判断 容器中的编号值的长度是否含有不等于5的
            foreach (string item in eeNumber)
            {
                if (item.Length!=5)
                {
                    MessageBox.Show("员工编号格式有误,请修改错误的数据后再导入");
                    booleanNumber = true;

                }
            }

            //用foreach判断 容器中的年月编号的长度是否含有不等于6的
            foreach (string item in eeYearMonth)
            {
                if (item.Length!=6)
                {
                    MessageBox.Show("年月编号格式有误,请修改错误的数据后再导入");
                    booleanYearMonth = true;
                }
            }

            //当所有的 员工编号和年月编号都正确时才执行添加操作
            if (booleanNumber!=true&booleanYearMonth!=true)
            {

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    //Excel表格中每一行中包含的数据   如员工编号 员工姓名
                    EmployeeNumber = dataRow["员工编号"].ToString();
                    EmployeeName = dataRow["员工姓名"].ToString();
                    YearMonth = dataRow["年月编号"].ToString();
                    AttendanceHour = dataRow["出勤"].ToString();
                    AbsenceHour = dataRow["缺勤"].ToString();
                    LeaveHour = dataRow["请假"].ToString();
                    NormalOverTimeHour = dataRow["工作日加班"].ToString();
                    WeekOverTimeHour = dataRow["节假日加班"].ToString();
                    FestivalOverTimeHour = dataRow["法定节假日加班"].ToString();



                    //创建SqlConnection类的实例  此类是密封类 不能被继承
                    SqlConnection sqlConnection = new SqlConnection(UtilitySql.SetConnectionString());
                    Count++;
                    try
                    {
                        //打开连接
                        sqlConnection.Open();
                        //创建要执行的Sql语句
                        string strSqlInsert = "insert into AttendanceReport values('" + EmployeeNumber + "','" + EmployeeName + "','" + YearMonth + "','" + AttendanceHour + "','" + AbsenceHour + "','" + LeaveHour + "','" + NormalOverTimeHour + "','" + WeekOverTimeHour + "','" + FestivalOverTimeHour + "')";
                        //创建SQLcommand实例 
                        //使用带接受string类型参数 和SqlConnection类型参数的构造函数
                        SqlCommand command = new SqlCommand(strSqlInsert, sqlConnection);
                        //创建SQLdataReader实例
                        SqlDataReader dataReader = command.ExecuteReader();
                        //关闭dataReader对象
                        dataReader.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        //弹出消息框提示用户导入了多少条数据
                        MessageBox.Show("已成功导入" + Count + "条数据");
                        throw e;
                    }
                    finally
                    {
                        //关闭连接
                        sqlConnection.Close();
                    }
                }
                //弹出消息框提示用户导入了多少条数据
                MessageBox.Show("已成功导入" + Count + "条数据");
            }

            MessageBox.Show(""+Count);
           
            return Count;
        }
        }
    }


