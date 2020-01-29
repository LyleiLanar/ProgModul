using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAlakzatokkal
{
    class Program
    {
        static void Main(string[] args)
        {
            Alakzat[] alakzatok = new Alakzat[4];

            alakzatok[0] = new Sokszog("Sokszog");
            alakzatok[1] = new Haromszog("Haromszog");
            alakzatok[2] = new Kor("Kor");
            alakzatok[3] = new Kor3D("Kor");

            Console.WriteLine("Alakzatok: ");
            foreach (Alakzat item in alakzatok)
            {
                Console.WriteLine(item);
            }

            foreach (Object item in alakzatok)
            {
                IPontjaiVannak itfP = item as IPontjaiVannak;
                if (itfP != null) { Console.WriteLine(itfP.Pontok()); }
                else { Console.WriteLine("Nincsenek neki pontjai!"); }
            }
           
            Console.ReadLine();
        }
    }
}
