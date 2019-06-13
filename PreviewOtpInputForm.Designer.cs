namespace EmployeeManagementSystem
{
    partial class PreviewOtpInputForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsl_lookup = new System.Windows.Forms.ToolStripLabel();
            this.tsl_remove = new System.Windows.Forms.ToolStripLabel();
            this.tsl_FirstEmployee = new System.Windows.Forms.ToolStripLabel();
            this.tsl_previousEmployee = new System.Windows.Forms.ToolStripLabel();
            this.tsl_nextEmployee = new System.Windows.Forms.ToolStripLabel();
            this.tsl_EndEmployee = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_OTDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_EmployeeNumber = new System.Windows.Forms.TextBox();
            this.tb_EmployeeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_OTStart = new System.Windows.Forms.DateTimePicker();
            this.dtp_OTStop = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_OTLength = new System.Windows.Forms.TextBox();
            this.cb_OTCause = new System.Windows.Forms.ComboBox();
            this.cb_OTType = new System.Windows.Forms.ComboBox();
            this.rtb_OTCause = new System.Windows.Forms.RichTextBox();
            this.btn_Embed = new System.Windows.Forms.Button();
            this.btn_Lookup = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox_GroupName = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listView_Group = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.lv_previewOT = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox_previewOTWholeMember = new System.Windows.Forms.CheckBox();
            this.checkBox_WholeGroupMember = new System.Windows.Forms.CheckBox();
            this.checkBox_Manually = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_SectionNmae = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label_totalCount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtp_LookupOTHistory = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_lookup,
            this.tsl_remove,
            this.tsl_FirstEmployee,
            this.tsl_previousEmployee,
            this.tsl_nextEmployee,
            this.tsl_EndEmployee});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(785, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsl_lookup
            // 
            this.tsl_lookup.Name = "tsl_lookup";
            this.tsl_lookup.Size = new System.Drawing.Size(32, 22);
            this.tsl_lookup.Text = "查找";
            this.tsl_lookup.Click += new System.EventHandler(this.tsl_lookup_Click);
            // 
            // tsl_remove
            // 
            this.tsl_remove.Name = "tsl_remove";
            this.tsl_remove.Size = new System.Drawing.Size(32, 22);
            this.tsl_remove.Text = "删除";
            this.tsl_remove.Click += new System.EventHandler(this.tsl_remove_Click);
            // 
            // tsl_FirstEmployee
            // 
            this.tsl_FirstEmployee.Name = "tsl_FirstEmployee";
            this.tsl_FirstEmployee.Size = new System.Drawing.Size(128, 22);
            this.tsl_FirstEmployee.Text = "加班表中的第一个员工";
            // 
            // tsl_previousEmployee
            // 
            this.tsl_previousEmployee.Name = "tsl_previousEmployee";
            this.tsl_previousEmployee.Size = new System.Drawing.Size(120, 22);
            this.tsl_previousEmployee.Text = "加班表中上一个员工";
            // 
            // tsl_nextEmployee
            // 
            this.tsl_nextEmployee.Name = "tsl_nextEmployee";
            this.tsl_nextEmployee.Size = new System.Drawing.Size(116, 22);
            this.tsl_nextEmployee.Text = "加班表中下一个员工";
            // 
            // tsl_EndEmployee
            // 
            this.tsl_EndEmployee.Name = "tsl_EndEmployee";
            this.tsl_EndEmployee.Size = new System.Drawing.Size(128, 22);
            this.tsl_EndEmployee.Text = "加班表中最后一个员工";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "加班日期";
            // 
            // dtp_OTDate
            // 
            this.dtp_OTDate.Location = new System.Drawing.Point(437, 173);
            this.dtp_OTDate.Name = "dtp_OTDate";
            this.dtp_OTDate.Size = new System.Drawing.Size(251, 21);
            this.dtp_OTDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "员工工号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "员工姓名";
            // 
            // tb_EmployeeNumber
            // 
            this.tb_EmployeeNumber.Location = new System.Drawing.Point(522, 70);
            this.tb_EmployeeNumber.Name = "tb_EmployeeNumber";
            this.tb_EmployeeNumber.Size = new System.Drawing.Size(100, 21);
            this.tb_EmployeeNumber.TabIndex = 5;
            this.tb_EmployeeNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_EmployeeNumber_KeyDown);
            // 
            // tb_EmployeeName
            // 
            this.tb_EmployeeName.Location = new System.Drawing.Point(522, 104);
            this.tb_EmployeeName.Name = "tb_EmployeeName";
            this.tb_EmployeeName.ReadOnly = true;
            this.tb_EmployeeName.Size = new System.Drawing.Size(100, 21);
            this.tb_EmployeeName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "加班开始时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "加班结束时间";
            // 
            // dtp_OTStart
            // 
            this.dtp_OTStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_OTStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_OTStart.Location = new System.Drawing.Point(437, 211);
            this.dtp_OTStart.Name = "dtp_OTStart";
            this.dtp_OTStart.Size = new System.Drawing.Size(251, 21);
            this.dtp_OTStart.TabIndex = 9;
            // 
            // dtp_OTStop
            // 
            this.dtp_OTStop.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_OTStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_OTStop.Location = new System.Drawing.Point(437, 246);
            this.dtp_OTStop.Name = "dtp_OTStop";
            this.dtp_OTStop.Size = new System.Drawing.Size(251, 21);
            this.dtp_OTStop.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "加班工时";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "加班原因";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "加班类别";
            // 
            // tb_OTLength
            // 
            this.tb_OTLength.Location = new System.Drawing.Point(437, 282);
            this.tb_OTLength.Name = "tb_OTLength";
            this.tb_OTLength.ReadOnly = true;
            this.tb_OTLength.Size = new System.Drawing.Size(251, 21);
            this.tb_OTLength.TabIndex = 14;
            this.tb_OTLength.Click += new System.EventHandler(this.tb_OTLength_Click);
            this.tb_OTLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_OTLength_KeyDown);
            // 
            // cb_OTCause
            // 
            this.cb_OTCause.FormattingEnabled = true;
            this.cb_OTCause.Location = new System.Drawing.Point(439, 314);
            this.cb_OTCause.Name = "cb_OTCause";
            this.cb_OTCause.Size = new System.Drawing.Size(249, 20);
            this.cb_OTCause.TabIndex = 15;
            this.cb_OTCause.SelectedIndexChanged += new System.EventHandler(this.cb_OTCause_SelectedIndexChanged);
            // 
            // cb_OTType
            // 
            this.cb_OTType.FormattingEnabled = true;
            this.cb_OTType.Items.AddRange(new object[] {
            "工作日加班",
            "节假日加班",
            "法定节假日加班"});
            this.cb_OTType.Location = new System.Drawing.Point(439, 388);
            this.cb_OTType.Name = "cb_OTType";
            this.cb_OTType.Size = new System.Drawing.Size(249, 20);
            this.cb_OTType.TabIndex = 16;
            // 
            // rtb_OTCause
            // 
            this.rtb_OTCause.Location = new System.Drawing.Point(439, 340);
            this.rtb_OTCause.Name = "rtb_OTCause";
            this.rtb_OTCause.ReadOnly = true;
            this.rtb_OTCause.Size = new System.Drawing.Size(249, 32);
            this.rtb_OTCause.TabIndex = 17;
            this.rtb_OTCause.Text = "";
            // 
            // btn_Embed
            // 
            this.btn_Embed.Location = new System.Drawing.Point(294, 421);
            this.btn_Embed.Name = "btn_Embed";
            this.btn_Embed.Size = new System.Drawing.Size(182, 23);
            this.btn_Embed.TabIndex = 18;
            this.btn_Embed.Text = "向预计加班人员列表中添加";
            this.btn_Embed.UseVisualStyleBackColor = true;
            this.btn_Embed.Click += new System.EventHandler(this.btn_Embed_Click);
            // 
            // btn_Lookup
            // 
            this.btn_Lookup.Location = new System.Drawing.Point(482, 421);
            this.btn_Lookup.Name = "btn_Lookup";
            this.btn_Lookup.Size = new System.Drawing.Size(206, 23);
            this.btn_Lookup.TabIndex = 19;
            this.btn_Lookup.Text = "查看预计加班人员列表中所有成员";
            this.btn_Lookup.UseVisualStyleBackColor = true;
            this.btn_Lookup.Click += new System.EventHandler(this.btn_Lookup_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "组名框";
            // 
            // listBox_GroupName
            // 
            this.listBox_GroupName.FormattingEnabled = true;
            this.listBox_GroupName.ItemHeight = 12;
            this.listBox_GroupName.Location = new System.Drawing.Point(15, 118);
            this.listBox_GroupName.Name = "listBox_GroupName";
            this.listBox_GroupName.Size = new System.Drawing.Size(117, 244);
            this.listBox_GroupName.TabIndex = 21;
            this.listBox_GroupName.SelectedIndexChanged += new System.EventHandler(this.listBox_GroupName_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "组成员列表";
            // 
            // listView_Group
            // 
            this.listView_Group.CheckBoxes = true;
            this.listView_Group.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView_Group.FullRowSelect = true;
            this.listView_Group.GridLines = true;
            this.listView_Group.Location = new System.Drawing.Point(161, 119);
            this.listView_Group.Name = "listView_Group";
            this.listView_Group.Size = new System.Drawing.Size(164, 243);
            this.listView_Group.TabIndex = 23;
            this.listView_Group.UseCompatibleStateImageBehavior = false;
            this.listView_Group.View = System.Windows.Forms.View.Details;
            this.listView_Group.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_Group_ItemChecked);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.Width = 41;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "工号";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "姓名";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "部门";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 463);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "预计加班人员列表";
            // 
            // lv_previewOT
            // 
            this.lv_previewOT.CheckBoxes = true;
            this.lv_previewOT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lv_previewOT.Cursor = System.Windows.Forms.Cursors.Default;
            this.lv_previewOT.FullRowSelect = true;
            this.lv_previewOT.GridLines = true;
            this.lv_previewOT.Location = new System.Drawing.Point(12, 485);
            this.lv_previewOT.Name = "lv_previewOT";
            this.lv_previewOT.Size = new System.Drawing.Size(676, 204);
            this.lv_previewOT.TabIndex = 26;
            this.lv_previewOT.UseCompatibleStateImageBehavior = false;
            this.lv_previewOT.View = System.Windows.Forms.View.Details;
            this.lv_previewOT.ItemActivate += new System.EventHandler(this.lv_previewOT_ItemActivate);
            this.lv_previewOT.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lv_previewOT_ItemCheck);
            this.lv_previewOT.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lv_previewOT_ItemChecked);
            this.lv_previewOT.SelectedIndexChanged += new System.EventHandler(this.lv_previewOT_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "工号";
            this.columnHeader2.Width = 56;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "姓名";
            this.columnHeader3.Width = 53;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "部门";
            this.columnHeader8.Width = 72;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "加班日期";
            this.columnHeader9.Width = 74;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "加班类型";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "加班工时";
            this.columnHeader11.Width = 79;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "加班开始时间";
            this.columnHeader12.Width = 99;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "加班结束时间";
            this.columnHeader13.Width = 167;
            // 
            // checkBox_previewOTWholeMember
            // 
            this.checkBox_previewOTWholeMember.AutoSize = true;
            this.checkBox_previewOTWholeMember.Location = new System.Drawing.Point(147, 462);
            this.checkBox_previewOTWholeMember.Name = "checkBox_previewOTWholeMember";
            this.checkBox_previewOTWholeMember.Size = new System.Drawing.Size(168, 16);
            this.checkBox_previewOTWholeMember.TabIndex = 27;
            this.checkBox_previewOTWholeMember.Text = "全选预计加班列表所有人员";
            this.checkBox_previewOTWholeMember.UseVisualStyleBackColor = true;
            this.checkBox_previewOTWholeMember.CheckedChanged += new System.EventHandler(this.checkBox_previewOTWholeMember_CheckedChanged);
            // 
            // checkBox_WholeGroupMember
            // 
            this.checkBox_WholeGroupMember.AutoSize = true;
            this.checkBox_WholeGroupMember.Location = new System.Drawing.Point(161, 368);
            this.checkBox_WholeGroupMember.Name = "checkBox_WholeGroupMember";
            this.checkBox_WholeGroupMember.Size = new System.Drawing.Size(108, 16);
            this.checkBox_WholeGroupMember.TabIndex = 28;
            this.checkBox_WholeGroupMember.Text = "全选组列表成员";
            this.checkBox_WholeGroupMember.UseVisualStyleBackColor = true;
            this.checkBox_WholeGroupMember.CheckedChanged += new System.EventHandler(this.checkBox_WholeGroupMember_CheckedChanged);
            // 
            // checkBox_Manually
            // 
            this.checkBox_Manually.AutoSize = true;
            this.checkBox_Manually.Location = new System.Drawing.Point(465, 28);
            this.checkBox_Manually.Name = "checkBox_Manually";
            this.checkBox_Manually.Size = new System.Drawing.Size(108, 16);
            this.checkBox_Manually.TabIndex = 29;
            this.checkBox_Manually.Text = "手工录入加班单";
            this.checkBox_Manually.UseVisualStyleBackColor = true;
            this.checkBox_Manually.CheckedChanged += new System.EventHandler(this.checkBox_Manually_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 30;
            this.label11.Text = "部门";
            // 
            // tb_SectionNmae
            // 
            this.tb_SectionNmae.Location = new System.Drawing.Point(522, 133);
            this.tb_SectionNmae.Name = "tb_SectionNmae";
            this.tb_SectionNmae.ReadOnly = true;
            this.tb_SectionNmae.Size = new System.Drawing.Size(100, 21);
            this.tb_SectionNmae.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(444, 465);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 12);
            this.label13.TabIndex = 32;
            this.label13.Text = "当前预计加班人数";
            // 
            // label_totalCount
            // 
            this.label_totalCount.AutoSize = true;
            this.label_totalCount.Location = new System.Drawing.Point(572, 465);
            this.label_totalCount.Name = "label_totalCount";
            this.label_totalCount.Size = new System.Drawing.Size(0, 12);
            this.label_totalCount.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 34;
            this.label14.Text = "查看加班历史";
            // 
            // dtp_LookupOTHistory
            // 
            this.dtp_LookupOTHistory.Location = new System.Drawing.Point(102, 38);
            this.dtp_LookupOTHistory.Name = "dtp_LookupOTHistory";
            this.dtp_LookupOTHistory.Size = new System.Drawing.Size(200, 21);
            this.dtp_LookupOTHistory.TabIndex = 35;
            this.dtp_LookupOTHistory.CloseUp += new System.EventHandler(this.dtp_LookupOTHistory_CloseUp);
            // 
            // PreviewOtpInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 692);
            this.Controls.Add(this.dtp_LookupOTHistory);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label_totalCount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_SectionNmae);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkBox_Manually);
            this.Controls.Add(this.checkBox_WholeGroupMember);
            this.Controls.Add(this.checkBox_previewOTWholeMember);
            this.Controls.Add(this.lv_previewOT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listView_Group);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox_GroupName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Lookup);
            this.Controls.Add(this.btn_Embed);
            this.Controls.Add(this.rtb_OTCause);
            this.Controls.Add(this.cb_OTType);
            this.Controls.Add(this.cb_OTCause);
            this.Controls.Add(this.tb_OTLength);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_OTStop);
            this.Controls.Add(this.dtp_OTStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_EmployeeName);
            this.Controls.Add(this.tb_EmployeeNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_OTDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PreviewOtpInputForm";
            this.Text = "预计加班单录入";
            this.Load += new System.EventHandler(this.PreviewOtpInputForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsl_lookup;
        private System.Windows.Forms.ToolStripLabel tsl_remove;
        private System.Windows.Forms.ToolStripLabel tsl_FirstEmployee;
        private System.Windows.Forms.ToolStripLabel tsl_previousEmployee;
        private System.Windows.Forms.ToolStripLabel tsl_nextEmployee;
        private System.Windows.Forms.ToolStripLabel tsl_EndEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_OTDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_EmployeeNumber;
        private System.Windows.Forms.TextBox tb_EmployeeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_OTStart;
        private System.Windows.Forms.DateTimePicker dtp_OTStop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_OTLength;
        private System.Windows.Forms.ComboBox cb_OTCause;
        private System.Windows.Forms.ComboBox cb_OTType;
        private System.Windows.Forms.RichTextBox rtb_OTCause;
        private System.Windows.Forms.Button btn_Embed;
        private System.Windows.Forms.Button btn_Lookup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox_GroupName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView_Group;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView lv_previewOT;
        private System.Windows.Forms.CheckBox checkBox_previewOTWholeMember;
        private System.Windows.Forms.CheckBox checkBox_WholeGroupMember;
        private System.Windows.Forms.CheckBox checkBox_Manually;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_SectionNmae;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_totalCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtp_LookupOTHistory;
    }
}