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

namespace PasswordManager
{
    public partial class frmCreatePassword : Form
    {
        public frmCreatePassword()
        {
            InitializeComponent();
        }

        private void buttonCreatePassword_Click(object sender, EventArgs e)
        {
            #region 입력값 검증
            if (textBoxKey.Text == "")
            {
                MessageBox.Show("키 값을 입력해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxKey.Focus(); return;
            }

            if (textBoxKey.Text != textBoxConKey.Text)
            {
                MessageBox.Show("입력하신 키 값이 서로 일치하지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxConKey.Focus(); return;
            }

            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxPassword.Focus(); return;
            }

            if (textBoxPassword.Text != textBoxConPassword.Text)
            {
                MessageBox.Show("입력하신 비밀번호가 서로 일치하지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxConPassword.Focus(); return;
            }
            #endregion

            AES256 AES = new AES256();
            string hashString = null; byte[] encryptedBytes = null;

            // 암호화 기본 설정
            AES.KeyString = textBoxKey.Text;
            AES.SaltBytes = CommonData.EncryptSalt;

            // 폴더 생성
            Directory.CreateDirectory(Path.Combine(Application.StartupPath, CommonData.Folder));

            // 비밀번호 암호화
            hashString = Convert.ToBase64String(SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes(CommonData.HashSalt + textBoxPassword.Text)));
            encryptedBytes = AES.EncryptByte(Encoding.UTF8.GetBytes(hashString + textBoxPassword.Text));

            // 정보 저장
            File.WriteAllBytes(Path.Combine(Application.StartupPath, CommonData.Folder, CommonData.PasswordFile), encryptedBytes);

            // 성공 메세지
            MessageBox.Show("성공적으로 비밀번호를 생성하였습니다. \n프로그램을 다시 실행해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}