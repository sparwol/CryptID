using System;
using System.IO;
//using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Ionic.Zip;


namespace Cryptid.Forms
{
    public partial class FormCompress : Form
    {
        public FormCompress()
        {
            InitializeComponent();
        }

        private void buttonCompFile_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                textBoxPathComp.Text = path;
            }
        }
        
        private void buttonComp_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (textBoxPathComp.Text != "")
                {
                    saveFileDialog1.DefaultExt = "zip";
                    saveFileDialog1.AddExtension = true;
                    string zipPath = saveFileDialog1.FileName;
                    string startPath = textBoxPathComp.Text;
                    string pass = textCompPass.Text;
                    using (ZipFile zip = new ZipFile())
                    {
                        zip.Password = pass;
                        zip.Encryption = EncryptionAlgorithm.WinZipAes256;
                        zip.AddDirectory(startPath);
                        zip.Save(zipPath);
                    }
                }
                else
                {
                    MessageBox.Show("Please choose location.");
                }
            }
        }

        private void buttonZipFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog1.Filter = "Zip Files (.zip)|*.zip";
                saveFileDialog1.DefaultExt = "zip";
                saveFileDialog1.AddExtension = true; 
                string zippath = openFileDialog1.FileName;
                textBoxPathDecomp.Text = zippath;


            }
        }
        private void buttonDecomp_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                if (textBoxPathDecomp.Text != "")
                {
                    
                    try
                    {
                        string zipPath = textBoxPathDecomp.Text;
                        string extractPath = folderBrowserDialog2.SelectedPath;
                        FileInfo fInfo = new FileInfo(extractPath);
                        // Pass the file name without the path.
                        string name = fInfo.FullName;
                        string pass = textCompPass.Text;
                        using (ZipFile zip = ZipFile.Read(zipPath))
                        {
                            //zip.ExtractAll(extractPath, ExtractExistingFileAction.DoNotOverwrite);
                            foreach (ZipEntry entry in zip)
                            {
                                entry.Encryption = EncryptionAlgorithm.WinZipAes256;
                                entry.ExtractWithPassword(extractPath, pass);
                                    
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Please choose location.");
                }
            }
        }

       
    }    
}
