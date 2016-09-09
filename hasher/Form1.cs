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

        private void bCopyMd5_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tFile.Text)) return;

            Clipboard.SetText(tMD5.Text);
        }

        private void bCopySha1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tFile.Text)) return;

            Clipboard.SetText(tSha1.Text);
        }

        private void bCopySha256_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tFile.Text)) return;

            Clipboard.SetText(tSha256.Text);
        }

        private void bCopySha512_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tFile.Text)) return;

            Clipboard.SetText(tSha512.Text);
        }

        private void tFile_TextChanged(object sender, EventArgs e)
        {
            if (!File.Exists(tFile.Text)) return;

            tMD5.Text = GetChecksum(HashFunction.Md5);
            tSha1.Text = GetChecksum(HashFunction.Sha1);
            tSha256.Text = GetChecksum(HashFunction.Sha256);
            tSha512.Text = GetChecksum(HashFunction.Sha512);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) 
                e.Effect = DragDropEffects.Copy;
        }

        private string GetChecksum(HashFunction algorithm)
        {
            string fileName = tFile.Text;
            var file = new FileStream(fileName, FileMode.Open);
            var hashProvider = CryptoProvider(algorithm);
            byte[] retVal = hashProvider.ComputeHash(file);
            file.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();
        }

        private static HashAlgorithm CryptoProvider(HashFunction algorithm)
        {
            switch (algorithm)
            {
                case HashFunction.Md5:
                    return new MD5CryptoServiceProvider();
                case HashFunction.Sha1:
                    return new SHA1CryptoServiceProvider();                
                case HashFunction.Sha256:
                    return new SHA256CryptoServiceProvider();
                default:
                    return new SHA512CryptoServiceProvider();
            }
        }

        private enum HashFunction
        {
            Md5, Sha1, Sha256, Sha512
        }
    }
}
