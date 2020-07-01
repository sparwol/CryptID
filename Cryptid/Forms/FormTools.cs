using System;
using System.Windows.Forms;

namespace Cryptid.Forms
{
    public partial class FormTools : System.Windows.Forms.Form
    {
        private Form activeForm;
        public FormTools()
        {
            InitializeComponent();
        }

        private void buttonPassGen_Click(object sender, EventArgs e)
        {
            FormGenPass gen = new FormGenPass();
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = gen;
            gen.TopLevel = false;
            gen.FormBorderStyle = FormBorderStyle.None;
            gen.Dock = DockStyle.Fill;
            this.Controls.Add(gen);
            this.Tag = gen;
            gen.BringToFront();
            gen.Show();
        }

        private void buttonCompress_Click(object sender, EventArgs e)
        {
            FormCompress comp = new FormCompress();
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = comp;
            comp.TopLevel = false;
            comp.FormBorderStyle = FormBorderStyle.None;
            comp.Dock = DockStyle.Fill;
            this.Controls.Add(comp);
            this.Tag = comp;
            comp.BringToFront();
            comp.Show();
        }
    }
}
