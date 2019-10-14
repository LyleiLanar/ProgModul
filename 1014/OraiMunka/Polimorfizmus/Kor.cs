using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizmus
{
    class Kor: Alakzat
    {
        private double r;

        public Kor(double r)
        {
            this.r = r;
        }

        public void SetR(double r)
        {
            this.r = r;
        }
        public override void Kiir()
        {
            Console.WriteLine($"Kör(T:{this.Terulet()})");
        }
        public override double Terulet()
        {
            return r * r * Math.PI;
        }
        

    }
}
