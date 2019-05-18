namespace EmployeeManagementSystem
{
    partial class ImportEmployee2SqlForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_selectExcel = new System.Windows.Forms.Button();
            this.tb_filePath = new System.Windows.Forms.TextBox();
            this.btn_import2Sql = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_fileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_selectExcel
            // 
            this.btn_selectExcel.Location = new System.Drawing.Point(279, 82);
            this.btn_selectExcel.Name = "btn_selectExcel";
            this.btn_selectExcel.Size = new System.Drawing.Size(489, 23);
            this.btn_selectExcel.TabIndex = 1;
            this.btn_selectExcel.Text = "选择要导入的Excel文件";
            this.btn_selectExcel.UseVisualStyleBackColor = true;
            this.btn_selectExcel.Click += new System.EventHandler(this.btn_selectExcel_Click);
            // 
            // tb_filePath
            // 
            this.tb_filePath.Location = new System.Drawing.Point(296, 137);
            this.tb_filePath.Name = "tb_filePath";
            this.tb_filePath.Size = new System.Drawing.Size(453, 21);
            this.tb_filePath.TabIndex = 0;
            // 
            // btn_import2Sql
            // 
            this.btn_import2Sql.Location = new System.Drawing.Point(270, 278);
            this.btn_import2Sql.Name = "btn_import2Sql";
            this.btn_import2Sql.Size = new System.Drawing.Size(498, 23);
            this.btn_import2Sql.TabIndex = 3;
            this.btn_import2Sql.Text = "导入到Sql数据库中";
            this.btn_import2Sql.UseVisualStyleBackColor = true;
            this.btn_import2Sql.Click += new System.EventHandler(this.btn_import2Sql_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "文件路径名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "文件名";
            // 
            // tb_fileName
            // 
            this.tb_fileName.Location = new System.Drawing.Point(296, 209);
            this.tb_fileName.Name = "tb_fileName";
            this.tb_fileName.Size = new System.Drawing.Size(453, 21);
            this.tb_fileName.TabIndex = 1;
            // 
            // ImportEmployee2SqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 628);
            this.Controls.Add(this.tb_fileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_import2Sql);
            this.Controls.Add(this.tb_filePath);
            this.Controls.Add(this.btn_selectExcel);
            this.Controls.Add(this.button1);
            this.Name = "ImportEmployee2SqlForm";
            this.Text = "导入人员档案";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_selectExcel;
        private System.Windows.Forms.TextBox tb_filePath;
        private System.Windows.Forms.Button btn_import2Sql;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_fileName;
    }
}