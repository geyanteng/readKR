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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabTreeView = new System.Windows.Forms.TabPage();
            this.tbScope = new System.Windows.Forms.TextBox();
            this.wbContent = new System.Windows.Forms.WebBrowser();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabWordSearch = new System.Windows.Forms.TabPage();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.tbsearchword = new System.Windows.Forms.TextBox();
            this.btntitlesearch = new System.Windows.Forms.Button();
            this.tabCheckList = new System.Windows.Forms.TabPage();
            this.tabTest = new System.Windows.Forms.TabPage();
            this.grpLanguage.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabTreeView.SuspendLayout();
            this.tabWordSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.tabTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.btnGetInfo.Location = new System.Drawing.Point(17, 7);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(117, 34);
            this.btnGetInfo.TabIndex = 0;
            this.btnGetInfo.Text = "get";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            // 
            // tbCategoryInfo
            // 
            this.tbCategoryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCategoryInfo.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.tbCategoryInfo.Location = new System.Drawing.Point(166, 10);
            this.tbCategoryInfo.Multiline = true;
            this.tbCategoryInfo.Name = "tbCategoryInfo";
            this.tbCategoryInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCategoryInfo.Size = new System.Drawing.Size(453, 422);
            this.tbCategoryInfo.TabIndex = 1;
            // 
            // tbTextInfo
            // 
            this.tbTextInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTextInfo.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTextInfo.Location = new System.Drawing.Point(166, 438);
            this.tbTextInfo.Multiline = true;
            this.tbTextInfo.Name = "tbTextInfo";
            this.tbTextInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTextInfo.Size = new System.Drawing.Size(453, 149);
            this.tbTextInfo.TabIndex = 3;
            // 
            // tbCategoryID
            // 
            this.tbCategoryID.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.tbCategoryID.Location = new System.Drawing.Point(19, 100);
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
            this.rbEn.Location = new System.Drawing.Point(31, 68);
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
            this.grpLanguage.Location = new System.Drawing.Point(17, 170);
            this.grpLanguage.Name = "grpLanguage";
            this.grpLanguage.Size = new System.Drawing.Size(117, 102);
            this.grpLanguage.TabIndex = 7;
            this.grpLanguage.TabStop = false;
            this.grpLanguage.Text = "language";
            // 
            // wbXML
            // 
            this.wbXML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbXML.Location = new System.Drawing.Point(625, 10);
            this.wbXML.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbXML.Name = "wbXML";
            this.wbXML.Size = new System.Drawing.Size(744, 577);
            this.wbXML.TabIndex = 8;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lblCategoryID.Location = new System.Drawing.Point(32, 59);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(102, 23);
            this.lblCategoryID.TabIndex = 9;
            this.lblCategoryID.Text = "CategoryID:";
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabTreeView);
            this.tabs.Controls.Add(this.tabWordSearch);
            this.tabs.Controls.Add(this.tabCheckList);
            this.tabs.Controls.Add(this.tabTest);
            this.tabs.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1383, 659);
            this.tabs.TabIndex = 11;
            // 
            // tabTreeView
            // 
            this.tabTreeView.Controls.Add(this.tbScope);
            this.tabTreeView.Controls.Add(this.wbContent);
            this.tabTreeView.Controls.Add(this.treeView1);
            this.tabTreeView.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTreeView.Location = new System.Drawing.Point(4, 29);
            this.tabTreeView.Name = "tabTreeView";
            this.tabTreeView.Padding = new System.Windows.Forms.Padding(3);
            this.tabTreeView.Size = new System.Drawing.Size(1375, 626);
            this.tabTreeView.TabIndex = 1;
            this.tabTreeView.Text = "公约显示";
            this.tabTreeView.UseVisualStyleBackColor = true;
            // 
            // tbScope
            // 
            this.tbScope.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbScope.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbScope.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.tbScope.Location = new System.Drawing.Point(537, 14);
            this.tbScope.Multiline = true;
            this.tbScope.Name = "tbScope";
            this.tbScope.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbScope.Size = new System.Drawing.Size(832, 115);
            this.tbScope.TabIndex = 14;
            // 
            // wbContent
            // 
            this.wbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbContent.Location = new System.Drawing.Point(525, 135);
            this.wbContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbContent.Name = "wbContent";
            this.wbContent.Size = new System.Drawing.Size(844, 485);
            this.wbContent.TabIndex = 11;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.FullRowSelect = true;
            this.treeView1.Location = new System.Drawing.Point(6, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(513, 617);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // tabWordSearch
            // 
            this.tabWordSearch.Controls.Add(this.lblCount);
            this.tabWordSearch.Controls.Add(this.dgvSearch);
            this.tabWordSearch.Controls.Add(this.tbsearchword);
            this.tabWordSearch.Controls.Add(this.btntitlesearch);
            this.tabWordSearch.Location = new System.Drawing.Point(4, 29);
            this.tabWordSearch.Name = "tabWordSearch";
            this.tabWordSearch.Size = new System.Drawing.Size(1375, 626);
            this.tabWordSearch.TabIndex = 2;
            this.tabWordSearch.Text = "关键词搜索";
            this.tabWordSearch.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(417, 25);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 20);
            this.lblCount.TabIndex = 19;
            // 
            // dgvSearch
            // 
            this.dgvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearch.Location = new System.Drawing.Point(18, 59);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(1340, 549);
            this.dgvSearch.TabIndex = 0;
            this.dgvSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellDoubleClick);
            // 
            // tbsearchword
            // 
            this.tbsearchword.Location = new System.Drawing.Point(116, 25);
            this.tbsearchword.Name = "tbsearchword";
            this.tbsearchword.Size = new System.Drawing.Size(262, 27);
            this.tbsearchword.TabIndex = 18;
            // 
            // btntitlesearch
            // 
            this.btntitlesearch.Location = new System.Drawing.Point(18, 17);
            this.btntitlesearch.Name = "btntitlesearch";
            this.btntitlesearch.Size = new System.Drawing.Size(77, 36);
            this.btntitlesearch.TabIndex = 17;
            this.btntitlesearch.Text = "搜索";
            this.btntitlesearch.UseVisualStyleBackColor = true;
            this.btntitlesearch.Click += new System.EventHandler(this.btntitlesearch_Click);
            // 
            // tabCheckList
            // 
            this.tabCheckList.Location = new System.Drawing.Point(4, 29);
            this.tabCheckList.Name = "tabCheckList";
            this.tabCheckList.Size = new System.Drawing.Size(1375, 626);
            this.tabCheckList.TabIndex = 3;
            this.tabCheckList.Text = "调查清单";
            this.tabCheckList.UseVisualStyleBackColor = true;
            // 
            // tabTest
            // 
            this.tabTest.Controls.Add(this.wbXML);
            this.tabTest.Controls.Add(this.tbTextInfo);
            this.tabTest.Controls.Add(this.grpLanguage);
            this.tabTest.Controls.Add(this.lblCategoryID);
            this.tabTest.Controls.Add(this.tbCategoryInfo);
            this.tabTest.Controls.Add(this.btnGetInfo);
            this.tabTest.Controls.Add(this.tbCategoryID);
            this.tabTest.Location = new System.Drawing.Point(4, 29);
            this.tabTest.Name = "tabTest";
            this.tabTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabTest.Size = new System.Drawing.Size(1375, 626);
            this.tabTest.TabIndex = 0;
            this.tabTest.Text = "条目测试";
            this.tabTest.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 680);
            this.Controls.Add(this.tabs);
            this.Name = "frmMain";
            this.Text = "readKR";
            this.grpLanguage.ResumeLayout(false);
            this.grpLanguage.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabTreeView.ResumeLayout(false);
            this.tabTreeView.PerformLayout();
            this.tabWordSearch.ResumeLayout(false);
            this.tabWordSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.tabTest.ResumeLayout(false);
            this.tabTest.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabTest;
        private System.Windows.Forms.TabPage tabTreeView;
        private System.Windows.Forms.WebBrowser wbContent;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox tbScope;
        private System.Windows.Forms.TabPage tabWordSearch;
        private System.Windows.Forms.TabPage tabCheckList;
        private System.Windows.Forms.TextBox tbsearchword;
        private System.Windows.Forms.Button btntitlesearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Label lblCount;
    }
}
