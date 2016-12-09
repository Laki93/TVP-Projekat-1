using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviProjekatGit
{
    [Serializable]
    public class Projekcija
    {
        public static int brojac = 0;
        private int id;
        private Film film;
        private Sala sala;
        private DateTime vreme;
        public List<int> kupljenaMesta;

        public Projekcija()
        {
            id = ++brojac;
            film = new Film();
            sala = new Sala();
            vreme = new DateTime();
            kupljenaMesta = new List<int>();
          
            

        }

        public Projekcija(Film _film, Sala _sala, DateTime _vreme)
        {
            id = ++brojac;
            film = _film;
            sala = _sala;
            vreme = _vreme;
            kupljenaMesta = new List<int>();
            
             
        }

        public Film getFilm { get { return film; } }
        public int ID { get { return id; } }
        public DateTime Vreme { get { return vreme; } }
        public Sala getSala { get { return sala; } }

        public override string ToString()
        {
            return "ID:"+id + " | Naziv filma:" + film.Naziv + " | Naziv sale:" + sala.Naziv + " | Vreme:" + vreme.Day+"."+vreme.Month+"."+vreme.Year+". / "+vreme.Hour+":"+vreme.Minute;
        }
    }

    
}
