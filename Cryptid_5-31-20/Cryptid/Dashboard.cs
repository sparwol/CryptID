/*
 * ----------------------------------
 *          CRYPTID 
 *        
 *      File Encryption
 *    
 *    by Sean Parrott-Wolfe
 *    Last updated 5/31/20
 * ----------------------------------
 *  Estimated Time for Incremental: 3 hrs
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cryptid.Forms;

namespace Cryptid
{ 
    public partial class Sirrus : Form
    {
        
        private Form activeForm;
        
        public Sirrus()
        {
            InitializeComponent();
        }
        
        private void Sirrus_Load(object sender, EventArgs e)
        {
            
        }
        
        private void OpenChildForm(Form childForm, object buttonSend)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
            
        }

        
        private void buttonAes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAes(), sender);
            panel2.Height = buttonAes.Height;
            panel2.Top = buttonAes.Top;
            //labelTitle.Text = buttonAes.Text;
        }

        private void buttonTwofish_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTwofish(), sender); 
            panel2.Height = buttonTwofish.Height;
            panel2.Top = buttonTwofish.Top;
        }

        private void buttonEllipticCurve_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEllipticCurve(), sender); 
            panel2.Height = buttonEllipticCurve.Height;
            panel2.Top = buttonEllipticCurve.Top;
        }

        private void buttonTools_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTools(), sender); 
            panel2.Height = buttonTools.Height;
            panel2.Top = buttonTools.Top;
        }

        
    }
    
}