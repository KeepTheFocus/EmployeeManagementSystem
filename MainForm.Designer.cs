namespace EmployeeManagementSystem
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Text = "文件";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.考勤管理ToolStripMenuItem,
            this.薪资计算ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1204, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.新建入职职员ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新建入职职员ToolStripMenuItem.Text = "维护人员档案";
            this.新建入职职员ToolStripMenuItem.Click += new System.EventHandler(this.btn_AddEmployee);
            // 
            // 新建部门ToolStripMenuItem
            // 
            this.新建部门ToolStripMenuItem.Name = "新建部门ToolStripMenuItem";
            this.新建部门ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新建部门ToolStripMenuItem.Text = "维护部门数据";
            this.新建部门ToolStripMenuItem.Click += new System.EventHandler(this.新建部门ToolStripMenuItem_Click);
            // 
            // 维护职务数据ToolStripMenuItem
            // 
            this.维护职务数据ToolStripMenuItem.Name = "维护职务数据ToolStripMenuItem";
            this.维护职务数据ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.维护职务数据ToolStripMenuItem.Text = "维护职务数据";
            this.维护职务数据ToolStripMenuItem.Click += new System.EventHandler(this.维护职务数据ToolStripMenuItem_Click);
            // 
            // 维护薪资档案ToolStripMenuItem
            // 
            this.维护薪资档案ToolStripMenuItem.Name = "维护薪资档案ToolStripMenuItem";
            this.维护薪资档案ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.维护薪资档案ToolStripMenuItem.Text = "维护薪资档案";
            this.维护薪资档案ToolStripMenuItem.Click += new System.EventHandler(this.维护薪资档案ToolStripMenuItem_Click);
            // 
            // 导入人员档案ToolStripMenuItem
            // 
            this.导入人员档案ToolStripMenuItem.Name = "导入人员档案ToolStripMenuItem";
            this.导入人员档案ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.导入人员档案ToolStripMenuItem.Text = "导入人员档案";
            this.导入人员档案ToolStripMenuItem.Click += new System.EventHandler(this.导入人员档案ToolStripMenuItem_Click);
            // 
            // 导入薪资档案ToolStripMenuItem
            // 
            this.导入薪资档案ToolStripMenuItem.Name = "导入薪资档案ToolStripMenuItem";
            this.导入薪资档案ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.导入薪资档案ToolStripMenuItem.Text = "导入薪资档案";
            this.导入薪资档案ToolStripMenuItem.Click += new System.EventHandler(this.导入薪资档案ToolStripMenuItem_Click);
            // 
            // 考勤管理ToolStripMenuItem
            // 
            this.考勤管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.维护考勤日历ToolStripMenuItem,
            this.导入考勤汇总ToolStripMenuItem,
            this.维护考勤汇总ToolStripMenuItem});
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
            this.工资计算ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.工资计算ToolStripMenuItem.Text = "工资计算";
            this.工资计算ToolStripMenuItem.Click += new System.EventHandler(this.工资计算ToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 628);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人事管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建入职职员ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
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
    }
}

