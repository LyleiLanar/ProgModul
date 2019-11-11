using System;
using System.IO;

namespace Mozi
{
    static class Feladatok
    {
        static Terem mozi;

        static Feladatok()
        {
            string input = File.ReadAllText("eladasok.txt");
            mozi = new Terem(input);
        }


        //1. feladat sorok száma, valamint a leghosszabb sor mérete.
        public static void f1()
        {
            int db = 0;
            int maxIndex = 0;

            for (int i = 0; i < mozi.Helyek.Length; i++)
            {
                db++;
            }

            for (int i = 1; i < mozi.Helyek.Length; i++)
            {
                if (mozi.Helyek[i].Length > mozi.Helyek[maxIndex].Length)
                {
                    maxIndex = i;
                }
            }

            System.Console.WriteLine($"Összesen {db} sor van. A leghosszabb a {maxIndex + 1}. sor.");

        }

        //bekérünk egy sorszámot, de az csak annyi lehet ami jó 
        //üres-e vagy van-e benne szabad hely
        //egy kategórián belül egymás mellett van-e 3 egyforma üres hely

        //üres-e a sor
        public static void f2()
        {
            bool helyes = false;
            int sor;

            do
            {
                System.Console.Write("Kérlek add meg a sor számát: ");
                sor = int.Parse(Console.ReadLine());

                if (sor < mozi.Helyek.Length && sor > 0)
                {
                    helyes = true;
                }

            } while (!helyes);

            int szek = 0;
            while (szek < mozi.Helyek[sor].Length && !mozi.Helyek[sor][szek].Foglalt)
            {

            }

        }
        public static void Kirajzol()
        {
            Feladatok.mozi.Kirajzol();
        }




    }
}
