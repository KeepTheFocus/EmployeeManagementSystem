using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
namespace EmployeeManagementSystem
{
    class Export2Excel
    {
        //声明一个导出excel函数
        public void Export(ListView listView,string FileName)
        {
            //声明行   listView.Items代表有多少行
          int row  =listView.Items.Count;
            //声明列   listView.Items[].SubItems代表一行有多少列
            int colum = listView.Items[0].SubItems.Count;
            //从第二行开始填充数据
        
            int rowIndex = 1;
            //从第一列开始填充数据
            int columIndex = 0;

            //如果行数大于0
            if (row>0)
            {
                //创建一个Application接口的实例   xlApp
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                //如果xlApp实例不存在
                if (xlApp==null)
                {
                    //弹出消息框提示
                    MessageBox.Show("无法创建Excel");
                }
                //给xlApp的属性DefaultFilePath赋值
                xlApp.DefaultFilePath = "";
                //给xlApp的属性DisplayAlerts赋值
                xlApp.DisplayAlerts = true;
                //给xlApp的属性SheetsInNewWorkbook赋值
                xlApp.SheetsInNewWorkbook = 1;
                //定义一个Workbook类的实例xlbook 也可以说是一个单独Excel文件
                Workbook xlbook = xlApp.Workbooks.Add(true);
                //将listview的列名导入第一行
                //循环遍历列表的每列的表头
                foreach (ColumnHeader ch in listView.Columns)
                {
                    //列的索引 进行加1运算
                    columIndex++;
                    //将表头的Text的属性值赋予给  Cells[行索引，列索引]
                    xlApp.Cells[rowIndex,columIndex]= ch.Text;
                }

                //将数据保存到Excel中  
                //Excel的第一行是默认的列(A B C D E F G H I J K L M N)索引区域 
                //Excel的第一列是默认的行(1 2 3 4 5 6 7 8 9 10 11 12 13 14)索引区域 
                //Excel的第二行是默认的表头文件(员工编号 员工姓名 性别 身份证号...)区域
                for ( rowIndex = 2; rowIndex <listView.Items.Count+2; rowIndex++)
                {     //从Excel表格的第三行 第二列开始保存数据
                      //Form窗体中 listview列表的Items[0] 就是（除表头外的）第一行
                    xlApp.Cells[rowIndex, 1] = listView.Items[rowIndex - 2].Text;


                    for (columIndex = 2; columIndex < listView.Columns.Count+1; columIndex++)
                    {
                        //从Excel表格的第三行 第二列开始保存数据       
                        //从Form窗体中 listview列表的Items[0] 就是（除表头外的）第一行 subItems[0]就是第一行的第一格开始取出数据
                        xlApp.Cells[rowIndex, columIndex] = listView.Items[rowIndex - 2].SubItems[columIndex-1].Text;
                    }
                }

                xlbook.SaveAs(FileName);
                //保存好Excel文件后 弹出消息提示用户 数据导出成功 
                MessageBox.Show("导出成功");

            }
        
        }
    }
}
