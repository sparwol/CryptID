﻿using System;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Linq;

namespace Cryptid.Forms
{
    public partial class FormFile : Form
    {
        // Declare CspParmeters and RsaCryptoServiceProvider
        // objects with global scope of your Form class.
        CspParameters cspp = new CspParameters();
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

        // Path variables for source, encryption, and
        // decryption folders. Must end with a backslash.
        public const string EncrFolder = @"c:\Encrypt\";
        public const string DecrFolder = @"c:\Decrypt\";
        public const string SrcFolder = @"c:\Docs\";

        // Public key file
        public const string PubKeyFile = @"c:\Encrypt\rsaPublicKey.txt";

        // Key container name for
        // private/public key value pair.
        const string keyName = "RSA Key";

        public FormFile()
        {
            InitializeComponent();
            this.panel1.DragDrop += new DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragOver += new DragEventHandler(this.panel1_DragOver);
            this.panel2.DragDrop += new DragEventHandler(this.panel2_DragDrop);
            this.panel2.DragOver += new DragEventHandler(this.panel2_DragOver);

        }

        public void aesEncryptFile(string inFile)
        {
            // Create instance of AES for
            // symetric encryption of the data.

            RijndaelManaged aes1 = new RijndaelManaged();
            aes1.KeySize = 256;
            aes1.BlockSize = 128;
            aes1.Mode = CipherMode.CBC;
            ICryptoTransform transform = aes1.CreateEncryptor();

            // Use RSACryptoServiceProvider to
            // enrypt the AES key.
            byte[] keyEncrypted = rsa.Encrypt(aes1.Key, false);

            // Create byte arrays to contain
            // the length values of the key and IV.
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            int lKey = keyEncrypted.Length;
            LenK = BitConverter.GetBytes(lKey);
            int lIV = aes1.IV.Length;
            LenIV = BitConverter.GetBytes(lIV);

            // Write the following to the FileStream
            // for the encrypted file (outFs):
            // - length of the key
            // - length of the IV
            // - ecrypted key
            // - the IV
            // - the encrypted cipher content

            int startFileName = inFile.LastIndexOf("\\") + 1;
            // Change the file's extension to ".enc"
            string outFile = Dashboard.EncrFolder + inFile.Substring(startFileName, inFile.LastIndexOf(".") - startFileName) + ".enc";

            using (FileStream outFs = new FileStream(outFile, FileMode.Create))
            {

                outFs.Write(LenK, 0, 4);
                outFs.Write(LenIV, 0, 4);
                outFs.Write(keyEncrypted, 0, lKey);
                outFs.Write(aes1.IV, 0, lIV);

                // Now write the cipher text using
                // a CryptoStream for encrypting.
                using (CryptoStream outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                {

                    // By encrypting a chunk at
                    // a time, you can save memory
                    // and accommodate large files.
                    int count = 0;
                    int offset = 0;

                    // blockSizeBytes can be any arbitrary size.
                    int blockSizeBytes = aes1.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];
                    int bytesRead = 0;

                    using (FileStream inFs = new FileStream(inFile, FileMode.Open))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamEncrypted.Write(data, 0, count);
                            bytesRead += blockSizeBytes;
                        }
                        while (count > 0);
                        inFs.Close();
                    }
                    outStreamEncrypted.FlushFinalBlock();
                    outStreamEncrypted.Close();
                }
                outFs.Close();
            }
        }

        private void aesDecryptFile(string inFile)
        {

            // Create instance of AES for
            // symetric decryption of the data.
           RijndaelManaged aes1 = new RijndaelManaged();
            aes1.KeySize = 256;
            aes1.BlockSize = 128;
            aes1.Mode = CipherMode.CBC;
            
           

            // Create byte arrays to get the length of
            // the encrypted key and IV.
            // These values were stored as 4 bytes each
            // at the beginning of the encrypted package.
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            // Consruct the file name for the decrypted file.
            string outFile = Dashboard.DecrFolder + inFile.Substring(0, inFile.LastIndexOf(".")) + ".txt";

            // Use FileStream objects to read the encrypted
            // file (inFs) and save the decrypted file (outFs).
            using (FileStream inFs = new FileStream(Dashboard.EncrFolder + inFile, FileMode.Open))
            {

                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Read(LenK, 0, 3);
                inFs.Seek(4, SeekOrigin.Begin);
                inFs.Read(LenIV, 0, 3);

                // Convert the lengths to integer values.
                int lenK = BitConverter.ToInt32(LenK, 0);
                int lenIV = BitConverter.ToInt32(LenIV, 0);

                // Determine the start postition of
                // the ciphter text (startC)
                // and its length(lenC).
                int startC = lenK + lenIV + 8;
                int lenC = (int)inFs.Length - startC;

                // Create the byte arrays for
                // the encrypted AES key,
                // the IV, and the cipher text.
                byte[] KeyEncrypted = new byte[lenK];
                byte[] IV = new byte[lenIV];

                // Extract the key and IV
                // starting from index 8
                // after the length values.
                inFs.Seek(8, SeekOrigin.Begin);
                inFs.Read(KeyEncrypted, 0, lenK);
                inFs.Seek(8 + lenK, SeekOrigin.Begin);
                inFs.Read(IV, 0, lenIV);
                Directory.CreateDirectory(Dashboard.DecrFolder);
                // Use RSACryptoServiceProvider
                // to decrypt the AES key.
                byte[] KeyDecrypted = rsa.Decrypt(KeyEncrypted, false);

                // Decrypt the key.
                ICryptoTransform transform = aes1.CreateDecryptor(KeyDecrypted, IV);

                // Decrypt the cipher text from
                // from the FileSteam of the encrypted
                // file (inFs) into the FileStream
                // for the decrypted file (outFs).
                using (FileStream outFs = new FileStream(outFile, FileMode.Create))
                {

                    int count = 0;
                    int offset = 0;

                    // blockSizeBytes can be any arbitrary size.
                    int blockSizeBytes = aes1.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];

                    // By decrypting a chunk a time,
                    // you can save memory and
                    // accommodate large files.

                    // Start at the beginning
                    // of the cipher text.
                    inFs.Seek(startC, SeekOrigin.Begin);
                    using (CryptoStream outStreamDecrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamDecrypted.Write(data, 0, count);
                        }
                        while (count > 0);

                        outStreamDecrypted.FlushFinalBlock();
                        outStreamDecrypted.Close();
                    }
                    outFs.Close();
                }
                inFs.Close();
            }
        }
        // Encrypt Button
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (rsa == null)
            {
                MessageBox.Show("Key not set.");
            }
            else
            {
                // Display a dialog box to select a file to encrypt.
                openFileDialog1.InitialDirectory = Dashboard.SrcFolder;
                openFileDialog1.Title = "Choose file(s) to encrypt";
                openFileDialog1.Multiselect = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fName = openFileDialog1.FileName;
                    if (fName != null)
                    {
                        FileInfo fInfo = new FileInfo(fName);
                        // Pass the file name without the path.
                        string name = fInfo.FullName;
                        aesEncryptFile(name);
                    }
                }
            }
        }

        // Decrypt Button
        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (rsa == null)
            {
                MessageBox.Show("Key not set.");
            }
            else
            {
                // Display a dialog box to select the encrypted file.
                openFileDialog2.InitialDirectory = Dashboard.EncrFolder;
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    string fName = openFileDialog2.FileName;
                    if (fName != null)
                    {
                        FileInfo fi = new FileInfo(fName);
                        string name = fi.Name;
                        aesDecryptFile(name);
                    }
                }
            }
        }
 
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        void panel1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (rsa == null)
            {
                MessageBox.Show("Key not set.");
            }
            else
            {
                try
                { 
                    string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
                    if (files != null && files.Any())
                    {
                        label5.Text = files.First();
                        FileInfo fInfo = new FileInfo(label5.Text);
                        // Pass the file name without the path.
                        string name = fInfo.FullName;
                        aesEncryptFile(name);
                        MessageBox.Show(name + " was encrypted to " + EncrFolder);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            
                
        }
        void panel2_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        void panel2_DragDrop(object sender, DragEventArgs e)
        {
            if (rsa == null)
            {
                MessageBox.Show("Key not set.");
            }
            else
            {
                try
                {
                    string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
                    if (files != null && files.Any())
                    {
                        label5.Text = files.First();
                        // Pass the file name without the path.
                        FileInfo fi = new FileInfo(label5.Text);
                        string name = fi.Name;
                        aesDecryptFile(name);
                        MessageBox.Show(name + " was decrypted to " + DecrFolder);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }


        }

        
    }
}

