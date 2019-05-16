using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public static class UtilitySql
    {

       //返回一个与数据库实例进行连接的字符串对象
        public static String SetConnectionString()
        {
            //建立数据库的连接的字符串
           string  strConnection = "Initial catalog=HarvestRhythmZero;" +
                "Integrated Security=SSPI; Data Source=(local)";


            return strConnection;
        }
    }
}
