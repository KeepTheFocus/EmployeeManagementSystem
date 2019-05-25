namespace EmployeeManagementSystem
{
    partial class ImportAttendanceReport2SqlForm
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Path = new System.Windows.Forms.Label();
            this.tb_FileName = new System.Windows.Forms.TextBox();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.btn_Import2Sql = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(245, 90);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(41, 12);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "文件名";
            // 
            // label_Path
            // 
            this.label_Path.AutoSize = true;
            this.label_Path.Location = new System.Drawing.Point(221, 177);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(65, 12);
            this.label_Path.TabIndex = 1;
            this.label_Path.Text = "文件的路径";
            // 
            // tb_FileName
            // 
            this.tb_FileName.Location = new System.Drawing.Point(292, 87);
            this.tb_FileName.Name = "tb_FileName";
            this.tb_FileName.Size = new System.Drawing.Size(306, 21);
            this.tb_FileName.TabIndex = 2;
            // 
            // tb_Path
            // 
            this.tb_Path.Location = new System.Drawing.Point(292, 168);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(306, 21);
            this.tb_Path.TabIndex = 3;
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Location = new System.Drawing.Point(289, 43);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(309, 23);
            this.btn_SelectFile.TabIndex = 4;
            this.btn_SelectFile.Text = "选择考勤汇总文件";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // btn_Import2Sql
            // 
            this.btn_Import2Sql.Location = new System.Drawing.Point(289, 229);
            this.btn_Import2Sql.Name = "btn_Import2Sql";
            this.btn_Import2Sql.Size = new System.Drawing.Size(309, 23);
            this.btn_Import2Sql.TabIndex = 5;
            this.btn_Import2Sql.Text = "将文件导入进Sql数据库中";
            this.btn_Import2Sql.UseVisualStyleBackColor = true;
            this.btn_Import2Sql.Click += new System.EventHandler(this.btn_Import2Sql_Click);
            // 
            // ImportAttendanceReport2SqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Import2Sql);
            this.Controls.Add(this.btn_SelectFile);
            this.Controls.Add(this.tb_Path);
            this.Controls.Add(this.tb_FileName);
            this.Controls.Add(this.label_Path);
            this.Controls.Add(this.label_Name);
            this.Name = "ImportAttendanceReport2SqlForm";
            this.Text = "导入考勤汇总";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Path;
        private System.Windows.Forms.TextBox tb_FileName;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.Button btn_Import2Sql;
    }
}