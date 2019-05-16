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
        public DataTable getExcelData(string filePath,string fileName)
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

            int i = 0;
            string EmployeeNumber = "";
            string EmployeeName = "";
            string Sex = "";
            string IndentityCardNumber = "";
            string DateOfBirth = "";
            string Nation = "";
            string Academic = "";
            string SectionName = "";
            string DutyName = "";
            string HomeAddress = "";

            foreach (DataRow dataRow in dataTable.Rows)
            {
                //Excel表格中的列名  如员工编号 员工姓名

                EmployeeNumber = dataRow["员工编号"].ToString();
                EmployeeName = dataRow["员工姓名"].ToString();
                Sex = dataRow["性别"].ToString();
                IndentityCardNumber = dataRow["身份证号"].ToString();
                DateOfBirth= dataRow["出生日期"].ToString();
                Nation = dataRow["民族"].ToString();
                Academic = dataRow["学历"].ToString();
                SectionName = dataRow["部门"].ToString();
                DutyName= dataRow["职务"].ToString();
                HomeAddress= dataRow["家庭住址"].ToString();


                string strSql = "insert into EmployeeFiles values('"+EmployeeNumber+ "','" + EmployeeName + "','" + Sex + "','" + IndentityCardNumber + "','" +DateOfBirth + "','" + Nation + "','" + Academic + "','" + SectionName + "','" + DutyName + "','" + HomeAddress + "')";


                //创建SqlConnection类的实例  此类是密封类 不能被继承

                SqlConnection sqlConnection = new SqlConnection(UtilitySql.SetConnectionString());
                i++;
                try
                {   
                    //打开连接
                    sqlConnection.Open();
                    //创建SQLcommand实例 
                    //使用带接受string类型参数 和SqlConnection类型参数的构造函数
                    SqlCommand command = new SqlCommand(strSql,sqlConnection);
                    //创建SQLdataReader实例
                    SqlDataReader dataReader = command.ExecuteReader();
                   

                    //关闭dataReader对象
                    dataReader.Close();
                    MessageBox.Show("数据已经到成功");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("数据已存在数据库中，请勿重复插入");
                   throw ex;
                }
                finally
                {
                    //关闭连接
                    sqlConnection.Close();
                    
                }
            }


            return i;

        }



    }
}
