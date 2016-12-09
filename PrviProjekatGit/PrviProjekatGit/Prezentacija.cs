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
    public partial class Prezentacija : Form
    {
        Admin admin;
        User user;
        public Prezentacija(String username)
        {
            InitializeComponent();
            admin = new Admin();
            user = new User();
            labelUsername.Text = username;
            user.username = username;
            if (File.Exists("admin.txt"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead("admin.txt");

                admin = bf.Deserialize(fs) as Admin;
                if (admin.listaFilmova.Count != 0)
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

        public void DugmeCheck()
        {
            //Za Film detalje dugme
            if (listBoxFilmovi.SelectedItems.Count == 0)
                buttonFilmDetalji.Enabled = false;
            else
                buttonFilmDetalji.Enabled = true;

            //Za Projekcije detalje dugme
            if (listBoxProjekcije.SelectedItems.Count == 0)
                buttonProjDetalji.Enabled = false;
            else
                buttonProjDetalji.Enabled = true;

        }

        private void Prezentacija_FormClosed(object sender, FormClosedEventArgs e)
        {
            admin.Sacuvaj();
            Application.Exit();
        }

        private void Prezentacija_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //dodavanje filmova u listbox
            for (int i = 0; i < admin.listaFilmova.Count; i++)
            {
                listBoxFilmovi.Items.Add(admin.listaFilmova[i]);
            }
            DugmeCheck();

        }

        private void listBoxFilmovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxProjekcije.Items.Clear();
            for (int i = 0; i < admin.listaProjekcija.Count; i++)
            {
                if(admin.listaProjekcija[i].getFilm==((Film)listBoxFilmovi.SelectedItem))
                {
                    listBoxProjekcije.Items.Add(admin.listaProjekcija[i]);
                }
            }
            DugmeCheck();
        }

        private void buttonFilmDetalji_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Film)(listBoxFilmovi.SelectedItem)).Ispisi());
        }

        private void listBoxProjekcije_SelectedIndexChanged(object sender, EventArgs e)
        {
            DugmeCheck();
        }

        private void buttonProjDetalji_Click(object sender, EventArgs e)
        {
            RezervacijaKarata x = new RezervacijaKarata(admin, listBoxProjekcije.SelectedItem as Projekcija,user);
            x.ShowDialog();
           
        }
    }
}
