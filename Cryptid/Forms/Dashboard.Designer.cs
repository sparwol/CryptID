namespace Cryptid
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.buttonFile = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonKeys = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.logoTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonTools = new System.Windows.Forms.Button();
            this.buttonText = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelKeys = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPrivate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonImportPublicKey = new System.Windows.Forms.Button();
            this.buttonCreateAsmKeys = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonExportPublicKey = new System.Windows.Forms.Button();
            this.buttonGetPrivateKey = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEncFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDecFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEncDecText = new System.Windows.Forms.ToolStripMenuItem();
            this.keyMgmtStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKeysCreateAsmKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKeysExport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKeysImport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKeysGetPrivate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressAndEncryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelKeys.SuspendLayout();
            this.panel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFile
            // 
            this.buttonFile.FlatAppearance.BorderSize = 0;
            this.buttonFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFile.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonFile.Location = new System.Drawing.Point(0, 80);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(200, 60);
            this.buttonFile.TabIndex = 5;
            this.buttonFile.Text = "                    File";
            this.buttonFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.buttonFile, "Encrypt and decrypt files");
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.buttonKeys);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.buttonExit);
            this.panel3.Controls.Add(this.buttonTools);
            this.panel3.Controls.Add(this.buttonText);
            this.panel3.Controls.Add(this.button);
            this.panel3.Controls.Add(this.buttonFile);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 561);
            this.panel3.TabIndex = 11;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(25, 206);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, 266);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // buttonKeys
            // 
            this.buttonKeys.FlatAppearance.BorderSize = 0;
            this.buttonKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeys.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonKeys.Location = new System.Drawing.Point(0, 260);
            this.buttonKeys.Name = "buttonKeys";
            this.buttonKeys.Size = new System.Drawing.Size(200, 60);
            this.buttonKeys.TabIndex = 5;
            this.buttonKeys.Text = "                    Keys";
            this.buttonKeys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.buttonKeys, "Manage asymmetric keys ");
            this.buttonKeys.UseVisualStyleBackColor = true;
            this.buttonKeys.Click += new System.EventHandler(this.buttonKeys_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Olive;
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.logoTitle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 80);
            this.panel4.TabIndex = 13;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(134, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(73, 71);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // logoTitle
            // 
            this.logoTitle.AutoSize = true;
            this.logoTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoTitle.Location = new System.Drawing.Point(8, 18);
            this.logoTitle.Name = "logoTitle";
            this.logoTitle.Size = new System.Drawing.Size(134, 39);
            this.logoTitle.TabIndex = 0;
            this.logoTitle.Text = "CryptID";
            this.logoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(191, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 60);
            this.panel2.TabIndex = 12;
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonExit.Location = new System.Drawing.Point(0, 501);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 60);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonTools
            // 
            this.buttonTools.FlatAppearance.BorderSize = 0;
            this.buttonTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTools.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonTools.Location = new System.Drawing.Point(0, 200);
            this.buttonTools.Name = "buttonTools";
            this.buttonTools.Size = new System.Drawing.Size(200, 60);
            this.buttonTools.TabIndex = 5;
            this.buttonTools.Text = "                    Tools";
            this.buttonTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.buttonTools, "Additional tools");
            this.buttonTools.UseVisualStyleBackColor = true;
            this.buttonTools.Click += new System.EventHandler(this.buttonTools_Click);
            // 
            // buttonText
            // 
            this.buttonText.FlatAppearance.BorderSize = 0;
            this.buttonText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonText.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonText.Location = new System.Drawing.Point(0, 140);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(200, 60);
            this.buttonText.TabIndex = 5;
            this.buttonText.Text = "                    Text";
            this.buttonText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.buttonText, "Encrypt and decrypt text");
            this.buttonText.UseVisualStyleBackColor = true;
            this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.labelTitle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(200, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(744, 80);
            this.panel5.TabIndex = 13;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.labelTitle.Location = new System.Drawing.Point(336, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(95, 33);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Home";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.panelKeys);
            this.panelMain.Controls.Add(this.menuStrip1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelMain.Location = new System.Drawing.Point(200, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(744, 481);
            this.panelMain.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(170, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 42);
            this.label3.TabIndex = 30;
            this.label3.Text = "Encryption Tool\r\nv. 1.0.4";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(113, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 58);
            this.label1.TabIndex = 29;
            this.label1.Text = "CryptID\r\n";
            // 
            // panelKeys
            // 
            this.panelKeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelKeys.Controls.Add(this.panel6);
            this.panelKeys.Controls.Add(this.label2);
            this.panelKeys.Controls.Add(this.buttonImportPublicKey);
            this.panelKeys.Controls.Add(this.buttonCreateAsmKeys);
            this.panelKeys.Controls.Add(this.button2);
            this.panelKeys.Controls.Add(this.buttonExportPublicKey);
            this.panelKeys.Controls.Add(this.buttonGetPrivateKey);
            this.panelKeys.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelKeys.Location = new System.Drawing.Point(0, 347);
            this.panelKeys.Name = "panelKeys";
            this.panelKeys.Size = new System.Drawing.Size(744, 134);
            this.panelKeys.TabIndex = 0;
            this.panelKeys.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.labelPrivate);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(0, 99);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(744, 35);
            this.panel6.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Key: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelPrivate
            // 
            this.labelPrivate.AutoSize = true;
            this.labelPrivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPrivate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrivate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelPrivate.Location = new System.Drawing.Point(65, 10);
            this.labelPrivate.Name = "labelPrivate";
            this.labelPrivate.Size = new System.Drawing.Size(95, 15);
            this.labelPrivate.TabIndex = 6;
            this.labelPrivate.Text = "Key Not Set";
            this.labelPrivate.Click += new System.EventHandler(this.labelPrivate_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(0, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 35);
            this.label2.TabIndex = 25;
            this.label2.Text = "Key Management";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonImportPublicKey
            // 
            this.buttonImportPublicKey.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.buttonImportPublicKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonImportPublicKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImportPublicKey.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.buttonImportPublicKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonImportPublicKey.Location = new System.Drawing.Point(341, 46);
            this.buttonImportPublicKey.Name = "buttonImportPublicKey";
            this.buttonImportPublicKey.Size = new System.Drawing.Size(150, 35);
            this.buttonImportPublicKey.TabIndex = 29;
            this.buttonImportPublicKey.Text = "Import Public Key";
            this.toolTip1.SetToolTip(this.buttonImportPublicKey, "Import public key to encrypt file");
            this.buttonImportPublicKey.UseVisualStyleBackColor = true;
            this.buttonImportPublicKey.Click += new System.EventHandler(this.buttonImportPublicKey_Click);
            // 
            // buttonCreateAsmKeys
            // 
            this.buttonCreateAsmKeys.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.buttonCreateAsmKeys.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonCreateAsmKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAsmKeys.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.buttonCreateAsmKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonCreateAsmKeys.Location = new System.Drawing.Point(29, 46);
            this.buttonCreateAsmKeys.Name = "buttonCreateAsmKeys";
            this.buttonCreateAsmKeys.Size = new System.Drawing.Size(150, 35);
            this.buttonCreateAsmKeys.TabIndex = 26;
            this.buttonCreateAsmKeys.Text = "Create Keys";
            this.toolTip1.SetToolTip(this.buttonCreateAsmKeys, "Create asymmetric key pair");
            this.buttonCreateAsmKeys.UseVisualStyleBackColor = true;
            this.buttonCreateAsmKeys.Click += new System.EventHandler(this.buttonCreateAsmKeys_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(26, 602);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "Create 256-bit Key";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonExportPublicKey
            // 
            this.buttonExportPublicKey.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.buttonExportPublicKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonExportPublicKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportPublicKey.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.buttonExportPublicKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonExportPublicKey.Location = new System.Drawing.Point(185, 46);
            this.buttonExportPublicKey.Name = "buttonExportPublicKey";
            this.buttonExportPublicKey.Size = new System.Drawing.Size(150, 35);
            this.buttonExportPublicKey.TabIndex = 28;
            this.buttonExportPublicKey.Text = "Export Public Key";
            this.toolTip1.SetToolTip(this.buttonExportPublicKey, "Export public key to send for encrypting a file");
            this.buttonExportPublicKey.UseVisualStyleBackColor = true;
            this.buttonExportPublicKey.Click += new System.EventHandler(this.buttonExportPublicKey_Click);
            // 
            // buttonGetPrivateKey
            // 
            this.buttonGetPrivateKey.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.buttonGetPrivateKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonGetPrivateKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetPrivateKey.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.buttonGetPrivateKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonGetPrivateKey.Location = new System.Drawing.Point(497, 46);
            this.buttonGetPrivateKey.Name = "buttonGetPrivateKey";
            this.buttonGetPrivateKey.Size = new System.Drawing.Size(150, 35);
            this.buttonGetPrivateKey.TabIndex = 27;
            this.buttonGetPrivateKey.Text = "Get Private Key";
            this.toolTip1.SetToolTip(this.buttonGetPrivateKey, "Get private key to decrypt a sent file");
            this.buttonGetPrivateKey.UseVisualStyleBackColor = true;
            this.buttonGetPrivateKey.Click += new System.EventHandler(this.buttonGetPrivateKey_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Olive;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem,
            this.keyMgmtStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 26);
            this.menuStrip1.TabIndex = 28;
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEncFile,
            this.menuDecFile,
            this.MenuEncDecText});
            this.encryptToolStripMenuItem.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.encryptToolStripMenuItem.Text = "Encrypt/Decrypt";
            // 
            // menuEncFile
            // 
            this.menuEncFile.Name = "menuEncFile";
            this.menuEncFile.Size = new System.Drawing.Size(195, 22);
            this.menuEncFile.Text = "Encrypt File";
            this.menuEncFile.Click += new System.EventHandler(this.menuEncFile_Click);
            // 
            // menuDecFile
            // 
            this.menuDecFile.Name = "menuDecFile";
            this.menuDecFile.Size = new System.Drawing.Size(195, 22);
            this.menuDecFile.Text = "Decrypt File";
            this.menuDecFile.Click += new System.EventHandler(this.menuDecFile_Click);
            // 
            // MenuEncDecText
            // 
            this.MenuEncDecText.Name = "MenuEncDecText";
            this.MenuEncDecText.Size = new System.Drawing.Size(195, 22);
            this.MenuEncDecText.Text = "Encrypt/Decrypt Text";
            this.MenuEncDecText.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // keyMgmtStripMenuItem
            // 
            this.keyMgmtStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuKeysCreateAsmKeys,
            this.MenuKeysExport,
            this.MenuKeysImport,
            this.MenuKeysGetPrivate});
            this.keyMgmtStripMenuItem.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyMgmtStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.keyMgmtStripMenuItem.Name = "keyMgmtStripMenuItem";
            this.keyMgmtStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.keyMgmtStripMenuItem.Text = "Key Mangagement";
            // 
            // MenuKeysCreateAsmKeys
            // 
            this.MenuKeysCreateAsmKeys.Name = "MenuKeysCreateAsmKeys";
            this.MenuKeysCreateAsmKeys.Size = new System.Drawing.Size(225, 22);
            this.MenuKeysCreateAsmKeys.Text = "Create Key Pair";
            this.MenuKeysCreateAsmKeys.Click += new System.EventHandler(this.buttonCreateAsmKeys_Click);
            // 
            // MenuKeysExport
            // 
            this.MenuKeysExport.Name = "MenuKeysExport";
            this.MenuKeysExport.Size = new System.Drawing.Size(225, 22);
            this.MenuKeysExport.Text = "Export Public Key to File";
            this.MenuKeysExport.Click += new System.EventHandler(this.buttonExportPublicKey_Click);
            // 
            // MenuKeysImport
            // 
            this.MenuKeysImport.Name = "MenuKeysImport";
            this.MenuKeysImport.Size = new System.Drawing.Size(225, 22);
            this.MenuKeysImport.Text = "Import Public Key from File";
            this.MenuKeysImport.Click += new System.EventHandler(this.buttonImportPublicKey_Click);
            // 
            // MenuKeysGetPrivate
            // 
            this.MenuKeysGetPrivate.Name = "MenuKeysGetPrivate";
            this.MenuKeysGetPrivate.Size = new System.Drawing.Size(225, 22);
            this.MenuKeysGetPrivate.Text = "Get Private Key";
            this.MenuKeysGetPrivate.Click += new System.EventHandler(this.buttonGetPrivateKey_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordGeneratorToolStripMenuItem,
            this.compressAndEncryptToolStripMenuItem});
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // passwordGeneratorToolStripMenuItem
            // 
            this.passwordGeneratorToolStripMenuItem.Name = "passwordGeneratorToolStripMenuItem";
            this.passwordGeneratorToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.passwordGeneratorToolStripMenuItem.Text = "Password Generator";
            this.passwordGeneratorToolStripMenuItem.Click += new System.EventHandler(this.passwordGeneratorToolStripMenuItem_Click);
            // 
            // compressAndEncryptToolStripMenuItem
            // 
            this.compressAndEncryptToolStripMenuItem.Name = "compressAndEncryptToolStripMenuItem";
            this.compressAndEncryptToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.compressAndEncryptToolStripMenuItem.Text = "Compress and Encrypt";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Dashboard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Aqua;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptID";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelKeys.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTools;
        private System.Windows.Forms.Button buttonKeys;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label logoTitle;
        public System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonText;
		private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelKeys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonImportPublicKey;
        private System.Windows.Forms.Button buttonCreateAsmKeys;
        private System.Windows.Forms.Button buttonExportPublicKey;
        private System.Windows.Forms.Button buttonGetPrivateKey;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelPrivate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEncFile;
        private System.Windows.Forms.ToolStripMenuItem menuDecFile;
        private System.Windows.Forms.ToolStripMenuItem keyMgmtStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem MenuKeysExport;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuKeysImport;
        private System.Windows.Forms.ToolStripMenuItem MenuKeysGetPrivate;
        private System.Windows.Forms.ToolStripMenuItem MenuKeysCreateAsmKeys;
        private System.Windows.Forms.ToolStripMenuItem MenuEncDecText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem compressAndEncryptToolStripMenuItem;
    }
}

