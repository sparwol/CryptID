namespace Cryptid.Forms
{
    partial class FormCompress
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
            this.buttonCompFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonComp = new System.Windows.Forms.Button();
            this.buttonDecomp = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxPathComp = new System.Windows.Forms.TextBox();
            this.buttonZipFile = new System.Windows.Forms.Button();
            this.textBoxPathDecomp = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.textCompPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCompFile
            // 
            this.buttonCompFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompFile.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.buttonCompFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonCompFile.Location = new System.Drawing.Point(157, 259);
            this.buttonCompFile.Name = "buttonCompFile";
            this.buttonCompFile.Size = new System.Drawing.Size(106, 30);
            this.buttonCompFile.TabIndex = 0;
            this.buttonCompFile.Text = "Select folder";
            this.buttonCompFile.UseVisualStyleBackColor = true;
            this.buttonCompFile.Click += new System.EventHandler(this.buttonCompFile_Click);
            // 
            // buttonComp
            // 
            this.buttonComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComp.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.buttonComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonComp.Location = new System.Drawing.Point(117, 334);
            this.buttonComp.Name = "buttonComp";
            this.buttonComp.Size = new System.Drawing.Size(185, 50);
            this.buttonComp.TabIndex = 0;
            this.buttonComp.Text = "Compress and encrypt";
            this.buttonComp.UseVisualStyleBackColor = true;
            this.buttonComp.Click += new System.EventHandler(this.buttonComp_Click);
            // 
            // buttonDecomp
            // 
            this.buttonDecomp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecomp.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.buttonDecomp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDecomp.Location = new System.Drawing.Point(452, 334);
            this.buttonDecomp.Name = "buttonDecomp";
            this.buttonDecomp.Size = new System.Drawing.Size(185, 50);
            this.buttonDecomp.TabIndex = 0;
            this.buttonDecomp.Text = "Decompress and decrypt";
            this.buttonDecomp.UseVisualStyleBackColor = true;
            this.buttonDecomp.Click += new System.EventHandler(this.buttonDecomp_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxPathComp
            // 
            this.textBoxPathComp.BackColor = System.Drawing.Color.Gray;
            this.textBoxPathComp.Font = new System.Drawing.Font("Gill Sans MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathComp.Location = new System.Drawing.Point(57, 228);
            this.textBoxPathComp.Name = "textBoxPathComp";
            this.textBoxPathComp.Size = new System.Drawing.Size(302, 25);
            this.textBoxPathComp.TabIndex = 1;
            // 
            // buttonZipFile
            // 
            this.buttonZipFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZipFile.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.buttonZipFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonZipFile.Location = new System.Drawing.Point(491, 259);
            this.buttonZipFile.Name = "buttonZipFile";
            this.buttonZipFile.Size = new System.Drawing.Size(106, 30);
            this.buttonZipFile.TabIndex = 0;
            this.buttonZipFile.Text = "Select zip file";
            this.buttonZipFile.UseVisualStyleBackColor = true;
            this.buttonZipFile.Click += new System.EventHandler(this.buttonZipFile_Click);
            // 
            // textBoxPathDecomp
            // 
            this.textBoxPathDecomp.BackColor = System.Drawing.Color.Gray;
            this.textBoxPathDecomp.Font = new System.Drawing.Font("Gill Sans MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathDecomp.Location = new System.Drawing.Point(387, 228);
            this.textBoxPathDecomp.Name = "textBoxPathDecomp";
            this.textBoxPathDecomp.Size = new System.Drawing.Size(302, 25);
            this.textBoxPathDecomp.TabIndex = 1;
            // 
            // textCompPass
            // 
            this.textCompPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.textCompPass.ForeColor = System.Drawing.Color.Aqua;
            this.textCompPass.Location = new System.Drawing.Point(284, 111);
            this.textCompPass.Name = "textCompPass";
            this.textCompPass.Size = new System.Drawing.Size(281, 25);
            this.textCompPass.TabIndex = 2;
            this.textCompPass.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(202, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password :";
            // 
            // FormCompress
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(744, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCompPass);
            this.Controls.Add(this.textBoxPathDecomp);
            this.Controls.Add(this.textBoxPathComp);
            this.Controls.Add(this.buttonDecomp);
            this.Controls.Add(this.buttonComp);
            this.Controls.Add(this.buttonZipFile);
            this.Controls.Add(this.buttonCompFile);
            this.Font = new System.Drawing.Font("Gill Sans MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCompress";
            this.Text = "FormCompress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCompFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonComp;
        private System.Windows.Forms.Button buttonDecomp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxPathComp;
        private System.Windows.Forms.Button buttonZipFile;
        private System.Windows.Forms.TextBox textBoxPathDecomp;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.TextBox textCompPass;
        private System.Windows.Forms.Label label1;
    }
}