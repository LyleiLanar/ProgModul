using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakk
{
    class Koord
    {
        private int sor, oszlop;

        public Koord(int sor, int oszlop)
        {
            this.sor = sor;
            this.oszlop = oszlop;
        }

        public int GetSor() { return this.sor; }
        public int GetOszlop() { return this.oszlop; }
        public void SetSor(int x)
        {
            if (x<0)
            {
                throw new Exception("Pont x koord, kisebb mint 0!");
            }
            this.sor = x;
        }
        public void SetOszlop(int y)
        {
            if (y < 0)
            {
                throw new Exception("Pont y koord, kisebb mint 0!");
            }
            this.oszlop = y;
        }

    }
}
