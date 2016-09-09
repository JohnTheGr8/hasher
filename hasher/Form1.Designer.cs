namespace hasher
{
    partial class Form1
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
            this.bBrowse = new System.Windows.Forms.Button();
            this.tFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bCopyMd5 = new System.Windows.Forms.Button();
            this.tMD5 = new System.Windows.Forms.TextBox();
            this.tSha1 = new System.Windows.Forms.TextBox();
            this.bCopySha1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tSha256 = new System.Windows.Forms.TextBox();
            this.bCopySha256 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tSha512 = new System.Windows.Forms.TextBox();
            this.bCopySha512 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bBrowse
            // 
            this.bBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowse.Location = new System.Drawing.Point(592, 23);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(41, 23);
            this.bBrowse.TabIndex = 0;
            this.bBrowse.Text = "...";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // tFile
            // 
            this.tFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tFile.Enabled = false;
            this.tFile.Location = new System.Drawing.Point(12, 25);
            this.tFile.Name = "tFile";
            this.tFile.Size = new System.Drawing.Size(574, 20);
            this.tFile.TabIndex = 1;
            this.tFile.Text = "Browse for a file or drag-n-drop one here";
            this.tFile.TextChanged += new System.EventHandler(this.tFile_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MD5:";
            // 
            // bCopyMd5
            // 
            this.bCopyMd5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCopyMd5.Location = new System.Drawing.Point(558, 73);
            this.bCopyMd5.Name = "bCopyMd5";
            this.bCopyMd5.Size = new System.Drawing.Size(75, 26);
            this.bCopyMd5.TabIndex = 4;
            this.bCopyMd5.Text = "Copy";
            this.bCopyMd5.UseVisualStyleBackColor = true;
            this.bCopyMd5.Click += new System.EventHandler(this.bCopyMd5_Click);
            // 
            // tMD5
            // 
            this.tMD5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tMD5.Enabled = false;
            this.tMD5.Location = new System.Drawing.Point(12, 77);
            this.tMD5.Name = "tMD5";
            this.tMD5.ReadOnly = true;
            this.tMD5.Size = new System.Drawing.Size(540, 20);
            this.tMD5.TabIndex = 5;
            this.tMD5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tSha1
            // 
            this.tSha1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tSha1.Enabled = false;
            this.tSha1.Location = new System.Drawing.Point(12, 116);
            this.tSha1.Name = "tSha1";
            this.tSha1.ReadOnly = true;
            this.tSha1.Size = new System.Drawing.Size(540, 20);
            this.tSha1.TabIndex = 8;
            this.tSha1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bCopySha1
            // 
            this.bCopySha1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCopySha1.Location = new System.Drawing.Point(558, 112);
            this.bCopySha1.Name = "bCopySha1";
            this.bCopySha1.Size = new System.Drawing.Size(75, 26);
            this.bCopySha1.TabIndex = 7;
            this.bCopySha1.Text = "Copy";
            this.bCopySha1.UseVisualStyleBackColor = true;
            this.bCopySha1.Click += new System.EventHandler(this.bCopySha1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SHA-1:";
            // 
            // tSha256
            // 
            this.tSha256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tSha256.Enabled = false;
            this.tSha256.Location = new System.Drawing.Point(12, 155);
            this.tSha256.Name = "tSha256";
            this.tSha256.ReadOnly = true;
            this.tSha256.Size = new System.Drawing.Size(540, 20);
            this.tSha256.TabIndex = 11;
            this.tSha256.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bCopySha256
            // 
            this.bCopySha256.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCopySha256.Location = new System.Drawing.Point(558, 151);
            this.bCopySha256.Name = "bCopySha256";
            this.bCopySha256.Size = new System.Drawing.Size(75, 26);
            this.bCopySha256.TabIndex = 10;
            this.bCopySha256.Text = "Copy";
            this.bCopySha256.UseVisualStyleBackColor = true;
            this.bCopySha256.Click += new System.EventHandler(this.bCopySha256_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SHA-256:";
            // 
            // tSha512
            // 
            this.tSha512.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tSha512.Enabled = false;
            this.tSha512.Location = new System.Drawing.Point(12, 194);
            this.tSha512.Name = "tSha512";
            this.tSha512.ReadOnly = true;
            this.tSha512.Size = new System.Drawing.Size(540, 20);
            this.tSha512.TabIndex = 14;
            this.tSha512.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bCopySha512
            // 
            this.bCopySha512.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCopySha512.Location = new System.Drawing.Point(558, 190);
            this.bCopySha512.Name = "bCopySha512";
            this.bCopySha512.Size = new System.Drawing.Size(75, 26);
            this.bCopySha512.TabIndex = 13;
            this.bCopySha512.Text = "Copy";
            this.bCopySha512.UseVisualStyleBackColor = true;
            this.bCopySha512.Click += new System.EventHandler(this.bCopySha512_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "SHA-512:";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 229);
            this.Controls.Add(this.tSha512);
            this.Controls.Add(this.bCopySha512);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tSha256);
            this.Controls.Add(this.bCopySha256);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tSha1);
            this.Controls.Add(this.bCopySha1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tMD5);
            this.Controls.Add(this.bCopyMd5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tFile);
            this.Controls.Add(this.bBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hasher";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.TextBox tFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCopyMd5;
        private System.Windows.Forms.TextBox tMD5;
        private System.Windows.Forms.TextBox tSha1;
        private System.Windows.Forms.Button bCopySha1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tSha256;
        private System.Windows.Forms.Button bCopySha256;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tSha512;
        private System.Windows.Forms.Button bCopySha512;
        private System.Windows.Forms.Label label5;
    }
}

