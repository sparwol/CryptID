namespace Cryptid.Forms
{
    partial class FormTools
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
            this.buttonPassGen = new System.Windows.Forms.Button();
            this.buttonCompress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPassGen
            // 
            this.buttonPassGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPassGen.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPassGen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonPassGen.Location = new System.Drawing.Point(101, 159);
            this.buttonPassGen.Name = "buttonPassGen";
            this.buttonPassGen.Size = new System.Drawing.Size(189, 51);
            this.buttonPassGen.TabIndex = 0;
            this.buttonPassGen.Text = "Password Generator";
            this.buttonPassGen.UseVisualStyleBackColor = true;
            this.buttonPassGen.Click += new System.EventHandler(this.buttonPassGen_Click);
            // 
            // buttonCompress
            // 
            this.buttonCompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompress.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonCompress.Location = new System.Drawing.Point(101, 235);
            this.buttonCompress.Name = "buttonCompress";
            this.buttonCompress.Size = new System.Drawing.Size(189, 51);
            this.buttonCompress.TabIndex = 0;
            this.buttonCompress.Text = "Compress and Encrypt";
            this.buttonCompress.UseVisualStyleBackColor = true;
            this.buttonCompress.Click += new System.EventHandler(this.buttonCompress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(327, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generate a random password of a set length\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(327, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Compress and extract a folder with encryption";
            // 
            // FormTools
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(744, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCompress);
            this.Controls.Add(this.buttonPassGen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTools";
            this.Text = "Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPassGen;
        private System.Windows.Forms.Button buttonCompress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}