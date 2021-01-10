using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PasswordManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            ManageItems manageItems = new ManageItems(this);
            manageItems.LoadFile(); manageItems.Search();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "비밀번호 관리 프로그램 v" + CommonData.ProgramVersion + " - Made By retn0@naver.com";
            comboBoxSearch.Text = "사이트 이름";
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            프로그램종료ToolStripMenuItem_Click(sender, e);
        }

        private void 비밀번호변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageItems manageItems = new ManageItems(this);
            textBoxSearch.Text = ""; manageItems.Search();

            frmChangePassword form = new frmChangePassword(this);
            form.Show(); this.Hide();
        }

        private void 프로그램종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 제작자블로그방문ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://blog.naver.com/retn0");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ManageItems manageItems = new ManageItems(this);
            manageItems.Search(comboBoxSearch.Text, textBoxSearch.Text);
        }

        private void listViewMain_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem LVI in listViewMain.SelectedItems)
            {
                try
                {
                    Process.Start(LVI.SubItems[1].Text);
                }
                catch (Win32Exception)
                {
                    MessageBox.Show("사이트 주소가 잘못되었습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listViewMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMain.SelectedItems.Count > 0)
            {
                AES256 AES = new AES256();
                checkBoxShowPassword.Checked = false;

                foreach (ListViewItem LVI in listViewMain.SelectedItems)
                {
                    textBoxSiteName.Text = LVI.Text;
                    textBoxSiteAddress.Text = LVI.SubItems[1].Text;
                    textBoxID.Text = LVI.SubItems[2].Text;
                    textBoxMemo.Text = LVI.SubItems[3].Text;
                    textBoxPassword.Text = AES.DecryptString((string)LVI.Tag);
                }
            }
            else
            {
                textBoxSiteName.Text = "";
                textBoxSiteAddress.Text = "";
                textBoxID.Text = "";
                textBoxMemo.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.Font = new Font("맑은 고딕", 9);
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.Font = new Font("Wingdings", 10.5F);
                textBoxPassword.PasswordChar = 'l';
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ManageItems manageItems = new ManageItems(this);
            AES256 AES = new AES256();

            string[] arrItems = { textBoxSiteName.Text, textBoxSiteAddress.Text, textBoxID.Text, textBoxMemo.Text, textBoxPassword.Text };
            arrItems[4] = AES.EncryptString(arrItems[4]);

            if (manageItems.CheckInputData())
            {
                ListViewItem LVI = new ListViewItem();
                LVI.Text = arrItems[0];
                LVI.SubItems.Add(arrItems[1]);
                LVI.SubItems.Add(arrItems[2]);
                LVI.SubItems.Add(arrItems[3]);
                LVI.Tag = arrItems[4];

                listViewMain.Items.Add(LVI);
                manageItems.Add(arrItems);
                manageItems.SaveFile();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listViewMain.SelectedItems.Count == 1)
            {
                ManageItems manageItems = new ManageItems(this);
                AES256 AES = new AES256();

                if (manageItems.CheckInputData() && MessageBox.Show("정말로 변경하시겠습니까?", "질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string[] arrItems = { textBoxSiteName.Text, textBoxSiteAddress.Text, textBoxID.Text, textBoxMemo.Text, textBoxPassword.Text };
                    arrItems[4] = AES.EncryptString(arrItems[4]);

                    foreach (ListViewItem LVI in listViewMain.SelectedItems)
                    {
                        LVI.Text = arrItems[0];
                        LVI.SubItems[1].Text = arrItems[1];
                        LVI.SubItems[2].Text = arrItems[2];
                        LVI.SubItems[3].Text = arrItems[3];
                        LVI.Tag = arrItems[4];

                        manageItems.Change(LVI.Index, arrItems);
                    }

                    manageItems.SaveFile();
                }
            }
            else
            {
                MessageBox.Show("변경하실 항목을 선택해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewMain.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("정말로 삭제하시겠습니까?", "질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ManageItems manageItems = new ManageItems(this);

                    foreach (ListViewItem LVI in listViewMain.SelectedItems)
                    {
                        manageItems.Delete(LVI.Index);
                        LVI.Remove();
                    }

                    manageItems.SaveFile();
                }
            }
            else
            {
                MessageBox.Show("삭제하실 항목을 선택해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }

    class ManageItems
    {
        private static DataTable dataTable = new DataTable();
        private frmMain mainForm;

        static ManageItems()
        {
            dataTable.Columns.Add("사이트 이름", typeof(string));
            dataTable.Columns.Add("사이트 주소", typeof(string));
            dataTable.Columns.Add("아이디", typeof(string));
            dataTable.Columns.Add("메모", typeof(string));
            dataTable.Columns.Add("Password", typeof(string));
        }

        public ManageItems(frmMain mainForm)
        {
            this.mainForm = mainForm;
        }
        
        // 정보 추가할 때 값 상태 검증
        public bool CheckInputData()
        {
            if (mainForm.textBoxSiteName.Text == "")
            {
                MessageBox.Show("사이트 이름을 입력해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mainForm.textBoxSiteName.Focus(); return false;
            }

            if (mainForm.textBoxID.Text == "")
            {
                MessageBox.Show("아이디를 입력해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mainForm.textBoxID.Focus(); return false;
            }

            if (mainForm.textBoxPassword.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mainForm.textBoxPassword.Focus(); return false;
            }

            return true;
        }

        // 정보 추가 (사이트 이름, 사이트 주소, 아이디, 메모, 비밀번호)
        public void Add(string[] arrItems)
        {
            dataTable.Rows.Add(arrItems[0], arrItems[1], arrItems[2], arrItems[3], arrItems[4]);
        }

        // 정보 변경
        public void Change(int index, string[] arrItems)
        {
            dataTable.Rows[index]["사이트 이름"] = arrItems[0];
            dataTable.Rows[index]["사이트 주소"] = arrItems[1];
            dataTable.Rows[index]["아이디"] = arrItems[2];
            dataTable.Rows[index]["메모"] = arrItems[3];
            dataTable.Rows[index]["Password"] = arrItems[4];
        }

        // 정보 삭제
        public void Delete(int index)
        {
            dataTable.Rows[index].Delete();
        }

        // 검색 결과 추가
        public void Search(string filter = "사이트 이름", string value = "")
        {
            mainForm.listViewMain.Items.Clear();
            mainForm.listViewMain.BeginUpdate();

            foreach (DataRow row in dataTable.Rows)
            {
                if (row[filter].ToString().Contains(value))
                {
                    ListViewItem LVI = new ListViewItem();
                    LVI.Text = row["사이트 이름"].ToString();
                    LVI.SubItems.Add(row["사이트 주소"].ToString());
                    LVI.SubItems.Add(row["아이디"].ToString());
                    LVI.SubItems.Add(row["메모"].ToString());
                    LVI.Tag = row["Password"].ToString();

                    mainForm.listViewMain.Items.Add(LVI);
                }
            }

            mainForm.listViewMain.EndUpdate();
        }

        // 파일로 정보 저장
        public void SaveFile()
        {
            if (mainForm.listViewMain.Items.Count > 0)
            {
                using (MemoryStream MS = new MemoryStream())
                {
                    using (StreamWriter SW = new StreamWriter(MS, Encoding.UTF8))
                    {
                        AES256 AES = new AES256();
                        byte[] encryptedBytes = null;

                        foreach (DataRow row in dataTable.Rows)
                        {
                            SW.WriteLine(row["사이트 이름"].ToString());
                            SW.WriteLine(row["사이트 주소"].ToString());
                            SW.WriteLine(row["아이디"].ToString());
                            SW.WriteLine(row["메모"].ToString());
                            SW.WriteLine(row["Password"].ToString());
                            SW.Flush();
                        }

                        encryptedBytes = AES.EncryptByte(MS.ToArray());
                        File.WriteAllBytes(Path.Combine(Application.StartupPath, CommonData.Folder, CommonData.DataFile), encryptedBytes);
                    }
                }
            }
        }

        // 파일에서 정보 로드
        public void LoadFile()
        {
            if (File.Exists(Path.Combine(Application.StartupPath, CommonData.Folder, CommonData.DataFile)))
            {
                using (MemoryStream MS = new MemoryStream())
                {
                    using (StreamReader SR = new StreamReader(MS, Encoding.UTF8))
                    {
                        try
                        {
                            AES256 AES = new AES256();
                            byte[] decryptedBytes = null; string[] arrItems = new string[5];

                            decryptedBytes = AES.DecryptByte(File.ReadAllBytes(Path.Combine(Application.StartupPath, CommonData.Folder, CommonData.DataFile)));
                            MS.Write(decryptedBytes, 0, decryptedBytes.Length); MS.Position = 0;

                            // 리스트뷰 데이터 입력 준비
                            mainForm.listViewMain.BeginUpdate();

                            // 리스트뷰에 데이터 추가
                            while (!SR.EndOfStream)
                            {
                                for (int i = 0; i < 5; i++)
                                {
                                    arrItems[i] = SR.ReadLine();
                                }

                                Add(arrItems);
                            }

                            // 리스트뷰 데이터 입력 완료
                            mainForm.listViewMain.EndUpdate();
                        }
                        catch
                        {
                            Application.Exit();
                        }
                    }
                }
            }
        }
    }
}