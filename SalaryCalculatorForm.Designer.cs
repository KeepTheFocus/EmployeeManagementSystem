namespace EmployeeManagementSystem
{
    partial class SalaryCalculatorForm
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
            this.tb_EmployeeNumber = new System.Windows.Forms.TextBox();
            this.tb_EmployeeNumber2 = new System.Windows.Forms.TextBox();
            this.tb_YearMonth = new System.Windows.Forms.TextBox();
            this.tb_SectionName = new System.Windows.Forms.TextBox();
            this.tb_YearMonth2 = new System.Windows.Forms.TextBox();
            this.tb_SectionName2 = new System.Windows.Forms.TextBox();
            this.btn_count = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_2Excel = new System.Windows.Forms.Button();
            this.btn_Esc = new System.Windows.Forms.Button();
            this.listView_CountResult = new System.Windows.Forms.ListView();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "年月编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "部    门";
            // 
            // tb_EmployeeNumber
            // 
            this.tb_EmployeeNumber.Location = new System.Drawing.Point(171, 104);
            this.tb_EmployeeNumber.Name = "tb_EmployeeNumber";
            this.tb_EmployeeNumber.Size = new System.Drawing.Size(182, 21);
            this.tb_EmployeeNumber.TabIndex = 0;
            // 
            // tb_EmployeeNumber2
            // 
            this.tb_EmployeeNumber2.Location = new System.Drawing.Point(498, 101);
            this.tb_EmployeeNumber2.Name = "tb_EmployeeNumber2";
            this.tb_EmployeeNumber2.Size = new System.Drawing.Size(235, 21);
            this.tb_EmployeeNumber2.TabIndex = 1;
            // 
            // tb_YearMonth
            // 
            this.tb_YearMonth.Location = new System.Drawing.Point(171, 192);
            this.tb_YearMonth.Name = "tb_YearMonth";
            this.tb_YearMonth.Size = new System.Drawing.Size(182, 21);
            this.tb_YearMonth.TabIndex = 2;
            // 
            // tb_SectionName
            // 
            this.tb_SectionName.Location = new System.Drawing.Point(171, 264);
            this.tb_SectionName.Name = "tb_SectionName";
            this.tb_SectionName.Size = new System.Drawing.Size(182, 21);
            this.tb_SectionName.TabIndex = 4;
            // 
            // tb_YearMonth2
            // 
            this.tb_YearMonth2.Location = new System.Drawing.Point(498, 192);
            this.tb_YearMonth2.Name = "tb_YearMonth2";
            this.tb_YearMonth2.Size = new System.Drawing.Size(235, 21);
            this.tb_YearMonth2.TabIndex = 3;
            // 
            // tb_SectionName2
            // 
            this.tb_SectionName2.Location = new System.Drawing.Point(498, 266);
            this.tb_SectionName2.Name = "tb_SectionName2";
            this.tb_SectionName2.Size = new System.Drawing.Size(235, 21);
            this.tb_SectionName2.TabIndex = 5;
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(811, 99);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(341, 23);
            this.btn_count.TabIndex = 6;
            this.btn_count.Text = "计算";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(811, 184);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(341, 23);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "查找";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(811, 256);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(341, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_2Excel
            // 
            this.btn_2Excel.Location = new System.Drawing.Point(811, 324);
            this.btn_2Excel.Name = "btn_2Excel";
            this.btn_2Excel.Size = new System.Drawing.Size(341, 23);
            this.btn_2Excel.TabIndex = 9;
            this.btn_2Excel.Text = "导出";
            this.btn_2Excel.UseVisualStyleBackColor = true;
            this.btn_2Excel.Click += new System.EventHandler(this.btn_2Excel_Click);
            // 
            // btn_Esc
            // 
            this.btn_Esc.Location = new System.Drawing.Point(811, 398);
            this.btn_Esc.Name = "btn_Esc";
            this.btn_Esc.Size = new System.Drawing.Size(341, 23);
            this.btn_Esc.TabIndex = 10;
            this.btn_Esc.Text = "退出";
            this.btn_Esc.UseVisualStyleBackColor = true;
            this.btn_Esc.Click += new System.EventHandler(this.button5_Click);
            // 
            // listView_CountResult
            // 
            this.listView_CountResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView_CountResult.FullRowSelect = true;
            this.listView_CountResult.GridLines = true;
            this.listView_CountResult.Location = new System.Drawing.Point(60, 324);
            this.listView_CountResult.Name = "listView_CountResult";
            this.listView_CountResult.Size = new System.Drawing.Size(673, 97);
            this.listView_CountResult.TabIndex = 14;
            this.listView_CountResult.UseCompatibleStateImageBehavior = false;
            this.listView_CountResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "员工编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "员工姓名";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "年月编号";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "基本工资";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "全勤奖";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "职务津贴";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "住宿补贴";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "餐费补贴";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "加班费";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "应发工资";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(205, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(589, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "To";
            // 
            // SalaryCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 628);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView_CountResult);
            this.Controls.Add(this.btn_Esc);
            this.Controls.Add(this.btn_2Excel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.tb_SectionName2);
            this.Controls.Add(this.tb_YearMonth2);
            this.Controls.Add(this.tb_SectionName);
            this.Controls.Add(this.tb_YearMonth);
            this.Controls.Add(this.tb_EmployeeNumber2);
            this.Controls.Add(this.tb_EmployeeNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalaryCalculatorForm";
            this.Text = "工资计算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_EmployeeNumber;
        private System.Windows.Forms.TextBox tb_EmployeeNumber2;
        private System.Windows.Forms.TextBox tb_YearMonth;
        private System.Windows.Forms.TextBox tb_SectionName;
        private System.Windows.Forms.TextBox tb_YearMonth2;
        private System.Windows.Forms.TextBox tb_SectionName2;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_2Excel;
        private System.Windows.Forms.Button btn_Esc;
        private System.Windows.Forms.ListView listView_CountResult;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}