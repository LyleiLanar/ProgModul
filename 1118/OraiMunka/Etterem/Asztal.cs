using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
    class Asztal
    {        

        public string Szin { get;  }
        public Dictionary<Etel,int> Etelek { get; }       

        public Asztal(string input)
        {
            this.Szin = input;
            this.Etelek = new Dictionary<Etel, int>();
        }

        public void Kiir()
        {
            foreach (KeyValuePair<Etel, int> item in Etelek)
            {
                string nev = item.Key.Nev + ": ";
                string ar = item.Key.Ar.ToString() + " Ft";
                string db = item.Value+  "db";
                Console.WriteLine($"{nev,-17}{ar,8}{db,5}");             
            }
        }
        public int TeljesOsszeg()
        {
            int szum = 0;
            foreach (KeyValuePair<Etel, int> item in Etelek)
            {
                szum += (item.Key.Ar)*item.Value;
            }
            return szum;
        }

        public void UjEtel(Etel etel)
        {
            if (Etelek.ContainsKey(etel))
            {
                Etelek[etel]++;
            }
            else
            {
                Etelek.Add(etel,1);
            }
           // this.Etelek.Add(etel);
        }

        
    }
}
