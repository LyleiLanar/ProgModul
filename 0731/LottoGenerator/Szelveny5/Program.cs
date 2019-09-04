using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szelveny5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MEZODB = 35;
            const int NYERODB = 7;

            //szelvény legenerálása
            bool[] szamok = new bool[MEZODB + 1];//0..90 között indexelhető
            Random rnd = new Random();
            int joDb = 0;
            while (joDb < NYERODB)
            {
                int szam = rnd.Next(1, MEZODB + 1);//1..90 között vél.szám 
                if (!szamok[szam])
                {
                    szamok[szam] = true;
                    joDb++;
                }
            }


            //számok kiírása
            for (int i = 0; i < MEZODB + 1; i++)
            {
                if (szamok[i])
                {
                    Console.Write($"{i} "); 
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
