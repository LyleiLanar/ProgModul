using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcStats
{
    class SorozatGenerator
    {
        static Random rnd = new Random();

        public static List<int> UjSorozat(int elemszam, int kezdoErtek, int vegErtek)
        {
            List<int> szamok = new List<int>();

            for (int i = 0; i < elemszam-1; i++)
            {
                szamok.Add(rnd.Next(kezdoErtek,vegErtek));
            }

            return szamok;
        }
    }
}
