namespace EmployeeManagementSystem
{
    partial class QueryInGroupForm
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
            this.btn_queryInGroup = new System.Windows.Forms.Button();
            this.tb_EmployeeNumber2query = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入要查找的工号";
            // 
            // btn_queryInGroup
            // 
            this.btn_queryInGroup.Location = new System.Drawing.Point(354, 39);
            this.btn_queryInGroup.Name = "btn_queryInGroup";
            this.btn_queryInGroup.Size = new System.Drawing.Size(75, 23);
            this.btn_queryInGroup.TabIndex = 1;
            this.btn_queryInGroup.Text = "查询";
            this.btn_queryInGroup.UseVisualStyleBackColor = true;
            this.btn_queryInGroup.Click += new System.EventHandler(this.btn_queryInGroup_Click);
            // 
            // tb_EmployeeNumber2query
            // 
            this.tb_EmployeeNumber2query.Location = new System.Drawing.Point(173, 39);
            this.tb_EmployeeNumber2query.Name = "tb_EmployeeNumber2query";
            this.tb_EmployeeNumber2query.Size = new System.Drawing.Size(133, 21);
            this.tb_EmployeeNumber2query.TabIndex = 2;
            // 
            // QueryInGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 125);
            this.Controls.Add(this.tb_EmployeeNumber2query);
            this.Controls.Add(this.btn_queryInGroup);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QueryInGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueryInGroupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_queryInGroup;
        private System.Windows.Forms.TextBox tb_EmployeeNumber2query;
    }
}