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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetterOrDigit(e.KeyChar) && !char.Equals(e.KeyChar, (char)Keys.Back) && !char.Equals(e.KeyChar, (char)Keys.Enter))
                e.Handled = true;

            if (e.KeyChar == ((char)Keys.Enter))
                buttonReg_Click(this, new EventArgs());
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            String noviAcc = textBoxUser.Text + " " + textBoxPass.Text; //citanje
            String userName = textBoxUser.Text;
            String izFajla;
            String[] niz;
            System.IO.StreamReader reader = new System.IO.StreamReader(@"C:\Users\Car Lazar\Documents\GitHub\TVP-Projekat-1\PrviProjekatGit\PrviProjekatGit\acc.txt");
            while ((izFajla = reader.ReadLine()) != null)
            {
                niz = izFajla.Split(' ');
                if (String.Compare(niz[0], userName) == 0)
                {
                    MessageBox.Show("Username vec postoji, pokusajte ponovo");
                    reader.Close();
                    return;
                }
            }
            reader.Close();
                                                                    //upisivanje
            System.IO.StreamWriter writer = new System.IO.StreamWriter(@"C:\Users\Car Lazar\Documents\GitHub\TVP-Projekat-1\PrviProjekatGit\PrviProjekatGit\acc.txt", true);
            writer.WriteLine(noviAcc);
            writer.Close();
            MessageBox.Show("Nalog " + userName + " uspesno registrovan.");
            this.Close();

        }

        private void buttonCnc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
