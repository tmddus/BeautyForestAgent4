﻿namespace BeautyForestAgent
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
            this.loadFileDlg = new System.Windows.Forms.TabPage();
            this.saveFileDlg = new System.Windows.Forms.TabPage();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.txtLoadFile = new System.Windows.Forms.TextBox();
            this.btnLoadFileSelect = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.txtLoadText = new System.Windows.Forms.TextBox();
            this.txtSaveFile = new System.Windows.Forms.TextBox();
            this.txtSaveText = new System.Windows.Forms.TextBox();
            this.btnSaveFileSelect = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.tabMode.SuspendLayout();
            this.loadFileDlg.SuspendLayout();
            this.saveFileDlg.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMode
            // 
            this.tabMode.Controls.Add(this.loadFileDlg);
            this.tabMode.Controls.Add(this.saveFileDlg);
            this.tabMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMode.Location = new System.Drawing.Point(0, 0);
            this.tabMode.Multiline = true;
            this.tabMode.Name = "tabMode";
            this.tabMode.SelectedIndex = 0;
            this.tabMode.Size = new System.Drawing.Size(485, 341);
            this.tabMode.TabIndex = 0;
            // 
            // loadFileDlg
            // 
            this.loadFileDlg.Controls.Add(this.txtLoadText);
            this.loadFileDlg.Controls.Add(this.btnLoadFile);
            this.loadFileDlg.Controls.Add(this.btnLoadFileSelect);
            this.loadFileDlg.Controls.Add(this.txtLoadFile);
            this.loadFileDlg.Controls.Add(this.Status);
            this.loadFileDlg.Location = new System.Drawing.Point(4, 22);
            this.loadFileDlg.Name = "loadFileDlg";
            this.loadFileDlg.Padding = new System.Windows.Forms.Padding(3);
            this.loadFileDlg.Size = new System.Drawing.Size(477, 315);
            this.loadFileDlg.TabIndex = 0;
            this.loadFileDlg.Text = "파일읽기";
            this.loadFileDlg.UseVisualStyleBackColor = true;
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.Controls.Add(this.btnSaveFile);
            this.saveFileDlg.Controls.Add(this.btnSaveFileSelect);
            this.saveFileDlg.Controls.Add(this.txtSaveText);
            this.saveFileDlg.Controls.Add(this.txtSaveFile);
            this.saveFileDlg.Location = new System.Drawing.Point(4, 22);
            this.saveFileDlg.Name = "saveFileDlg";
            this.saveFileDlg.Padding = new System.Windows.Forms.Padding(3);
            this.saveFileDlg.Size = new System.Drawing.Size(477, 315);
            this.saveFileDlg.TabIndex = 1;
            this.saveFileDlg.Text = "파일쓰기";
            this.saveFileDlg.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(3, 290);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(471, 22);
            this.Status.TabIndex = 0;
            this.Status.Text = "statusStrip1";
            // 
            // txtLoadFile
            // 
            this.txtLoadFile.Location = new System.Drawing.Point(8, 8);
            this.txtLoadFile.Name = "txtLoadFile";
            this.txtLoadFile.ReadOnly = true;
            this.txtLoadFile.Size = new System.Drawing.Size(271, 21);
            this.txtLoadFile.TabIndex = 1;
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
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(394, 8);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 3;
            this.btnLoadFile.Text = "불러오기";
            this.btnLoadFile.UseVisualStyleBackColor = true;
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
            // txtSaveFile
            // 
            this.txtSaveFile.Location = new System.Drawing.Point(8, 8);
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.ReadOnly = true;
            this.txtSaveFile.Size = new System.Drawing.Size(299, 21);
            this.txtSaveFile.TabIndex = 0;
            // 
            // txtSaveText
            // 
            this.txtSaveText.Location = new System.Drawing.Point(8, 35);
            this.txtSaveText.Multiline = true;
            this.txtSaveText.Name = "txtSaveText";
            this.txtSaveText.Size = new System.Drawing.Size(461, 272);
            this.txtSaveText.TabIndex = 1;
            // 
            // btnSaveFileSelect
            // 
            this.btnSaveFileSelect.Location = new System.Drawing.Point(313, 8);
            this.btnSaveFileSelect.Name = "btnSaveFileSelect";
            this.btnSaveFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFileSelect.TabIndex = 2;
            this.btnSaveFileSelect.Text = "파일열기";
            this.btnSaveFileSelect.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(394, 6);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 3;
            this.btnSaveFile.Text = "저장하기";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // FormMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 341);
            this.Controls.Add(this.tabMode);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMemo";
            this.Text = "FormMemo";
            this.tabMode.ResumeLayout(false);
            this.loadFileDlg.ResumeLayout(false);
            this.loadFileDlg.PerformLayout();
            this.saveFileDlg.ResumeLayout(false);
            this.saveFileDlg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMode;
        private System.Windows.Forms.TabPage loadFileDlg;
        private System.Windows.Forms.TabPage saveFileDlg;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.TextBox txtLoadText;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnLoadFileSelect;
        private System.Windows.Forms.TextBox txtLoadFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnSaveFileSelect;
        private System.Windows.Forms.TextBox txtSaveText;
        private System.Windows.Forms.TextBox txtSaveFile;
    }
}