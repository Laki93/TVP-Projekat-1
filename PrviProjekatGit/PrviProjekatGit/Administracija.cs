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
            if (listBoxSale.SelectedItems.Count == 0)
                buttonDelSale.Enabled = false;
            else buttonDelSale.Enabled = true;
        }

        private void Administracija_FormClosed(object sender, FormClosedEventArgs e)
        {
            admin.Sacuvaj();
            Application.Exit();
        }

        private void Administracija_Load(object sender, EventArgs e)
        {
            //Dodavanje u ListBoxove
            for (int i = 0; i < admin.listaFilmova.Count; i++)
              listBoxFilmovi.Items.Add(admin.listaFilmova[i]);
            for (int i = 0; i < admin.listaSala.Count; i++)
                listBoxSale.Items.Add(admin.listaSala[i]);


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
                LBFilmCheck();
            }
            
        }

        private void buttonFilmRemove_Click(object sender, EventArgs e)
        {
            admin.listaFilmova.Remove((Film)listBoxFilmovi.SelectedItem);
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
            admin.listaSala.Remove((Sala)listBoxSale.SelectedItem);
            listBoxSale.Items.Remove(listBoxSale.SelectedItem);
            LBFilmCheck();
        }
    }
}
