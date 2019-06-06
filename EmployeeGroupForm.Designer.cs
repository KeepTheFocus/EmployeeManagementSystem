namespace EmployeeManagementSystem
{
    partial class EmployeeGroupForm
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
            this.tb_GruopName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lv_Section = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cb_All = new System.Windows.Forms.CheckBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lv_Group = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_EmployeeNumber = new System.Windows.Forms.TextBox();
            this.tb_EmployeeName = new System.Windows.Forms.TextBox();
            this.btn_AddManually = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.lbx_SectionName = new System.Windows.Forms.ListBox();
            this.btn_peek = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsl_Create = new System.Windows.Forms.ToolStripLabel();
            this.tsl_store = new System.Windows.Forms.ToolStripLabel();
            this.tsl_Query = new System.Windows.Forms.ToolStripLabel();
            this.tsl_remove = new System.Windows.Forms.ToolStripLabel();
            this.tsl_Cancel = new System.Windows.Forms.ToolStripLabel();
            this.tsl_FirstRecord = new System.Windows.Forms.ToolStripLabel();
            this.tsl_previousRecord = new System.Windows.Forms.ToolStripLabel();
            this.tsl_NextRecord = new System.Windows.Forms.ToolStripLabel();
            this.tsl_EndRecord = new System.Windows.Forms.ToolStripLabel();
            this.rtb_description = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "小组名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "小组说明";
            // 
            // tb_GruopName
            // 
            this.tb_GruopName.Location = new System.Drawing.Point(555, 22);
            this.tb_GruopName.Name = "tb_GruopName";
            this.tb_GruopName.Size = new System.Drawing.Size(171, 21);
            this.tb_GruopName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "部门";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "部门人员列表";
            // 
            // lv_Section
            // 
            this.lv_Section.CheckBoxes = true;
            this.lv_Section.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6});
            this.lv_Section.FullRowSelect = true;
            this.lv_Section.GridLines = true;
            this.lv_Section.Location = new System.Drawing.Point(210, 83);
            this.lv_Section.Name = "lv_Section";
            this.lv_Section.Scrollable = false;
            this.lv_Section.Size = new System.Drawing.Size(235, 244);
            this.lv_Section.TabIndex = 7;
            this.lv_Section.UseCompatibleStateImageBehavior = false;
            this.lv_Section.View = System.Windows.Forms.View.Details;
            this.lv_Section.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lv_Section_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 15;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "工号";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "姓名";
            this.columnHeader6.Width = 168;
            // 
            // cb_All
            // 
            this.cb_All.AutoSize = true;
            this.cb_All.Location = new System.Drawing.Point(210, 354);
            this.cb_All.Name = "cb_All";
            this.cb_All.Size = new System.Drawing.Size(48, 16);
            this.cb_All.TabIndex = 8;
            this.cb_All.Text = "全选";
            this.cb_All.UseVisualStyleBackColor = true;
            this.cb_All.CheckedChanged += new System.EventHandler(this.cb_All_CheckedChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(271, 354);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(174, 23);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "向小组人员列表中添加成员";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "小组人员列表";
            // 
            // lv_Group
            // 
            this.lv_Group.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_Group.FullRowSelect = true;
            this.lv_Group.GridLines = true;
            this.lv_Group.Location = new System.Drawing.Point(553, 138);
            this.lv_Group.Name = "lv_Group";
            this.lv_Group.Size = new System.Drawing.Size(180, 256);
            this.lv_Group.TabIndex = 11;
            this.lv_Group.UseCompatibleStateImageBehavior = false;
            this.lv_Group.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "工号";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "姓名";
            this.columnHeader4.Width = 53;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "部门";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(774, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "手动输入";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(774, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "工号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(774, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "姓名";
            // 
            // tb_EmployeeNumber
            // 
            this.tb_EmployeeNumber.Location = new System.Drawing.Point(809, 114);
            this.tb_EmployeeNumber.Name = "tb_EmployeeNumber";
            this.tb_EmployeeNumber.Size = new System.Drawing.Size(100, 21);
            this.tb_EmployeeNumber.TabIndex = 15;
            this.tb_EmployeeNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_EmployeeName_KeyDown);
            // 
            // tb_EmployeeName
            // 
            this.tb_EmployeeName.Location = new System.Drawing.Point(809, 153);
            this.tb_EmployeeName.Name = "tb_EmployeeName";
            this.tb_EmployeeName.ReadOnly = true;
            this.tb_EmployeeName.Size = new System.Drawing.Size(100, 21);
            this.tb_EmployeeName.TabIndex = 16;
            // 
            // btn_AddManually
            // 
            this.btn_AddManually.Location = new System.Drawing.Point(751, 204);
            this.btn_AddManually.Name = "btn_AddManually";
            this.btn_AddManually.Size = new System.Drawing.Size(170, 23);
            this.btn_AddManually.TabIndex = 17;
            this.btn_AddManually.Text = "手动添加人员进小组人员列表中";
            this.btn_AddManually.UseVisualStyleBackColor = true;
            this.btn_AddManually.Click += new System.EventHandler(this.btn_AddManually_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(553, 432);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(180, 23);
            this.btn_Remove.TabIndex = 18;
            this.btn_Remove.Text = "删除小组人员列表中的成员";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // lbx_SectionName
            // 
            this.lbx_SectionName.FormattingEnabled = true;
            this.lbx_SectionName.ItemHeight = 12;
            this.lbx_SectionName.Location = new System.Drawing.Point(12, 83);
            this.lbx_SectionName.Name = "lbx_SectionName";
            this.lbx_SectionName.Size = new System.Drawing.Size(181, 244);
            this.lbx_SectionName.TabIndex = 19;
            this.lbx_SectionName.SelectedIndexChanged += new System.EventHandler(this.lbx_SectionName_SelectedIndexChanged);
            // 
            // btn_peek
            // 
            this.btn_peek.Location = new System.Drawing.Point(45, 47);
            this.btn_peek.Name = "btn_peek";
            this.btn_peek.Size = new System.Drawing.Size(148, 23);
            this.btn_peek.TabIndex = 20;
            this.btn_peek.Text = "查看当前选中部门的人员";
            this.btn_peek.UseVisualStyleBackColor = true;
            this.btn_peek.Click += new System.EventHandler(this.btn_peek_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_Create,
            this.tsl_store,
            this.tsl_Query,
            this.tsl_remove,
            this.tsl_Cancel,
            this.tsl_FirstRecord,
            this.tsl_previousRecord,
            this.tsl_NextRecord,
            this.tsl_EndRecord});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(921, 25);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "最后一条记录";
            // 
            // tsl_Create
            // 
            this.tsl_Create.Name = "tsl_Create";
            this.tsl_Create.Size = new System.Drawing.Size(56, 22);
            this.tsl_Create.Text = "新建小组";
            this.tsl_Create.Click += new System.EventHandler(this.tsl_Create_Click);
            // 
            // tsl_store
            // 
            this.tsl_store.Name = "tsl_store";
            this.tsl_store.Size = new System.Drawing.Size(56, 22);
            this.tsl_store.Text = "保存小组";
            this.tsl_store.Click += new System.EventHandler(this.tsl_store_Click);
            // 
            // tsl_Query
            // 
            this.tsl_Query.Name = "tsl_Query";
            this.tsl_Query.Size = new System.Drawing.Size(80, 22);
            this.tsl_Query.Text = "查找小组员工";
            this.tsl_Query.Click += new System.EventHandler(this.tsl_Query_Click);
            // 
            // tsl_remove
            // 
            this.tsl_remove.Name = "tsl_remove";
            this.tsl_remove.Size = new System.Drawing.Size(56, 22);
            this.tsl_remove.Text = "删除小组";
            this.tsl_remove.Click += new System.EventHandler(this.tsl_remove_Click);
            // 
            // tsl_Cancel
            // 
            this.tsl_Cancel.Name = "tsl_Cancel";
            this.tsl_Cancel.Size = new System.Drawing.Size(32, 22);
            this.tsl_Cancel.Text = "取消";
            // 
            // tsl_FirstRecord
            // 
            this.tsl_FirstRecord.Name = "tsl_FirstRecord";
            this.tsl_FirstRecord.Size = new System.Drawing.Size(68, 22);
            this.tsl_FirstRecord.Text = "第一个小组";
            this.tsl_FirstRecord.Click += new System.EventHandler(this.tsl_FirstRecord_Click);
            // 
            // tsl_previousRecord
            // 
            this.tsl_previousRecord.Name = "tsl_previousRecord";
            this.tsl_previousRecord.Size = new System.Drawing.Size(68, 22);
            this.tsl_previousRecord.Text = "上一个小组";
            this.tsl_previousRecord.Click += new System.EventHandler(this.tsl_previousRecord_Click);
            // 
            // tsl_NextRecord
            // 
            this.tsl_NextRecord.Name = "tsl_NextRecord";
            this.tsl_NextRecord.Size = new System.Drawing.Size(68, 22);
            this.tsl_NextRecord.Text = "下一个小组";
            this.tsl_NextRecord.Click += new System.EventHandler(this.tsl_NextRecord_Click);
            // 
            // tsl_EndRecord
            // 
            this.tsl_EndRecord.Name = "tsl_EndRecord";
            this.tsl_EndRecord.Size = new System.Drawing.Size(80, 22);
            this.tsl_EndRecord.Text = "最后一个小组";
            this.tsl_EndRecord.Click += new System.EventHandler(this.tsl_EndRecord_Click);
            // 
            // rtb_description
            // 
            this.rtb_description.Location = new System.Drawing.Point(553, 58);
            this.rtb_description.Name = "rtb_description";
            this.rtb_description.Size = new System.Drawing.Size(173, 38);
            this.rtb_description.TabIndex = 1;
            this.rtb_description.Text = "";
            // 
            // EmployeeGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 758);
            this.Controls.Add(this.rtb_description);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_peek);
            this.Controls.Add(this.lbx_SectionName);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_AddManually);
            this.Controls.Add(this.tb_EmployeeName);
            this.Controls.Add(this.tb_EmployeeNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lv_Group);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cb_All);
            this.Controls.Add(this.lv_Section);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_GruopName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeGroupForm";
            this.Text = "员工分组";
            this.Load += new System.EventHandler(this.EmployeeGroupForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_GruopName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lv_Section;
        private System.Windows.Forms.CheckBox cb_All;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lv_Group;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_EmployeeNumber;
        private System.Windows.Forms.TextBox tb_EmployeeName;
        private System.Windows.Forms.Button btn_AddManually;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListBox lbx_SectionName;
        private System.Windows.Forms.Button btn_peek;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsl_Create;
        private System.Windows.Forms.ToolStripLabel tsl_store;
        private System.Windows.Forms.ToolStripLabel tsl_Query;
        private System.Windows.Forms.ToolStripLabel tsl_remove;
        private System.Windows.Forms.ToolStripLabel tsl_Cancel;
        private System.Windows.Forms.ToolStripLabel tsl_FirstRecord;
        private System.Windows.Forms.ToolStripLabel tsl_previousRecord;
        private System.Windows.Forms.ToolStripLabel tsl_NextRecord;
        private System.Windows.Forms.ToolStripLabel tsl_EndRecord;
        private System.Windows.Forms.RichTextBox rtb_description;
    }
}