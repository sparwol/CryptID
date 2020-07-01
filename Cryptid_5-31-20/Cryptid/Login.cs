/* 
 * -------------------------------------
 *   Login for Encryption Creation Tool
 * -------------------------------------
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptid
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            int pin;

            string passwd = textPass.Text;
            if(int.TryParse(textPin.Text,out pin))
            {
                if (textPin.Text.Length != 6)
                {
                    MessageBox.Show("PIN length is incorrect.", "Try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(pin == 123456)
                {
                    if (passwd == "")
                    {
                        MessageBox.Show("Please enter a password.");
                    }
                    else if (passwd == "Password123")
                    {
                        Sirrus x = new Sirrus();
                        x.Show();

                    }
                    else
                    {
                        MessageBox.Show("Wrong Password.", "Try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                 else
                {
                    MessageBox.Show("Wrong PIN.", "Try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
            else
            {
                MessageBox.Show("Not a valid PIN. PIN can only be numbers.");
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonEnter.PerformClick();
            }
        }

        private void textPin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textPass.Focus();
            }
        }
    }
}
