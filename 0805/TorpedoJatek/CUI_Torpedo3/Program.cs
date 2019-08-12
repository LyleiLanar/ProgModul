using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUI_Torpedo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hajo = { 4, 5, 6 };//ezt kell véletlen generálni...
            int hajoHossza = hajo.Length;
            const int PALYAHOSSZ = 7;
            
            char[] palya = new char[PALYAHOSSZ + 1];
            int[] sorszam = new int[PALYAHOSSZ + 1];
            for (int i = 1; i <= PALYAHOSSZ; i++)
            {
                palya[i] = '_';
                sorszam[i] = i;
            }

            int talalat = 0;
            do
            {
                int i;
                //pályát kiír
                for (i = 1; i <= PALYAHOSSZ; i++)
                {
                    Console.Write(palya[i] + " ");
                }
                Console.WriteLine();
                for (i = 1; i <= PALYAHOSSZ; i++)
                {
                    Console.Write(sorszam[i] + " ");
                }
                Console.WriteLine();
                //pályát kiír vége

                //tippet bekér
                Console.Write("tipp: ");
                int tipp;
                int.TryParse(Console.ReadLine(), out tipp);

                if (!(tipp > 0 && tipp <= PALYAHOSSZ))
                {
                    Console.WriteLine("Érvénytelen!");
                    continue;//itt lehetne ellenőrzött adatbekérés: do/while
                }
                //tippet bekér vége

                //eldöntés
                i = 0;
                while (i < hajoHossza && !(tipp == hajo[i])) { i++; }

                if (i < hajoHossza)
                {
                    if (palya[hajo[i]] == '_' || palya[hajo[i]] == '~')
                    {
                        talalat++;
                        palya[hajo[i]] = 'X';
                        Console.WriteLine($"Talált! ({hajoHossza}/{talalat})");
                    }
                    else
                    {
                        Console.WriteLine("Ez már volt!");
                    }
                }
                else
                {
                    Console.WriteLine("Nem talált!");
                    palya[tipp] = '~';
                }

            } while (talalat < hajoHossza);

            Console.WriteLine("A hajó elsüllyedt!");
            
            Console.ReadLine();
        }
    }
}
