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
    public partial class NovaSalaForma : Form
    {
        public NovaSalaForma()
        {
            InitializeComponent();
            buttonOk.DialogResult = DialogResult.OK;
            buttonCnc.DialogResult = DialogResult.Cancel;
        }

        private void NovaSalaForma_Load(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text.Trim().Length == 0 || textBoxRedova.Text.Trim().Length == 0 || textBoxKolona.Text.Trim().Length == 0)
                buttonOk.Enabled = false;
            else buttonOk.Enabled = true;
        }

        private void buttonCnc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Sala getItem()
        {
            if (textBoxNaziv.Text.Trim().Length != 0 && textBoxRedova.Text.Trim().Length != 0 && textBoxKolona.Text.Trim().Length != 0)
            {
                Sala nova = new Sala(textBoxNaziv.Text,int.Parse(textBoxRedova.Text), int.Parse(textBoxKolona.Text));
                return nova;
                this.Close();
            }
            else return null;
        }

        private void textBoxNaziv_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text.Trim().Length == 0 || textBoxRedova.Text.Trim().Length == 0 || textBoxKolona.Text.Trim().Length == 0)
                buttonOk.Enabled = false;
            else buttonOk.Enabled = true;
        }

        private void textBoxRedova_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar==(char)Keys.Back))
                e.Handled = true;
        }


    }
}
