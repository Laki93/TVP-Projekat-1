using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviProjekatGit
{
    [Serializable]
    public class Karta
    {
        public static int brojac = 0;
        private int id;
        private int cena;
        private Film film;
        private Sala sala;
        public int sediste;

        public Karta()
        {
            id = ++brojac;
            film = new Film();
            sala = new Sala();
            sediste = 0;
            cena = 0;
        }

        public Karta(Film _film,Sala _sala,int _sediste,int _cena)
        {
            id = ++brojac;
            film = _film;
            sala = _sala;
            sediste = _sediste;
            cena = _cena;
        }
        public Film getFilm { get { return film; } }
        public int ID { get { return id; } }
        public int Sediste { get { return Sediste; } }
        public Sala getSala { get { return sala; } }
        public int Cena { get { return cena; } }

        public override string ToString()
        {
            return id + " | " + sediste + " | " + film.Naziv + " | " + sala.Naziv;
        }
    }
}
