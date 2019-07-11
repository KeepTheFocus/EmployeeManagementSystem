namespace EmployeeManagementSystem
{
    partial class UpholdAttendanceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Number = new System.Windows.Forms.TextBox();
            this.tb_AttendanceHour = new System.Windows.Forms.TextBox();
            this.tb_AbsenceHour = new System.Windows.Forms.TextBox();
            this.tb_LeaveHour = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_normal = new System.Windows.Forms.TextBox();
            this.tb_Week = new System.Windows.Forms.TextBox();
            this.tb_Festival = new System.Windows.Forms.TextBox();
            this.btn_Alter = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.listview_AttendanceReport = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_YearMonth = new System.Windows.Forms.DateTimePicker();
            this.tb_YearMonth = new System.Windows.Forms.TextBox();
            this.btn_RetrieveFromAtt2000 = new System.Windows.Forms.Button();
            this.checkBox_Manually = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "缺勤(H)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "请假(H)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "员工姓名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "工作日加班(H)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "节假日加班(H)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "法定节假日加班(H)";
            // 
            // tb_Number
            // 
            this.tb_Number.Location = new System.Drawing.Point(89, 56);
            this.tb_Number.Name = "tb_Number";
            this.tb_Number.Size = new System.Drawing.Size(200, 21);
            this.tb_Number.TabIndex = 0;
            this.tb_Number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Number_KeyDown);
            // 
            // tb_AttendanceHour
            // 
            this.tb_AttendanceHour.Location = new System.Drawing.Point(89, 184);
            this.tb_AttendanceHour.Name = "tb_AttendanceHour";
            this.tb_AttendanceHour.Size = new System.Drawing.Size(200, 21);
            this.tb_AttendanceHour.TabIndex = 3;
            // 
            // tb_AbsenceHour
            // 
            this.tb_AbsenceHour.Location = new System.Drawing.Point(89, 227);
            this.tb_AbsenceHour.Name = "tb_AbsenceHour";
            this.tb_AbsenceHour.Size = new System.Drawing.Size(200, 21);
            this.tb_AbsenceHour.TabIndex = 4;
            // 
            // tb_LeaveHour
            // 
            this.tb_LeaveHour.Location = new System.Drawing.Point(89, 284);
            this.tb_LeaveHour.Name = "tb_LeaveHour";
            this.tb_LeaveHour.Size = new System.Drawing.Size(200, 21);
            this.tb_LeaveHour.TabIndex = 5;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(470, 56);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.ReadOnly = true;
            this.tb_Name.Size = new System.Drawing.Size(170, 21);
            this.tb_Name.TabIndex = 1;
            // 
            // tb_normal
            // 
            this.tb_normal.Location = new System.Drawing.Point(470, 139);
            this.tb_normal.Name = "tb_normal";
            this.tb_normal.Size = new System.Drawing.Size(170, 21);
            this.tb_normal.TabIndex = 6;
            // 
            // tb_Week
            // 
            this.tb_Week.Location = new System.Drawing.Point(470, 190);
            this.tb_Week.Name = "tb_Week";
            this.tb_Week.Size = new System.Drawing.Size(170, 21);
            this.tb_Week.TabIndex = 7;
            // 
            // tb_Festival
            // 
            this.tb_Festival.Location = new System.Drawing.Point(470, 227);
            this.tb_Festival.Name = "tb_Festival";
            this.tb_Festival.Size = new System.Drawing.Size(170, 21);
            this.tb_Festival.TabIndex = 8;
            // 
            // btn_Alter
            // 
            this.btn_Alter.Location = new System.Drawing.Point(759, 122);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(128, 23);
            this.btn_Alter.TabIndex = 10;
            this.btn_Alter.Text = "修   改";
            this.btn_Alter.UseVisualStyleBackColor = true;
            this.btn_Alter.Click += new System.EventHandler(this.btn_Alter_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(759, 59);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(128, 23);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "保   存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(759, 179);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(128, 23);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "删   除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // listview_AttendanceReport
            // 
            this.listview_AttendanceReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader9,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listview_AttendanceReport.FullRowSelect = true;
            this.listview_AttendanceReport.GridLines = true;
            this.listview_AttendanceReport.Location = new System.Drawing.Point(27, 332);
            this.listview_AttendanceReport.Name = "listview_AttendanceReport";
            this.listview_AttendanceReport.Size = new System.Drawing.Size(668, 271);
            this.listview_AttendanceReport.TabIndex = 20;
            this.listview_AttendanceReport.UseCompatibleStateImageBehavior = false;
            this.listview_AttendanceReport.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "员工编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "员工姓名";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "年月编号";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "出勤(H)";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "缺勤(H)";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "请假(H)";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "工作日加班(H)";
            this.columnHeader6.Width = 97;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "节假日加班(H)";
            this.columnHeader7.Width = 92;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "法定节假日加班(H)";
            this.columnHeader8.Width = 115;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "出勤(H)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "年月编号";
            // 
            // dtp_YearMonth
            // 
            this.dtp_YearMonth.CustomFormat = "yyyyMM";
            this.dtp_YearMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_YearMonth.Location = new System.Drawing.Point(89, 105);
            this.dtp_YearMonth.Name = "dtp_YearMonth";
            this.dtp_YearMonth.Size = new System.Drawing.Size(200, 21);
            this.dtp_YearMonth.TabIndex = 23;
            this.dtp_YearMonth.ValueChanged += new System.EventHandler(this.dtp_YearMonth_ValueChanged);
            // 
            // tb_YearMonth
            // 
            this.tb_YearMonth.Location = new System.Drawing.Point(89, 142);
            this.tb_YearMonth.Name = "tb_YearMonth";
            this.tb_YearMonth.ReadOnly = true;
            this.tb_YearMonth.Size = new System.Drawing.Size(200, 21);
            this.tb_YearMonth.TabIndex = 24;
            // 
            // btn_RetrieveFromAtt2000
            // 
            this.btn_RetrieveFromAtt2000.Location = new System.Drawing.Point(759, 252);
            this.btn_RetrieveFromAtt2000.Name = "btn_RetrieveFromAtt2000";
            this.btn_RetrieveFromAtt2000.Size = new System.Drawing.Size(189, 53);
            this.btn_RetrieveFromAtt2000.TabIndex = 25;
            this.btn_RetrieveFromAtt2000.Text = "从att2000数据库中读取数据";
            this.btn_RetrieveFromAtt2000.UseVisualStyleBackColor = true;
            this.btn_RetrieveFromAtt2000.Click += new System.EventHandler(this.btn_RetrieveFromAtt2000_Click);
            // 
            // checkBox_Manually
            // 
            this.checkBox_Manually.AutoSize = true;
            this.checkBox_Manually.Location = new System.Drawing.Point(759, 347);
            this.checkBox_Manually.Name = "checkBox_Manually";
            this.checkBox_Manually.Size = new System.Drawing.Size(120, 16);
            this.checkBox_Manually.TabIndex = 26;
            this.checkBox_Manually.Text = "手动录入考勤数据";
            this.checkBox_Manually.UseVisualStyleBackColor = true;
            this.checkBox_Manually.CheckedChanged += new System.EventHandler(this.checkBox_Manually_CheckedChanged);
            this.checkBox_Manually.CheckStateChanged += new System.EventHandler(this.checkBox_Manually_CheckStateChanged);
            // 
            // UpholdAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 628);
            this.Controls.Add(this.checkBox_Manually);
            this.Controls.Add(this.btn_RetrieveFromAtt2000);
            this.Controls.Add(this.tb_YearMonth);
            this.Controls.Add(this.dtp_YearMonth);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listview_AttendanceReport);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Alter);
            this.Controls.Add(this.tb_Festival);
            this.Controls.Add(this.tb_Week);
            this.Controls.Add(this.tb_normal);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_LeaveHour);
            this.Controls.Add(this.tb_AbsenceHour);
            this.Controls.Add(this.tb_AttendanceHour);
            this.Controls.Add(this.tb_Number);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpholdAttendanceForm";
            this.Text = "维护考勤汇总";
            this.Load += new System.EventHandler(this.UpholdAttendanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Number;
        private System.Windows.Forms.TextBox tb_AttendanceHour;
        private System.Windows.Forms.TextBox tb_AbsenceHour;
        private System.Windows.Forms.TextBox tb_LeaveHour;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_normal;
        private System.Windows.Forms.TextBox tb_Week;
        private System.Windows.Forms.TextBox tb_Festival;
        private System.Windows.Forms.Button btn_Alter;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ListView listview_AttendanceReport;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_YearMonth;
        private System.Windows.Forms.TextBox tb_YearMonth;
        private System.Windows.Forms.Button btn_RetrieveFromAtt2000;
        private System.Windows.Forms.CheckBox checkBox_Manually;
    }
}