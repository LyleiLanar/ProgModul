using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorFeladat
{
    class HengerTarolo: IEnumerable<MertaniHenger>
    {
        public List<MertaniHenger> Hengerek { get; private set; }
        public HengerTarolo()
        {
            Hengerek = new List<MertaniHenger>();

        }

        public void AddNewHenger(MertaniHenger henger)
        {
            Hengerek.Add(henger);
        }

        public IEnumerator<MertaniHenger> GetEnumerator()
        {
            return ((IEnumerable<MertaniHenger>)Hengerek).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<MertaniHenger>)Hengerek).GetEnumerator();
        }


        /*Ezt meg kell majd próbálni ezt az interface dolgot, hogy tudjak minumot kiválasztani agy Enumerable-ből*/
        public double MinV()
        {
            return Hengerek.Min().Terfogat();
        }
    }
}
