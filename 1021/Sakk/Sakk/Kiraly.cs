using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakk
{
    class Kiraly : Babu
    {
        public Kiraly(Babu.Szin szin) : base(szin, 'K') { }

        public override bool Lepes(Koord honnan, Koord hova)
        {
            if (!(honnan.GetSor()<0 || honnan.GetOszlop()<0||hova.GetSor()<0 || hova.GetOszlop()<0))
            {
                return true;                
            }

            //szabály
            return false;
        }
    }
}
