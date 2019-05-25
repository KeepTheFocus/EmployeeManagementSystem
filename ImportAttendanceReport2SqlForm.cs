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

namespace EmployeeManagementSystem
{
    public partial class ImportAttendanceReport2SqlForm : Form
    {
        public ImportAttendanceReport2SqlForm()
        {
            InitializeComponent();
        }


        //给选择EXCEL文件按钮  添加点击事件
        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            //打开文件选择框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                //获取被选中文件的名称 （不带扩展名）
                tb_FileName.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                //获取被选中文件的绝对路径
                tb_Path.Text = Path.GetFullPath(openFileDialog.FileName);
            }
        }
        //给导入到Sql数据库按钮  添加点击事件
        private void btn_Import2Sql_Click(object sender, EventArgs e)
        {
            //将获取到的路径名和文件名分别赋值给filePath和fileName
            string filePath = tb_Path.Text,
                   fileName = tb_FileName.Text;

            //新建一个将Excel文件导入到数据库  类的实例
            ImportAttendanceReportExcel2DataBase excel2DataBase = new ImportAttendanceReportExcel2DataBase();
            //调用类中的getExcelData函数
            DataTable dataTable = excel2DataBase.getExcelData(filePath, fileName);
            //调用类中的InsertIntoDatabase函数   
            excel2DataBase.InsertInToDatabase(dataTable);
        }
    }
}
