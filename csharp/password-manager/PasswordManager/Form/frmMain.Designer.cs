namespace PasswordManager
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.비밀번호변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.프로그램종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.제작자블로그방문ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.columnHeaderSiteName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSiteAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMemo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.labelMemo = new System.Windows.Forms.Label();
            this.textBoxSiteAddress = new System.Windows.Forms.TextBox();
            this.labelSiteAddress = new System.Windows.Forms.Label();
            this.textBoxSiteName = new System.Windows.Forms.TextBox();
            this.labelSiteName = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(660, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.비밀번호변경ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.프로그램종료ToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.fileFToolStripMenuItem.Text = "파일(F)";
            // 
            // 비밀번호변경ToolStripMenuItem
            // 
            this.비밀번호변경ToolStripMenuItem.Name = "비밀번호변경ToolStripMenuItem";
            this.비밀번호변경ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.비밀번호변경ToolStripMenuItem.Text = "비밀번호 변경";
            this.비밀번호변경ToolStripMenuItem.Click += new System.EventHandler(this.비밀번호변경ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 6);
            // 
            // 프로그램종료ToolStripMenuItem
            // 
            this.프로그램종료ToolStripMenuItem.Name = "프로그램종료ToolStripMenuItem";
            this.프로그램종료ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.프로그램종료ToolStripMenuItem.Text = "프로그램 종료";
            this.프로그램종료ToolStripMenuItem.Click += new System.EventHandler(this.프로그램종료ToolStripMenuItem_Click);
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.제작자블로그방문ToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.helpHToolStripMenuItem.Text = "도움말(H)";
            // 
            // 제작자블로그방문ToolStripMenuItem
            // 
            this.제작자블로그방문ToolStripMenuItem.Name = "제작자블로그방문ToolStripMenuItem";
            this.제작자블로그방문ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.제작자블로그방문ToolStripMenuItem.Text = "제작자 블로그 방문";
            this.제작자블로그방문ToolStripMenuItem.Click += new System.EventHandler(this.제작자블로그방문ToolStripMenuItem_Click);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "사이트 이름",
            "사이트 주소",
            "아이디",
            "메모"});
            this.comboBoxSearch.Location = new System.Drawing.Point(12, 36);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(102, 23);
            this.comboBoxSearch.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(120, 36);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(528, 23);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // listViewMain
            // 
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSiteName,
            this.columnHeaderSiteAddress,
            this.columnHeaderID,
            this.columnHeaderMemo});
            this.listViewMain.FullRowSelect = true;
            this.listViewMain.GridLines = true;
            this.listViewMain.Location = new System.Drawing.Point(12, 65);
            this.listViewMain.MultiSelect = false;
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(636, 243);
            this.listViewMain.TabIndex = 3;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            this.listViewMain.SelectedIndexChanged += new System.EventHandler(this.listViewMain_SelectedIndexChanged);
            this.listViewMain.DoubleClick += new System.EventHandler(this.listViewMain_DoubleClick);
            // 
            // columnHeaderSiteName
            // 
            this.columnHeaderSiteName.Text = "사이트 이름";
            this.columnHeaderSiteName.Width = 200;
            // 
            // columnHeaderSiteAddress
            // 
            this.columnHeaderSiteAddress.Text = "사이트 주소";
            this.columnHeaderSiteAddress.Width = 300;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "아이디";
            this.columnHeaderID.Width = 150;
            // 
            // columnHeaderMemo
            // 
            this.columnHeaderMemo.Text = "메모";
            this.columnHeaderMemo.Width = 400;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.textBoxPassword);
            this.groupBoxInfo.Controls.Add(this.checkBoxShowPassword);
            this.groupBoxInfo.Controls.Add(this.textBoxID);
            this.groupBoxInfo.Controls.Add(this.labelID);
            this.groupBoxInfo.Controls.Add(this.textBoxMemo);
            this.groupBoxInfo.Controls.Add(this.labelMemo);
            this.groupBoxInfo.Controls.Add(this.textBoxSiteAddress);
            this.groupBoxInfo.Controls.Add(this.labelSiteAddress);
            this.groupBoxInfo.Controls.Add(this.textBoxSiteName);
            this.groupBoxInfo.Controls.Add(this.labelSiteName);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 314);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(636, 163);
            this.groupBoxInfo.TabIndex = 4;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "정보";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Wingdings", 10.5F);
            this.textBoxPassword.Location = new System.Drawing.Point(378, 124);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = 'l';
            this.textBoxPassword.Size = new System.Drawing.Size(238, 23);
            this.textBoxPassword.TabIndex = 9;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(270, 126);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(102, 19);
            this.checkBoxShowPassword.TabIndex = 8;
            this.checkBoxShowPassword.Text = "비밀번호 보기";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(72, 124);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(134, 23);
            this.textBoxID.TabIndex = 7;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(16, 127);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(50, 15);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "아이디 :";
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.Location = new System.Drawing.Point(100, 84);
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.Size = new System.Drawing.Size(516, 23);
            this.textBoxMemo.TabIndex = 5;
            // 
            // labelMemo
            // 
            this.labelMemo.AutoSize = true;
            this.labelMemo.Location = new System.Drawing.Point(16, 87);
            this.labelMemo.Name = "labelMemo";
            this.labelMemo.Size = new System.Drawing.Size(38, 15);
            this.labelMemo.TabIndex = 4;
            this.labelMemo.Text = "메모 :";
            // 
            // textBoxSiteAddress
            // 
            this.textBoxSiteAddress.Location = new System.Drawing.Point(100, 55);
            this.textBoxSiteAddress.Name = "textBoxSiteAddress";
            this.textBoxSiteAddress.Size = new System.Drawing.Size(516, 23);
            this.textBoxSiteAddress.TabIndex = 3;
            // 
            // labelSiteAddress
            // 
            this.labelSiteAddress.AutoSize = true;
            this.labelSiteAddress.Location = new System.Drawing.Point(16, 58);
            this.labelSiteAddress.Name = "labelSiteAddress";
            this.labelSiteAddress.Size = new System.Drawing.Size(78, 15);
            this.labelSiteAddress.TabIndex = 2;
            this.labelSiteAddress.Text = "사이트 주소 :";
            // 
            // textBoxSiteName
            // 
            this.textBoxSiteName.Location = new System.Drawing.Point(100, 26);
            this.textBoxSiteName.Name = "textBoxSiteName";
            this.textBoxSiteName.Size = new System.Drawing.Size(516, 23);
            this.textBoxSiteName.TabIndex = 1;
            // 
            // labelSiteName
            // 
            this.labelSiteName.AutoSize = true;
            this.labelSiteName.Location = new System.Drawing.Point(16, 29);
            this.labelSiteName.Name = "labelSiteName";
            this.labelSiteName.Size = new System.Drawing.Size(78, 15);
            this.labelSiteName.TabIndex = 0;
            this.labelSiteName.Text = "사이트 이름 :";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 483);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(208, 34);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "추가";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonChange.Location = new System.Drawing.Point(226, 483);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(208, 34);
            this.buttonChange.TabIndex = 6;
            this.buttonChange.Text = "변경";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(440, 483);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(208, 34);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "삭제";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 529);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.listViewMain);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "비밀번호 관리 프로그램 v0.0 - Made By retn0@naver.com";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 제작자블로그방문ToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ColumnHeader columnHeaderSiteName;
        private System.Windows.Forms.ColumnHeader columnHeaderSiteAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderMemo;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelSiteName;
        private System.Windows.Forms.Label labelSiteAddress;
        private System.Windows.Forms.Label labelMemo;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        internal System.Windows.Forms.TextBox textBoxSiteName;
        internal System.Windows.Forms.TextBox textBoxID;
        internal System.Windows.Forms.TextBox textBoxPassword;
        internal System.Windows.Forms.TextBox textBoxSiteAddress;
        internal System.Windows.Forms.TextBox textBoxMemo;
        private System.Windows.Forms.ToolStripMenuItem 비밀번호변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        internal System.Windows.Forms.ListView listViewMain;
    }
}

