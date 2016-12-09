using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrviProjekatGit
{
    public partial class Administracija : Form
    {
        Admin admin;
        public Administracija()
        {
            InitializeComponent();
            admin = new Admin();
            if (File.Exists("admin.txt"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead("admin.txt");
                
                admin = bf.Deserialize(fs) as Admin;
                if(admin.listaFilmova.Count!=0)
                    Film.brojac = admin.listaFilmova.ElementAt(admin.listaFilmova.Count - 1).ID;
                if (admin.listaSala.Count != 0)
                    Sala.brojac = admin.listaSala.ElementAt(admin.listaSala.Count - 1).ID;
                if (admin.listaKarti.Count != 0)
                    Karta.brojac = admin.listaKarti.ElementAt(admin.listaKarti.Count - 1).ID;
                if (admin.listaProjekcija.Count != 0)
                    Projekcija.brojac = admin.listaProjekcija.ElementAt(admin.listaProjekcija.Count - 1).ID;
                fs.Dispose();
                fs.Close();
            }
        }

        public void LBFilmCheck()
        {
            //Dugme za delete i details filma
            if (listBoxFilmovi.SelectedItems.Count == 0)
            {
                buttonFilmDet.Enabled = false;
                buttonFilmRemove.Enabled = false;
            }
            else
            {
                buttonFilmDet.Enabled = true;
                buttonFilmRemove.Enabled = true;
            }
            //Dugme za delete sale
            if (listBoxSale.SelectedItems.Count == 0)
                buttonDelSale.Enabled = false;
            else buttonDelSale.Enabled = true;
            //Dugme za pravljenje karata
            if (comboBoxFilmovi.SelectedItem == null || comboBoxSale.SelectedItem == null || textBoxCena.Text.Trim().Length == 0)
            {
                buttonNapraviKarte.Enabled = false;
            }
            else buttonNapraviKarte.Enabled = true;
            //Dugme za pravljenje projekcija
            if (comboBoxProjFilmovi.SelectedItem == null || comboBoxProjSale.SelectedItem == null)
                buttonProjNapravi.Enabled = false;
            else buttonProjNapravi.Enabled = true;
        }

        private void Administracija_FormClosed(object sender, FormClosedEventArgs e)
        {
            admin.Sacuvaj();
            Application.Exit();
        }

        private void Administracija_Load(object sender, EventArgs e)
        {
            //Dodavanje u ListBoxove i comboBoxove
            for (int i = 0; i < admin.listaFilmova.Count; i++)
            {
                listBoxFilmovi.Items.Add(admin.listaFilmova[i]);
                comboBoxFilmovi.Items.Add(admin.listaFilmova[i]);
                comboBoxProjFilmovi.Items.Add(admin.listaFilmova[i]);
            }
            for (int i = 0; i < admin.listaSala.Count; i++)
            {
                listBoxSale.Items.Add(admin.listaSala[i]);
                comboBoxSale.Items.Add(admin.listaSala[i]);
                comboBoxProjSale.Items.Add(admin.listaSala[i]);
            }
            for (int i = 0; i < admin.listaKarti.Count; i++)
            {
                listBoxKarte.Items.Add(admin.listaKarti[i]);
            }
            for(int i=0;i<admin.listaProjekcija.Count;i++)
            {
                listBoxProjekcije.Items.Add(admin.listaProjekcija[i]);
            }
                LBFilmCheck();

            //podesavanja velicine i pozicije kontrola
            this.WindowState = FormWindowState.Maximized;
            tabControl.Height =this.Size.Height-43;
            tabControl.Width = this.Size.Width-14;

            listBoxFilmovi.Height = tabControl.Height - 50;
            listBoxFilmovi.Width = tabControl.Width - buttonFilmAdd.Width - 30;

            listBoxSale.Height = tabControl.Height - 50;
            listBoxSale.Width = tabControl.Width - buttonFilmAdd.Width - 30;

        }

        private void Administracija_Resize(object sender, EventArgs e)
        {
            tabControl.Height = this.Size.Height-43;
            tabControl.Width = this.Size.Width-14;

            listBoxFilmovi.Height = tabControl.Height - 50;
            listBoxFilmovi.Width = tabControl.Width - buttonFilmAdd.Width - 30;

            listBoxSale.Height = tabControl.Height - 50;
            listBoxSale.Width = tabControl.Width - buttonFilmAdd.Width - 30;

        }

        private void buttonFilmAdd_Click(object sender, EventArgs e)
        {
            NoviFilmForma x = new NoviFilmForma();
            if (x.ShowDialog(this) == DialogResult.OK)
            {
               admin.listaFilmova.Add(x.getItem());
                listBoxFilmovi.Items.Add(admin.listaFilmova[admin.listaFilmova.Count-1]);
                comboBoxFilmovi.Items.Add(admin.listaFilmova[admin.listaFilmova.Count - 1]);
                comboBoxProjFilmovi.Items.Add(admin.listaFilmova[admin.listaFilmova.Count - 1]);
                LBFilmCheck();
            }
            
        }

        private void buttonFilmRemove_Click(object sender, EventArgs e)
        {
            for(int i= admin.listaProjekcija.Count-1; i>=0;i--)
                if (admin.listaProjekcija[i].getFilm == (Film)listBoxFilmovi.SelectedItem) { admin.listaProjekcija.RemoveAt(i);listBoxProjekcije.Items.RemoveAt(i); }
            for (int i = admin.listaKarti.Count-1; i >=0 ; i--)
                if (admin.listaKarti[i].getFilm == (Film)listBoxFilmovi.SelectedItem) { admin.listaKarti.RemoveAt(i);listBoxKarte.Items.RemoveAt(i); }
            admin.listaFilmova.Remove((Film)listBoxFilmovi.SelectedItem);
            comboBoxFilmovi.Items.Remove(listBoxFilmovi.SelectedItem);
            comboBoxProjFilmovi.Items.Remove(listBoxFilmovi.SelectedItem);
            listBoxFilmovi.Items.Remove(listBoxFilmovi.SelectedItem);
            
            LBFilmCheck();

        }

        private void listBoxFilmovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBFilmCheck();
        }

        private void buttonFilmDet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Film)listBoxFilmovi.SelectedItem).Ispisi());
        }

        private void buttonAddSale_Click(object sender, EventArgs e)
        {
            NovaSalaForma x = new NovaSalaForma();
            if (x.ShowDialog(this) == DialogResult.OK)
            {
                admin.listaSala.Add(x.getItem());
                comboBoxSale.Items.Add(admin.listaSala[admin.listaSala.Count - 1]);
                comboBoxProjSale.Items.Add(admin.listaSala[admin.listaSala.Count - 1]);
                listBoxSale.Items.Add(admin.listaSala[admin.listaSala.Count - 1]);

                LBFilmCheck();
            }
        }

        private void listBoxSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBFilmCheck();
        }

        private void buttonDelSale_Click(object sender, EventArgs e)
        {
            for (int i = admin.listaProjekcija.Count - 1; i >= 0; i--)
                if (admin.listaProjekcija[i].getSala == (Sala)listBoxSale.SelectedItem) { admin.listaProjekcija.RemoveAt(i); listBoxProjekcije.Items.RemoveAt(i); }
            for (int i = admin.listaKarti.Count-1; i >= 0; i--)
                if (admin.listaKarti[i].getSala == (Sala)listBoxSale.SelectedItem) { admin.listaKarti.RemoveAt(i); listBoxKarte.Items.RemoveAt(i); }
            admin.listaSala.Remove((Sala)listBoxSale.SelectedItem);
            comboBoxSale.Items.Remove(listBoxSale.SelectedItem);
            comboBoxProjSale.Items.Remove(listBoxSale.SelectedItem);
            listBoxSale.Items.Remove(listBoxSale.SelectedItem);
            LBFilmCheck();
        }

        private void textBoxCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void buttonNapraviKarte_Click(object sender, EventArgs e)
        {
            for(int i=0;i<((Sala)comboBoxSale.SelectedItem).BrojMesta;i++)
            {
                Karta x = new Karta(((Film)comboBoxFilmovi.SelectedItem), ((Sala)comboBoxSale.SelectedItem),i, int.Parse(textBoxCena.Text));
                admin.listaKarti.Add(x);
                listBoxKarte.Items.Add(admin.listaKarti[admin.listaKarti.Count - 1]);
            }
            MessageBox.Show("Uspesno napravljene karte za film: "+ ((Film)comboBoxFilmovi.SelectedItem).Naziv+" i salu: "+((Sala)comboBoxSale.SelectedItem).Naziv+"\r\nKomada: "+ ((Sala)comboBoxSale.SelectedItem).BrojMesta);
            LBFilmCheck();
        }

        private void textBoxCena_TextChanged(object sender, EventArgs e)
        {
            LBFilmCheck();
        }

        private void comboBoxFilmovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBFilmCheck();
        }

        private void buttonProjNapravi_Click(object sender, EventArgs e)
        {
            Projekcija x = new Projekcija(((Film)comboBoxProjFilmovi.SelectedItem), ((Sala)comboBoxProjSale.SelectedItem), dateTimePickerVreme.Value);
            admin.listaProjekcija.Add(x);
            listBoxProjekcije.Items.Add(admin.listaProjekcija[admin.listaProjekcija.Count - 1]);
            LBFilmCheck();
        }
    }
}
