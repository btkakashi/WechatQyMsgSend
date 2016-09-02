namespace QyWexin
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
            this.btnSend = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblPic = new System.Windows.Forms.Label();
            this.lblRtnMsg = new System.Windows.Forms.Label();
            this.tRtnMsg = new System.Windows.Forms.TextBox();
            this.tUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.tDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tCorpSecret = new System.Windows.Forms.TextBox();
            this.lblCorpSecret = new System.Windows.Forms.Label();
            this.tCorpId = new System.Windows.Forms.TextBox();
            this.lblCorpId = new System.Windows.Forms.Label();
            this.tProxyPassword = new System.Windows.Forms.TextBox();
            this.lblProxyPassword = new System.Windows.Forms.Label();
            this.tProxyName = new System.Windows.Forms.TextBox();
            this.lblProxyName = new System.Windows.Forms.Label();
            this.tProxyPort = new System.Windows.Forms.TextBox();
            this.lblProxyPort = new System.Windows.Forms.Label();
            this.tProxyHost = new System.Windows.Forms.TextBox();
            this.lblProxyHost = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tPicPath = new System.Windows.Forms.TextBox();
            this.tUploadPicUrl = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(132, 237);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 21);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(18, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 487);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tUploadPicUrl);
            this.tabPage1.Controls.Add(this.tPicPath);
            this.tabPage1.Controls.Add(this.btnUpload);
            this.tabPage1.Controls.Add(this.lblPic);
            this.tabPage1.Controls.Add(this.lblRtnMsg);
            this.tabPage1.Controls.Add(this.tRtnMsg);
            this.tabPage1.Controls.Add(this.tUrl);
            this.tabPage1.Controls.Add(this.lblUrl);
            this.tabPage1.Controls.Add(this.tDescription);
            this.tabPage1.Controls.Add(this.lblDescription);
            this.tabPage1.Controls.Add(this.tTitle);
            this.tabPage1.Controls.Add(this.lblTitle);
            this.tabPage1.Controls.Add(this.btnSend);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(501, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "消息发送";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(366, 158);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 21);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "选择图片";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Location = new System.Drawing.Point(49, 164);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(52, 16);
            this.lblPic.TabIndex = 9;
            this.lblPic.Text = "上传图片";
            // 
            // lblRtnMsg
            // 
            this.lblRtnMsg.AutoSize = true;
            this.lblRtnMsg.Location = new System.Drawing.Point(49, 349);
            this.lblRtnMsg.Name = "lblRtnMsg";
            this.lblRtnMsg.Size = new System.Drawing.Size(52, 16);
            this.lblRtnMsg.TabIndex = 8;
            this.lblRtnMsg.Text = "返回消息";
            // 
            // tRtnMsg
            // 
            this.tRtnMsg.Location = new System.Drawing.Point(132, 346);
            this.tRtnMsg.Multiline = true;
            this.tRtnMsg.Name = "tRtnMsg";
            this.tRtnMsg.Size = new System.Drawing.Size(200, 89);
            this.tRtnMsg.TabIndex = 7;
            // 
            // tUrl
            // 
            this.tUrl.Location = new System.Drawing.Point(132, 113);
            this.tUrl.Name = "tUrl";
            this.tUrl.Size = new System.Drawing.Size(200, 22);
            this.tUrl.TabIndex = 6;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(49, 118);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(52, 16);
            this.lblUrl.TabIndex = 5;
            this.lblUrl.Text = "链接地址";
            // 
            // tDescription
            // 
            this.tDescription.Location = new System.Drawing.Point(132, 67);
            this.tDescription.Name = "tDescription";
            this.tDescription.Size = new System.Drawing.Size(200, 22);
            this.tDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(49, 73);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(30, 16);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "描述";
            // 
            // tTitle
            // 
            this.tTitle.Location = new System.Drawing.Point(132, 25);
            this.tTitle.Name = "tTitle";
            this.tTitle.Size = new System.Drawing.Size(147, 22);
            this.tTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(49, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "标题";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tCorpSecret);
            this.tabPage2.Controls.Add(this.lblCorpSecret);
            this.tabPage2.Controls.Add(this.tCorpId);
            this.tabPage2.Controls.Add(this.lblCorpId);
            this.tabPage2.Controls.Add(this.tProxyPassword);
            this.tabPage2.Controls.Add(this.lblProxyPassword);
            this.tabPage2.Controls.Add(this.tProxyName);
            this.tabPage2.Controls.Add(this.lblProxyName);
            this.tabPage2.Controls.Add(this.tProxyPort);
            this.tabPage2.Controls.Add(this.lblProxyPort);
            this.tabPage2.Controls.Add(this.tProxyHost);
            this.tabPage2.Controls.Add(this.lblProxyHost);
            this.tabPage2.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(501, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "参数配置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tCorpSecret
            // 
            this.tCorpSecret.Location = new System.Drawing.Point(142, 236);
            this.tCorpSecret.Name = "tCorpSecret";
            this.tCorpSecret.Size = new System.Drawing.Size(318, 22);
            this.tCorpSecret.TabIndex = 11;
            // 
            // lblCorpSecret
            // 
            this.lblCorpSecret.AutoSize = true;
            this.lblCorpSecret.Location = new System.Drawing.Point(48, 241);
            this.lblCorpSecret.Name = "lblCorpSecret";
            this.lblCorpSecret.Size = new System.Drawing.Size(68, 16);
            this.lblCorpSecret.TabIndex = 10;
            this.lblCorpSecret.Text = "Corp Secret";
            // 
            // tCorpId
            // 
            this.tCorpId.Location = new System.Drawing.Point(142, 204);
            this.tCorpId.Name = "tCorpId";
            this.tCorpId.Size = new System.Drawing.Size(147, 22);
            this.tCorpId.TabIndex = 9;
            // 
            // lblCorpId
            // 
            this.lblCorpId.AutoSize = true;
            this.lblCorpId.Location = new System.Drawing.Point(48, 209);
            this.lblCorpId.Name = "lblCorpId";
            this.lblCorpId.Size = new System.Drawing.Size(46, 16);
            this.lblCorpId.TabIndex = 8;
            this.lblCorpId.Text = "Corp Id";
            // 
            // tProxyPassword
            // 
            this.tProxyPassword.Location = new System.Drawing.Point(142, 133);
            this.tProxyPassword.Name = "tProxyPassword";
            this.tProxyPassword.Size = new System.Drawing.Size(147, 22);
            this.tProxyPassword.TabIndex = 7;
            // 
            // lblProxyPassword
            // 
            this.lblProxyPassword.AutoSize = true;
            this.lblProxyPassword.Location = new System.Drawing.Point(48, 138);
            this.lblProxyPassword.Name = "lblProxyPassword";
            this.lblProxyPassword.Size = new System.Drawing.Size(91, 16);
            this.lblProxyPassword.TabIndex = 6;
            this.lblProxyPassword.Text = "Proxy Password";
            // 
            // tProxyName
            // 
            this.tProxyName.Location = new System.Drawing.Point(142, 102);
            this.tProxyName.Name = "tProxyName";
            this.tProxyName.Size = new System.Drawing.Size(147, 22);
            this.tProxyName.TabIndex = 5;
            // 
            // lblProxyName
            // 
            this.lblProxyName.AutoSize = true;
            this.lblProxyName.Location = new System.Drawing.Point(48, 107);
            this.lblProxyName.Name = "lblProxyName";
            this.lblProxyName.Size = new System.Drawing.Size(72, 16);
            this.lblProxyName.TabIndex = 4;
            this.lblProxyName.Text = "Proxy Name";
            // 
            // tProxyPort
            // 
            this.tProxyPort.Location = new System.Drawing.Point(142, 74);
            this.tProxyPort.Name = "tProxyPort";
            this.tProxyPort.Size = new System.Drawing.Size(147, 22);
            this.tProxyPort.TabIndex = 3;
            // 
            // lblProxyPort
            // 
            this.lblProxyPort.AutoSize = true;
            this.lblProxyPort.Location = new System.Drawing.Point(48, 78);
            this.lblProxyPort.Name = "lblProxyPort";
            this.lblProxyPort.Size = new System.Drawing.Size(63, 16);
            this.lblProxyPort.TabIndex = 2;
            this.lblProxyPort.Text = "Proxy Port";
            // 
            // tProxyHost
            // 
            this.tProxyHost.Location = new System.Drawing.Point(142, 43);
            this.tProxyHost.Name = "tProxyHost";
            this.tProxyHost.Size = new System.Drawing.Size(147, 22);
            this.tProxyHost.TabIndex = 1;
            // 
            // lblProxyHost
            // 
            this.lblProxyHost.AutoSize = true;
            this.lblProxyHost.Location = new System.Drawing.Point(48, 48);
            this.lblProxyHost.Name = "lblProxyHost";
            this.lblProxyHost.Size = new System.Drawing.Size(66, 16);
            this.lblProxyHost.TabIndex = 0;
            this.lblProxyHost.Text = "Proxy Host";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tPicPath
            // 
            this.tPicPath.Location = new System.Drawing.Point(132, 158);
            this.tPicPath.Name = "tPicPath";
            this.tPicPath.Size = new System.Drawing.Size(200, 22);
            this.tPicPath.TabIndex = 12;
            // 
            // tUploadPicUrl
            // 
            this.tUploadPicUrl.Location = new System.Drawing.Point(132, 197);
            this.tUploadPicUrl.Name = "tUploadPicUrl";
            this.tUploadPicUrl.Size = new System.Drawing.Size(200, 22);
            this.tUploadPicUrl.TabIndex = 13;
            this.tUploadPicUrl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 601);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tProxyHost;
        private System.Windows.Forms.Label lblProxyHost;
        private System.Windows.Forms.TextBox tCorpSecret;
        private System.Windows.Forms.Label lblCorpSecret;
        private System.Windows.Forms.TextBox tCorpId;
        private System.Windows.Forms.Label lblCorpId;
        private System.Windows.Forms.TextBox tProxyPassword;
        private System.Windows.Forms.Label lblProxyPassword;
        private System.Windows.Forms.TextBox tProxyName;
        private System.Windows.Forms.Label lblProxyName;
        private System.Windows.Forms.TextBox tProxyPort;
        private System.Windows.Forms.Label lblProxyPort;
        private System.Windows.Forms.TextBox tTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox tDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tRtnMsg;
        private System.Windows.Forms.Label lblRtnMsg;
        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox tPicPath;
        private System.Windows.Forms.TextBox tUploadPicUrl;
    }
}

