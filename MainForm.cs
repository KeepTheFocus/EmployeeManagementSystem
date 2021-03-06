﻿using System;
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

        Color[] colors = { Color.Red,Color.Green,Color.Blue,Color.Black,Color.Purple,Color.Cyan,Color.OrangeRed,Color.Yellow};
        Random random = new Random();

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
          
            //创建 导入人员档案 窗体实例
            ImportEmployee2SqlForm employee2SqlForm = new ImportEmployee2SqlForm();
            employee2SqlForm.MdiParent = this;
            employee2SqlForm.Show();
            //设置子窗体会随着父窗体的最大化而最大化
            employee2SqlForm.Dock = DockStyle.Fill;
        }

        private void 导入薪资档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
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
            //打开 考勤汇总的窗体
            ImportAttendanceReport2SqlForm i2m = new ImportAttendanceReport2SqlForm();
            i2m.MdiParent = this;
            i2m.Show();
            i2m.Dock = DockStyle.Fill;
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



        private void 员工分组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建员工分组的窗体
            EmployeeGroupForm employeeGroupForm = new EmployeeGroupForm();

            employeeGroupForm.MdiParent = this;

            employeeGroupForm.Show();

            employeeGroupForm.Dock = DockStyle.Fill;

        }

        private void 加班内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建加班原因的窗体
            OverTimeCauseForm overTimeCauseForm = new OverTimeCauseForm();

            overTimeCauseForm.MdiParent = this;

            overTimeCauseForm.Show();

            overTimeCauseForm.Dock = DockStyle.Fill;
            
        }

        private void 预计加班单录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建预计加班单录入窗体
            PreviewOTPaperInputForm previewOtpInputForm = new PreviewOTPaperInputForm();

            previewOtpInputForm.MdiParent = this;

            previewOtpInputForm.Show();

            previewOtpInputForm.Dock = DockStyle.Fill;
        }

        private void 预定加班部门批准ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建部门确认窗体
            SectionAcknowledgeForm sectionAcknowledgeForm = new SectionAcknowledgeForm();

            sectionAcknowledgeForm.MdiParent = this;

            sectionAcknowledgeForm.Show();

            sectionAcknowledgeForm.Dock = DockStyle.Fill;

        }

        private void 预定加班总经理批准ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建总经理确认窗体
            CEOAcknowledgeForm cEOAcknowledgeForm = new CEOAcknowledgeForm();

            cEOAcknowledgeForm.MdiParent = this;

            cEOAcknowledgeForm.Show();

            cEOAcknowledgeForm.Dock = DockStyle.Fill;
        }

        private void 工资报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryReportForm salaryReportForm = new SalaryReportForm();
            salaryReportForm.MdiParent = this;
            salaryReportForm.Show();
            salaryReportForm.Dock = DockStyle.Fill;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void 班次时间段维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassTimeUpholdForm classTimeUpholdForm = new ClassTimeUpholdForm();
            classTimeUpholdForm.MdiParent = this;
            classTimeUpholdForm.Show();
            classTimeUpholdForm.Dock = DockStyle.Fill;
        }

        private void 职员排班ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeArrangementForm employeeArrangementForm = new EmployeeArrangementForm();
            employeeArrangementForm.MdiParent = this;
            employeeArrangementForm.Show();
            employeeArrangementForm.Dock = DockStyle.Fill;
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
           
        //}

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label2.Text = " " + DateTime.Now.ToString("F");
        }

        private void 查询考勤信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchAttendanceForm attendanceForm = new SearchAttendanceForm();
            attendanceForm.MdiParent = this;
            attendanceForm.Show();
            attendanceForm.Dock = DockStyle.Fill;


        }
    }
}
