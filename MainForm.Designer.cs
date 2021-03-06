﻿namespace EmployeeManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建入职职员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建部门ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维护职务数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维护薪资档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入人员档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入薪资档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维护考勤日历ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入考勤汇总ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维护考勤汇总ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.薪资计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工资计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.加班管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工分组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加班原因ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预计加班单录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.实际加班单录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加班后加班单补录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门加班单导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加班确认ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预定加班部门批准ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.实际加班部门批准ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加班后加班ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预定加班总经理批准ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工资报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班次数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班次时间段维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.职员排班ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.查询考勤信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Text = "文件";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建入职职员ToolStripMenuItem,
            this.新建部门ToolStripMenuItem,
            this.维护职务数据ToolStripMenuItem,
            this.维护薪资档案ToolStripMenuItem,
            this.导入人员档案ToolStripMenuItem,
            this.导入薪资档案ToolStripMenuItem});
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.新建ToolStripMenuItem.Text = "基础数据";
            // 
            // 新建入职职员ToolStripMenuItem
            // 
            this.新建入职职员ToolStripMenuItem.Name = "新建入职职员ToolStripMenuItem";
            this.新建入职职员ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.新建入职职员ToolStripMenuItem.Text = "维护人员档案";
            this.新建入职职员ToolStripMenuItem.Click += new System.EventHandler(this.btn_AddEmployee);
            // 
            // 新建部门ToolStripMenuItem
            // 
            this.新建部门ToolStripMenuItem.Name = "新建部门ToolStripMenuItem";
            this.新建部门ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.新建部门ToolStripMenuItem.Text = "维护部门数据";
            this.新建部门ToolStripMenuItem.Click += new System.EventHandler(this.新建部门ToolStripMenuItem_Click);
            // 
            // 维护职务数据ToolStripMenuItem
            // 
            this.维护职务数据ToolStripMenuItem.Name = "维护职务数据ToolStripMenuItem";
            this.维护职务数据ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.维护职务数据ToolStripMenuItem.Text = "维护职务数据";
            this.维护职务数据ToolStripMenuItem.Click += new System.EventHandler(this.维护职务数据ToolStripMenuItem_Click);
            // 
            // 维护薪资档案ToolStripMenuItem
            // 
            this.维护薪资档案ToolStripMenuItem.Name = "维护薪资档案ToolStripMenuItem";
            this.维护薪资档案ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.维护薪资档案ToolStripMenuItem.Text = "维护薪资档案";
            this.维护薪资档案ToolStripMenuItem.Click += new System.EventHandler(this.维护薪资档案ToolStripMenuItem_Click);
            // 
            // 导入人员档案ToolStripMenuItem
            // 
            this.导入人员档案ToolStripMenuItem.Name = "导入人员档案ToolStripMenuItem";
            this.导入人员档案ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.导入人员档案ToolStripMenuItem.Text = "导入人员档案";
            this.导入人员档案ToolStripMenuItem.Click += new System.EventHandler(this.导入人员档案ToolStripMenuItem_Click);
            // 
            // 导入薪资档案ToolStripMenuItem
            // 
            this.导入薪资档案ToolStripMenuItem.Name = "导入薪资档案ToolStripMenuItem";
            this.导入薪资档案ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.导入薪资档案ToolStripMenuItem.Text = "导入薪资档案";
            this.导入薪资档案ToolStripMenuItem.Click += new System.EventHandler(this.导入薪资档案ToolStripMenuItem_Click);
            // 
            // 考勤管理ToolStripMenuItem
            // 
            this.考勤管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.维护考勤日历ToolStripMenuItem,
            this.导入考勤汇总ToolStripMenuItem,
            this.维护考勤汇总ToolStripMenuItem,
            this.查询考勤信息ToolStripMenuItem});
            this.考勤管理ToolStripMenuItem.Name = "考勤管理ToolStripMenuItem";
            this.考勤管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.考勤管理ToolStripMenuItem.Text = "考勤管理";
            // 
            // 维护考勤日历ToolStripMenuItem
            // 
            this.维护考勤日历ToolStripMenuItem.Name = "维护考勤日历ToolStripMenuItem";
            this.维护考勤日历ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.维护考勤日历ToolStripMenuItem.Text = "维护考勤日历";
            this.维护考勤日历ToolStripMenuItem.Click += new System.EventHandler(this.维护考勤日历ToolStripMenuItem_Click);
            // 
            // 导入考勤汇总ToolStripMenuItem
            // 
            this.导入考勤汇总ToolStripMenuItem.Name = "导入考勤汇总ToolStripMenuItem";
            this.导入考勤汇总ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.导入考勤汇总ToolStripMenuItem.Text = "导入考勤汇总";
            this.导入考勤汇总ToolStripMenuItem.Click += new System.EventHandler(this.导入考勤汇总ToolStripMenuItem_Click);
            // 
            // 维护考勤汇总ToolStripMenuItem
            // 
            this.维护考勤汇总ToolStripMenuItem.Name = "维护考勤汇总ToolStripMenuItem";
            this.维护考勤汇总ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.维护考勤汇总ToolStripMenuItem.Text = "维护考勤汇总";
            this.维护考勤汇总ToolStripMenuItem.Click += new System.EventHandler(this.维护考勤汇总ToolStripMenuItem_Click);
            // 
            // 薪资计算ToolStripMenuItem
            // 
            this.薪资计算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工资计算ToolStripMenuItem});
            this.薪资计算ToolStripMenuItem.Name = "薪资计算ToolStripMenuItem";
            this.薪资计算ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.薪资计算ToolStripMenuItem.Text = "薪资计算";
            // 
            // 工资计算ToolStripMenuItem
            // 
            this.工资计算ToolStripMenuItem.Name = "工资计算ToolStripMenuItem";
            this.工资计算ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.工资计算ToolStripMenuItem.Text = "工资计算";
            this.工资计算ToolStripMenuItem.Click += new System.EventHandler(this.工资计算ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.考勤管理ToolStripMenuItem,
            this.薪资计算ToolStripMenuItem,
            this.加班管理ToolStripMenuItem,
            this.加班确认ToolStripMenuItem,
            this.报表管理ToolStripMenuItem,
            this.班次数据ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1204, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 加班管理ToolStripMenuItem
            // 
            this.加班管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工分组ToolStripMenuItem,
            this.加班原因ToolStripMenuItem,
            this.预计加班单录入ToolStripMenuItem,
            this.实际加班单录入ToolStripMenuItem,
            this.加班后加班单补录ToolStripMenuItem,
            this.部门加班单导出ToolStripMenuItem});
            this.加班管理ToolStripMenuItem.Name = "加班管理ToolStripMenuItem";
            this.加班管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.加班管理ToolStripMenuItem.Text = "加班管理";
            // 
            // 员工分组ToolStripMenuItem
            // 
            this.员工分组ToolStripMenuItem.Name = "员工分组ToolStripMenuItem";
            this.员工分组ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.员工分组ToolStripMenuItem.Text = "员工分组";
            this.员工分组ToolStripMenuItem.Click += new System.EventHandler(this.员工分组ToolStripMenuItem_Click);
            // 
            // 加班原因ToolStripMenuItem
            // 
            this.加班原因ToolStripMenuItem.Name = "加班原因ToolStripMenuItem";
            this.加班原因ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.加班原因ToolStripMenuItem.Text = "加班原因";
            this.加班原因ToolStripMenuItem.Click += new System.EventHandler(this.加班内容ToolStripMenuItem_Click);
            // 
            // 预计加班单录入ToolStripMenuItem
            // 
            this.预计加班单录入ToolStripMenuItem.Name = "预计加班单录入ToolStripMenuItem";
            this.预计加班单录入ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.预计加班单录入ToolStripMenuItem.Text = "预计加班单录入";
            this.预计加班单录入ToolStripMenuItem.Click += new System.EventHandler(this.预计加班单录入ToolStripMenuItem_Click);
            // 
            // 实际加班单录入ToolStripMenuItem
            // 
            this.实际加班单录入ToolStripMenuItem.Name = "实际加班单录入ToolStripMenuItem";
            this.实际加班单录入ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.实际加班单录入ToolStripMenuItem.Text = "实际加班单录入";
            // 
            // 加班后加班单补录ToolStripMenuItem
            // 
            this.加班后加班单补录ToolStripMenuItem.Name = "加班后加班单补录ToolStripMenuItem";
            this.加班后加班单补录ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.加班后加班单补录ToolStripMenuItem.Text = "加班后加班单补录";
            // 
            // 部门加班单导出ToolStripMenuItem
            // 
            this.部门加班单导出ToolStripMenuItem.Name = "部门加班单导出ToolStripMenuItem";
            this.部门加班单导出ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.部门加班单导出ToolStripMenuItem.Text = "部门加班单导出";
            // 
            // 加班确认ToolStripMenuItem
            // 
            this.加班确认ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.预定加班部门批准ToolStripMenuItem,
            this.实际加班部门批准ToolStripMenuItem,
            this.加班后加班ToolStripMenuItem,
            this.预定加班总经理批准ToolStripMenuItem});
            this.加班确认ToolStripMenuItem.Name = "加班确认ToolStripMenuItem";
            this.加班确认ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.加班确认ToolStripMenuItem.Text = "加班批准";
            // 
            // 预定加班部门批准ToolStripMenuItem
            // 
            this.预定加班部门批准ToolStripMenuItem.Name = "预定加班部门批准ToolStripMenuItem";
            this.预定加班部门批准ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.预定加班部门批准ToolStripMenuItem.Text = "预定加班部门批准";
            this.预定加班部门批准ToolStripMenuItem.Click += new System.EventHandler(this.预定加班部门批准ToolStripMenuItem_Click);
            // 
            // 实际加班部门批准ToolStripMenuItem
            // 
            this.实际加班部门批准ToolStripMenuItem.Name = "实际加班部门批准ToolStripMenuItem";
            this.实际加班部门批准ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.实际加班部门批准ToolStripMenuItem.Text = "实际加班部门批准";
            // 
            // 加班后加班ToolStripMenuItem
            // 
            this.加班后加班ToolStripMenuItem.Name = "加班后加班ToolStripMenuItem";
            this.加班后加班ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.加班后加班ToolStripMenuItem.Text = "加班后加班单补录批准";
            // 
            // 预定加班总经理批准ToolStripMenuItem
            // 
            this.预定加班总经理批准ToolStripMenuItem.Name = "预定加班总经理批准ToolStripMenuItem";
            this.预定加班总经理批准ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.预定加班总经理批准ToolStripMenuItem.Text = "预定加班总经理批准";
            this.预定加班总经理批准ToolStripMenuItem.Click += new System.EventHandler(this.预定加班总经理批准ToolStripMenuItem_Click);
            // 
            // 报表管理ToolStripMenuItem
            // 
            this.报表管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工资报表ToolStripMenuItem});
            this.报表管理ToolStripMenuItem.Name = "报表管理ToolStripMenuItem";
            this.报表管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.报表管理ToolStripMenuItem.Text = "报表管理";
            // 
            // 工资报表ToolStripMenuItem
            // 
            this.工资报表ToolStripMenuItem.Name = "工资报表ToolStripMenuItem";
            this.工资报表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.工资报表ToolStripMenuItem.Text = "工资报表";
            this.工资报表ToolStripMenuItem.Click += new System.EventHandler(this.工资报表ToolStripMenuItem_Click);
            // 
            // 班次数据ToolStripMenuItem
            // 
            this.班次数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.班次时间段维护ToolStripMenuItem,
            this.职员排班ToolStripMenuItem});
            this.班次数据ToolStripMenuItem.Name = "班次数据ToolStripMenuItem";
            this.班次数据ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.班次数据ToolStripMenuItem.Text = "班次数据";
            // 
            // 班次时间段维护ToolStripMenuItem
            // 
            this.班次时间段维护ToolStripMenuItem.Name = "班次时间段维护ToolStripMenuItem";
            this.班次时间段维护ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.班次时间段维护ToolStripMenuItem.Text = "班次时间段维护";
            this.班次时间段维护ToolStripMenuItem.Click += new System.EventHandler(this.班次时间段维护ToolStripMenuItem_Click);
            // 
            // 职员排班ToolStripMenuItem
            // 
            this.职员排班ToolStripMenuItem.Name = "职员排班ToolStripMenuItem";
            this.职员排班ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.职员排班ToolStripMenuItem.Text = "职员排班";
            this.职员排班ToolStripMenuItem.Click += new System.EventHandler(this.职员排班ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 593);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 35);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前时间";
            // 
            // 查询考勤信息ToolStripMenuItem
            // 
            this.查询考勤信息ToolStripMenuItem.Name = "查询考勤信息ToolStripMenuItem";
            this.查询考勤信息ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.查询考勤信息ToolStripMenuItem.Text = "查询考勤信息";
            this.查询考勤信息ToolStripMenuItem.Click += new System.EventHandler(this.查询考勤信息ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人事管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建入职职员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建部门ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维护职务数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维护薪资档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入人员档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入薪资档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考勤管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维护考勤日历ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入考勤汇总ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维护考勤汇总ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 薪资计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工资计算ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 加班管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工分组ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加班原因ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预计加班单录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 实际加班单录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加班后加班单补录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门加班单导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加班确认ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预定加班部门批准ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 实际加班部门批准ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加班后加班ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预定加班总经理批准ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工资报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班次数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班次时间段维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 职员排班ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 查询考勤信息ToolStripMenuItem;
    }
}

