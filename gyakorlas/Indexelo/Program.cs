using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexelo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ő egy nem indexelős horgász
            Horgasz jani = new Horgasz();

            jani.ZsakbaRak(new Hal(10));
            jani.ZsakbaRak(new Hal(3.3));
            jani.ZsakbaRak(new Hal(2));

            // ő pedig egy indexelős horgász

            HorgaszIndexelos pali = new HorgaszIndexelos();

            pali.ZsakbaRak(new Hal(20));
            pali.ZsakbaRak(new Hal(3.34));

            Console.WriteLine("Nulladink elem a csere előtt: ");
            Console.WriteLine(jani.Zsak_eleme(0).Suly);
            Console.WriteLine(pali[0].Suly);
            Console.WriteLine();

            Console.WriteLine("Nullladik elem a csere után: ");            
            jani.CsereHal(0, new Hal(1));
            pali[0] = new Hal(2);
            Console.WriteLine(jani.Zsak_eleme(0).Suly);
            Console.WriteLine(pali[0].Suly);
            Console.WriteLine();






            Console.ReadLine();
        }
    }
}
