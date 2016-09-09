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
            this.bCopy = new System.Windows.Forms.Button();
            this.tMD5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(285, 23);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(41, 23);
            this.bBrowse.TabIndex = 0;
            this.bBrowse.Text = "...";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // tFile
            // 
            this.tFile.Enabled = false;
            this.tFile.Location = new System.Drawing.Point(12, 25);
            this.tFile.Name = "tFile";
            this.tFile.Size = new System.Drawing.Size(267, 20);
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
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MD5:";
            // 
            // bCopy
            // 
            this.bCopy.Location = new System.Drawing.Point(248, 119);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(78, 34);
            this.bCopy.TabIndex = 4;
            this.bCopy.Text = "Copy";
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // tMD5
            // 
            this.tMD5.Enabled = false;
            this.tMD5.Location = new System.Drawing.Point(15, 93);
            this.tMD5.Name = "tMD5";
            this.tMD5.ReadOnly = true;
            this.tMD5.Size = new System.Drawing.Size(311, 20);
            this.tMD5.TabIndex = 5;
            this.tMD5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 163);
            this.Controls.Add(this.tMD5);
            this.Controls.Add(this.bCopy);
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
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.TextBox tMD5;
    }
}

