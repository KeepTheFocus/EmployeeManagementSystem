namespace EmployeeManagementSystem
{
    partial class AttendanceCalenderForm
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
            this.tb_Month = new System.Windows.Forms.TextBox();
            this.tb_Hour = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_alter = new System.Windows.Forms.Button();
            this.btn_esc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_Calender = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Day = new System.Windows.Forms.TextBox();
            this.btn_SaveAfterAlter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Month
            // 
            this.tb_Month.Location = new System.Drawing.Point(146, 55);
            this.tb_Month.Name = "tb_Month";
            this.tb_Month.Size = new System.Drawing.Size(100, 21);
            this.tb_Month.TabIndex = 0;
            // 
            // tb_Hour
            // 
            this.tb_Hour.Location = new System.Drawing.Point(146, 131);
            this.tb_Hour.Name = "tb_Hour";
            this.tb_Hour.Size = new System.Drawing.Size(100, 21);
            this.tb_Hour.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(382, 55);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_alter
            // 
            this.btn_alter.Location = new System.Drawing.Point(382, 94);
            this.btn_alter.Name = "btn_alter";
            this.btn_alter.Size = new System.Drawing.Size(75, 23);
            this.btn_alter.TabIndex = 4;
            this.btn_alter.Text = "修改";
            this.btn_alter.UseVisualStyleBackColor = true;
            this.btn_alter.Click += new System.EventHandler(this.btn_alter_Click);
            // 
            // btn_esc
            // 
            this.btn_esc.Location = new System.Drawing.Point(382, 158);
            this.btn_esc.Name = "btn_esc";
            this.btn_esc.Size = new System.Drawing.Size(75, 23);
            this.btn_esc.TabIndex = 6;
            this.btn_esc.Text = "退出";
            this.btn_esc.UseVisualStyleBackColor = true;
            this.btn_esc.Click += new System.EventHandler(this.btn_esc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "年月编码(6位)：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "工作时长(小时)：";
            // 
            // listView_Calender
            // 
            this.listView_Calender.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_Calender.FullRowSelect = true;
            this.listView_Calender.Location = new System.Drawing.Point(37, 184);
            this.listView_Calender.Name = "listView_Calender";
            this.listView_Calender.Size = new System.Drawing.Size(345, 151);
            this.listView_Calender.TabIndex = 3;
            this.listView_Calender.UseCompatibleStateImageBehavior = false;
            this.listView_Calender.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "年月编码";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "工作时长（天）";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "工作时长（小时）";
            this.columnHeader5.Width = 144;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "工作时长(天)：";
            // 
            // tb_Day
            // 
            this.tb_Day.Location = new System.Drawing.Point(146, 91);
            this.tb_Day.Name = "tb_Day";
            this.tb_Day.Size = new System.Drawing.Size(100, 21);
            this.tb_Day.TabIndex = 1;
            this.tb_Day.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Day_KeyDown);
            // 
            // btn_SaveAfterAlter
            // 
            this.btn_SaveAfterAlter.Location = new System.Drawing.Point(382, 129);
            this.btn_SaveAfterAlter.Name = "btn_SaveAfterAlter";
            this.btn_SaveAfterAlter.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveAfterAlter.TabIndex = 5;
            this.btn_SaveAfterAlter.Text = "修改后保存";
            this.btn_SaveAfterAlter.UseVisualStyleBackColor = true;
            this.btn_SaveAfterAlter.Click += new System.EventHandler(this.btn_SaveAfterAlter_Click);
            // 
            // AttendanceCalenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.btn_SaveAfterAlter);
            this.Controls.Add(this.tb_Day);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView_Calender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_esc);
            this.Controls.Add(this.btn_alter);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_Hour);
            this.Controls.Add(this.tb_Month);
            this.Name = "AttendanceCalenderForm";
            this.Text = "考勤日历";
            this.Load += new System.EventHandler(this.AttendanceCalenderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Month;
        private System.Windows.Forms.TextBox tb_Hour;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_alter;
        private System.Windows.Forms.Button btn_esc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_Calender;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Day;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_SaveAfterAlter;
    }
}