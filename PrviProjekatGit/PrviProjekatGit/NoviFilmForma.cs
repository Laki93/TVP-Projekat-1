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
    public partial class NoviFilmForma : Form
    {
        
        
        public NoviFilmForma()
        {
            InitializeComponent();
            buttonOk.DialogResult = DialogResult.OK;
            buttonCncl.DialogResult = DialogResult.Cancel;

        }

        private void NoviFilmForma_Load(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text.Trim().Length == 0 || textBoxZanr.Text.Trim().Length == 0 || textBoxOpis.Text.Trim().Length == 0)
                buttonOk.Enabled = false;
            else buttonOk.Enabled = true;
               
        }

        private void buttonCncl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            
                
               
        }

        public Film getItem()
        {
            if (textBoxNaziv.Text.Trim().Length != 0 && textBoxZanr.Text.Trim().Length != 0 && textBoxOpis.Text.Trim().Length != 0)
            {
                Film novi = new Film(textBoxNaziv.Text, textBoxZanr.Text, textBoxOpis.Text);
                return novi;
                this.Close();
            }
            else return null;
        }

        private void textBoxNaziv_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text.Trim().Length == 0 || textBoxZanr.Text.Trim().Length == 0 || textBoxOpis.Text.Trim().Length == 0)
                buttonOk.Enabled = false;
            else buttonOk.Enabled = true;
        }
    }
}
