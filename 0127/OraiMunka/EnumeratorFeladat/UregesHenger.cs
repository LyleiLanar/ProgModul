using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorFeladat
{
    class UregesHenger : TomorHenger
    {
        public TomorHenger Furat { get; private set; }

        public UregesHenger(double r, double h, double furatR) : base(r, h)
        {
            this.Furat = new TomorHenger(furatR, h);

        }

        public override double Terfogat()
        {
            return base.Terfogat() - this.Furat.Terfogat();

        }

        public override string ToString()
        {
        String s = base.ToString();
            s += $"fajsúly: {this.Fajsuly} tömeg: {this.Tomeg()}";

            return s;
            
        }
    }
}
