namespace PasswordManager
{
    partial class frmCreatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreatePassword));
            this.labelExplain = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxConKey = new System.Windows.Forms.TextBox();
            this.labelConKey = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxConPassword = new System.Windows.Forms.TextBox();
            this.labelConPassword = new System.Windows.Forms.Label();
            this.buttonCreatePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelExplain
            // 
            this.labelExplain.AutoSize = true;
            this.labelExplain.ForeColor = System.Drawing.Color.Red;
            this.labelExplain.Location = new System.Drawing.Point(12, 9);
            this.labelExplain.Name = "labelExplain";
            this.labelExplain.Size = new System.Drawing.Size(349, 15);
            this.labelExplain.TabIndex = 0;
            this.labelExplain.Text = "비밀번호가 존재하지 않습니다. 비밀번호를 새로 생성해 주세요.";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelKey.ForeColor = System.Drawing.Color.Green;
            this.labelKey.Location = new System.Drawing.Point(12, 45);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(35, 15);
            this.labelKey.TabIndex = 1;
            this.labelKey.Text = "Key :";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBoxKey.Location = new System.Drawing.Point(130, 43);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.PasswordChar = 'l';
            this.textBoxKey.Size = new System.Drawing.Size(259, 21);
            this.textBoxKey.TabIndex = 2;
            // 
            // textBoxConKey
            // 
            this.textBoxConKey.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBoxConKey.Location = new System.Drawing.Point(130, 70);
            this.textBoxConKey.Name = "textBoxConKey";
            this.textBoxConKey.PasswordChar = 'l';
            this.textBoxConKey.Size = new System.Drawing.Size(259, 21);
            this.textBoxConKey.TabIndex = 4;
            // 
            // labelConKey
            // 
            this.labelConKey.AutoSize = true;
            this.labelConKey.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelConKey.ForeColor = System.Drawing.Color.Green;
            this.labelConKey.Location = new System.Drawing.Point(12, 72);
            this.labelConKey.Name = "labelConKey";
            this.labelConKey.Size = new System.Drawing.Size(84, 15);
            this.labelConKey.TabIndex = 3;
            this.labelConKey.Text = "Confirm Key :";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBoxPassword.Location = new System.Drawing.Point(130, 97);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = 'l';
            this.textBoxPassword.Size = new System.Drawing.Size(260, 21);
            this.textBoxPassword.TabIndex = 6;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPassword.Location = new System.Drawing.Point(12, 99);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 15);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password :";
            // 
            // textBoxConPassword
            // 
            this.textBoxConPassword.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBoxConPassword.Location = new System.Drawing.Point(130, 124);
            this.textBoxConPassword.Name = "textBoxConPassword";
            this.textBoxConPassword.PasswordChar = 'l';
            this.textBoxConPassword.Size = new System.Drawing.Size(259, 21);
            this.textBoxConPassword.TabIndex = 8;
            // 
            // labelConPassword
            // 
            this.labelConPassword.AutoSize = true;
            this.labelConPassword.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelConPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelConPassword.Location = new System.Drawing.Point(12, 126);
            this.labelConPassword.Name = "labelConPassword";
            this.labelConPassword.Size = new System.Drawing.Size(112, 15);
            this.labelConPassword.TabIndex = 7;
            this.labelConPassword.Text = "Confirm Password :";
            // 
            // buttonCreatePassword
            // 
            this.buttonCreatePassword.Location = new System.Drawing.Point(12, 151);
            this.buttonCreatePassword.Name = "buttonCreatePassword";
            this.buttonCreatePassword.Size = new System.Drawing.Size(377, 36);
            this.buttonCreatePassword.TabIndex = 9;
            this.buttonCreatePassword.Text = "비밀번호 생성";
            this.buttonCreatePassword.UseVisualStyleBackColor = true;
            this.buttonCreatePassword.Click += new System.EventHandler(this.buttonCreatePassword_Click);
            // 
            // frmCreatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 199);
            this.Controls.Add(this.buttonCreatePassword);
            this.Controls.Add(this.textBoxConPassword);
            this.Controls.Add(this.labelConPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxConKey);
            this.Controls.Add(this.labelConKey);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.labelExplain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmCreatePassword";
            this.Text = "비밀번호 생성";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExplain;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxConKey;
        private System.Windows.Forms.Label labelConKey;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxConPassword;
        private System.Windows.Forms.Label labelConPassword;
        private System.Windows.Forms.Button buttonCreatePassword;
    }
}