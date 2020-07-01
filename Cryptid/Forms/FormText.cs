using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using Encryption;

namespace Cryptid.Forms
{
    public partial class FormText : System.Windows.Forms.Form
    {
        private SecurityController _security;
        public FormText()
        {
            InitializeComponent();
            _security = new SecurityController();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            string notEncryptedText = richPlainText.Text;
            string encryptedText = _security.Encrypt(password, notEncryptedText);

            richCipherText.Text = encryptedText;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            string encryptedText = richCipherText.Text;
            string notEncryptedText = _security.Decrypt(password, encryptedText);

            richPlainText.Text = notEncryptedText;
        }

        
    }
}