using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HengerekProject
{
    class LyukasHenger:TomorHenger
    {
        public double Falvastagsag { get;  }

        public LyukasHenger(double sugar, double magassag, double fajsuly, double falvastagsag): base(sugar, magassag, fajsuly)
        {
            Falvastagsag = falvastagsag;
        }

        public LyukasHenger(double sugar, double magassag, double falvastagsag) : this(sugar, magassag, 1, falvastagsag)
        {
            ;
        }

        public override double Terfogat()
        {
            //not implemented
            return base.Terfogat();
        }

    }

}
