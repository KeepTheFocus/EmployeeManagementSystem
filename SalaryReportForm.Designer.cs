namespace EmployeeManagementSystem
{
    partial class SalaryReportForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_YearMonth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.combox_SectionName = new System.Windows.Forms.ComboBox();
            this.btn_CreateReportViewer = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HarvestRhythmZeroDataSet = new EmployeeManagementSystem.HarvestRhythmZeroDataSet();
            this.SalaryCalculatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalaryCalculatorTableAdapter = new EmployeeManagementSystem.HarvestRhythmZeroDataSetTableAdapters.SalaryCalculatorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HarvestRhythmZeroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryCalculatorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择月份";
            // 
            // dtp_YearMonth
            // 
            this.dtp_YearMonth.CustomFormat = "yyyyMM";
            this.dtp_YearMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_YearMonth.Location = new System.Drawing.Point(83, 65);
            this.dtp_YearMonth.Name = "dtp_YearMonth";
            this.dtp_YearMonth.Size = new System.Drawing.Size(200, 21);
            this.dtp_YearMonth.TabIndex = 1;
            this.dtp_YearMonth.ValueChanged += new System.EventHandler(this.dtp_YearMonth_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "请选择部门";
            // 
            // combox_SectionName
            // 
            this.combox_SectionName.FormattingEnabled = true;
            this.combox_SectionName.Location = new System.Drawing.Point(406, 68);
            this.combox_SectionName.Name = "combox_SectionName";
            this.combox_SectionName.Size = new System.Drawing.Size(121, 20);
            this.combox_SectionName.TabIndex = 3;
            // 
            // btn_CreateReportViewer
            // 
            this.btn_CreateReportViewer.Location = new System.Drawing.Point(570, 66);
            this.btn_CreateReportViewer.Name = "btn_CreateReportViewer";
            this.btn_CreateReportViewer.Size = new System.Drawing.Size(193, 23);
            this.btn_CreateReportViewer.TabIndex = 4;
            this.btn_CreateReportViewer.Text = "生成报表";
            this.btn_CreateReportViewer.UseVisualStyleBackColor = true;
            this.btn_CreateReportViewer.Click += new System.EventHandler(this.btn_CreateReportViewer_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EmployeeManagementSystem.ReportSalary.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 153);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(774, 586);
            this.reportViewer1.TabIndex = 5;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // HarvestRhythmZeroDataSet
            // 
            this.HarvestRhythmZeroDataSet.DataSetName = "HarvestRhythmZeroDataSet";
            this.HarvestRhythmZeroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalaryCalculatorBindingSource
            // 
            this.SalaryCalculatorBindingSource.DataMember = "SalaryCalculator";
            this.SalaryCalculatorBindingSource.DataSource = this.HarvestRhythmZeroDataSet;
            // 
            // SalaryCalculatorTableAdapter
            // 
            this.SalaryCalculatorTableAdapter.ClearBeforeFill = true;
            // 
            // SalaryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 751);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_CreateReportViewer);
            this.Controls.Add(this.combox_SectionName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_YearMonth);
            this.Controls.Add(this.label1);
            this.Name = "SalaryReportForm";
            this.Text = "工资报表";
            this.Load += new System.EventHandler(this.SalaryReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HarvestRhythmZeroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryCalculatorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_YearMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combox_SectionName;
        private System.Windows.Forms.Button btn_CreateReportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalaryCalculatorBindingSource;
        private HarvestRhythmZeroDataSet HarvestRhythmZeroDataSet;
        private HarvestRhythmZeroDataSetTableAdapters.SalaryCalculatorTableAdapter SalaryCalculatorTableAdapter;
    }
}