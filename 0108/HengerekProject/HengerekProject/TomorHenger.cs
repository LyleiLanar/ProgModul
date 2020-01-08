using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HengerekProject
{
    class TomorHenger: Henger
    {
        public double Fajsuly { get;  }
        public TomorHenger(double sugar, double magassag, double fajsuly):base(sugar,magassag)
        {
            this.Fajsuly = fajsuly;
        }
        public TomorHenger(double sugar, double magassag):this(sugar, magassag,1)
        {
            ;
        }

        public double Suly { get { return base.Terfogat() * this.Fajsuly; } }
    }
}
