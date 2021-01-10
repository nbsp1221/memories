using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Collections;

namespace PasswordManager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBoxKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonLogin_Click(sender, e);
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonLogin_Click(sender, e);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            AES256 AES = new AES256();
            string hashString = null; byte[] encryptedBytes = null;

            // 암호화 기본 설정
            AES.KeyString = textBoxKey.Text;
            AES.SaltBytes = CommonData.EncryptSalt;

            // 비밀번호 암호화
            hashString = Convert.ToBase64String(SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes(CommonData.HashSalt + textBoxPassword.Text)));
            encryptedBytes = AES.EncryptByte(Encoding.UTF8.GetBytes(hashString + textBoxPassword.Text));

            // 정보 로드 및 배열 비교 준비
            byte[] loadData = File.ReadAllBytes(Path.Combine(Application.StartupPath, CommonData.Folder, CommonData.PasswordFile));
            IStructuralEquatable SE = loadData;
            
            // 배열 서로 비교
            if (SE.Equals(encryptedBytes, StructuralComparisons.StructuralEqualityComparer))
            {
                frmMain form = new frmMain();
                form.Show(); this.Hide();
            }
            else
            {
                MessageBox.Show("로그인에 실패하였습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }
    }
}