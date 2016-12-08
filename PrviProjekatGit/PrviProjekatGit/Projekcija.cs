using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviProjekatGit
{
    [Serializable]
    class Projekcija
    {
        public static int brojac = 0;
        private int id;
        private Film film;
        private Sala sala;
        private DateTime vreme;

        Projekcija()
        {
            id = ++brojac;
            film = new Film();
            sala = new Sala();
            vreme = new DateTime();            
        }

        public Film getFilm { get { return film; } }
        public int ID { get { return id; } }
        public DateTime Vreme { get { return vreme; } }
        public Sala getSala { get { return sala; } }

        public override string ToString()
        {
            return id + " | " + film.Naziv + " | " + sala.Naziv + " | " + vreme.ToString();
        }
    }

    
}
