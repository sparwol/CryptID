namespace Cryptid
{
    partial class Sirrus
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
            this.buttonAes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTools = new System.Windows.Forms.Button();
            this.buttonTwofish = new System.Windows.Forms.Button();
            this.buttonEllipticCurve = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAes
            // 
            this.buttonAes.FlatAppearance.BorderSize = 0;
            this.buttonAes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAes.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAes.Location = new System.Drawing.Point(0, 80);
            this.buttonAes.Name = "buttonAes";
            this.buttonAes.Size = new System.Drawing.Size(200, 60);
            this.buttonAes.TabIndex = 5;
            this.buttonAes.Text = "AES";
            this.buttonAes.UseVisualStyleBackColor = true;
            this.buttonAes.Click += new System.EventHandler(this.buttonAes_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.buttonTools);
            this.panel3.Controls.Add(this.buttonTwofish);
            this.panel3.Controls.Add(this.buttonEllipticCurve);
            this.panel3.Controls.Add(this.button);
            this.panel3.Controls.Add(this.buttonAes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 561);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Olive;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 80);
            this.panel4.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "CryptID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 60);
            this.panel2.TabIndex = 12;
            // 
            // buttonTools
            // 
            this.buttonTools.FlatAppearance.BorderSize = 0;
            this.buttonTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTools.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonTools.Location = new System.Drawing.Point(0, 260);
            this.buttonTools.Name = "buttonTools";
            this.buttonTools.Size = new System.Drawing.Size(200, 60);
            this.buttonTools.TabIndex = 5;
            this.buttonTools.Text = "Tools";
            this.buttonTools.UseVisualStyleBackColor = true;
            this.buttonTools.Click += new System.EventHandler(this.buttonTools_Click);
            // 
            // buttonTwofish
            // 
            this.buttonTwofish.FlatAppearance.BorderSize = 0;
            this.buttonTwofish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwofish.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTwofish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonTwofish.Location = new System.Drawing.Point(0, 140);
            this.buttonTwofish.Name = "buttonTwofish";
            this.buttonTwofish.Size = new System.Drawing.Size(200, 60);
            this.buttonTwofish.TabIndex = 5;
            this.buttonTwofish.Text = "Twofish";
            this.buttonTwofish.UseVisualStyleBackColor = true;
            this.buttonTwofish.Click += new System.EventHandler(this.buttonTwofish_Click);
            // 
            // buttonEllipticCurve
            // 
            this.buttonEllipticCurve.FlatAppearance.BorderSize = 0;
            this.buttonEllipticCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEllipticCurve.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEllipticCurve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonEllipticCurve.Location = new System.Drawing.Point(0, 200);
            this.buttonEllipticCurve.Name = "buttonEllipticCurve";
            this.buttonEllipticCurve.Size = new System.Drawing.Size(200, 60);
            this.buttonEllipticCurve.TabIndex = 5;
            this.buttonEllipticCurve.Text = "Elliptic Curve";
            this.buttonEllipticCurve.UseVisualStyleBackColor = true;
            this.buttonEllipticCurve.Click += new System.EventHandler(this.buttonEllipticCurve_Click);
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
            this.labelTitle.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.labelTitle.Location = new System.Drawing.Point(336, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(85, 34);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Home";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(744, 481);
            this.panelMain.TabIndex = 14;
            // 
            // Sirrus
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
            this.Name = "Sirrus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptID";
            this.Load += new System.EventHandler(this.Sirrus_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTools;
        private System.Windows.Forms.Button buttonEllipticCurve;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonTwofish;
    }
}

