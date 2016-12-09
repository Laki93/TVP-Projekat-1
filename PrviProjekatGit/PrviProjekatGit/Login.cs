using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrviProjekatGit
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.Equals(e.KeyChar, (char)Keys.Back) && !char.Equals(e.KeyChar, (char)Keys.Enter))
                e.Handled = true;

            if (e.KeyChar==((char)Keys.Enter))
                   buttonLogin_Click(this,new EventArgs());

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String acc = textBoxUsername.Text;

            if (acc == "admin")
            {
                Administracija y = new Administracija();
                y.Show();
                this.Hide();
            }
            else if (acc.Trim().Length == 0)
            {
                MessageBox.Show("Unesite username.");
            }
            else { 
            Prezentacija x = new Prezentacija(textBoxUsername.Text);
                        x.Show();
                        this.Hide();
                        return;
                    }              
        }
        

        private void labelReg_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }
    }
}
