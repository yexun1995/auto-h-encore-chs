﻿namespace auto_h_encore {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAID = new System.Windows.Forms.TextBox();
            this.lblAID = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblHowToAID = new System.Windows.Forms.LinkLabel();
            this.lblQCMA = new System.Windows.Forms.Label();
            this.txtQCMA = new System.Windows.Forms.TextBox();
            this.btnBrowseQCMA = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.barProgress = new System.Windows.Forms.ProgressBar();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.cbxDelete = new System.Windows.Forms.CheckBox();
            this.cbxTrim = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtAID
            // 
            this.txtAID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAID.Location = new System.Drawing.Point(12, 26);
            this.txtAID.Name = "txtAID";
            this.txtAID.Size = new System.Drawing.Size(569, 21);
            this.txtAID.TabIndex = 0;
            this.txtAID.TextChanged += new System.EventHandler(this.txtAID_TextChanged);
            // 
            // lblAID
            // 
            this.lblAID.AutoSize = true;
            this.lblAID.Location = new System.Drawing.Point(9, 11);
            this.lblAID.Name = "lblAID";
            this.lblAID.Size = new System.Drawing.Size(101, 12);
            this.lblAID.TabIndex = 1;
            this.lblAID.Text = "Account ID (AID)";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 381);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(569, 259);
            this.txtLog.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 354);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(569, 21);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblHowToAID
            // 
            this.lblHowToAID.AutoSize = true;
            this.lblHowToAID.Location = new System.Drawing.Point(9, 86);
            this.lblHowToAID.Name = "lblHowToAID";
            this.lblHowToAID.Size = new System.Drawing.Size(119, 12);
            this.lblHowToAID.TabIndex = 4;
            this.lblHowToAID.TabStop = true;
            this.lblHowToAID.Text = "我如何获取这些信息?";
            this.lblHowToAID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHowToAID_LinkClicked);
            // 
            // lblQCMA
            // 
            this.lblQCMA.AutoSize = true;
            this.lblQCMA.Location = new System.Drawing.Point(9, 50);
            this.lblQCMA.Name = "lblQCMA";
            this.lblQCMA.Size = new System.Drawing.Size(155, 12);
            this.lblQCMA.TabIndex = 6;
            this.lblQCMA.Text = "QCMA PS Vita 数据备份目录";
            // 
            // txtQCMA
            // 
            this.txtQCMA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQCMA.Location = new System.Drawing.Point(12, 65);
            this.txtQCMA.Name = "txtQCMA";
            this.txtQCMA.Size = new System.Drawing.Size(488, 21);
            this.txtQCMA.TabIndex = 5;
            this.txtQCMA.TextChanged += new System.EventHandler(this.txtQCMA_TextChanged);
            // 
            // btnBrowseQCMA
            // 
            this.btnBrowseQCMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseQCMA.Location = new System.Drawing.Point(506, 63);
            this.btnBrowseQCMA.Name = "btnBrowseQCMA";
            this.btnBrowseQCMA.Size = new System.Drawing.Size(75, 21);
            this.btnBrowseQCMA.TabIndex = 7;
            this.btnBrowseQCMA.Text = "浏览";
            this.btnBrowseQCMA.UseVisualStyleBackColor = true;
            this.btnBrowseQCMA.Click += new System.EventHandler(this.btnBrowseQCMA_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Location = new System.Drawing.Point(12, 112);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(569, 137);
            this.lblInfo.TabIndex = 8;
            // 
            // barProgress
            // 
            this.barProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barProgress.Location = new System.Drawing.Point(12, 328);
            this.barProgress.Maximum = 17;
            this.barProgress.Name = "barProgress";
            this.barProgress.Size = new System.Drawing.Size(569, 21);
            this.barProgress.TabIndex = 9;
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(326, 644);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(255, 12);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "auto h-encore version x";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 260);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(566, 21);
            this.btnImport.TabIndex = 11;
            this.btnImport.Text = "我已经下载了一部分或者全部必要的文件，我想使用它们";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // cbxDelete
            // 
            this.cbxDelete.AutoSize = true;
            this.cbxDelete.Location = new System.Drawing.Point(15, 306);
            this.cbxDelete.Name = "cbxDelete";
            this.cbxDelete.Size = new System.Drawing.Size(306, 16);
            this.cbxDelete.TabIndex = 12;
            this.cbxDelete.Text = "删除已存在的文件 (如果之前的操作出错了，选择它)";
            this.cbxDelete.UseVisualStyleBackColor = true;
            // 
            // cbxTrim
            // 
            this.cbxTrim.AutoSize = true;
            this.cbxTrim.Checked = true;
            this.cbxTrim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTrim.Location = new System.Drawing.Point(15, 285);
            this.cbxTrim.Name = "cbxTrim";
            this.cbxTrim.Size = new System.Drawing.Size(498, 16);
            this.cbxTrim.TabIndex = 13;
            this.cbxTrim.Text = "删减 bitter smile 试玩版 的多余内容 (将 h-encore app 大小 从 240MB 减小至 17MB)";
            this.cbxTrim.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 663);
            this.Controls.Add(this.cbxTrim);
            this.Controls.Add(this.cbxDelete);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.barProgress);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnBrowseQCMA);
            this.Controls.Add(this.lblQCMA);
            this.Controls.Add(this.txtQCMA);
            this.Controls.Add(this.lblHowToAID);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblAID);
            this.Controls.Add(this.txtAID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "自动化 h-encore 汉化By 多玩 天鹰叶寻";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAID;
        private System.Windows.Forms.Label lblAID;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.LinkLabel lblHowToAID;
        private System.Windows.Forms.Label lblQCMA;
        private System.Windows.Forms.TextBox txtQCMA;
        private System.Windows.Forms.Button btnBrowseQCMA;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ProgressBar barProgress;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.CheckBox cbxDelete;
        private System.Windows.Forms.CheckBox cbxTrim;
    }
}

