using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cryptid.Properties;
using Org.BouncyCastle.Security;

namespace Cryptid.Forms
{
    
    public partial class FormGenPass : System.Windows.Forms.Form
    {
        public FormGenPass()
        {
            InitializeComponent();
        }
        private void FormGenPass_Load(object sender, EventArgs e)
        {

        }
        public String GeneratePasswordAlpha(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        public String GeneratePasswordSpec(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void buttonGenPass_Click(object sender, EventArgs e)
        {
            int len = 0;

            Int32.TryParse(textPassLength.Text, out len);
            if(radioButtonAlpha.Checked)
            {
                richTextBoxPass.Text = GeneratePasswordAlpha(len);
            }
            else if(radioButtonSpec.Checked)
            {
                richTextBoxPass.Text = GeneratePasswordSpec(len);
            }
        }

        
    }

}
