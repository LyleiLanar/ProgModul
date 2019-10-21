using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakk
{
    class Tabla
    {
        private Babu[,] tabla;
        private const int MEZO=8;

        public Tabla()
        {
            tabla = new Babu[MEZO, MEZO];

            /*
            tabla = new Babu[MEZO][];
            for (int i = 0; i < MEZO; i++)
            {
                tabla[i] = new Babu[MEZO];
            }
           */
        }

        public void Lerak(Babu babu, Koord koord)
        {
            //ellenőrzés!!!    
            tabla[koord.GetSor(), koord.GetOszlop()]= babu;
        }

        public void Megjelenit()
        {
            for (int i = 0; i < MEZO; i++)
            {
                for (int j = 0; j < MEZO; j++)
                {
                    Console.BackgroundColor = ((i + j) % 2 == 0) ? ConsoleColor.DarkGray : ConsoleColor.Black;
                    if (tabla[i, j] != null)
                    {
                        tabla[i, j].Megjelenit();
                        Console.Write(" ");
                    }
                    else
                    {                       
                        Console.Write("  ");                       
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine();
            }
        }
        public void Mozgat(Koord honnan, Koord hova)
        {
            //U+2654
            Console.WriteLine("\u2654");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\u03C0");
            int sor = honnan.GetSor();
            int oszlop = honnan.GetOszlop();            

            if (tabla[sor,oszlop].Lepes(honnan,hova))
            {
                tabla[hova.GetSor(), hova.GetOszlop()] = tabla[honnan.GetSor(), honnan.GetOszlop()];
                tabla[honnan.GetSor(), honnan.GetOszlop()] = null;
            }
            else
            {
                Console.WriteLine("Nem lehetségés a lépés!");
            }            
        }
    }
}
