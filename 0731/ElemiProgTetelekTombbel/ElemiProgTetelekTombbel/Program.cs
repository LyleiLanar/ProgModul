using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElemiProgTetelekTombbel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = { 12, 25, 45, 20, 358, 12 };
            int length = szamok.Length;
            //a kiválasztáshoz biztosan legyen páratlan 2jegyű:
            int paratlan2Jegyu = new Random().Next(45)*2+11;
            szamok[length - 1] = paratlan2Jegyu;//utolsó elem felülírása

            //tömb kiírása:
            for (int i = 0; i < length; i++){ Console.Write($"{szamok[i]} "); }
            Console.WriteLine();

            //összegzés:
            int osszeg = 0;
            for (int i = 0; i < length; i++)
            {
                osszeg += szamok[i];
            }
            Console.WriteLine($"tömb összege: {osszeg}");

            //megszámlálás: 2jegyű, 5-re vegződő:
            int db = 0;
            for (int i = 0; i < length; i++)
            {
                bool jegy2 = szamok[i] > 9 && szamok[i] < 100;
                bool vege5 = szamok[i] % 5 == 0 && szamok[i] % 10 != 0;
                if ( jegy2 && vege5)
                {
                    db++;
                }
            }
            Console.WriteLine($"2jegyű, 5-re vegződő: {db}darab");

            //szélsőérték: az 1. max és az UTOLSÓ min értékek:
            int minInd = 0, maxInd = 0;
            for (int aktInd = 1; aktInd < length; aktInd++)
            {
                //1. max
                if (szamok[aktInd] > szamok[maxInd])
                {
                    maxInd = aktInd;
                }
                //UTOLSÓ min
                if (szamok[aktInd] <= szamok[minInd])
                {
                    minInd = aktInd;
                }
            }
            Console.WriteLine($"minimum:[{minInd}]={szamok[minInd]}\nmaximum:[{maxInd}]={szamok[maxInd]}");

            //kiválasztás: az 1. páratlan
            int ind = 0;
            while (!(szamok[ind] % 2 == 1))
            {
                ind++;
            }
            Console.WriteLine($"az 1. páratlan:[{ind}]={szamok[ind]}");

            //eldöntés: van e 50-nél nagyobb
            ind = 0;
            while(ind < length && !(szamok[ind] > 50))
            {
                ind++;
            }
            bool van = ind < length | ind >= length;

            //eldöntés: mindenki 50-nél kisebb


            //adjuk meg, ha van benne tökéletes szám

            Console.ReadLine();
        }
    }
}
