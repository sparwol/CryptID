namespace Cryptid.Forms
{
    partial class FormAes
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateAsmKeys = new System.Windows.Forms.Button();
            this.buttonGetPrivateKey = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelKey = new System.Windows.Forms.Label();
            this.buttonExportPublicKey = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonImportPublicKey = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Key Management";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCreateAsmKeys
            // 
            this.buttonCreateAsmKeys.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.buttonCreateAsmKeys.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonCreateAsmKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAsmKeys.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.buttonCreateAsmKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonCreateAsmKeys.Location = new System.Drawing.Point(15, 139);
            this.buttonCreateAsmKeys.Name = "buttonCreateAsmKeys";
            this.buttonCreateAsmKeys.Size = new System.Drawing.Size(150, 35);
            this.buttonCreateAsmKeys.TabIndex = 20;
            this.buttonCreateAsmKeys.Text = "Create Keys";
            this.buttonCreateAsmKeys.UseVisualStyleBackColor = true;
            this.buttonCreateAsmKeys.Click += new System.EventHandler(this.buttonCreateAsmKeys_Click);
            // 
            // buttonGetPrivateKey
            // 
            this.buttonGetPrivateKey.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.buttonGetPrivateKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonGetPrivateKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetPrivateKey.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.buttonGetPrivateKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonGetPrivateKey.Location = new System.Drawing.Point(15, 277);
            this.buttonGetPrivateKey.Name = "buttonGetPrivateKey";
            this.buttonGetPrivateKey.Size = new System.Drawing.Size(150, 35);
            this.buttonGetPrivateKey.TabIndex = 21;
            this.buttonGetPrivateKey.Text = "Get Private Key";
            this.buttonGetPrivateKey.UseVisualStyleBackColor = true;
            this.buttonGetPrivateKey.Click += new System.EventHandler(this.buttonGetPrivateKey_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 33);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelKey.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelKey.Location = new System.Drawing.Point(12, 9);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(127, 15);
            this.labelKey.TabIndex = 6;
            this.labelKey.Text = "RSA Key Not Set";
            // 
            // buttonExportPublicKey
            // 
            this.buttonExportPublicKey.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.buttonExportPublicKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonExportPublicKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportPublicKey.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.buttonExportPublicKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonExportPublicKey.Location = new System.Drawing.Point(15, 185);
            this.buttonExportPublicKey.Name = "buttonExportPublicKey";
            this.buttonExportPublicKey.Size = new System.Drawing.Size(150, 35);
            this.buttonExportPublicKey.TabIndex = 22;
            this.buttonExportPublicKey.Text = "Export Public Key";
            this.buttonExportPublicKey.UseVisualStyleBackColor = true;
            this.buttonExportPublicKey.Click += new System.EventHandler(this.buttonExportPublicKey_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDecrypt.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDecrypt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecrypt.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.buttonDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDecrypt.Location = new System.Drawing.Point(121, 206);
            this.buttonDecrypt.MaximumSize = new System.Drawing.Size(200, 60);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(200, 60);
            this.buttonDecrypt.TabIndex = 23;
            this.buttonDecrypt.Text = "Decrypt File";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonImportPublicKey
            // 
            this.buttonImportPublicKey.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.buttonImportPublicKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonImportPublicKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImportPublicKey.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.buttonImportPublicKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonImportPublicKey.Location = new System.Drawing.Point(15, 231);
            this.buttonImportPublicKey.Name = "buttonImportPublicKey";
            this.buttonImportPublicKey.Size = new System.Drawing.Size(150, 35);
            this.buttonImportPublicKey.TabIndex = 24;
            this.buttonImportPublicKey.Text = "Import Public Key";
            this.buttonImportPublicKey.UseVisualStyleBackColor = true;
            this.buttonImportPublicKey.Click += new System.EventHandler(this.buttonImportPublicKey_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncrypt.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.buttonEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonEncrypt.Location = new System.Drawing.Point(121, 126);
            this.buttonEncrypt.MaximumSize = new System.Drawing.Size(200, 60);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(200, 60);
            this.buttonEncrypt.TabIndex = 19;
            this.buttonEncrypt.Text = "Encrypt File";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonImportPublicKey);
            this.panel2.Controls.Add(this.buttonCreateAsmKeys);
            this.panel2.Controls.Add(this.buttonExportPublicKey);
            this.panel2.Controls.Add(this.buttonGetPrivateKey);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(441, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 462);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonEncrypt);
            this.panel3.Controls.Add(this.buttonDecrypt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 429);
            this.panel3.TabIndex = 28;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // FormAes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(620, 462);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAes";
            this.Text = "AES";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreateAsmKeys;
        private System.Windows.Forms.Button buttonGetPrivateKey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Button buttonExportPublicKey;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonImportPublicKey;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}