namespace EmployeeManagementSystem
{
    partial class OverTimeCauseForm
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
            this.tsl_create = new System.Windows.Forms.ToolStripLabel();
            this.tsl_store = new System.Windows.Forms.ToolStripLabel();
            this.tsl_search = new System.Windows.Forms.ToolStripLabel();
            this.tsl_remove = new System.Windows.Forms.ToolStripLabel();
            this.tsl_Cancel = new System.Windows.Forms.ToolStripLabel();
            this.tsl_FirstCause = new System.Windows.Forms.ToolStripLabel();
            this.tsl_previousCause = new System.Windows.Forms.ToolStripLabel();
            this.tsl_nextCause = new System.Windows.Forms.ToolStripLabel();
            this.tsl_EndCause = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtb_CauseScription = new System.Windows.Forms.RichTextBox();
            this.tb_CauseNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_create,
            this.tsl_store,
            this.tsl_search,
            this.tsl_remove,
            this.tsl_Cancel,
            this.tsl_FirstCause,
            this.tsl_previousCause,
            this.tsl_nextCause,
            this.tsl_EndCause});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(581, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsl_create
            // 
            this.tsl_create.Name = "tsl_create";
            this.tsl_create.Size = new System.Drawing.Size(32, 22);
            this.tsl_create.Text = "新建";
            this.tsl_create.Click += new System.EventHandler(this.tsl_create_Click);
            // 
            // tsl_store
            // 
            this.tsl_store.Name = "tsl_store";
            this.tsl_store.Size = new System.Drawing.Size(32, 22);
            this.tsl_store.Text = "保存";
            this.tsl_store.Click += new System.EventHandler(this.tsl_store_Click);
            // 
            // tsl_search
            // 
            this.tsl_search.Name = "tsl_search";
            this.tsl_search.Size = new System.Drawing.Size(32, 22);
            this.tsl_search.Text = "查找";
            this.tsl_search.Click += new System.EventHandler(this.tsl_search_Click);
            // 
            // tsl_remove
            // 
            this.tsl_remove.Name = "tsl_remove";
            this.tsl_remove.Size = new System.Drawing.Size(32, 22);
            this.tsl_remove.Text = "删除";
            this.tsl_remove.Click += new System.EventHandler(this.tsl_remove_Click);
            // 
            // tsl_Cancel
            // 
            this.tsl_Cancel.Name = "tsl_Cancel";
            this.tsl_Cancel.Size = new System.Drawing.Size(32, 22);
            this.tsl_Cancel.Text = "取消";
            this.tsl_Cancel.Click += new System.EventHandler(this.tsl_Cancel_Click);
            // 
            // tsl_FirstCause
            // 
            this.tsl_FirstCause.Name = "tsl_FirstCause";
            this.tsl_FirstCause.Size = new System.Drawing.Size(68, 22);
            this.tsl_FirstCause.Text = "第一个原因";
            this.tsl_FirstCause.Click += new System.EventHandler(this.tsl_FirstCause_Click);
            // 
            // tsl_previousCause
            // 
            this.tsl_previousCause.Name = "tsl_previousCause";
            this.tsl_previousCause.Size = new System.Drawing.Size(68, 22);
            this.tsl_previousCause.Text = "上一个原因";
            this.tsl_previousCause.Click += new System.EventHandler(this.tsl_previousCause_Click);
            // 
            // tsl_nextCause
            // 
            this.tsl_nextCause.Name = "tsl_nextCause";
            this.tsl_nextCause.Size = new System.Drawing.Size(68, 22);
            this.tsl_nextCause.Text = "下一个原因";
            this.tsl_nextCause.Click += new System.EventHandler(this.tsl_nextCause_Click);
            // 
            // tsl_EndCause
            // 
            this.tsl_EndCause.Name = "tsl_EndCause";
            this.tsl_EndCause.Size = new System.Drawing.Size(80, 22);
            this.tsl_EndCause.Text = "最后一个原因";
            this.tsl_EndCause.Click += new System.EventHandler(this.tsl_EndCause_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtb_CauseScription);
            this.panel1.Controls.Add(this.tb_CauseNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 191);
            this.panel1.TabIndex = 1;
            // 
            // rtb_CauseScription
            // 
            this.rtb_CauseScription.Location = new System.Drawing.Point(162, 95);
            this.rtb_CauseScription.Name = "rtb_CauseScription";
            this.rtb_CauseScription.Size = new System.Drawing.Size(266, 54);
            this.rtb_CauseScription.TabIndex = 3;
            this.rtb_CauseScription.Text = "";
            // 
            // tb_CauseNumber
            // 
            this.tb_CauseNumber.Location = new System.Drawing.Point(162, 49);
            this.tb_CauseNumber.Name = "tb_CauseNumber";
            this.tb_CauseNumber.Size = new System.Drawing.Size(145, 21);
            this.tb_CauseNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "原因描述";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原因编号";
            // 
            // OverTimeCauseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 287);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "OverTimeCauseForm";
            this.Text = "加班原因";
            this.Load += new System.EventHandler(this.OverTimeCauseForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsl_create;
        private System.Windows.Forms.ToolStripLabel tsl_store;
        private System.Windows.Forms.ToolStripLabel tsl_search;
        private System.Windows.Forms.ToolStripLabel tsl_remove;
        private System.Windows.Forms.ToolStripLabel tsl_Cancel;
        private System.Windows.Forms.ToolStripLabel tsl_FirstCause;
        private System.Windows.Forms.ToolStripLabel tsl_previousCause;
        private System.Windows.Forms.ToolStripLabel tsl_nextCause;
        private System.Windows.Forms.ToolStripLabel tsl_EndCause;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox rtb_CauseScription;
        public System.Windows.Forms.TextBox tb_CauseNumber;
    }
}