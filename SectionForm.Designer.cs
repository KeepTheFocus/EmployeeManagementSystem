namespace EmployeeManagementSystem
{
    partial class SectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SectionName = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SectionCode = new System.Windows.Forms.TextBox();
            this.button_Esc = new System.Windows.Forms.Button();
            this.listView_section = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "部门名称:";
            // 
            // textBox_SectionName
            // 
            this.textBox_SectionName.Location = new System.Drawing.Point(381, 111);
            this.textBox_SectionName.Name = "textBox_SectionName";
            this.textBox_SectionName.Size = new System.Drawing.Size(170, 21);
            this.textBox_SectionName.TabIndex = 1;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(767, 57);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(227, 23);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "保存";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "部门代码:";
            // 
            // textBox_SectionCode
            // 
            this.textBox_SectionCode.Location = new System.Drawing.Point(381, 54);
            this.textBox_SectionCode.Name = "textBox_SectionCode";
            this.textBox_SectionCode.Size = new System.Drawing.Size(170, 21);
            this.textBox_SectionCode.TabIndex = 0;
            // 
            // button_Esc
            // 
            this.button_Esc.Location = new System.Drawing.Point(767, 109);
            this.button_Esc.Name = "button_Esc";
            this.button_Esc.Size = new System.Drawing.Size(227, 23);
            this.button_Esc.TabIndex = 3;
            this.button_Esc.Text = "退出";
            this.button_Esc.UseVisualStyleBackColor = true;
            this.button_Esc.Click += new System.EventHandler(this.button_Esc_Click);
            // 
            // listView_section
            // 
            this.listView_section.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_section.FullRowSelect = true;
            this.listView_section.GridLines = true;
            this.listView_section.Location = new System.Drawing.Point(250, 210);
            this.listView_section.Name = "listView_section";
            this.listView_section.Scrollable = false;
            this.listView_section.Size = new System.Drawing.Size(526, 241);
            this.listView_section.TabIndex = 8;
            this.listView_section.UseCompatibleStateImageBehavior = false;
            this.listView_section.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "部门代码";
            this.columnHeader1.Width = 282;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "部门名称";
            this.columnHeader2.Width = 361;
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 628);
            this.Controls.Add(this.listView_section);
            this.Controls.Add(this.button_Esc);
            this.Controls.Add(this.textBox_SectionCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_SectionName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SectionForm";
            this.Text = "新建部门";
            this.Load += new System.EventHandler(this.SectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SectionName;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SectionCode;
        private System.Windows.Forms.Button button_Esc;
        private System.Windows.Forms.ListView listView_section;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}