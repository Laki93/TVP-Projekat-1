using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviProjekatGit
{
    [Serializable]
    public class Sala
    {
        public static int brojac = 0;
        private int id;
        private string naziv;
        private int brojMesta;
        private int brojRedova;
        private int brojKolona;

        public Sala()
        {
            id = ++brojac;
            naziv = "";
            brojMesta =brojRedova=brojKolona= 0;
        }

        public Sala(string _naziv,int redova,int kolona)
        {
            id = ++brojac;
            naziv = _naziv;
            brojRedova = redova;
            brojKolona = kolona;
            brojMesta = redova * kolona;
        }

        public string Naziv { get { return naziv; } }
        public int ID { get { return id; } }
        public int BrojMesta { get { return brojMesta; } }
        public int Redovi { get { return brojRedova; } }
        public int Kolone { get { return brojKolona; } }

        public override string ToString()
        {
            return "ID:"+id + " | Naziv:" + naziv + " | Broj mesta:" + BrojMesta;
        }
    }
   
}
