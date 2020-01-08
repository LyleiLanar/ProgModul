using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HengerekProject
{
    class Henger
    {

        static public int HengerDarab { get; private set; }
        public double Sugar { get; }
        public double Magassag { get; }

        static Henger()
        {
            HengerDarab=0;    
        }

        public Henger(double sugar, double magassag)
        {
            this.Magassag = magassag;
            this.Sugar = sugar;
            Henger.HengerDarab++;
        }

        public virtual double Terfogat()
        {
            return this.Sugar * this.Sugar * Math.PI * this.Magassag;
        }

        public override string ToString()
        {
            return $"<Sugar: {this.Sugar}, Magassag: {this.Magassag}, Térfogat: {this.Terfogat()}>";
        }

    }
}
