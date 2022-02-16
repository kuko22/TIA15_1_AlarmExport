namespace TIA15_1_AlarmExport
{
    partial class Form1
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
            this.textBox_ProjectPath = new System.Windows.Forms.TextBox();
            this.openFileDialog_Project = new System.Windows.Forms.OpenFileDialog();
            this.button_ExportAlarms = new System.Windows.Forms.Button();
            this.button_SearchProject = new System.Windows.Forms.Button();
            this.checkedListBox_Lang = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_AbortTextCode = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_AbortHMIClassName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_Custom3HMIClassName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_PauseTextCode = new System.Windows.Forms.TextBox();
            this.textBox_FinishTextCode = new System.Windows.Forms.TextBox();
            this.textBox_SlowTextCode = new System.Windows.Forms.TextBox();
            this.textBox_WarningTextCode = new System.Windows.Forms.TextBox();
            this.textBox_Custom1TextCode = new System.Windows.Forms.TextBox();
            this.textBox_Custom2TextCode = new System.Windows.Forms.TextBox();
            this.textBox_Custom3TextCode = new System.Windows.Forms.TextBox();
            this.textBox_PauseHMIClassName = new System.Windows.Forms.TextBox();
            this.textBox_FinishHMIClassName = new System.Windows.Forms.TextBox();
            this.textBox_SlowHMIClassName = new System.Windows.Forms.TextBox();
            this.textBox_Custom1HMIClassName = new System.Windows.Forms.TextBox();
            this.textBox_Custom2HMIClassName = new System.Windows.Forms.TextBox();
            this.textBox_WarningHMIClassName = new System.Windows.Forms.TextBox();
            this.checkBox_AbortDefaultAlarmClass = new System.Windows.Forms.CheckBox();
            this.checkBox_PauseDefaultAlarmClass = new System.Windows.Forms.CheckBox();
            this.checkBox_FinishDefaultAlarmClass = new System.Windows.Forms.CheckBox();
            this.checkBox_SlowDefaultAlarmClass = new System.Windows.Forms.CheckBox();
            this.checkBox_WarningDefaultAlarmClass = new System.Windows.Forms.CheckBox();
            this.checkBox_Custom1DefaultAlarmClass = new System.Windows.Forms.CheckBox();
            this.checkBox_Custom2DefaultAlarmClass = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_AbortFBname = new System.Windows.Forms.TextBox();
            this.checkBox_Custom3DefaultAlarmClass = new System.Windows.Forms.CheckBox();
            this.textBox_PauseFBname = new System.Windows.Forms.TextBox();
            this.textBox_FinishFBname = new System.Windows.Forms.TextBox();
            this.textBox_SlowFBname = new System.Windows.Forms.TextBox();
            this.textBox_WarningFBname = new System.Windows.Forms.TextBox();
            this.textBox_Custom1FBname = new System.Windows.Forms.TextBox();
            this.textBox_Custom2FBname = new System.Windows.Forms.TextBox();
            this.textBox_Custom3FBname = new System.Windows.Forms.TextBox();
            this.comboBox_SourceLangForAlarmCode = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.progressBar_Process = new System.Windows.Forms.ProgressBar();
            this.textBox_DBalarms = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_PLCconnection = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBox_NoGeneratingEnable = new System.Windows.Forms.CheckBox();
            this.textBox_NoGeneratingText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ProjectPath
            // 
            this.textBox_ProjectPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this, "Projectpath", true));
            this.textBox_ProjectPath.Enabled = false;
            this.textBox_ProjectPath.Location = new System.Drawing.Point(12, 12);
            this.textBox_ProjectPath.Name = "textBox_ProjectPath";
            this.textBox_ProjectPath.Size = new System.Drawing.Size(776, 20);
            this.textBox_ProjectPath.TabIndex = 0;
            this.textBox_ProjectPath.Tag = "Projectpath";
            // 
            // openFileDialog_Project
            // 
            this.openFileDialog_Project.CheckFileExists = false;
            this.openFileDialog_Project.CheckPathExists = false;
            this.openFileDialog_Project.FileName = "TIA Porta 15.1 Projcet *.ap15_1|TIA Porta 16 Projcet *.ap16";
            this.openFileDialog_Project.Filter = "TIA Portal 16|*.ap16|TIA Portal 15.1|*.ap15_1|All files|*.*";
            this.openFileDialog_Project.ValidateNames = false;
            // 
            // button_ExportAlarms
            // 
            this.button_ExportAlarms.Location = new System.Drawing.Point(173, 38);
            this.button_ExportAlarms.Name = "button_ExportAlarms";
            this.button_ExportAlarms.Size = new System.Drawing.Size(155, 57);
            this.button_ExportAlarms.TabIndex = 1;
            this.button_ExportAlarms.Text = "Export Alarms";
            this.button_ExportAlarms.UseVisualStyleBackColor = true;
            this.button_ExportAlarms.Click += new System.EventHandler(this.button_ExportAlarms_Click);
            // 
            // button_SearchProject
            // 
            this.button_SearchProject.Location = new System.Drawing.Point(12, 38);
            this.button_SearchProject.Name = "button_SearchProject";
            this.button_SearchProject.Size = new System.Drawing.Size(155, 57);
            this.button_SearchProject.TabIndex = 2;
            this.button_SearchProject.Text = "SearchProject";
            this.button_SearchProject.UseVisualStyleBackColor = true;
            this.button_SearchProject.Click += new System.EventHandler(this.button_SearchProject_Click);
            // 
            // checkedListBox_Lang
            // 
            this.checkedListBox_Lang.FormattingEnabled = true;
            this.checkedListBox_Lang.Items.AddRange(new object[] {
            "[sk-SK]",
            "[en-US]",
            "[ru-RU]",
            "[de-DE]"});
            this.checkedListBox_Lang.Location = new System.Drawing.Point(455, 38);
            this.checkedListBox_Lang.Name = "checkedListBox_Lang";
            this.checkedListBox_Lang.Size = new System.Drawing.Size(145, 79);
            this.checkedListBox_Lang.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Abort";
            // 
            // textBox_AbortTextCode
            // 
            this.textBox_AbortTextCode.Location = new System.Drawing.Point(60, 29);
            this.textBox_AbortTextCode.Name = "textBox_AbortTextCode";
            this.textBox_AbortTextCode.Size = new System.Drawing.Size(70, 20);
            this.textBox_AbortTextCode.TabIndex = 5;
            this.textBox_AbortTextCode.Text = "A";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_AbortTextCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_AbortHMIClassName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Custom3HMIClassName, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBox_PauseTextCode, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_FinishTextCode, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_SlowTextCode, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_WarningTextCode, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Custom1TextCode, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Custom2TextCode, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Custom3TextCode, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBox_PauseHMIClassName, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_FinishHMIClassName, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_SlowHMIClassName, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Custom1HMIClassName, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Custom2HMIClassName, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox_WarningHMIClassName, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AbortDefaultAlarmClass, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_PauseDefaultAlarmClass, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_FinishDefaultAlarmClass, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_SlowDefaultAlarmClass, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_WarningDefaultAlarmClass, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_Custom1DefaultAlarmClass, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_Custom2DefaultAlarmClass, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.label15, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_AbortFBname, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_Custom3DefaultAlarmClass, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBox_PauseFBname, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_FinishFBname, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_SlowFBname, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_WarningFBname, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Custom1FBname, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Custom2FBname, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Custom3FBname, 3, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 101);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(427, 235);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // textBox_AbortHMIClassName
            // 
            this.textBox_AbortHMIClassName.Location = new System.Drawing.Point(138, 29);
            this.textBox_AbortHMIClassName.Name = "textBox_AbortHMIClassName";
            this.textBox_AbortHMIClassName.Size = new System.Drawing.Size(70, 20);
            this.textBox_AbortHMIClassName.TabIndex = 6;
            this.textBox_AbortHMIClassName.Text = "ABORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Code in Alarm\r\nText ($X)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alarm Class Name \r\nin HMI";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 26);
            this.label12.TabIndex = 30;
            this.label12.Text = "Default\r\nAlarm Class";
            // 
            // textBox_Custom3HMIClassName
            // 
            this.textBox_Custom3HMIClassName.Location = new System.Drawing.Point(138, 211);
            this.textBox_Custom3HMIClassName.Name = "textBox_Custom3HMIClassName";
            this.textBox_Custom3HMIClassName.Size = new System.Drawing.Size(70, 20);
            this.textBox_Custom3HMIClassName.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pause";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Finish";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Slow";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Warining";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Custom 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Custom 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Custom 3";
            // 
            // textBox_PauseTextCode
            // 
            this.textBox_PauseTextCode.Location = new System.Drawing.Point(60, 55);
            this.textBox_PauseTextCode.Name = "textBox_PauseTextCode";
            this.textBox_PauseTextCode.Size = new System.Drawing.Size(70, 20);
            this.textBox_PauseTextCode.TabIndex = 16;
            this.textBox_PauseTextCode.Text = "P";
            // 
            // textBox_FinishTextCode
            // 
            this.textBox_FinishTextCode.Location = new System.Drawing.Point(60, 81);
            this.textBox_FinishTextCode.Name = "textBox_FinishTextCode";
            this.textBox_FinishTextCode.Size = new System.Drawing.Size(70, 20);
            this.textBox_FinishTextCode.TabIndex = 17;
            this.textBox_FinishTextCode.Text = "F";
            // 
            // textBox_SlowTextCode
            // 
            this.textBox_SlowTextCode.Location = new System.Drawing.Point(60, 107);
            this.textBox_SlowTextCode.Name = "textBox_SlowTextCode";
            this.textBox_SlowTextCode.Size = new System.Drawing.Size(70, 20);
            this.textBox_SlowTextCode.TabIndex = 18;
            this.textBox_SlowTextCode.Text = "S";
            // 
            // textBox_WarningTextCode
            // 
            this.textBox_WarningTextCode.Location = new System.Drawing.Point(60, 133);
            this.textBox_WarningTextCode.Name = "textBox_WarningTextCode";
            this.textBox_WarningTextCode.Size = new System.Drawing.Size(70, 20);
            this.textBox_WarningTextCode.TabIndex = 19;
            this.textBox_WarningTextCode.Text = "W";
            // 
            // textBox_Custom1TextCode
            // 
            this.textBox_Custom1TextCode.Location = new System.Drawing.Point(60, 159);
            this.textBox_Custom1TextCode.Name = "textBox_Custom1TextCode";
            this.textBox_Custom1TextCode.Size = new System.Drawing.Size(70, 20);
            this.textBox_Custom1TextCode.TabIndex = 20;
            // 
            // textBox_Custom2TextCode
            // 
            this.textBox_Custom2TextCode.Location = new System.Drawing.Point(60, 185);
            this.textBox_Custom2TextCode.Name = "textBox_Custom2TextCode";
            this.textBox_Custom2TextCode.Size = new System.Drawing.Size(70, 20);
            this.textBox_Custom2TextCode.TabIndex = 21;
            // 
            // textBox_Custom3TextCode
            // 
            this.textBox_Custom3TextCode.Location = new System.Drawing.Point(60, 211);
            this.textBox_Custom3TextCode.Name = "textBox_Custom3TextCode";
            this.textBox_Custom3TextCode.Size = new System.Drawing.Size(70, 20);
            this.textBox_Custom3TextCode.TabIndex = 22;
            // 
            // textBox_PauseHMIClassName
            // 
            this.textBox_PauseHMIClassName.Location = new System.Drawing.Point(138, 55);
            this.textBox_PauseHMIClassName.Name = "textBox_PauseHMIClassName";
            this.textBox_PauseHMIClassName.Size = new System.Drawing.Size(70, 20);
            this.textBox_PauseHMIClassName.TabIndex = 23;
            this.textBox_PauseHMIClassName.Text = "PAUSE";
            // 
            // textBox_FinishHMIClassName
            // 
            this.textBox_FinishHMIClassName.Location = new System.Drawing.Point(138, 81);
            this.textBox_FinishHMIClassName.Name = "textBox_FinishHMIClassName";
            this.textBox_FinishHMIClassName.Size = new System.Drawing.Size(70, 20);
            this.textBox_FinishHMIClassName.TabIndex = 24;
            this.textBox_FinishHMIClassName.Text = "FINISH";
            // 
            // textBox_SlowHMIClassName
            // 
            this.textBox_SlowHMIClassName.Location = new System.Drawing.Point(138, 107);
            this.textBox_SlowHMIClassName.Name = "textBox_SlowHMIClassName";
            this.textBox_SlowHMIClassName.Size = new System.Drawing.Size(70, 20);
            this.textBox_SlowHMIClassName.TabIndex = 25;
            this.textBox_SlowHMIClassName.Text = "RUNSLOW";
            // 
            // textBox_Custom1HMIClassName
            // 
            this.textBox_Custom1HMIClassName.Location = new System.Drawing.Point(138, 159);
            this.textBox_Custom1HMIClassName.Name = "textBox_Custom1HMIClassName";
            this.textBox_Custom1HMIClassName.Size = new System.Drawing.Size(70, 20);
            this.textBox_Custom1HMIClassName.TabIndex = 27;
            // 
            // textBox_Custom2HMIClassName
            // 
            this.textBox_Custom2HMIClassName.Location = new System.Drawing.Point(138, 185);
            this.textBox_Custom2HMIClassName.Name = "textBox_Custom2HMIClassName";
            this.textBox_Custom2HMIClassName.Size = new System.Drawing.Size(70, 20);
            this.textBox_Custom2HMIClassName.TabIndex = 29;
            // 
            // textBox_WarningHMIClassName
            // 
            this.textBox_WarningHMIClassName.Location = new System.Drawing.Point(138, 133);
            this.textBox_WarningHMIClassName.Name = "textBox_WarningHMIClassName";
            this.textBox_WarningHMIClassName.Size = new System.Drawing.Size(70, 20);
            this.textBox_WarningHMIClassName.TabIndex = 28;
            this.textBox_WarningHMIClassName.Text = "WARNING";
            // 
            // checkBox_AbortDefaultAlarmClass
            // 
            this.checkBox_AbortDefaultAlarmClass.AutoSize = true;
            this.checkBox_AbortDefaultAlarmClass.Location = new System.Drawing.Point(361, 29);
            this.checkBox_AbortDefaultAlarmClass.Name = "checkBox_AbortDefaultAlarmClass";
            this.checkBox_AbortDefaultAlarmClass.Size = new System.Drawing.Size(15, 14);
            this.checkBox_AbortDefaultAlarmClass.TabIndex = 30;
            this.checkBox_AbortDefaultAlarmClass.UseVisualStyleBackColor = true;
            this.checkBox_AbortDefaultAlarmClass.CheckStateChanged += new System.EventHandler(this.checkBox_xDefaultAlarmClass_CheckStateChanged);
            // 
            // checkBox_PauseDefaultAlarmClass
            // 
            this.checkBox_PauseDefaultAlarmClass.AutoSize = true;
            this.checkBox_PauseDefaultAlarmClass.Location = new System.Drawing.Point(361, 55);
            this.checkBox_PauseDefaultAlarmClass.Name = "checkBox_PauseDefaultAlarmClass";
            this.checkBox_PauseDefaultAlarmClass.Size = new System.Drawing.Size(15, 14);
            this.checkBox_PauseDefaultAlarmClass.TabIndex = 31;
            this.checkBox_PauseDefaultAlarmClass.UseVisualStyleBackColor = true;
            this.checkBox_PauseDefaultAlarmClass.CheckStateChanged += new System.EventHandler(this.checkBox_xDefaultAlarmClass_CheckStateChanged);
            // 
            // checkBox_FinishDefaultAlarmClass
            // 
            this.checkBox_FinishDefaultAlarmClass.AutoSize = true;
            this.checkBox_FinishDefaultAlarmClass.Location = new System.Drawing.Point(361, 81);
            this.checkBox_FinishDefaultAlarmClass.Name = "checkBox_FinishDefaultAlarmClass";
            this.checkBox_FinishDefaultAlarmClass.Size = new System.Drawing.Size(15, 14);
            this.checkBox_FinishDefaultAlarmClass.TabIndex = 32;
            this.checkBox_FinishDefaultAlarmClass.UseVisualStyleBackColor = true;
            this.checkBox_FinishDefaultAlarmClass.CheckStateChanged += new System.EventHandler(this.checkBox_xDefaultAlarmClass_CheckStateChanged);
            // 
            // checkBox_SlowDefaultAlarmClass
            // 
            this.checkBox_SlowDefaultAlarmClass.AutoSize = true;
            this.checkBox_SlowDefaultAlarmClass.Location = new System.Drawing.Point(361, 107);
            this.checkBox_SlowDefaultAlarmClass.Name = "checkBox_SlowDefaultAlarmClass";
            this.checkBox_SlowDefaultAlarmClass.Size = new System.Drawing.Size(15, 14);
            this.checkBox_SlowDefaultAlarmClass.TabIndex = 33;
            this.checkBox_SlowDefaultAlarmClass.UseVisualStyleBackColor = true;
            this.checkBox_SlowDefaultAlarmClass.CheckStateChanged += new System.EventHandler(this.checkBox_xDefaultAlarmClass_CheckStateChanged);
            // 
            // checkBox_WarningDefaultAlarmClass
            // 
            this.checkBox_WarningDefaultAlarmClass.AutoSize = true;
            this.checkBox_WarningDefaultAlarmClass.Location = new System.Drawing.Point(361, 133);
            this.checkBox_WarningDefaultAlarmClass.Name = "checkBox_WarningDefaultAlarmClass";
            this.checkBox_WarningDefaultAlarmClass.Size = new System.Drawing.Size(15, 14);
            this.checkBox_WarningDefaultAlarmClass.TabIndex = 34;
            this.checkBox_WarningDefaultAlarmClass.UseVisualStyleBackColor = true;
            this.checkBox_WarningDefaultAlarmClass.CheckStateChanged += new System.EventHandler(this.checkBox_xDefaultAlarmClass_CheckStateChanged);
            // 
            // checkBox_Custom1DefaultAlarmClass
            // 
            this.checkBox_Custom1DefaultAlarmClass.AutoSize = true;
            this.checkBox_Custom1DefaultAlarmClass.Location = new System.Drawing.Point(361, 159);
            this.checkBox_Custom1DefaultAlarmClass.Name = "checkBox_Custom1DefaultAlarmClass";
            this.checkBox_Custom1DefaultAlarmClass.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Custom1DefaultAlarmClass.TabIndex = 36;
            this.checkBox_Custom1DefaultAlarmClass.UseVisualStyleBackColor = true;
            this.checkBox_Custom1DefaultAlarmClass.CheckStateChanged += new System.EventHandler(this.checkBox_xDefaultAlarmClass_CheckStateChanged);
            // 
            // checkBox_Custom2DefaultAlarmClass
            // 
            this.checkBox_Custom2DefaultAlarmClass.AutoSize = true;
            this.checkBox_Custom2DefaultAlarmClass.Location = new System.Drawing.Point(361, 185);
            this.checkBox_Custom2DefaultAlarmClass.Name = "checkBox_Custom2DefaultAlarmClass";
            this.checkBox_Custom2DefaultAlarmClass.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Custom2DefaultAlarmClass.TabIndex = 35;
            this.checkBox_Custom2DefaultAlarmClass.UseVisualStyleBackColor = true;
            this.checkBox_Custom2DefaultAlarmClass.CheckStateChanged += new System.EventHandler(this.checkBox_xDefaultAlarmClass_CheckStateChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(239, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 26);
            this.label15.TabIndex = 38;
            this.label15.Text = "Program alarm\r\nFB name";
            // 
            // textBox_AbortFBname
            // 
            this.textBox_AbortFBname.Location = new System.Drawing.Point(239, 29);
            this.textBox_AbortFBname.Name = "textBox_AbortFBname";
            this.textBox_AbortFBname.Size = new System.Drawing.Size(116, 20);
            this.textBox_AbortFBname.TabIndex = 39;
            this.textBox_AbortFBname.Text = "FB_Alarm_Abort";
            // 
            // checkBox_Custom3DefaultAlarmClass
            // 
            this.checkBox_Custom3DefaultAlarmClass.AutoSize = true;
            this.checkBox_Custom3DefaultAlarmClass.Location = new System.Drawing.Point(361, 211);
            this.checkBox_Custom3DefaultAlarmClass.Name = "checkBox_Custom3DefaultAlarmClass";
            this.checkBox_Custom3DefaultAlarmClass.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Custom3DefaultAlarmClass.TabIndex = 37;
            this.checkBox_Custom3DefaultAlarmClass.UseVisualStyleBackColor = true;
            this.checkBox_Custom3DefaultAlarmClass.CheckStateChanged += new System.EventHandler(this.checkBox_xDefaultAlarmClass_CheckStateChanged);
            // 
            // textBox_PauseFBname
            // 
            this.textBox_PauseFBname.Location = new System.Drawing.Point(239, 55);
            this.textBox_PauseFBname.Name = "textBox_PauseFBname";
            this.textBox_PauseFBname.Size = new System.Drawing.Size(116, 20);
            this.textBox_PauseFBname.TabIndex = 40;
            this.textBox_PauseFBname.Text = "FB_Alarm_Pause";
            // 
            // textBox_FinishFBname
            // 
            this.textBox_FinishFBname.Location = new System.Drawing.Point(239, 81);
            this.textBox_FinishFBname.Name = "textBox_FinishFBname";
            this.textBox_FinishFBname.Size = new System.Drawing.Size(116, 20);
            this.textBox_FinishFBname.TabIndex = 41;
            this.textBox_FinishFBname.Text = "FB_Alarm_Finish";
            // 
            // textBox_SlowFBname
            // 
            this.textBox_SlowFBname.Location = new System.Drawing.Point(239, 107);
            this.textBox_SlowFBname.Name = "textBox_SlowFBname";
            this.textBox_SlowFBname.Size = new System.Drawing.Size(116, 20);
            this.textBox_SlowFBname.TabIndex = 42;
            this.textBox_SlowFBname.Text = "FB_Alarm_RunSlow";
            // 
            // textBox_WarningFBname
            // 
            this.textBox_WarningFBname.Location = new System.Drawing.Point(239, 133);
            this.textBox_WarningFBname.Name = "textBox_WarningFBname";
            this.textBox_WarningFBname.Size = new System.Drawing.Size(116, 20);
            this.textBox_WarningFBname.TabIndex = 43;
            this.textBox_WarningFBname.Text = "FB_Alarm_Warning";
            // 
            // textBox_Custom1FBname
            // 
            this.textBox_Custom1FBname.Location = new System.Drawing.Point(239, 159);
            this.textBox_Custom1FBname.Name = "textBox_Custom1FBname";
            this.textBox_Custom1FBname.Size = new System.Drawing.Size(116, 20);
            this.textBox_Custom1FBname.TabIndex = 44;
            // 
            // textBox_Custom2FBname
            // 
            this.textBox_Custom2FBname.Location = new System.Drawing.Point(239, 185);
            this.textBox_Custom2FBname.Name = "textBox_Custom2FBname";
            this.textBox_Custom2FBname.Size = new System.Drawing.Size(116, 20);
            this.textBox_Custom2FBname.TabIndex = 45;
            // 
            // textBox_Custom3FBname
            // 
            this.textBox_Custom3FBname.Location = new System.Drawing.Point(239, 211);
            this.textBox_Custom3FBname.Name = "textBox_Custom3FBname";
            this.textBox_Custom3FBname.Size = new System.Drawing.Size(116, 20);
            this.textBox_Custom3FBname.TabIndex = 46;
            // 
            // comboBox_SourceLangForAlarmCode
            // 
            this.comboBox_SourceLangForAlarmCode.FormattingEnabled = true;
            this.comboBox_SourceLangForAlarmCode.Items.AddRange(new object[] {
            "[sk-SK]",
            "[en-US]",
            "[ru-RU]",
            "[de-DE]"});
            this.comboBox_SourceLangForAlarmCode.Location = new System.Drawing.Point(457, 156);
            this.comboBox_SourceLangForAlarmCode.Name = "comboBox_SourceLangForAlarmCode";
            this.comboBox_SourceLangForAlarmCode.Size = new System.Drawing.Size(145, 21);
            this.comboBox_SourceLangForAlarmCode.TabIndex = 10;
            this.comboBox_SourceLangForAlarmCode.SelectedIndexChanged += new System.EventHandler(this.comboBox_SourceLangForAlarmCode_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(454, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 26);
            this.label11.TabIndex = 30;
            this.label11.Text = "In witch Alarm Language Text\r\nis Alarm Code:";
            // 
            // progressBar_Process
            // 
            this.progressBar_Process.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar_Process.Location = new System.Drawing.Point(0, 427);
            this.progressBar_Process.Name = "progressBar_Process";
            this.progressBar_Process.Size = new System.Drawing.Size(788, 23);
            this.progressBar_Process.TabIndex = 31;
            // 
            // textBox_DBalarms
            // 
            this.textBox_DBalarms.Location = new System.Drawing.Point(457, 202);
            this.textBox_DBalarms.Name = "textBox_DBalarms";
            this.textBox_DBalarms.Size = new System.Drawing.Size(145, 20);
            this.textBox_DBalarms.TabIndex = 38;
            this.textBox_DBalarms.Text = "DB_Alarms";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(454, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Name of DB with alarms:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(456, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Name of PLC conection:";
            // 
            // textBox_PLCconnection
            // 
            this.textBox_PLCconnection.Location = new System.Drawing.Point(459, 251);
            this.textBox_PLCconnection.Name = "textBox_PLCconnection";
            this.textBox_PLCconnection.Size = new System.Drawing.Size(143, 20);
            this.textBox_PLCconnection.TabIndex = 40;
            this.textBox_PLCconnection.Text = "D1040A1_RM1.3-40PLC0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(456, 286);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 26);
            this.label16.TabIndex = 41;
            this.label16.Text = "Text wich will not (containing)\r\ngenerated  as alarm:";
            // 
            // checkBox_NoGeneratingEnable
            // 
            this.checkBox_NoGeneratingEnable.AutoSize = true;
            this.checkBox_NoGeneratingEnable.Location = new System.Drawing.Point(588, 301);
            this.checkBox_NoGeneratingEnable.Name = "checkBox_NoGeneratingEnable";
            this.checkBox_NoGeneratingEnable.Size = new System.Drawing.Size(15, 14);
            this.checkBox_NoGeneratingEnable.TabIndex = 47;
            this.checkBox_NoGeneratingEnable.UseVisualStyleBackColor = true;
            // 
            // textBox_NoGeneratingText
            // 
            this.textBox_NoGeneratingText.Location = new System.Drawing.Point(459, 318);
            this.textBox_NoGeneratingText.Name = "textBox_NoGeneratingText";
            this.textBox_NoGeneratingText.Size = new System.Drawing.Size(143, 20);
            this.textBox_NoGeneratingText.TabIndex = 48;
            this.textBox_NoGeneratingText.Text = "Reserve";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.textBox_NoGeneratingText);
            this.Controls.Add(this.checkBox_NoGeneratingEnable);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_PLCconnection);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_DBalarms);
            this.Controls.Add(this.progressBar_Process);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox_SourceLangForAlarmCode);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.checkedListBox_Lang);
            this.Controls.Add(this.button_SearchProject);
            this.Controls.Add(this.button_ExportAlarms);
            this.Controls.Add(this.textBox_ProjectPath);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "TIA Portal 15.1 Export Alarms";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ProjectPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Project;
        private System.Windows.Forms.Button button_ExportAlarms;
        private System.Windows.Forms.Button button_SearchProject;
        private System.Windows.Forms.CheckedListBox checkedListBox_Lang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_AbortTextCode;
        private System.Windows.Forms.TextBox textBox_AbortHMIClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Custom3HMIClassName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_PauseTextCode;
        private System.Windows.Forms.TextBox textBox_FinishTextCode;
        private System.Windows.Forms.TextBox textBox_SlowTextCode;
        private System.Windows.Forms.TextBox textBox_WarningTextCode;
        private System.Windows.Forms.TextBox textBox_Custom1TextCode;
        private System.Windows.Forms.TextBox textBox_Custom2TextCode;
        private System.Windows.Forms.TextBox textBox_Custom3TextCode;
        private System.Windows.Forms.TextBox textBox_PauseHMIClassName;
        private System.Windows.Forms.TextBox textBox_FinishHMIClassName;
        private System.Windows.Forms.TextBox textBox_SlowHMIClassName;
        private System.Windows.Forms.TextBox textBox_Custom1HMIClassName;
        private System.Windows.Forms.TextBox textBox_Custom2HMIClassName;
        private System.Windows.Forms.TextBox textBox_WarningHMIClassName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_SourceLangForAlarmCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox_AbortDefaultAlarmClass;
        private System.Windows.Forms.CheckBox checkBox_PauseDefaultAlarmClass;
        private System.Windows.Forms.CheckBox checkBox_FinishDefaultAlarmClass;
        private System.Windows.Forms.CheckBox checkBox_SlowDefaultAlarmClass;
        private System.Windows.Forms.CheckBox checkBox_WarningDefaultAlarmClass;
        private System.Windows.Forms.CheckBox checkBox_Custom2DefaultAlarmClass;
        private System.Windows.Forms.CheckBox checkBox_Custom1DefaultAlarmClass;
        private System.Windows.Forms.CheckBox checkBox_Custom3DefaultAlarmClass;
        private System.Windows.Forms.ProgressBar progressBar_Process;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_DBalarms;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_PLCconnection;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_AbortFBname;
        private System.Windows.Forms.TextBox textBox_PauseFBname;
        private System.Windows.Forms.TextBox textBox_FinishFBname;
        private System.Windows.Forms.TextBox textBox_SlowFBname;
        private System.Windows.Forms.TextBox textBox_WarningFBname;
        private System.Windows.Forms.TextBox textBox_Custom1FBname;
        private System.Windows.Forms.TextBox textBox_Custom2FBname;
        private System.Windows.Forms.TextBox textBox_Custom3FBname;
        private System.Windows.Forms.TextBox textBox_NoGeneratingText;
        private System.Windows.Forms.CheckBox checkBox_NoGeneratingEnable;
        private System.Windows.Forms.Label label16;
    }
}

