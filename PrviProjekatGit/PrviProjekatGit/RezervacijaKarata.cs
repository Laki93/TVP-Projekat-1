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
    public partial class RezervacijaKarata : Form
    {
        
        Admin admin;
        Projekcija projekcija;
        List<int> nizCena;
        Button[] nizBatona;
        int brojac;
        int popunjenaMesta=0;
        User user;
        public RezervacijaKarata(Admin a, Projekcija p, User u)
        {
            InitializeComponent();
            user = u;
            nizCena = new List<int>();
            admin = a;
            projekcija = p;
            brojac = 0;


            for (int i = 0; i < admin.listaKarti.Count; i++)
            {
                if (!nizCena.Contains(admin.listaKarti[i].Cena) && projekcija.getSala == admin.listaKarti[i].getSala)
                    nizCena.Add(admin.listaKarti[i].Cena);
            }

            nizBatona = new Button[p.getSala.BrojMesta];
            for (int i = 0; i < projekcija.getSala.BrojMesta; i++)
            {
                Button btn = new Button() { Text = "" + i };
                btn.Click += Btn_Click;
                nizBatona[i] = btn;
            }
        }

        public void BtnCheck()
        {
            //Kupi Dugme
            if (brojac == 0 || comboBoxCena.SelectedItem == null)
                buttonKupi.Enabled = false;
            else
                buttonKupi.Enabled = true;

            //Oceni Dugme
            if (user.mojeKarte.Count == 0 || textBoxOcena.Text.Length == 0 || user.mojiFilmovi.ocenjen == true)
                buttonOceni.Enabled = false;
            else
                buttonOceni.Enabled = true;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (brojac > 5 && b.BackColor != Color.Red)
            { MessageBox.Show("Ne mozete kupiti vise od 6 karata"); BtnCheck(); return; }

            if (b.BackColor == Color.Red)
            {
                brojac--;
                b.BackColor = DefaultBackColor;
                BtnCheck();
            }
            else
            {
                b.BackColor = Color.Red;
                brojac++;
                BtnCheck();
            }
        }

        private void RezervacijaKarata_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < nizCena.Count; i++)
            {
                comboBoxCena.Items.Add(nizCena[i]);

            }

            tableLayoutPanel1.ColumnCount = projekcija.getSala.Kolone;
            tableLayoutPanel1.ColumnStyles.Clear();
            for (int i = 0; i < projekcija.getSala.Kolone; i++)
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / projekcija.getSala.Kolone));

            tableLayoutPanel1.RowCount = projekcija.getSala.Redovi;
            tableLayoutPanel1.RowStyles.Clear();
            for (int i = 0; i < projekcija.getSala.Redovi; i++)
                tableLayoutPanel1.RowStyles.Add(new ColumnStyle(SizeType.Percent, 100F / projekcija.getSala.Redovi));


            tableLayoutPanel1.Controls.AddRange(nizBatona);
            for (int i = 0; i < projekcija.getSala.Redovi; i++)
                for (int j = 0; j < projekcija.getSala.Kolone; j++)
                    for (int k = 0; k < projekcija.kupljenaMesta.Count; k++)
                        if (tableLayoutPanel1.GetControlFromPosition(i, j).Text == projekcija.kupljenaMesta[k].ToString())
                        { tableLayoutPanel1.GetControlFromPosition(i, j).Enabled = false;}

            NadjiPopunjena();
                    
            BtnCheck();
        }

        private void textBoxOcena_TextChanged(object sender, EventArgs e)
        {
            BtnCheck();
        }

        private void textBoxOcena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxOcena.Text != "")
                e.Handled = true;
            else if (!char.IsDigit(e.KeyChar) && !char.Equals(e.KeyChar, (char)Keys.Back))
                e.Handled = true;
            else
            {
                if (e.KeyChar > '5')
                { textBoxOcena.Text = "5"; e.Handled = true; }
                else if(e.KeyChar < '0')
                { textBoxOcena.Text = "5"; e.Handled = true; }
            }
        }

        private void buttonKupi_Click(object sender, EventArgs e)
        {
            int[] obelezeni = new int[6];
            int k = 0;
            user.mojiFilmovi = new Film();
            for (int i = 0; i < projekcija.getSala.Redovi; i++)
                for (int j = 0; j < projekcija.getSala.Kolone; j++)
                { if (tableLayoutPanel1.GetControlFromPosition(i, j).BackColor == Color.Red)
                    {
                        obelezeni[k] = int.Parse(((Button)tableLayoutPanel1.GetControlFromPosition(i, j)).Text);
                        k++;
                        tableLayoutPanel1.GetControlFromPosition(i, j).Enabled = false;
                    }
                }
            for(int i =0; i < admin.listaKarti.Count;i++)
            {
                if (admin.listaKarti[i].Cena == (int)comboBoxCena.SelectedItem &&  obelezeni.Contains(admin.listaKarti[i].sediste))
                {
                    user.mojeKarte.Add(admin.listaKarti[i]);
                } 
            }
            foreach (int x in obelezeni)
                projekcija.kupljenaMesta.Add(x);
            BtnCheck();
            NadjiPopunjena();
            Invalidate();
        }

        private void buttonOceni_Click(object sender, EventArgs e)
        {
            projekcija.getFilm.brojOcenjivanja++;
            projekcija.getFilm.ukupnaOcena = projekcija.getFilm.ukupnaOcena + int.Parse(textBoxOcena.Text);
            projekcija.getFilm.setOcena((double)projekcija.getFilm.ukupnaOcena / (double)projekcija.getFilm.brojOcenjivanja*1.0);
            user.mojiFilmovi.ocenjen = true;
            BtnCheck();
        }

        private void RezervacijaKarata_Paint(object sender, PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            Pen bluePen = new Pen(Color.Blue, 10);
            Rectangle rekt = new Rectangle(panelFull.Location.X, panelFull.Location.Y, panelFull.Width*popunjenaMesta/projekcija.getSala.BrojMesta, panelFull.Height);
            dc.DrawRectangle(bluePen, rekt);
        }

        private void NadjiPopunjena()
        {
            popunjenaMesta = 0;
            for (int i = 0; i < projekcija.getSala.Redovi; i++)
                for (int j = 0; j < projekcija.getSala.Kolone; j++)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(i, j).Enabled == false) popunjenaMesta++;
                }
            labelPuno.Text = "Popunjeno  " + popunjenaMesta * 1.0 / projekcija.getSala.BrojMesta * 100.0 + "% sale";
        }
    }
}
