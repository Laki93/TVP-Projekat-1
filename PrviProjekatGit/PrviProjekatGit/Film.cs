using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviProjekatGit
{
    [Serializable]
    public class Film 
    {
        public bool ocenjen;
        public static int brojac = 0;
        private int id;
        public int ukupnaOcena = 0;
        public int brojOcenjivanja = 0;
        private string naziv;
        private string zanr;
        private string opis;
        private double ocena;

        public Film()
        {
            id = ++brojac;
            naziv = zanr = opis = "";
            ocena = 0;
            ocenjen = false;
        }

        public Film(string _naziv,string _zanr,string _opis)
        {
            id = ++brojac;
            naziv = _naziv;
            zanr = _zanr;
            opis = _opis;
            ocena = 0;
            ocenjen = false;
        }

        public string Naziv { get { return naziv; } }
        public string Zanr { get { return zanr; } }
        public int ID { get { return id; } }
        public double Ocena { get { return ocena; } }
        public void setOcena(double x) { ocena = x; }
        public string Opis { get { return opis; } }

        public override string ToString()
        {
            return id+ " | "+naziv ;
        }

        public string Ispisi()
        {
            return "Naziv filma: " + naziv + "\r\n" + "Zanr filma: " + zanr + "\r\n" + "Opis filma: " + opis + "\r\n" + "Ocena filma: " + ocena;
        }

    }
}
