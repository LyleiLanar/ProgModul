using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGenerator2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] joSzamok = new int[5];

            Random rnd = new Random();

            int joSzamokDb = 0;
            do
            {
                int szam = rnd.Next(1, 91);

                //eldöntés
                int i = 0;
                while (i < joSzamokDb && !(joSzamok[i] == szam))
                {
                    i++;
                }

                if (i >= joSzamokDb)
                {
                    joSzamok[joSzamokDb] = szam;
                    joSzamokDb++;
                }

            } while (joSzamokDb < 5);



            Console.ReadLine();
        }
    }
}
