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
    public partial class frmChangePassword : Form
    {
        private frmMain mainForm;

        public frmChangePassword(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void frmChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void textBoxAuthKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonAuth_Click(sender, e);
        }

        private void textBoxAuthPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonAuth_Click(sender, e);
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            AES256 AES = new AES256();
            string hashString = null; byte[] encryptedBytes = null;

            // 비밀번호 암호화
            hashString = Convert.ToBase64String(SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes(CommonData.HashSalt + textBoxAuthPassword.Text)));
            encryptedBytes = AES.EncryptByte(Encoding.UTF8.GetBytes(hashString + textBoxAuthPassword.Text));

            // 정보 로드 및 배열 비교 준비
            byte[] loadData = File.ReadAllBytes(Path.Combine(Application.StartupPath, CommonData.Folder, CommonData.PasswordFile));
            IStructuralEquatable SE = loadData;

            // 배열 서로 비교
            if (SE.Equals(encryptedBytes, StructuralComparisons.StructuralEqualityComparer))
            {
                MessageBox.Show("정상적으로 인증되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBoxAuth.Enabled = false; groupBoxChange.Enabled = true;
            }
            else
            {
                MessageBox.Show("로그인에 실패하였습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            #region 입력값 검증
            if (textBoxChangeKey.Text == "")
            {
                MessageBox.Show("키 값을 입력해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxChangeKey.Focus(); return;
            }

            if (textBoxChangeKey.Text != textBoxChangeConKey.Text)
            {
                MessageBox.Show("입력하신 키 값이 서로 일치하지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxChangeConKey.Focus(); return;
            }

            if (textBoxChangePassword.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxChangePassword.Focus(); return;
            }

            if (textBoxChangePassword.Text != textBoxChangeConPassword.Text)
            {
                MessageBox.Show("입력하신 비밀번호가 서로 일치하지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxChangeConPassword.Focus(); return;
            }
            #endregion
            
            if (MessageBox.Show("정말로 변경하시겠습니까?", "질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AES256 AES = new AES256();
                string hashString = null; byte[] encryptedBytes = null;

                // 리스트뷰 정보 새로 암호화
                if (mainForm.listViewMain.Items.Count > 0)
                {
                    using (MemoryStream MS = new MemoryStream())
                    {
                        using (StreamWriter SW = new StreamWriter(MS, Encoding.UTF8))
                        {
                            List<string> list = new List<string>();

                            foreach (ListViewItem LVI in mainForm.listViewMain.Items)
                            {
                                list.Add(LVI.Text);
                                list.Add(LVI.SubItems[1].Text);
                                list.Add(LVI.SubItems[2].Text);
                                list.Add(LVI.SubItems[3].Text);
                                list.Add(AES.DecryptString((string)LVI.Tag));
                            }

                            AES.KeyString = textBoxChangeKey.Text;
                            AES.SaltBytes = CommonData.EncryptSalt;

                            for (int i = 0; i < list.Count; i += 5)
                            {
                                SW.WriteLine(list[i]);
                                SW.WriteLine(list[i + 1]);
                                SW.WriteLine(list[i + 2]);
                                SW.WriteLine(list[i + 3]);
                                SW.WriteLine(AES.EncryptString(list[i + 4]));
                                SW.Flush();
                            }

                            encryptedBytes = AES.EncryptByte(MS.ToArray());
                            File.WriteAllBytes(Path.Combine(Application.StartupPath, CommonData.Folder, CommonData.DataFile), encryptedBytes);
                        }
                    }
                }
                else
                {
                    AES.KeyString = textBoxChangeKey.Text; AES.SaltBytes = CommonData.EncryptSalt;
                    File.Delete(Path.Combine(Application.StartupPath, CommonData.Folder, CommonData.DataFile));
                }

                // 비밀번호 암호화
                hashString = Convert.ToBase64String(SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes(CommonData.HashSalt + textBoxChangePassword.Text)));
                encryptedBytes = AES.EncryptByte(Encoding.UTF8.GetBytes(hashString + textBoxChangePassword.Text));
                
                // 정보 저장
                File.WriteAllBytes(Path.Combine(Application.StartupPath, CommonData.Folder, CommonData.PasswordFile), encryptedBytes);

                // 성공 메세지
                MessageBox.Show("비밀번호가 정상적으로 변경되었습니다. \n프로그램을 다시 실행해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}