using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
    class Etel
    {
        public string Nev { get; }
        public int Ar { get; }

        public Etel(string input)
        {
            string[] adat = input.Split('|');
            this.Nev = adat[0];
            this.Ar = int.Parse(adat[1]);
        }

        public Etel(string nev, int ar) : this($"{nev}|{ar}")
        {
            ;
        }
    }
}
