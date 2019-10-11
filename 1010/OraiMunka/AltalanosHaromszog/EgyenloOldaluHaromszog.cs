using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltalanosHaromszog
{
    class EgyenloOldaluHaromszog:EgyenloSzaruHaromszog
    {
        private int oldal;

        public EgyenloOldaluHaromszog(int oldal): base(oldal,oldal)
        {

            this.Oldal = this.A;
        }

        public double Oldal { get; }

        public override string ToString()
        {
            return $"({this.A})|K:{this.Kerulet}|T:{this.Terulet:N4})";
        }
    }
}
