using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MZ
{
    class Elem
    {
        public int Ev { get;  }
        public string Nev { get; }
        public string Vegyjel { get; }
        public int Rendszam { get; }
        public string Felfedezo { get; }

        public Elem(string input)
        {            
            string[] adat = input.Split(';');

            this.Ev = int.Parse(adat[0]);
            this.Nev = adat[1];
            this.Vegyjel = adat[2];
            this.Rendszam = int.Parse(adat[3]);
            this.Felfedezo =adat[4];
        }

        public override string ToString()
        {
            return $"{this.Ev};{this.Nev};{this.Vegyjel};{this.Rendszam};{this.Felfedezo}";
        }



    }
}
