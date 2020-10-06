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
            this.openFileDialog_Project.FileName = "TIA Porta 15.1 Projcet *.ap15_1";
            this.openFileDialog_Project.Filter = "TIA Portal 15.1|*.ap15_1|All files|*.*";
            this.openFileDialog_Project.FilterIndex = 0;
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
            "[en-US]"});
            this.checkedListBox_Lang.Location = new System.Drawing.Point(334, 38);
            this.checkedListBox_Lang.Name = "checkedListBox_Lang";
            this.checkedListBox_Lang.Size = new System.Drawing.Size(120, 49);
            this.checkedListBox_Lang.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox_Lang);
            this.Controls.Add(this.button_SearchProject);
            this.Controls.Add(this.button_ExportAlarms);
            this.Controls.Add(this.textBox_ProjectPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ProjectPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Project;
        private System.Windows.Forms.Button button_ExportAlarms;
        private System.Windows.Forms.Button button_SearchProject;
        private System.Windows.Forms.CheckedListBox checkedListBox_Lang;
    }
}

