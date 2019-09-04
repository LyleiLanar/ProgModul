using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromAllapotuLampa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //HF megcsinálni, hogy színeket írjon ki!

            int kapcsolasokSzama = 0;
            const int ALLAPOTOK_SZAMA = 3;

            Console.WriteLine("Hányszor nyomva: {0}. Állapota: {1}", kapcsolasokSzama, kapcsolasokSzama % ALLAPOTOK_SZAMA);
            Console.WriteLine("Megynomjuk...");
            kapcsolasokSzama++;

            Console.WriteLine("Hányszor nyomva: {0}. Állapota: {1}", kapcsolasokSzama, kapcsolasokSzama % ALLAPOTOK_SZAMA);
            Console.WriteLine("Megynomjuk...");
            kapcsolasokSzama++;

            Console.WriteLine("Hányszor nyomva: {0}. Állapota: {1}", kapcsolasokSzama, kapcsolasokSzama % ALLAPOTOK_SZAMA);
            Console.WriteLine("Megynomjuk...");
            kapcsolasokSzama++;

            Console.WriteLine("Hányszor nyomva: {0}. Állapota: {1}", kapcsolasokSzama, kapcsolasokSzama % ALLAPOTOK_SZAMA);
            Console.WriteLine("Megynomjuk...");
            kapcsolasokSzama++;

        }
    }
}
