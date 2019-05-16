using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class MainForm : Form
    {
        //默认的构造函数
        public MainForm()
        {
            InitializeComponent();
        }

        //新建入职 职员信息
        private void btn_AddEmployee(object sender, EventArgs e)
        {
            //创建新增职员信息 窗口实例
            EmployeeForm em = new EmployeeForm();

            em.Show();
        }
       
      
     

        //新增部门
        private void 新建部门ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建新增部门窗口实例
            SectionForm sf = new SectionForm();
            sf.Show();
        }
        //新增职务
        private void 维护职务数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建新增职务窗口实例
            DutyForm df = new DutyForm();
            df.Show();
        }

        private void 维护薪资档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建维护薪资档案 窗口实例
            UpholdSalaryForm salaryForm = new UpholdSalaryForm();
            salaryForm.Show();
        }

        private void 导入人员档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////弹出一个  打开文件对话框
            //OpenFileDialog dialogEmployee = new OpenFileDialog();
            ////使对话框显示出来
            //dialogEmployee.ShowDialog();
            //创建 导入人员档案 窗体实例
            ImportEmployee2SqlForm employee2SqlForm = new ImportEmployee2SqlForm();
            employee2SqlForm.ShowDialog();
        }

        private void 导入薪资档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////弹出一个 打开文件对话框
            //OpenFileDialog dialogSalary = new OpenFileDialog();
            ////使对话框显示出来
            //dialogSalary.ShowDialog();
            //创建 导入薪资档案 窗体实例
            ImportSalary2SqlForm salary2SqlForm = new ImportSalary2SqlForm();
            salary2SqlForm.Show();
        }

        private void 维护考勤日历ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开考勤日历 窗体  
            AttendanceCalenderForm af = new AttendanceCalenderForm();
            af.Show();
        }

        private void 导入考勤汇总ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //弹出一个 打开文件对话框
            OpenFileDialog dialogAttendance = new OpenFileDialog();
            //使对话框显示出来
            dialogAttendance.ShowDialog();
        }

        private void 维护考勤汇总ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开维护考勤汇总的 窗体
            UpholdAttendanceForm uaf = new UpholdAttendanceForm();
            uaf.Show();
        }

        private void 工资计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建一个工资计算的  窗体
            SalaryCalculatorForm calculatorForm = new SalaryCalculatorForm();
            calculatorForm.Show();
        }
    }
}
