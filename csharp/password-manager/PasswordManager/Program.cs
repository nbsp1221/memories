using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PasswordManager
{
    public struct CommonData
    {
        // 프로그램 버전
        public const string ProgramVersion = "1.1";

        // 암호화 기본 정보
        public static readonly byte[] EncryptSalt = { 67, 182, 141, 79, 171, 211, 150, 133 };
        public const string HashSalt = "OMRFKS2IJX";

        // 데이터 저장 경로
        public const string Folder = "Info";
        public const string PasswordFile = "Password";
        public const string DataFile = "Data";
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (File.Exists(Path.Combine(Application.StartupPath, CommonData.Folder, CommonData.PasswordFile)))
            {
                Application.Run(new frmLogin());
            }
            else
            {
                Application.Run(new frmCreatePassword());
            }
        }
    }
}