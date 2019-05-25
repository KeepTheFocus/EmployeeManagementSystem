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
    class ImportEmployeeExcel2DataBase
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
                string sheetName = schemaTable.Rows[0]["TABLE_NAME"].ToString();

                //查询sheet中的数据
                string strSql = "select * from [" + sheetName + "]";
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

        //声明两个集合 用来存储表格中的员工编号和身份证号码
        List<string> eeNumber = new List<string>();
        List<string> eeIDCard = new List<string>();
        List<int > eeDE = new List<int>();
        //声明两个布尔类型的变量 booleanNumber,booleanIDCard;
        Boolean booleanNumber =false;
        Boolean booleanIDCard=false;

        //将数据从dataTable中导入到SQL数据库中 
        public int InsertInToDatabase(DataTable dataTable)
        {
            //声明变量Count 用来记录被添加进数据库中 记录的条数
            int Count = 0;
            string EmployeeNumber = "",
                 EmployeeName = "",
                  Sex = "",
                 IndentityCardNumber = "",
                 DateOfBirth = "",
                 Nation = "",
                 Academic = "",
                SectionName = "",
                 DutyName = "",
                 HomeAddress = "";

            //1.通过循环 取出 员工编号列、 身份证号列 和出生日期列的所有信息的集合

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                //取出Excel表格中第一列的数据   员工编号
                eeNumber.Add(dataTable.Rows[i][0].ToString());
                MessageBox.Show(dataTable.Rows[i][0].ToString());
                //取出Excel表格中第四列的数据    身份证号
                eeIDCard.Add(dataTable.Rows[i][3].ToString());
                MessageBox.Show(dataTable.Rows[i][3].ToString());
             


            }

            //判断员工编号集合中是否有 条目的长度不等于5
           foreach (string item in eeNumber)
            {
                if (item.Length != 5)
                {
                    MessageBox.Show("员工编号格式不对,请核对");
                    booleanNumber = true;
                    //跳出foreach循环
                    break;
                }
            }


            //判断身份证号集合中是否有  条目的长度不等于18

          foreach (string item in eeIDCard)
            {
                if (item.Length != 18)
                {
                    MessageBox.Show("身份证格式不对,请核对");
                    booleanIDCard = true;
                    //跳出foreach循环
                    break;
                }
            }


            //如果员工编号和身份证号都正确是才执行下面的foeach循环

            if (booleanNumber!=true&&booleanIDCard!=true)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    //Excel表格中的列名  如员工编号 员工姓名

                    EmployeeNumber = dataRow["员工编号"].ToString();
                    EmployeeName = dataRow["员工姓名"].ToString();
                    Sex = dataRow["性别"].ToString();
                    IndentityCardNumber = dataRow["身份证号"].ToString();
                    DateOfBirth = dataRow["出生日期"].ToString();
                    Nation = dataRow["民族"].ToString();
                    Academic = dataRow["学历"].ToString();
                    SectionName = dataRow["部门"].ToString();
                    DutyName = dataRow["职务"].ToString();
                    HomeAddress = dataRow["家庭住址"].ToString();
                    //创建SqlConnection类的实例  此类是密封类 不能被继承

                    SqlConnection sqlConnection = new SqlConnection(UtilitySql.SetConnectionString());
                    Count++;
                    try
                    {
                        //打开连接
                        sqlConnection.Open();
                        //创建将要执行的Insert语句
                        string strSQLInsert = "insert into EmployeeFiles values('" + EmployeeNumber + "','" + EmployeeName + "','" + Sex + "','" + IndentityCardNumber + "','" + DateOfBirth + "','" + Nation + "','" + Academic + "','" + SectionName + "','" + DutyName + "','" + HomeAddress + "')";
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
            }
            MessageBox.Show("" + Count);
            return Count;
        }
    }
}
