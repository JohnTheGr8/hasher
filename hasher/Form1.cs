using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace hasher
{
    public partial class Form1 : Form
    {
        public static string ArgFile = null;

        public Form1()
        {
            InitializeComponent();

            if (!string.IsNullOrWhiteSpace(ArgFile))
                tFile.Text = (File.Exists(ArgFile)) ? ArgFile : "Invalid file path...";
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string f in files)
                tFile.Text = f;
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (!File.Exists(ofd.FileName)) return;

            tFile.Text = ofd.FileName;

        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tFile.Text)) return;

            Clipboard.SetText(tMD5.Text);
        }

        protected string GetChecksum(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(file);
            file.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();
        }

        private void tFile_TextChanged(object sender, EventArgs e)
        {
            if (!File.Exists(tFile.Text)) return;

            tMD5.Text = GetChecksum(tFile.Text);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) 
                e.Effect = DragDropEffects.Copy;
        }
    }
}
