using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotesek
{
    class B:A
    {
        public int Bvalue { get; set; }

        /*Static konstruktor, ez felül fogja csapni az A osztály statikus adattagját, de csak akkor, amikor szükésés lesz rá. Ez 
         * futási időben fog majd valamikor megtörténni.
         * Ezzel vigyázni kell, mert a kódban komoly hibákat okozhat.
         */
        static B()
        {
            Console.WriteLine("B Statikus konstruktor meghívása.");
            common = 2;
        }
        //paraméteres konstruktora a B osztálynak, ami az ősosztály paraméteres konstruktorát hívja
        public B(int bvalue,int avalue):base(avalue)
        {
            Console.WriteLine("B, parameteres konstruktor");
            Bvalue = bvalue;
        }

        //paraméter nélküli konstruktor, ami az ősosztály paraméter NÉLKÜLI konstruktorát fogja hívni. (ami persze majd a saját paraméteresét)
        public B()
        {
            Console.WriteLine("B, parameter NÉLKÜLI konstruktor");
            Bvalue = 0;
        }

        //az eredeti metódus elfedése történik
        new public int GetValueKorai()
        {
            return AValue + Bvalue;
        }

        // az eredeti metódus felülírása történik
        public override int GetValueKesoi()
        {
            return AValue + Bvalue;
        }
    }
}
