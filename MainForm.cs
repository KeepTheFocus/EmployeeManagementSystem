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
            //设置MainForm为EmployeeForm的父窗体
            em.MdiParent = this;
            em.Show();
            //设置子窗体永远充满父窗体
            em.Dock = DockStyle.Fill;
        }
       
      
     

        //新增部门
        private void 新建部门ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建新增部门窗口实例
            SectionForm sf = new SectionForm();
            sf.MdiParent = this;
            sf.Show();
            //设置子窗体会随着父窗体的最大化而最大化
            sf.Dock = DockStyle.Fill;
        }
        //新增职务
        private void 维护职务数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建新增职务窗口实例
            DutyForm df = new DutyForm();
            df.MdiParent = this;
            df.Show();
            //设置子窗体会随着父窗体的最大化而最大化
            df.Dock = DockStyle.Fill;
        }

        private void 维护薪资档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建维护薪资档案 窗口实例
            UpholdSalaryForm salaryForm = new UpholdSalaryForm();
            salaryForm.MdiParent = this;
            salaryForm.Show();
            //设置子窗体会随着父窗体的最大化而最大化
            salaryForm.Dock = DockStyle.Fill;
        }

        private void 导入人员档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////弹出一个  打开文件对话框
            //OpenFileDialog dialogEmployee = new OpenFileDialog();
            ////使对话框显示出来
            //dialogEmployee.ShowDialog();
            //创建 导入人员档案 窗体实例
            ImportEmployee2SqlForm employee2SqlForm = new ImportEmployee2SqlForm();
            employee2SqlForm.MdiParent = this;
            employee2SqlForm.Show();
            //设置子窗体会随着父窗体的最大化而最大化
            employee2SqlForm.Dock = DockStyle.Fill;
        }

        private void 导入薪资档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////弹出一个 打开文件对话框
            //OpenFileDialog dialogSalary = new OpenFileDialog();
            ////使对话框显示出来
            //dialogSalary.ShowDialog();
            //创建 导入薪资档案 窗体实例
            ImportSalary2SqlForm salary2SqlForm = new ImportSalary2SqlForm();
            salary2SqlForm.MdiParent = this;
            salary2SqlForm.Show();
            //设置子窗体会随着父窗体的最大化而最大化
            salary2SqlForm.Dock = DockStyle.Fill;
        }

        private void 维护考勤日历ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开考勤日历 窗体  
            AttendanceCalenderForm af = new AttendanceCalenderForm();
            af.MdiParent = this;
            af.Show();
            //设置子窗体会随着父窗体的最大化而最大化
            af.Dock = DockStyle.Fill;
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
            uaf.MdiParent = this;
            uaf.Show();
            //设置子窗体会随着父窗体的最大化而最大化
            uaf.Dock = DockStyle.Fill;
        }

        private void 工资计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建一个工资计算的  窗体
            SalaryCalculatorForm calculatorForm = new SalaryCalculatorForm();
            calculatorForm.MdiParent = this;
            calculatorForm.Show();
            //设置子窗体会随着父窗体的最大化而最大化
            calculatorForm.Dock = DockStyle.Fill;
        }
    }
}
