namespace BeautyForestAgent
{
    partial class FormMemo
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
            this.tabMode = new System.Windows.Forms.TabControl();
            this.load = new System.Windows.Forms.TabPage();
            this.txtLoadText = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnLoadFileSelect = new System.Windows.Forms.Button();
            this.txtLoadFile = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.save = new System.Windows.Forms.TabPage();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnSaveFileSelect = new System.Windows.Forms.Button();
            this.txtSaveText = new System.Windows.Forms.TextBox();
            this.txtSaveFile = new System.Windows.Forms.TextBox();
            this.saveFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.loadFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMode.SuspendLayout();
            this.load.SuspendLayout();
            this.Status.SuspendLayout();
            this.save.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMode
            // 
            this.tabMode.Controls.Add(this.load);
            this.tabMode.Controls.Add(this.save);
            this.tabMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMode.Location = new System.Drawing.Point(0, 0);
            this.tabMode.Multiline = true;
            this.tabMode.Name = "tabMode";
            this.tabMode.SelectedIndex = 0;
            this.tabMode.Size = new System.Drawing.Size(485, 341);
            this.tabMode.TabIndex = 0;
            // 
            // load
            // 
            this.load.Controls.Add(this.txtLoadText);
            this.load.Controls.Add(this.btnLoadFile);
            this.load.Controls.Add(this.btnLoadFileSelect);
            this.load.Controls.Add(this.txtLoadFile);
            this.load.Controls.Add(this.Status);
            this.load.ImeMode = System.Windows.Forms.ImeMode.On;
            this.load.Location = new System.Drawing.Point(4, 22);
            this.load.Name = "load";
            this.load.Padding = new System.Windows.Forms.Padding(3);
            this.load.Size = new System.Drawing.Size(477, 315);
            this.load.TabIndex = 0;
            this.load.Text = "파일읽기";
            this.load.UseVisualStyleBackColor = true;
            // 
            // txtLoadText
            // 
            this.txtLoadText.Location = new System.Drawing.Point(8, 35);
            this.txtLoadText.Multiline = true;
            this.txtLoadText.Name = "txtLoadText";
            this.txtLoadText.ReadOnly = true;
            this.txtLoadText.Size = new System.Drawing.Size(461, 252);
            this.txtLoadText.TabIndex = 4;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(394, 8);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 3;
            this.btnLoadFile.Text = "불러오기";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // btnLoadFileSelect
            // 
            this.btnLoadFileSelect.Location = new System.Drawing.Point(303, 8);
            this.btnLoadFileSelect.Name = "btnLoadFileSelect";
            this.btnLoadFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFileSelect.TabIndex = 2;
            this.btnLoadFileSelect.Text = "파일선택";
            this.btnLoadFileSelect.UseVisualStyleBackColor = true;
            this.btnLoadFileSelect.Click += new System.EventHandler(this.BtnLoadFileSelect_Click);
            // 
            // txtLoadFile
            // 
            this.txtLoadFile.Location = new System.Drawing.Point(8, 8);
            this.txtLoadFile.Name = "txtLoadFile";
            this.txtLoadFile.ReadOnly = true;
            this.txtLoadFile.Size = new System.Drawing.Size(271, 21);
            this.txtLoadFile.TabIndex = 1;
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.Status.Location = new System.Drawing.Point(3, 290);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(471, 22);
            this.Status.TabIndex = 0;
            this.Status.Text = "statusStrip1";
            // 
            // save
            // 
            this.save.Controls.Add(this.btnSaveFile);
            this.save.Controls.Add(this.btnSaveFileSelect);
            this.save.Controls.Add(this.txtSaveText);
            this.save.Controls.Add(this.txtSaveFile);
            this.save.Location = new System.Drawing.Point(4, 22);
            this.save.Name = "save";
            this.save.Padding = new System.Windows.Forms.Padding(3);
            this.save.Size = new System.Drawing.Size(477, 315);
            this.save.TabIndex = 1;
            this.save.Text = "파일쓰기";
            this.save.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(396, 8);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 3;
            this.btnSaveFile.Text = "저장하기";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // btnSaveFileSelect
            // 
            this.btnSaveFileSelect.Location = new System.Drawing.Point(313, 8);
            this.btnSaveFileSelect.Name = "btnSaveFileSelect";
            this.btnSaveFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFileSelect.TabIndex = 2;
            this.btnSaveFileSelect.Text = "파일열기";
            this.btnSaveFileSelect.UseVisualStyleBackColor = true;
            this.btnSaveFileSelect.Click += new System.EventHandler(this.BtnSaveFileSelect_Click);
            // 
            // txtSaveText
            // 
            this.txtSaveText.Location = new System.Drawing.Point(8, 35);
            this.txtSaveText.Multiline = true;
            this.txtSaveText.Name = "txtSaveText";
            this.txtSaveText.Size = new System.Drawing.Size(461, 272);
            this.txtSaveText.TabIndex = 1;
            // 
            // txtSaveFile
            // 
            this.txtSaveFile.Location = new System.Drawing.Point(8, 8);
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.ReadOnly = true;
            this.txtSaveFile.Size = new System.Drawing.Size(299, 21);
            this.txtSaveFile.TabIndex = 0;
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.FileName = "openFileDialog1";
            // 
            // loadFileDlg
            // 
            this.loadFileDlg.FileName = "openFileDialog1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(168, 17);
            this.toolStripStatusLabel1.Text = "3610 송승연 - 파일 읽고 쓰기";
            // 
            // FormMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 341);
            this.Controls.Add(this.tabMode);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMemo";
            this.Text = "3610 송승연";
            this.tabMode.ResumeLayout(false);
            this.load.ResumeLayout(false);
            this.load.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.save.ResumeLayout(false);
            this.save.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMode;
        private System.Windows.Forms.TabPage load;
        private System.Windows.Forms.TabPage save;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.TextBox txtLoadText;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnLoadFileSelect;
        private System.Windows.Forms.TextBox txtLoadFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnSaveFileSelect;
        private System.Windows.Forms.TextBox txtSaveText;
        private System.Windows.Forms.TextBox txtSaveFile;
        private System.Windows.Forms.OpenFileDialog saveFileDlg;
        private System.Windows.Forms.OpenFileDialog loadFileDlg;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}