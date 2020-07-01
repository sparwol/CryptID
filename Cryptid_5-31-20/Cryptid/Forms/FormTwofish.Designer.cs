namespace Cryptid.Forms
{
    partial class FormTwofish
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
            this.labelTwofish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTwofish
            // 
            this.labelTwofish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTwofish.AutoSize = true;
            this.labelTwofish.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTwofish.Location = new System.Drawing.Point(237, 162);
            this.labelTwofish.Name = "labelTwofish";
            this.labelTwofish.Size = new System.Drawing.Size(123, 45);
            this.labelTwofish.TabIndex = 0;
            this.labelTwofish.Text = "Twofish";
            // 
            // FormTwofish
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(635, 417);
            this.Controls.Add(this.labelTwofish);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTwofish";
            this.Text = "Twofish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTwofish;
    }
}