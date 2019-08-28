using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyugtaModern
{
    class Program
    {
        static int HOSSZ;
        static void Main(string[] args)
        {
            string[] tetelek = { "kutya", "macska", "görény", "medvedisznó-ember" };
            int[] arak = { 2000, 2040, 2500, 5400 };
            
            for (int i = 0; i < tetelek.Length; i++)
            {
                int aktHossz = tetelek[i].Length + arak[i].ToString().Length+6;
                if (aktHossz>HOSSZ)
                {
                    HOSSZ = aktHossz;
                }                
            }
            Console.WriteLine(HOSSZ);
            Vonal(HOSSZ, '*');
            SzovegTeljesenKozepre("NYUGTA");
            SzovegJobbraKozepre("Aláírás");
            

            Vonal(HOSSZ,'*');
            Vonal(HOSSZ / 2, '_', false);
        }

        private static void Vonal(int hossz, char jel,bool balra = false)
        {
            if (!balra)
            {
                for (int i = 0; i < HOSSZ - hossz; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < hossz; i++)
                {
                    Console.Write(jel);
                }
            }
            Console.WriteLine();
            
        }

        private static void SzovegTeljesenKozepre(string szoveg)
        {
            int spaceSzamok = HOSSZ / 2 - szoveg.Length / 2;

            for (int i = 0; i < spaceSzamok; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(szoveg);
        }

        private static void SzovegJobbraKozepre(string szoveg)
        {
            int spaceSzamok = HOSSZ/4 - szoveg.Length / 2;
            
            for (int i = 0; i < spaceSzamok; i++)
            {
                szoveg += " ";
            }
            Console.WriteLine($"{szoveg,-0}");
        }
    }
}
