using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakk
{
    class Vezer: Babu
    {
        public Vezer(Babu.Szin szin) : base(szin, 'V') { }

        public override bool Lepes(Koord honnan, Koord hova)
        {
            //szabaly
            return true;
        }

    }
}
