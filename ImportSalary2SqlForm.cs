
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
    public partial class ImportSalary2SqlForm : Form
    {
        public ImportSalary2SqlForm()
        {
            InitializeComponent();
        }

        //给选择Excel文件  按钮添加点击事件
        private void btn_selectExcel_Click(object sender, EventArgs e)
        {
            //创建一个选择文件对话框
            OpenFileDialog fileDialog = new OpenFileDialog();
            //显示对话框
            fileDialog.ShowDialog();

            if (fileDialog.ShowDialog()==DialogResult.OK)
            {
                //获取被选中的文件的绝对路径
               tb_filePath.Text= Path.GetFullPath(fileDialog.FileName);
                //获取被选中的文件的文件名（不带扩展名）
                tb_fileName.Text=Path.GetFileNameWithoutExtension(fileDialog.FileName);

            }

        }

        //给导入到SQL数据库    按钮添加点击事件
        private void btn_Excel2SQL_Click(object sender, EventArgs e)
        {
            //将获取到的路径名和文件名分别赋值给filePath和fileName
            string filePath = tb_filePath.Text;
            string fileName = tb_fileName.Text;

            //新建一个将Excel文件导入到数据库  类的实例
            ImportSalaryExcel2DataBase salaryExcel2DataBase = new ImportSalaryExcel2DataBase();

            //调用类中的getExcelData函数
         DataTable dataTable =  salaryExcel2DataBase.getExcelData(filePath,fileName);
            //调用类中的InsertIntoDatabase函数   
            salaryExcel2DataBase.InsertInToDatabase(dataTable);
           
        }
    }
}
