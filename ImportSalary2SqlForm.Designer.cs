namespace EmployeeManagementSystem
{
    partial class ImportSalary2SqlForm
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
            this.btn_selectExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_filePath = new System.Windows.Forms.TextBox();
            this.tb_fileName = new System.Windows.Forms.TextBox();
            this.btn_Excel2SQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_selectExcel
            // 
            this.btn_selectExcel.Location = new System.Drawing.Point(425, 48);
            this.btn_selectExcel.Name = "btn_selectExcel";
            this.btn_selectExcel.Size = new System.Drawing.Size(337, 23);
            this.btn_selectExcel.TabIndex = 0;
            this.btn_selectExcel.Text = "选择要导入的薪资档案Excel文件";
            this.btn_selectExcel.UseVisualStyleBackColor = true;
            this.btn_selectExcel.Click += new System.EventHandler(this.btn_selectExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件的绝对路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "文件名";
            // 
            // tb_filePath
            // 
            this.tb_filePath.Location = new System.Drawing.Point(425, 126);
            this.tb_filePath.Name = "tb_filePath";
            this.tb_filePath.Size = new System.Drawing.Size(337, 21);
            this.tb_filePath.TabIndex = 1;
            // 
            // tb_fileName
            // 
            this.tb_fileName.Location = new System.Drawing.Point(425, 204);
            this.tb_fileName.Name = "tb_fileName";
            this.tb_fileName.Size = new System.Drawing.Size(337, 21);
            this.tb_fileName.TabIndex = 2;
            // 
            // btn_Excel2SQL
            // 
            this.btn_Excel2SQL.Location = new System.Drawing.Point(425, 245);
            this.btn_Excel2SQL.Name = "btn_Excel2SQL";
            this.btn_Excel2SQL.Size = new System.Drawing.Size(337, 23);
            this.btn_Excel2SQL.TabIndex = 3;
            this.btn_Excel2SQL.Text = "将薪资档案Excel文件导入进SQL中";
            this.btn_Excel2SQL.UseVisualStyleBackColor = true;
            this.btn_Excel2SQL.Click += new System.EventHandler(this.btn_Excel2SQL_Click);
            // 
            // ImportSalary2SqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 628);
            this.Controls.Add(this.btn_Excel2SQL);
            this.Controls.Add(this.tb_fileName);
            this.Controls.Add(this.tb_filePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_selectExcel);
            this.Name = "ImportSalary2SqlForm";
            this.Text = "导入薪资档案";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_selectExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_filePath;
        private System.Windows.Forms.TextBox tb_fileName;
        private System.Windows.Forms.Button btn_Excel2SQL;
    }
}