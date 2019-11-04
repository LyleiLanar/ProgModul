using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKJGyakorlat
{
    class Hegy
    {
        public string Nev { get;  }
        public string Hegyseg { get;  }
        public int Magssag { get;  }
        public string Megjegyzes { get; }

        public Hegy(string input)
        {
            string[] data = input.Split(';');
            this.Nev = data[1];
            this.Hegyseg = data[2];
            this.Magssag = int.Parse(data[3]);
            string megj = data[4];
            if (megj == "")
            {
                this.Megjegyzes = "Nincs megjegyzés!";
            }
            else
            {
                this.Megjegyzes = megj;
            }     
            

        }

        public Hegy(string nev, string hegyseg, int magssag, string megjegyzes) :this($"-1;{nev};{hegyseg};{magssag};{megjegyzes}")
        {
            ;
        }

        public Hegy(string nev, string hegyseg, int magssag) :this($"-1;{nev};{hegyseg};{magssag};{""}")
        {
            ;
        }

        public override string ToString()
        {
            return $"<{Nev},{Hegyseg},{Magssag},{Megjegyzes}>";
        }

    }
}
