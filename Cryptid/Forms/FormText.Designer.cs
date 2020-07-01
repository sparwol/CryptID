namespace Cryptid.Forms
{
    partial class FormText
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
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richPlainText = new System.Windows.Forms.RichTextBox();
            this.richCipherText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTextPass = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncrypt.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.buttonEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonEncrypt.Location = new System.Drawing.Point(321, 234);
            this.buttonEncrypt.MaximumSize = new System.Drawing.Size(200, 60);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(98, 33);
            this.buttonEncrypt.TabIndex = 24;
            this.buttonEncrypt.Text = "Encrypt >";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDecrypt.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDecrypt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecrypt.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.buttonDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDecrypt.Location = new System.Drawing.Point(321, 273);
            this.buttonDecrypt.MaximumSize = new System.Drawing.Size(200, 60);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(98, 33);
            this.buttonDecrypt.TabIndex = 25;
            this.buttonDecrypt.Text = "< Decypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(85, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 26;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richPlainText
            // 
            this.richPlainText.BackColor = System.Drawing.Color.Gray;
            this.richPlainText.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richPlainText.ForeColor = System.Drawing.Color.Black;
            this.richPlainText.Location = new System.Drawing.Point(67, 179);
            this.richPlainText.Name = "richPlainText";
            this.richPlainText.Size = new System.Drawing.Size(236, 198);
            this.richPlainText.TabIndex = 28;
            this.richPlainText.Text = "Plain text here...";
            // 
            // richCipherText
            // 
            this.richCipherText.BackColor = System.Drawing.Color.Gray;
            this.richCipherText.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.richCipherText.ForeColor = System.Drawing.Color.Black;
            this.richCipherText.Location = new System.Drawing.Point(437, 179);
            this.richCipherText.Name = "richCipherText";
            this.richCipherText.Size = new System.Drawing.Size(236, 198);
            this.richCipherText.TabIndex = 28;
            this.richCipherText.Text = "Cipher text here...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(151, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "PlainText";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(513, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "CipherText";
            // 
            // labelTextPass
            // 
            this.labelTextPass.AutoSize = true;
            this.labelTextPass.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.labelTextPass.ForeColor = System.Drawing.Color.Olive;
            this.labelTextPass.Location = new System.Drawing.Point(201, 97);
            this.labelTextPass.Name = "labelTextPass";
            this.labelTextPass.Size = new System.Drawing.Size(114, 21);
            this.labelTextPass.TabIndex = 29;
            this.labelTextPass.Text = "Enter Password :";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.textBoxPassword.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.Cyan;
            this.textBoxPassword.Location = new System.Drawing.Point(321, 94);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(151, 25);
            this.textBoxPassword.TabIndex = 30;
            // 
            // FormText
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(744, 481);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTextPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richCipherText);
            this.Controls.Add(this.richPlainText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonDecrypt);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormText";
            this.Text = "Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richPlainText;
        private System.Windows.Forms.RichTextBox richCipherText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTextPass;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}