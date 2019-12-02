using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosodApp
{
    class Ing : Ruha
    {
        public double SzinSat { get; private set; }

        public Ing(string tulaj, bool tiszta) : base(tulaj, tiszta)
        {
            this.SzinSat = 100;
        }

        public override void Kimosva()
        {
            base.Kimosva();
            this.SzinSat *= 0.97;
        }
        public override string ToString()
        {
            string s = (Tiszta ? "Tiszta" : "Koszos");
            return $"<Ing: {Tulaj}|{s}|{SzinSat}>";
        }

    }
}
