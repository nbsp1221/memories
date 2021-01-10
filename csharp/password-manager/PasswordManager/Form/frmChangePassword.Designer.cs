namespace PasswordManager
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.groupBoxAuth = new System.Windows.Forms.GroupBox();
            this.buttonAuth = new System.Windows.Forms.Button();
            this.textBoxAuthPassword = new System.Windows.Forms.TextBox();
            this.labelAuthPassword = new System.Windows.Forms.Label();
            this.textBoxAuthKey = new System.Windows.Forms.TextBox();
            this.labelAuthKey = new System.Windows.Forms.Label();
            this.groupBoxChange = new System.Windows.Forms.GroupBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxChangeConPassword = new System.Windows.Forms.TextBox();
            this.labelChangeConPassword = new System.Windows.Forms.Label();
            this.textBoxChangePassword = new System.Windows.Forms.TextBox();
            this.labelChangePassword = new System.Windows.Forms.Label();
            this.textBoxChangeConKey = new System.Windows.Forms.TextBox();
            this.labelChangeConKey = new System.Windows.Forms.Label();
            this.textBoxChangeKey = new System.Windows.Forms.TextBox();
            this.labelChangeKey = new System.Windows.Forms.Label();
            this.groupBoxAuth.SuspendLayout();
            this.groupBoxChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAuth
            // 
            this.groupBoxAuth.Controls.Add(this.buttonAuth);
            this.groupBoxAuth.Controls.Add(this.textBoxAuthPassword);
            this.groupBoxAuth.Controls.Add(this.labelAuthPassword);
            this.groupBoxAuth.Controls.Add(this.textBoxAuthKey);
            this.groupBoxAuth.Controls.Add(this.labelAuthKey);
            this.groupBoxAuth.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAuth.Name = "groupBoxAuth";
            this.groupBoxAuth.Size = new System.Drawing.Size(377, 133);
            this.groupBoxAuth.TabIndex = 0;
            this.groupBoxAuth.TabStop = false;
            this.groupBoxAuth.Text = "인증";
            // 
            // buttonAuth
            // 
            this.buttonAuth.Location = new System.Drawing.Point(19, 81);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(338, 36);
            this.buttonAuth.TabIndex = 4;
            this.buttonAuth.Text = "인증";
            this.buttonAuth.UseVisualStyleBackColor = true;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // textBoxAuthPassword
            // 
            this.textBoxAuthPassword.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBoxAuthPassword.Location = new System.Drawing.Point(86, 54);
            this.textBoxAuthPassword.Name = "textBoxAuthPassword";
            this.textBoxAuthPassword.PasswordChar = 'l';
            this.textBoxAuthPassword.Size = new System.Drawing.Size(271, 21);
            this.textBoxAuthPassword.TabIndex = 3;
            this.textBoxAuthPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAuthPassword_KeyDown);
            // 
            // labelAuthPassword
            // 
            this.labelAuthPassword.AutoSize = true;
            this.labelAuthPassword.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelAuthPassword.Location = new System.Drawing.Point(16, 56);
            this.labelAuthPassword.Name = "labelAuthPassword";
            this.labelAuthPassword.Size = new System.Drawing.Size(64, 15);
            this.labelAuthPassword.TabIndex = 2;
            this.labelAuthPassword.Text = "Password :";
            // 
            // textBoxAuthKey
            // 
            this.textBoxAuthKey.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBoxAuthKey.Location = new System.Drawing.Point(86, 27);
            this.textBoxAuthKey.Name = "textBoxAuthKey";
            this.textBoxAuthKey.PasswordChar = 'l';
            this.textBoxAuthKey.Size = new System.Drawing.Size(271, 21);
            this.textBoxAuthKey.TabIndex = 1;
            this.textBoxAuthKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAuthKey_KeyDown);
            // 
            // labelAuthKey
            // 
            this.labelAuthKey.AutoSize = true;
            this.labelAuthKey.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelAuthKey.ForeColor = System.Drawing.Color.Green;
            this.labelAuthKey.Location = new System.Drawing.Point(16, 29);
            this.labelAuthKey.Name = "labelAuthKey";
            this.labelAuthKey.Size = new System.Drawing.Size(35, 15);
            this.labelAuthKey.TabIndex = 0;
            this.labelAuthKey.Text = "Key :";
            // 
            // groupBoxChange
            // 
            this.groupBoxChange.Controls.Add(this.buttonChange);
            this.groupBoxChange.Controls.Add(this.textBoxChangeConPassword);
            this.groupBoxChange.Controls.Add(this.labelChangeConPassword);
            this.groupBoxChange.Controls.Add(this.textBoxChangePassword);
            this.groupBoxChange.Controls.Add(this.labelChangePassword);
            this.groupBoxChange.Controls.Add(this.textBoxChangeConKey);
            this.groupBoxChange.Controls.Add(this.labelChangeConKey);
            this.groupBoxChange.Controls.Add(this.textBoxChangeKey);
            this.groupBoxChange.Controls.Add(this.labelChangeKey);
            this.groupBoxChange.Enabled = false;
            this.groupBoxChange.Location = new System.Drawing.Point(12, 151);
            this.groupBoxChange.Name = "groupBoxChange";
            this.groupBoxChange.Size = new System.Drawing.Size(377, 187);
            this.groupBoxChange.TabIndex = 1;
            this.groupBoxChange.TabStop = false;
            this.groupBoxChange.Text = "비밀번호 변경";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(19, 135);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(338, 36);
            this.buttonChange.TabIndex = 8;
            this.buttonChange.Text = "비밀번호 변경";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxChangeConPassword
            // 
            this.textBoxChangeConPassword.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBoxChangeConPassword.Location = new System.Drawing.Point(134, 108);
            this.textBoxChangeConPassword.Name = "textBoxChangeConPassword";
            this.textBoxChangeConPassword.PasswordChar = 'l';
            this.textBoxChangeConPassword.Size = new System.Drawing.Size(223, 21);
            this.textBoxChangeConPassword.TabIndex = 7;
            // 
            // labelChangeConPassword
            // 
            this.labelChangeConPassword.AutoSize = true;
            this.labelChangeConPassword.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelChangeConPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelChangeConPassword.Location = new System.Drawing.Point(16, 110);
            this.labelChangeConPassword.Name = "labelChangeConPassword";
            this.labelChangeConPassword.Size = new System.Drawing.Size(112, 15);
            this.labelChangeConPassword.TabIndex = 6;
            this.labelChangeConPassword.Text = "Confirm Password :";
            // 
            // textBoxChangePassword
            // 
            this.textBoxChangePassword.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBoxChangePassword.Location = new System.Drawing.Point(134, 81);
            this.textBoxChangePassword.Name = "textBoxChangePassword";
            this.textBoxChangePassword.PasswordChar = 'l';
            this.textBoxChangePassword.Size = new System.Drawing.Size(223, 21);
            this.textBoxChangePassword.TabIndex = 5;
            // 
            // labelChangePassword
            // 
            this.labelChangePassword.AutoSize = true;
            this.labelChangePassword.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelChangePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelChangePassword.Location = new System.Drawing.Point(16, 83);
            this.labelChangePassword.Name = "labelChangePassword";
            this.labelChangePassword.Size = new System.Drawing.Size(64, 15);
            this.labelChangePassword.TabIndex = 4;
            this.labelChangePassword.Text = "Password :";
            // 
            // textBoxChangeConKey
            // 
            this.textBoxChangeConKey.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBoxChangeConKey.Location = new System.Drawing.Point(134, 54);
            this.textBoxChangeConKey.Name = "textBoxChangeConKey";
            this.textBoxChangeConKey.PasswordChar = 'l';
            this.textBoxChangeConKey.Size = new System.Drawing.Size(223, 21);
            this.textBoxChangeConKey.TabIndex = 3;
            // 
            // labelChangeConKey
            // 
            this.labelChangeConKey.AutoSize = true;
            this.labelChangeConKey.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelChangeConKey.ForeColor = System.Drawing.Color.Green;
            this.labelChangeConKey.Location = new System.Drawing.Point(16, 56);
            this.labelChangeConKey.Name = "labelChangeConKey";
            this.labelChangeConKey.Size = new System.Drawing.Size(84, 15);
            this.labelChangeConKey.TabIndex = 2;
            this.labelChangeConKey.Text = "Confirm Key :";
            // 
            // textBoxChangeKey
            // 
            this.textBoxChangeKey.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBoxChangeKey.Location = new System.Drawing.Point(134, 27);
            this.textBoxChangeKey.Name = "textBoxChangeKey";
            this.textBoxChangeKey.PasswordChar = 'l';
            this.textBoxChangeKey.Size = new System.Drawing.Size(223, 21);
            this.textBoxChangeKey.TabIndex = 1;
            // 
            // labelChangeKey
            // 
            this.labelChangeKey.AutoSize = true;
            this.labelChangeKey.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelChangeKey.ForeColor = System.Drawing.Color.Green;
            this.labelChangeKey.Location = new System.Drawing.Point(16, 29);
            this.labelChangeKey.Name = "labelChangeKey";
            this.labelChangeKey.Size = new System.Drawing.Size(35, 15);
            this.labelChangeKey.TabIndex = 0;
            this.labelChangeKey.Text = "Key :";
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 350);
            this.Controls.Add(this.groupBoxChange);
            this.Controls.Add(this.groupBoxAuth);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmChangePassword";
            this.Text = "비밀번호 변경";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChangePassword_FormClosed);
            this.groupBoxAuth.ResumeLayout(false);
            this.groupBoxAuth.PerformLayout();
            this.groupBoxChange.ResumeLayout(false);
            this.groupBoxChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAuth;
        private System.Windows.Forms.Label labelAuthKey;
        private System.Windows.Forms.TextBox textBoxAuthKey;
        private System.Windows.Forms.TextBox textBoxAuthPassword;
        private System.Windows.Forms.Label labelAuthPassword;
        private System.Windows.Forms.Button buttonAuth;
        private System.Windows.Forms.GroupBox groupBoxChange;
        private System.Windows.Forms.Label labelChangeKey;
        private System.Windows.Forms.TextBox textBoxChangeKey;
        private System.Windows.Forms.TextBox textBoxChangeConKey;
        private System.Windows.Forms.Label labelChangeConKey;
        private System.Windows.Forms.TextBox textBoxChangePassword;
        private System.Windows.Forms.Label labelChangePassword;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox textBoxChangeConPassword;
        private System.Windows.Forms.Label labelChangeConPassword;
    }
}