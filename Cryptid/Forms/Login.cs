/* 
 * -------------------------------------
 *   Login for Encryption Creation Tool
 * -------------------------------------
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            try
            {
                SqlConnection mycon = default(SqlConnection);
                mycon = new SqlConnection(@"data source=(localdb)\mssqllocaldb;attachdbfilename=|datadirectory|logindb.mdf;integrated security=true"); //make connection

                SqlCommand mySelect = default(SqlCommand);
                mySelect = new SqlCommand("SELECT Username,Password FROM Users WHERE Username=@Username AND Password=@Password", mycon);

                SqlParameter uName = new SqlParameter("@Username", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);

                uName.Value = textUser.Text;
                uPassword.Value = textPass.Text;

                mySelect.Parameters.Add(uName);
                mySelect.Parameters.Add(uPassword);
                mySelect.Connection.Open();

                SqlDataReader myRead = mySelect.ExecuteReader(CommandBehavior.CloseConnection);

                if (myRead.Read() == true)
                {
                    this.Hide();
                    new Dashboard().Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void textUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textPass.Focus();
            }
        }

        
    }
}
