namespace EmployeeManagementSystem
{
    partial class DutyForm
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
            this.textBox_dutyCode = new System.Windows.Forms.TextBox();
            this.textBox_dutyName = new System.Windows.Forms.TextBox();
            this.button_saveDuty = new System.Windows.Forms.Button();
            this.button_escDuty = new System.Windows.Forms.Button();
            this.listView_Duty = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "职务代码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "职务名称";
            // 
            // textBox_dutyCode
            // 
            this.textBox_dutyCode.Location = new System.Drawing.Point(192, 65);
            this.textBox_dutyCode.Name = "textBox_dutyCode";
            this.textBox_dutyCode.Size = new System.Drawing.Size(100, 21);
            this.textBox_dutyCode.TabIndex = 0;
            // 
            // textBox_dutyName
            // 
            this.textBox_dutyName.Location = new System.Drawing.Point(192, 145);
            this.textBox_dutyName.Name = "textBox_dutyName";
            this.textBox_dutyName.Size = new System.Drawing.Size(100, 21);
            this.textBox_dutyName.TabIndex = 1;
            // 
            // button_saveDuty
            // 
            this.button_saveDuty.Location = new System.Drawing.Point(376, 65);
            this.button_saveDuty.Name = "button_saveDuty";
            this.button_saveDuty.Size = new System.Drawing.Size(75, 23);
            this.button_saveDuty.TabIndex = 2;
            this.button_saveDuty.Text = "保存";
            this.button_saveDuty.UseVisualStyleBackColor = true;
            this.button_saveDuty.Click += new System.EventHandler(this.button_saveDuty_Click);
            // 
            // button_escDuty
            // 
            this.button_escDuty.Location = new System.Drawing.Point(376, 143);
            this.button_escDuty.Name = "button_escDuty";
            this.button_escDuty.Size = new System.Drawing.Size(75, 23);
            this.button_escDuty.TabIndex = 3;
            this.button_escDuty.Text = "退出";
            this.button_escDuty.UseVisualStyleBackColor = true;
            this.button_escDuty.Click += new System.EventHandler(this.button_escDuty_Click);
            // 
            // listView_Duty
            // 
            this.listView_Duty.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_Duty.FullRowSelect = true;
            this.listView_Duty.GridLines = true;
            this.listView_Duty.Location = new System.Drawing.Point(88, 185);
            this.listView_Duty.Name = "listView_Duty";
            this.listView_Duty.Scrollable = false;
            this.listView_Duty.Size = new System.Drawing.Size(363, 242);
            this.listView_Duty.TabIndex = 6;
            this.listView_Duty.UseCompatibleStateImageBehavior = false;
            this.listView_Duty.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "职务代码";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "职务名称";
            this.columnHeader2.Width = 316;
            // 
            // DutyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.listView_Duty);
            this.Controls.Add(this.button_escDuty);
            this.Controls.Add(this.button_saveDuty);
            this.Controls.Add(this.textBox_dutyName);
            this.Controls.Add(this.textBox_dutyCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DutyForm";
            this.Text = "新增职务";
            this.Load += new System.EventHandler(this.DutyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_dutyCode;
        private System.Windows.Forms.TextBox textBox_dutyName;
        private System.Windows.Forms.Button button_saveDuty;
        private System.Windows.Forms.Button button_escDuty;
        private System.Windows.Forms.ListView listView_Duty;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}