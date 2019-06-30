namespace EmployeeManagementSystem
{
    partial class CEOAcknowledgeForm
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
            this.lv_OTEmployee = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_AllPass = new System.Windows.Forms.Button();
            this.btn_TheCheckedPass = new System.Windows.Forms.Button();
            this.btn_TheCheckedRefuse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_RefuseCause = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_TotalEmployee = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "部门";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(73, 12);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 21);
            this.dtp_date.TabIndex = 2;
            this.dtp_date.ValueChanged += new System.EventHandler(this.dtp_date_ValueChanged);
            // 
            // cb_SectionName
            // 
            this.cb_SectionName.FormattingEnabled = true;
            this.cb_SectionName.Location = new System.Drawing.Point(337, 12);
            this.cb_SectionName.Name = "cb_SectionName";
            this.cb_SectionName.Size = new System.Drawing.Size(121, 20);
            this.cb_SectionName.TabIndex = 3;
            this.cb_SectionName.TextChanged += new System.EventHandler(this.cb_SectionName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "加班人员列表";
            // 
            // lv_OTEmployee
            // 
            this.lv_OTEmployee.CheckBoxes = true;
            this.lv_OTEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.lv_OTEmployee.FullRowSelect = true;
            this.lv_OTEmployee.GridLines = true;
            this.lv_OTEmployee.Location = new System.Drawing.Point(3, 109);
            this.lv_OTEmployee.Name = "lv_OTEmployee";
            this.lv_OTEmployee.Size = new System.Drawing.Size(1245, 274);
            this.lv_OTEmployee.TabIndex = 5;
            this.lv_OTEmployee.UseCompatibleStateImageBehavior = false;
            this.lv_OTEmployee.View = System.Windows.Forms.View.Details;
            this.lv_OTEmployee.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lv_OTEmployee_ItemChecked);
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "员工工号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "员工姓名";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "部门";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "加班日期";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "加班类型";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "加班工时";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "加班开始时间";
            this.columnHeader7.Width = 97;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "加班结束时间";
            this.columnHeader8.Width = 98;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "审核状态";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "加班原因";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "拒绝原因";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "本月已加班时长";
            this.columnHeader12.Width = 101;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "备注";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "总经理审核状态";
            this.columnHeader14.Width = 104;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "总经理拒绝原因";
            this.columnHeader15.Width = 96;
            // 
            // btn_AllPass
            // 
            this.btn_AllPass.Location = new System.Drawing.Point(3, 390);
            this.btn_AllPass.Name = "btn_AllPass";
            this.btn_AllPass.Size = new System.Drawing.Size(132, 23);
            this.btn_AllPass.TabIndex = 6;
            this.btn_AllPass.Text = "全部打钩并审核通过";
            this.btn_AllPass.UseVisualStyleBackColor = true;
            this.btn_AllPass.Click += new System.EventHandler(this.btn_AllPass_Click);
            // 
            // btn_TheCheckedPass
            // 
            this.btn_TheCheckedPass.Location = new System.Drawing.Point(150, 390);
            this.btn_TheCheckedPass.Name = "btn_TheCheckedPass";
            this.btn_TheCheckedPass.Size = new System.Drawing.Size(123, 23);
            this.btn_TheCheckedPass.TabIndex = 7;
            this.btn_TheCheckedPass.Text = "打钩的员工通过审核";
            this.btn_TheCheckedPass.UseVisualStyleBackColor = true;
            this.btn_TheCheckedPass.Click += new System.EventHandler(this.btn_TheCheckedPass_Click);
            // 
            // btn_TheCheckedRefuse
            // 
            this.btn_TheCheckedRefuse.Location = new System.Drawing.Point(279, 389);
            this.btn_TheCheckedRefuse.Name = "btn_TheCheckedRefuse";
            this.btn_TheCheckedRefuse.Size = new System.Drawing.Size(100, 23);
            this.btn_TheCheckedRefuse.TabIndex = 8;
            this.btn_TheCheckedRefuse.Text = "打钩的拒绝通过";
            this.btn_TheCheckedRefuse.UseVisualStyleBackColor = true;
            this.btn_TheCheckedRefuse.Click += new System.EventHandler(this.btn_TheCheckedRefuse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "拒绝原因";
            // 
            // cb_RefuseCause
            // 
            this.cb_RefuseCause.FormattingEnabled = true;
            this.cb_RefuseCause.Items.AddRange(new object[] {
            "加班人数过多",
            "加班时间过长",
            "加班记录重复"});
            this.cb_RefuseCause.Location = new System.Drawing.Point(492, 392);
            this.cb_RefuseCause.Name = "cb_RefuseCause";
            this.cb_RefuseCause.Size = new System.Drawing.Size(121, 20);
            this.cb_RefuseCause.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(645, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "加班人数";
            // 
            // label_TotalEmployee
            // 
            this.label_TotalEmployee.AutoSize = true;
            this.label_TotalEmployee.Location = new System.Drawing.Point(717, 401);
            this.label_TotalEmployee.Name = "label_TotalEmployee";
            this.label_TotalEmployee.Size = new System.Drawing.Size(11, 12);
            this.label_TotalEmployee.TabIndex = 12;
            this.label_TotalEmployee.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(749, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "加班小时累计";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(832, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(861, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "月人均累计加班小时";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(991, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "0";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CEOAcknowledgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 745);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_TotalEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_RefuseCause);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_TheCheckedRefuse);
            this.Controls.Add(this.btn_TheCheckedPass);
            this.Controls.Add(this.btn_AllPass);
            this.Controls.Add(this.lv_OTEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_SectionName);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CEOAcknowledgeForm";
            this.Text = "总经理确认";
            this.Load += new System.EventHandler(this.CEOAcknowledgeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ComboBox cb_SectionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lv_OTEmployee;
        private System.Windows.Forms.Button btn_AllPass;
        private System.Windows.Forms.Button btn_TheCheckedPass;
        private System.Windows.Forms.Button btn_TheCheckedRefuse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_RefuseCause;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_TotalEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
    }
}