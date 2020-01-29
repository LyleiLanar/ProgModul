using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorFeladat
{
    abstract class MertaniHenger: IComparable<MertaniHenger>
    {        

        public abstract double Terfogat();

        public abstract double Fajsuly { get;  }

        public  double Tomeg()
        {
            return this.Terfogat() * this.Fajsuly;
        }

        public override string ToString()
        {
            return $"Henger: ";
        }

        int IComparable<MertaniHenger>.CompareTo(MertaniHenger other)
        {
            return this.Tomeg().CompareTo(other.Tomeg());
        }
    }
}
