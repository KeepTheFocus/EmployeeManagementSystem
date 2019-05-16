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
    public partial class ImportEmployee2SqlForm : Form
    {
        public ImportEmployee2SqlForm()
        {
            InitializeComponent();
        }

        //给选择Excel文件按钮 添加点击事件
        private void btn_selectExcel_Click(object sender, EventArgs e)
        {
            //新建一个打开文件对话框 并调用showDialog函数显示出来
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();


            if (fileDialog.ShowDialog()==DialogResult.OK)
            {
                //获取被选中文件的  绝对路径
                tb_filePath.Text = Path.GetFullPath(fileDialog.FileName);
                //获取被选中文件的  文件名称（不带扩展名）
                tb_fileName.Text = Path.GetFileNameWithoutExtension(fileDialog.FileName);
            }
        }
        //给导入到SQL数据库按钮 添加点击事件 
        private void btn_import2Sql_Click(object sender, EventArgs e)
        {
            //将获取到的路径名和文件名分别赋值给filePath和fileName
            string filePath =tb_filePath.Text;
            string fileName =tb_fileName.Text;

            //新建一个将Excel文件导入到数据库  类的实例
            ImportEmployeeExcel2DataBase excel2DataBase=new ImportEmployeeExcel2DataBase();
            //调用类中的getExcelData函数
            DataTable dataTable=excel2DataBase.getExcelData(filePath,fileName);
            //调用类中的InsertIntoDatabase函数   
            excel2DataBase.InsertInToDatabase(dataTable);
        }
    }
}
