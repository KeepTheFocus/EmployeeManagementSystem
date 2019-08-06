namespace EmployeeManagementSystem
{
    partial class ClassTimeUpholdForm
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
            this.lv_ClassTimeUphold = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_AddClass = new System.Windows.Forms.Button();
            this.btn_SaveClass = new System.Windows.Forms.Button();
            this.btn_DeleteClass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_TimeName = new System.Windows.Forms.TextBox();
            this.textBox_leaveEarly = new System.Windows.Forms.TextBox();
            this.textBox_Comelate = new System.Windows.Forms.TextBox();
            this.textBox_WorkMinutes = new System.Windows.Forms.TextBox();
            this.textBox_WorkDays = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.mtb_MorningStart = new System.Windows.Forms.MaskedTextBox();
            this.mtb_MorningStop = new System.Windows.Forms.MaskedTextBox();
            this.mtb_startSignIn = new System.Windows.Forms.MaskedTextBox();
            this.mtb_StopSignIn = new System.Windows.Forms.MaskedTextBox();
            this.mtbStartSignOff = new System.Windows.Forms.MaskedTextBox();
            this.mtbStopSignff = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.mtb_AfternoonStart = new System.Windows.Forms.MaskedTextBox();
            this.mtb_AfternoonStop = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox_showColour = new System.Windows.Forms.PictureBox();
            this.linkLabel_openColourSelection = new System.Windows.Forms.LinkLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.maskedTextBox_startOT = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_stopOT = new System.Windows.Forms.MaskedTextBox();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showColour)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_ClassTimeUphold
            // 
            this.lv_ClassTimeUphold.AllowColumnReorder = true;
            this.lv_ClassTimeUphold.AllowDrop = true;
            this.lv_ClassTimeUphold.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader13,
            this.columnHeader14});
            this.lv_ClassTimeUphold.FullRowSelect = true;
            this.lv_ClassTimeUphold.GridLines = true;
            this.lv_ClassTimeUphold.LabelEdit = true;
            this.lv_ClassTimeUphold.Location = new System.Drawing.Point(12, 33);
            this.lv_ClassTimeUphold.Name = "lv_ClassTimeUphold";
            this.lv_ClassTimeUphold.Size = new System.Drawing.Size(780, 613);
            this.lv_ClassTimeUphold.TabIndex = 0;
            this.lv_ClassTimeUphold.UseCompatibleStateImageBehavior = false;
            this.lv_ClassTimeUphold.View = System.Windows.Forms.View.Details;
            this.lv_ClassTimeUphold.SelectedIndexChanged += new System.EventHandler(this.lv_ClassTimeUphold_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "时段名称";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "第一阶段上班时间";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "第一阶段下班时间";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "开始签到时间";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "结束签到时间";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 84;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "第二阶段上班时间";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 108;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "第二阶段下班时间";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 108;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "开始签退时间";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 84;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "结束签退时间";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 84;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "显示颜色";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "工作日";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 48;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "开始加班时间";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 84;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "结束加班时间";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 84;
            // 
            // btn_AddClass
            // 
            this.btn_AddClass.Location = new System.Drawing.Point(811, 33);
            this.btn_AddClass.Name = "btn_AddClass";
            this.btn_AddClass.Size = new System.Drawing.Size(75, 23);
            this.btn_AddClass.TabIndex = 1;
            this.btn_AddClass.Text = "增加";
            this.btn_AddClass.UseVisualStyleBackColor = true;
            this.btn_AddClass.Click += new System.EventHandler(this.btn_AddClass_Click);
            // 
            // btn_SaveClass
            // 
            this.btn_SaveClass.Location = new System.Drawing.Point(902, 33);
            this.btn_SaveClass.Name = "btn_SaveClass";
            this.btn_SaveClass.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveClass.TabIndex = 2;
            this.btn_SaveClass.Text = "保存";
            this.btn_SaveClass.UseVisualStyleBackColor = true;
            this.btn_SaveClass.Click += new System.EventHandler(this.btn_SaveClass_Click);
            // 
            // btn_DeleteClass
            // 
            this.btn_DeleteClass.Location = new System.Drawing.Point(986, 33);
            this.btn_DeleteClass.Name = "btn_DeleteClass";
            this.btn_DeleteClass.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteClass.TabIndex = 3;
            this.btn_DeleteClass.Text = "删除";
            this.btn_DeleteClass.UseVisualStyleBackColor = true;
            this.btn_DeleteClass.Click += new System.EventHandler(this.btn_DeleteClass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(874, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "时间段名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(851, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "第一阶段上班时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(851, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "第一阶段下班时间";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(838, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "记迟到时间(分钟)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(838, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "记早退时间(分钟)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(862, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "开始签到时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(862, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "结束签到时间";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(862, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "开始签退时间";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(862, 567);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "结束签退时间";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(862, 611);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "记为多少工作日";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(862, 653);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "记为多少分钟";
            // 
            // tb_TimeName
            // 
            this.tb_TimeName.Location = new System.Drawing.Point(958, 79);
            this.tb_TimeName.Name = "tb_TimeName";
            this.tb_TimeName.Size = new System.Drawing.Size(100, 21);
            this.tb_TimeName.TabIndex = 15;
            this.tb_TimeName.TextChanged += new System.EventHandler(this.tb_TimeName_TextChanged);
            this.tb_TimeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_TimeName_KeyDown);
            // 
            // textBox_leaveEarly
            // 
            this.textBox_leaveEarly.Location = new System.Drawing.Point(958, 255);
            this.textBox_leaveEarly.Name = "textBox_leaveEarly";
            this.textBox_leaveEarly.Size = new System.Drawing.Size(100, 21);
            this.textBox_leaveEarly.TabIndex = 18;
            // 
            // textBox_Comelate
            // 
            this.textBox_Comelate.Location = new System.Drawing.Point(958, 205);
            this.textBox_Comelate.Name = "textBox_Comelate";
            this.textBox_Comelate.Size = new System.Drawing.Size(100, 21);
            this.textBox_Comelate.TabIndex = 19;
            // 
            // textBox_WorkMinutes
            // 
            this.textBox_WorkMinutes.Location = new System.Drawing.Point(958, 644);
            this.textBox_WorkMinutes.Name = "textBox_WorkMinutes";
            this.textBox_WorkMinutes.Size = new System.Drawing.Size(100, 21);
            this.textBox_WorkMinutes.TabIndex = 21;
            this.textBox_WorkMinutes.TextChanged += new System.EventHandler(this.textBox_WorkMinutes_TextChanged);
            // 
            // textBox_WorkDays
            // 
            this.textBox_WorkDays.Location = new System.Drawing.Point(958, 608);
            this.textBox_WorkDays.Name = "textBox_WorkDays";
            this.textBox_WorkDays.Size = new System.Drawing.Size(100, 21);
            this.textBox_WorkDays.TabIndex = 22;
            this.textBox_WorkDays.TextChanged += new System.EventHandler(this.textBox_WorkDays_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(879, 703);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "必须签到";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(986, 703);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "必须签退";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // mtb_MorningStart
            // 
            this.mtb_MorningStart.Location = new System.Drawing.Point(958, 121);
            this.mtb_MorningStart.Mask = "90:00";
            this.mtb_MorningStart.Name = "mtb_MorningStart";
            this.mtb_MorningStart.Size = new System.Drawing.Size(100, 21);
            this.mtb_MorningStart.TabIndex = 28;
            this.mtb_MorningStart.ValidatingType = typeof(System.DateTime);
            this.mtb_MorningStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtb_MorningStart_KeyDown);
            // 
            // mtb_MorningStop
            // 
            this.mtb_MorningStop.Location = new System.Drawing.Point(958, 166);
            this.mtb_MorningStop.Mask = "90:00";
            this.mtb_MorningStop.Name = "mtb_MorningStop";
            this.mtb_MorningStop.Size = new System.Drawing.Size(100, 21);
            this.mtb_MorningStop.TabIndex = 29;
            this.mtb_MorningStop.ValidatingType = typeof(System.DateTime);
            this.mtb_MorningStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtb_MorningStop_KeyDown);
            // 
            // mtb_startSignIn
            // 
            this.mtb_startSignIn.Location = new System.Drawing.Point(958, 306);
            this.mtb_startSignIn.Mask = "90:00";
            this.mtb_startSignIn.Name = "mtb_startSignIn";
            this.mtb_startSignIn.Size = new System.Drawing.Size(100, 21);
            this.mtb_startSignIn.TabIndex = 30;
            this.mtb_startSignIn.ValidatingType = typeof(System.DateTime);
            this.mtb_startSignIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtb_startSignIn_KeyDown);
            // 
            // mtb_StopSignIn
            // 
            this.mtb_StopSignIn.Location = new System.Drawing.Point(958, 350);
            this.mtb_StopSignIn.Mask = "90:00";
            this.mtb_StopSignIn.Name = "mtb_StopSignIn";
            this.mtb_StopSignIn.Size = new System.Drawing.Size(100, 21);
            this.mtb_StopSignIn.TabIndex = 31;
            this.mtb_StopSignIn.ValidatingType = typeof(System.DateTime);
            this.mtb_StopSignIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtb_StopSignIn_KeyDown);
            // 
            // mtbStartSignOff
            // 
            this.mtbStartSignOff.Location = new System.Drawing.Point(958, 510);
            this.mtbStartSignOff.Mask = "90:00";
            this.mtbStartSignOff.Name = "mtbStartSignOff";
            this.mtbStartSignOff.Size = new System.Drawing.Size(100, 21);
            this.mtbStartSignOff.TabIndex = 32;
            this.mtbStartSignOff.ValidatingType = typeof(System.DateTime);
            this.mtbStartSignOff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbStartSignOff_KeyDown);
            // 
            // mtbStopSignff
            // 
            this.mtbStopSignff.Location = new System.Drawing.Point(958, 561);
            this.mtbStopSignff.Mask = "90:00";
            this.mtbStopSignff.Name = "mtbStopSignff";
            this.mtbStopSignff.Size = new System.Drawing.Size(100, 21);
            this.mtbStopSignff.TabIndex = 33;
            this.mtbStopSignff.ValidatingType = typeof(System.DateTime);
            this.mtbStopSignff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbStopSignff_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(838, 413);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 12);
            this.label12.TabIndex = 34;
            this.label12.Text = "第二阶段上班时间";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(838, 466);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 12);
            this.label13.TabIndex = 35;
            this.label13.Text = "第二阶段下班时间";
            // 
            // mtb_AfternoonStart
            // 
            this.mtb_AfternoonStart.Location = new System.Drawing.Point(958, 404);
            this.mtb_AfternoonStart.Mask = "90:00";
            this.mtb_AfternoonStart.Name = "mtb_AfternoonStart";
            this.mtb_AfternoonStart.Size = new System.Drawing.Size(100, 21);
            this.mtb_AfternoonStart.TabIndex = 36;
            this.mtb_AfternoonStart.ValidatingType = typeof(System.DateTime);
            this.mtb_AfternoonStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtb_AfternoonStart_KeyDown);
            // 
            // mtb_AfternoonStop
            // 
            this.mtb_AfternoonStop.Location = new System.Drawing.Point(958, 463);
            this.mtb_AfternoonStop.Mask = "90:00";
            this.mtb_AfternoonStop.Name = "mtb_AfternoonStop";
            this.mtb_AfternoonStop.Size = new System.Drawing.Size(100, 21);
            this.mtb_AfternoonStop.TabIndex = 37;
            this.mtb_AfternoonStop.ValidatingType = typeof(System.DateTime);
            this.mtb_AfternoonStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtb_AfternoonStop_KeyDown);
            // 
            // pictureBox_showColour
            // 
            this.pictureBox_showColour.BackColor = System.Drawing.Color.Red;
            this.pictureBox_showColour.Location = new System.Drawing.Point(333, 669);
            this.pictureBox_showColour.Name = "pictureBox_showColour";
            this.pictureBox_showColour.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_showColour.TabIndex = 38;
            this.pictureBox_showColour.TabStop = false;
            this.pictureBox_showColour.Click += new System.EventHandler(this.pictureBox_showColour_Click);
            // 
            // linkLabel_openColourSelection
            // 
            this.linkLabel_openColourSelection.AutoSize = true;
            this.linkLabel_openColourSelection.Location = new System.Drawing.Point(439, 704);
            this.linkLabel_openColourSelection.Name = "linkLabel_openColourSelection";
            this.linkLabel_openColourSelection.Size = new System.Drawing.Size(149, 12);
            this.linkLabel_openColourSelection.TabIndex = 39;
            this.linkLabel_openColourSelection.TabStop = true;
            this.linkLabel_openColourSelection.Text = "更改此时段类别的显示颜色";
            this.linkLabel_openColourSelection.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_openColourSelection_LinkClicked);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(616, 669);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 40;
            this.label14.Text = "开始加班时间";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(616, 707);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 41;
            this.label15.Text = "结束加班时间";
            // 
            // maskedTextBox_startOT
            // 
            this.maskedTextBox_startOT.Location = new System.Drawing.Point(699, 669);
            this.maskedTextBox_startOT.Mask = "90:00";
            this.maskedTextBox_startOT.Name = "maskedTextBox_startOT";
            this.maskedTextBox_startOT.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox_startOT.TabIndex = 42;
            this.maskedTextBox_startOT.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_startOT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_startOT_KeyDown);
            // 
            // maskedTextBox_stopOT
            // 
            this.maskedTextBox_stopOT.Location = new System.Drawing.Point(699, 704);
            this.maskedTextBox_stopOT.Mask = "90:00";
            this.maskedTextBox_stopOT.Name = "maskedTextBox_stopOT";
            this.maskedTextBox_stopOT.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox_stopOT.TabIndex = 43;
            this.maskedTextBox_stopOT.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_stopOT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_stopOT_KeyDown);
            // 
            // ClassTimeUpholdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 775);
            this.Controls.Add(this.maskedTextBox_stopOT);
            this.Controls.Add(this.maskedTextBox_startOT);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.linkLabel_openColourSelection);
            this.Controls.Add(this.pictureBox_showColour);
            this.Controls.Add(this.mtb_AfternoonStop);
            this.Controls.Add(this.mtb_AfternoonStart);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mtbStopSignff);
            this.Controls.Add(this.mtbStartSignOff);
            this.Controls.Add(this.mtb_StopSignIn);
            this.Controls.Add(this.mtb_startSignIn);
            this.Controls.Add(this.mtb_MorningStop);
            this.Controls.Add(this.mtb_MorningStart);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox_WorkDays);
            this.Controls.Add(this.textBox_WorkMinutes);
            this.Controls.Add(this.textBox_Comelate);
            this.Controls.Add(this.textBox_leaveEarly);
            this.Controls.Add(this.tb_TimeName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DeleteClass);
            this.Controls.Add(this.btn_SaveClass);
            this.Controls.Add(this.btn_AddClass);
            this.Controls.Add(this.lv_ClassTimeUphold);
            this.Name = "ClassTimeUpholdForm";
            this.Text = "班次时间段维护";
            this.Load += new System.EventHandler(this.ClassTimeUpholdForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showColour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_ClassTimeUphold;
        private System.Windows.Forms.Button btn_AddClass;
        private System.Windows.Forms.Button btn_SaveClass;
        private System.Windows.Forms.Button btn_DeleteClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_TimeName;
        private System.Windows.Forms.TextBox textBox_leaveEarly;
        private System.Windows.Forms.TextBox textBox_Comelate;
        private System.Windows.Forms.TextBox textBox_WorkMinutes;
        private System.Windows.Forms.TextBox textBox_WorkDays;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.MaskedTextBox mtb_MorningStart;
        private System.Windows.Forms.MaskedTextBox mtb_MorningStop;
        private System.Windows.Forms.MaskedTextBox mtb_startSignIn;
        private System.Windows.Forms.MaskedTextBox mtb_StopSignIn;
        private System.Windows.Forms.MaskedTextBox mtbStartSignOff;
        private System.Windows.Forms.MaskedTextBox mtbStopSignff;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mtb_AfternoonStart;
        private System.Windows.Forms.MaskedTextBox mtb_AfternoonStop;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.PictureBox pictureBox_showColour;
        private System.Windows.Forms.LinkLabel linkLabel_openColourSelection;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_startOT;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_stopOT;
        private System.Windows.Forms.ColorDialog colorDialog3;
    }
}