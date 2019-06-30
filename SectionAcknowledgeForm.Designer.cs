namespace EmployeeManagementSystem
{
    partial class SectionAcknowledgeForm
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
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.cb_SectionName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lv_OTStaff = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_CheckAllAndOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_NGCause = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_EmployeeTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "部门";
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(75, 12);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 21);
            this.dtp_date.TabIndex = 2;
            this.dtp_date.ValueChanged += new System.EventHandler(this.dtp_date_ValueChanged);
            // 
            // cb_SectionName
            // 
            this.cb_SectionName.FormattingEnabled = true;
            this.cb_SectionName.Location = new System.Drawing.Point(434, 12);
            this.cb_SectionName.Name = "cb_SectionName";
            this.cb_SectionName.Size = new System.Drawing.Size(121, 20);
            this.cb_SectionName.TabIndex = 3;
            this.cb_SectionName.TextChanged += new System.EventHandler(this.cb_SectionName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "加班人员列表";
            // 
            // lv_OTStaff
            // 
            this.lv_OTStaff.CheckBoxes = true;
            this.lv_OTStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26});
            this.lv_OTStaff.FullRowSelect = true;
            this.lv_OTStaff.GridLines = true;
            this.lv_OTStaff.Location = new System.Drawing.Point(15, 94);
            this.lv_OTStaff.Name = "lv_OTStaff";
            this.lv_OTStaff.Size = new System.Drawing.Size(965, 281);
            this.lv_OTStaff.TabIndex = 5;
            this.lv_OTStaff.UseCompatibleStateImageBehavior = false;
            this.lv_OTStaff.View = System.Windows.Forms.View.Details;
            this.lv_OTStaff.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lv_OTStaff_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 49;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "工号";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "姓名";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "部门";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "加班日期";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "加班类型";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "加班工时";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "开始加班时间";
            this.columnHeader20.Width = 99;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "结束加班时间";
            this.columnHeader21.Width = 96;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "审核状态";
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "加班原因";
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "拒绝原因";
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "本月累计加班小时";
            this.columnHeader25.Width = 116;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "备注";
            // 
            // btn_CheckAllAndOK
            // 
            this.btn_CheckAllAndOK.Location = new System.Drawing.Point(12, 381);
            this.btn_CheckAllAndOK.Name = "btn_CheckAllAndOK";
            this.btn_CheckAllAndOK.Size = new System.Drawing.Size(124, 23);
            this.btn_CheckAllAndOK.TabIndex = 6;
            this.btn_CheckAllAndOK.Text = "全部打钩并通过审核";
            this.btn_CheckAllAndOK.UseVisualStyleBackColor = true;
            this.btn_CheckAllAndOK.Click += new System.EventHandler(this.btn_CheckAllAndOK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "打钩的通过审核";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "打钩的不通过审核";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "不通过审核原因";
            // 
            // cb_NGCause
            // 
            this.cb_NGCause.FormattingEnabled = true;
            this.cb_NGCause.Items.AddRange(new object[] {
            "加班人数过多",
            "加班时间太长",
            "加班申请重复"});
            this.cb_NGCause.Location = new System.Drawing.Point(506, 385);
            this.cb_NGCause.Name = "cb_NGCause";
            this.cb_NGCause.Size = new System.Drawing.Size(121, 20);
            this.cb_NGCause.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "加班人数总计";
            // 
            // label_EmployeeTotal
            // 
            this.label_EmployeeTotal.AutoSize = true;
            this.label_EmployeeTotal.Location = new System.Drawing.Point(726, 389);
            this.label_EmployeeTotal.Name = "label_EmployeeTotal";
            this.label_EmployeeTotal.Size = new System.Drawing.Size(11, 12);
            this.label_EmployeeTotal.TabIndex = 12;
            this.label_EmployeeTotal.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(761, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "加班工时总计";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(844, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "0.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(886, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "月人均加班";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(957, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "0.0";
            // 
            // SectionAcknowledgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_EmployeeTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_NGCause);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_CheckAllAndOK);
            this.Controls.Add(this.lv_OTStaff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_SectionName);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SectionAcknowledgeForm";
            this.Text = "部门确认";
            this.Load += new System.EventHandler(this.SectionAcknowledgeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ComboBox cb_SectionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lv_OTStaff;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btn_CheckAllAndOK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_NGCause;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_EmployeeTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}