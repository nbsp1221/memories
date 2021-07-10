using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES256EncryptExample
{
    public partial class MainForm : Form
    {
        private byte[] saltBytes = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = AES.EncryptToString(textBox1.Text, keyTextBox.Text, saltBytes, compressCheckBox.Checked);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = AES.DecryptToString(textBox3.Text, keyTextBox.Text, saltBytes, compressCheckBox.Checked);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Text Length : " + textBox1.TextLength;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "Text Length : " + textBox2.TextLength;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "Text Length : " + textBox3.TextLength;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "Text Length : " + textBox4.TextLength;
        }
    }
}