using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PrviProjekatGit
{
    public class User
    {
        public string username;
        public int brojKarata;
        public Film mojiFilmovi;
        public List<Karta> mojeKarte;

        public User()
        {
            brojKarata = 0;
            username = "";
            mojiFilmovi = new Film();
            mojeKarte = new List<Karta>();
        }

        public void Sacuvaj()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite("user.txt");
            bf.Serialize(fs, this);
            fs.Dispose();
            fs.Close();
        }
    }
}
