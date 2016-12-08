using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrviProjekatGit
{
    [Serializable]
    class Admin
    {
        public List<Film> listaFilmova;
        public List<Sala> listaSala;
        public List<Karta> listaKarti;
        public List<Projekcija> listaProjekcija;

        public Admin()
        {
            listaProjekcija = new List<Projekcija>();
            listaFilmova = new List<Film>();
            listaKarti = new List<Karta>();
            listaSala = new List<Sala>();
            
          
        }

        public void Sacuvaj()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite("admin.txt");
            bf.Serialize(fs, this);
            fs.Dispose();
            fs.Close();
        }


    }
}
