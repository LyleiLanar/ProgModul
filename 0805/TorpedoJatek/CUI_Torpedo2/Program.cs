using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUI_Torpedo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hajo = { 2, 3 };//ezt kell véletlen generálni...
            int hajoHossza = hajo.Length;
            const int PALYAHOSSZ = 12;
            bool[] talalatok = new bool[PALYAHOSSZ];
            int talalat = 0;
            do
            {
                Console.Write("tipp: ");
                int tipp;
                int.TryParse(Console.ReadLine(), out tipp);
                
                if(tipp > PALYAHOSSZ)
                {
                    Console.WriteLine("Érvénytelen!");
                    continue;
                }

                //eldöntés
                int i = 0;
                while(i < hajoHossza && !(tipp == hajo[i])) { i++; }
                if(i < hajoHossza)
                {
                    if (!talalatok[i])
                    {
                        talalat++;
                        talalatok[i] = true;
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
                }
            } while (talalat < hajoHossza);
            Console.WriteLine("A hajó elsüllyedt!");

            Console.ReadLine();
        }
    }
}
