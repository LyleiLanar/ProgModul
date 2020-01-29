using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorFeladat
{
    class TomorHenger : MertaniHenger
    {
        public double R1 { get; private set; }
        public double H { get; private set; }

        public TomorHenger(double r, double h)
        {
            this.R1 = r;
            this.H = h;
            Fajsuly = 0.8;
        }

        public override double Fajsuly { get; }
        
        public override double Terfogat()
        {
            return R1 * R1 * Math.PI * H;
        }
        public override string ToString()
        {
            
            String s =  base.ToString();
            s += $"fajsúly: {this.Fajsuly} tömeg{this.Tomeg()}";

            return s;

        }
    }
}
