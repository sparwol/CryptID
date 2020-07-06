namespace Cryptid.Forms
{
    partial class FormGenPass
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxPass = new System.Windows.Forms.RichTextBox();
            this.buttonGenPass = new System.Windows.Forms.Button();
            this.textPassLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonAlpha = new System.Windows.Forms.RadioButton();
            this.radioButtonSpec = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(318, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 45);
            this.label1.TabIndex = 0;
            // 
            // richTextBoxPass
            // 
            this.richTextBoxPass.BackColor = System.Drawing.Color.Gray;
            this.richTextBoxPass.ForeColor = System.Drawing.Color.Aqua;
            this.richTextBoxPass.Location = new System.Drawing.Point(174, 215);
            this.richTextBoxPass.Name = "richTextBoxPass";
            this.richTextBoxPass.Size = new System.Drawing.Size(361, 107);
            this.richTextBoxPass.TabIndex = 2;
            this.richTextBoxPass.Text = "";
            // 
            // buttonGenPass
            // 
            this.buttonGenPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGenPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonGenPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenPass.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.buttonGenPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonGenPass.Location = new System.Drawing.Point(279, 353);
            this.buttonGenPass.MaximumSize = new System.Drawing.Size(200, 60);
            this.buttonGenPass.Name = "buttonGenPass";
            this.buttonGenPass.Size = new System.Drawing.Size(158, 40);
            this.buttonGenPass.TabIndex = 20;
            this.buttonGenPass.Text = "Generate Password";
            this.buttonGenPass.UseVisualStyleBackColor = true;
            this.buttonGenPass.Click += new System.EventHandler(this.buttonGenPass_Click);
            // 
            // textPassLength
            // 
            this.textPassLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.textPassLength.ForeColor = System.Drawing.Color.Aqua;
            this.textPassLength.Location = new System.Drawing.Point(350, 100);
            this.textPassLength.Name = "textPassLength";
            this.textPassLength.Size = new System.Drawing.Size(121, 20);
            this.textPassLength.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(227, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Password Length:";
            // 
            // radioButtonAlpha
            // 
            this.radioButtonAlpha.AutoSize = true;
            this.radioButtonAlpha.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAlpha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButtonAlpha.Location = new System.Drawing.Point(188, 159);
            this.radioButtonAlpha.Name = "radioButtonAlpha";
            this.radioButtonAlpha.Size = new System.Drawing.Size(131, 25);
            this.radioButtonAlpha.TabIndex = 26;
            this.radioButtonAlpha.TabStop = true;
            this.radioButtonAlpha.Text = "UPPERlower123";
            this.radioButtonAlpha.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpec
            // 
            this.radioButtonSpec.AutoSize = true;
            this.radioButtonSpec.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSpec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButtonSpec.Location = new System.Drawing.Point(364, 159);
            this.radioButtonSpec.Name = "radioButtonSpec";
            this.radioButtonSpec.Size = new System.Drawing.Size(159, 25);
            this.radioButtonSpec.TabIndex = 27;
            this.radioButtonSpec.TabStop = true;
            this.radioButtonSpec.Text = "UPPERlower123!@#";
            this.radioButtonSpec.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(249, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 28;
            // 
            // FormGenPass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(744, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonSpec);
            this.Controls.Add(this.radioButtonAlpha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPassLength);
            this.Controls.Add(this.buttonGenPass);
            this.Controls.Add(this.richTextBoxPass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGenPass";
            this.Text = "FormTools";
            this.Load += new System.EventHandler(this.FormGenPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxPass;
        private System.Windows.Forms.Button buttonGenPass;
        private System.Windows.Forms.TextBox textPassLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonAlpha;
        private System.Windows.Forms.RadioButton radioButtonSpec;
        private System.Windows.Forms.Label label3;
    }
}