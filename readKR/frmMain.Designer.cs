namespace readKR
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows 窗体设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.tbCategoryInfo = new System.Windows.Forms.TextBox();
            this.tbTextInfo = new System.Windows.Forms.TextBox();
            this.tbCategoryID = new System.Windows.Forms.TextBox();
            this.rbZh = new System.Windows.Forms.RadioButton();
            this.rbEn = new System.Windows.Forms.RadioButton();
            this.grpLanguage = new System.Windows.Forms.GroupBox();
            this.wbXML = new System.Windows.Forms.WebBrowser();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.grpLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.btnGetInfo.Location = new System.Drawing.Point(30, 37);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(107, 34);
            this.btnGetInfo.TabIndex = 0;
            this.btnGetInfo.Text = "get";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCategoryInfo
            // 
            this.tbCategoryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCategoryInfo.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.tbCategoryInfo.Location = new System.Drawing.Point(30, 111);
            this.tbCategoryInfo.Multiline = true;
            this.tbCategoryInfo.Name = "tbCategoryInfo";
            this.tbCategoryInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCategoryInfo.Size = new System.Drawing.Size(546, 354);
            this.tbCategoryInfo.TabIndex = 1;
            // 
            // tbTextInfo
            // 
            this.tbTextInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTextInfo.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTextInfo.Location = new System.Drawing.Point(30, 481);
            this.tbTextInfo.Multiline = true;
            this.tbTextInfo.Name = "tbTextInfo";
            this.tbTextInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTextInfo.Size = new System.Drawing.Size(546, 149);
            this.tbTextInfo.TabIndex = 3;
            // 
            // tbCategoryID
            // 
            this.tbCategoryID.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.tbCategoryID.Location = new System.Drawing.Point(268, 40);
            this.tbCategoryID.Name = "tbCategoryID";
            this.tbCategoryID.Size = new System.Drawing.Size(115, 29);
            this.tbCategoryID.TabIndex = 4;
            // 
            // rbZh
            // 
            this.rbZh.AutoSize = true;
            this.rbZh.Location = new System.Drawing.Point(31, 36);
            this.rbZh.Name = "rbZh";
            this.rbZh.Size = new System.Drawing.Size(49, 27);
            this.rbZh.TabIndex = 5;
            this.rbZh.Text = "zh";
            this.rbZh.UseVisualStyleBackColor = true;
            // 
            // rbEn
            // 
            this.rbEn.AutoSize = true;
            this.rbEn.Checked = true;
            this.rbEn.Location = new System.Drawing.Point(161, 36);
            this.rbEn.Name = "rbEn";
            this.rbEn.Size = new System.Drawing.Size(50, 27);
            this.rbEn.TabIndex = 6;
            this.rbEn.TabStop = true;
            this.rbEn.Text = "en";
            this.rbEn.UseVisualStyleBackColor = true;
            // 
            // grpLanguage
            // 
            this.grpLanguage.Controls.Add(this.rbEn);
            this.grpLanguage.Controls.Add(this.rbZh);
            this.grpLanguage.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.grpLanguage.Location = new System.Drawing.Point(389, 12);
            this.grpLanguage.Name = "grpLanguage";
            this.grpLanguage.Size = new System.Drawing.Size(248, 70);
            this.grpLanguage.TabIndex = 7;
            this.grpLanguage.TabStop = false;
            this.grpLanguage.Text = "language";
            // 
            // wbXML
            // 
            this.wbXML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbXML.Location = new System.Drawing.Point(603, 111);
            this.wbXML.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbXML.Name = "wbXML";
            this.wbXML.Size = new System.Drawing.Size(611, 519);
            this.wbXML.TabIndex = 8;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lblCategoryID.Location = new System.Drawing.Point(143, 43);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(102, 23);
            this.lblCategoryID.TabIndex = 9;
            this.lblCategoryID.Text = "CategoryID:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 781);
            this.Controls.Add(this.lblCategoryID);
            this.Controls.Add(this.wbXML);
            this.Controls.Add(this.grpLanguage);
            this.Controls.Add(this.tbCategoryID);
            this.Controls.Add(this.tbTextInfo);
            this.Controls.Add(this.tbCategoryInfo);
            this.Controls.Add(this.btnGetInfo);
            this.Name = "frmMain";
            this.Text = "readKR";
            this.grpLanguage.ResumeLayout(false);
            this.grpLanguage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox tbCategoryInfo;
        private System.Windows.Forms.TextBox tbTextInfo;
        private System.Windows.Forms.TextBox tbCategoryID;
        private System.Windows.Forms.RadioButton rbZh;
        private System.Windows.Forms.RadioButton rbEn;
        private System.Windows.Forms.GroupBox grpLanguage;
        private System.Windows.Forms.WebBrowser wbXML;
        private System.Windows.Forms.Label lblCategoryID;
    }
}
