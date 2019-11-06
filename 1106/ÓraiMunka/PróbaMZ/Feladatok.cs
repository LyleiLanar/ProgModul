using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PróbaMZ
{
    class Feladatok
    {
        //emberek száma
        static public void f1(List<Ember> emberek)
        {
            int db = 0;

            foreach (Ember e in emberek)
            {
                db++;
            }

            Console.WriteLine($"Összesen {db} ember van.");
            Console.WriteLine();
        }

        //hány bp-i van        
        static public void f2(List<Ember> emberek)
        {
            int db = 0;

            foreach (Ember item in emberek)
            {
                if (item.telepules == "Bp")
                {
                    db++;
                }
            }

            Console.WriteLine($"Összesen {db} budapesti van a listában.");
            Console.WriteLine();
        }

        //bi-i házasok száma
        static public void f3(List<Ember> emberek)
        {
            int db = 0;

            foreach (Ember item in emberek)
            {
                if (item.hazas == Ember.csAllapot.igen && item.telepules == "Bp")
                {
                    db++;
                }
            }

            Console.WriteLine($"Összesen {db} budapesti házas van a listában.");
            Console.WriteLine();
        }

        //átlag életkor
        static public void f4(List<Ember> emberek)
        {
            int szum = 0;
            int darab = 0;

            foreach (Ember item in emberek)
            {
                szum += item.kor;
                darab++;
            }

            Console.WriteLine($"Az emberek átlag kora {(double)szum / darab:n2}");
            Console.WriteLine();

        }

        //legfiatalabb házas neve
        static public void f5(List<Ember> emberek)
        {
            int minIndex;
            int index = 0;
            int length = emberek.Count;
            while (index < length && !(emberek[index].hazas == Ember.csAllapot.igen))
            {
                index++;
            }

            if (index < length)
            {
                minIndex = index;

                for (int i = minIndex + 1; i < emberek.Count; i++)
                {
                    if (emberek[minIndex].kor > emberek[i].kor)
                    {
                        minIndex = i;
                    }
                }
                Console.WriteLine($"A legfiatalabb házas neve {emberek[minIndex].nev}.");
            }
            else
            {
                Console.WriteLine("Nincs házas az emberek között!");
            }

            Console.WriteLine();
        }

        //Mindenki házas-e
        static public void f6(List<Ember> emberek)
        {
            int index = 0;
            while (index < emberek.Count && emberek[index].hazas == Ember.csAllapot.igen)
            {
                index++;
            }

            string megoldas = (index < emberek.Count ? "Nem m" : "M");
            Console.WriteLine($"{megoldas}indenki házas");
            Console.WriteLine();
        }

        //Mindnen bpi házas 20 feletti?
        static public void f7(List<Ember> emberek)
        {
            HashSet<int> korok = new HashSet<int>();

            foreach (Ember item in emberek)
            {
                if (item.hazas == Ember.csAllapot.igen && item.telepules == "Bp")
                {
                    korok.Add(item.kor);
                }
            }

            bool minden = true;
            foreach (int item in korok)
            {
                if (item < 20)
                {
                    minden = false;
                }
            }

            Console.WriteLine(minden ? "Minden bpi házas 20 év feletti!" : "Nem minden bpi házas 20 év feletti!");
            Console.WriteLine();

        }

        //Van 25 év feletti NEM házas
        static public void f8(List<Ember> emberek)
        {
            int index = 0;

            while (index < emberek.Count && !(emberek[index].hazas == Ember.csAllapot.nem && emberek[index].kor > 25))
            {
                index++;
            }

            string megoldas = index < emberek.Count ? "Van" : "Nincs";

            Console.WriteLine($"{megoldas} 25 év feletti NEM házas");
            Console.WriteLine();

        }

        //Keresés
        static public void f9(List<Ember> emberek)
        {
            string nev;
            bool ujra = true;

            //minimum 3 karakter
            do
            {
                Console.Write("Adj meg egy nevet pls. (min 3 karakter!):");
                nev = Console.ReadLine();

                if (nev.Length >= 3)
                {
                    ujra = false;
                }
                else
                {
                    Console.WriteLine("Nem elég hosszú a név!");
                }

            } while (ujra);

            int utolsoI = -1;

            for (int i = 0; i < emberek.Count; i++)
            {
                if (emberek[i].nev == nev)
                {
                    utolsoI = i;
                }
            }

            if (utolsoI == -1)
            {
                Console.WriteLine("Nincs találat!");
            }
            else
            {
                Console.WriteLine(emberek[utolsoI]);
                ToTextFile(emberek[utolsoI]);
            }
            Console.WriteLine();
        }

        //lakcímek listája
        public static void f10(List<Ember> emberek)
        {
            HashSet<string> cimek = new HashSet<string>();

            foreach (Ember item in emberek)
            {
                cimek.Add(item.telepules);
            }

            StringBuilder sb = new StringBuilder();

            foreach (string item in cimek)
            {
                sb.Append(item);
                sb.Append(" ");
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Replace(" ", ", ", 0, sb.Length - 1);

            Console.WriteLine($"A városok listája: {sb}.");
            Console.WriteLine();
        }

        //hány féle név kezdőbetű van
        public static void f11(List<Ember> emberek)
        {
            HashSet<char> kezdoBetuk = new HashSet<char>();

            foreach (Ember item in emberek)
            {
                kezdoBetuk.Add(item.nev[0]);
            }

            Console.WriteLine($"Összesen {kezdoBetuk.Count} féle kezdőbetű van.");
            Console.WriteLine();

        }

        //melyik címen hányan laknak
        public static void f12(List<Ember> emberek)
        {
            Dictionary<string, int> lakosokSzáma = new Dictionary<string, int>();

            foreach (Ember item in emberek)
            {
                if (!lakosokSzáma.ContainsKey(item.telepules))
                {
                    lakosokSzáma.Add(item.telepules, 1);
                }
                else
                {
                    lakosokSzáma[item.telepules]++;
                }
            }

            Console.WriteLine("Adott településen hány lakos van:");
            foreach (string item in lakosokSzáma.Keys)
            {
                Console.WriteLine($"{item}: {lakosokSzáma[item]}");
            }
            Console.WriteLine();
        }

        //adott (név) kezdőbetűihez hány ember tartozik
        public static void f13(List<Ember> emberek)
        {
            Dictionary<char, int> emberekAzonosKezdobetukkel = new Dictionary<char, int>();

            foreach (Ember item in emberek)
            {
                if (!emberekAzonosKezdobetukkel.ContainsKey(item.nev[0]))
                {
                    emberekAzonosKezdobetukkel.Add(item.nev[0], 1);
                }
                else
                {
                    emberekAzonosKezdobetukkel[item.nev[0]]++;
                }
            }

            Console.WriteLine("Adott név kezdőbetűvel hány lakos van:");
            foreach (char item in emberekAzonosKezdobetukkel.Keys)
            {
                Console.WriteLine($"{item}: {emberekAzonosKezdobetukkel[item]}");
            }
            Console.WriteLine();
        }

        static public void ToTextFile(Ember ember)
        {
            File.WriteAllText("output.txt", ember.ToString());
        }

        //Ez a metódus felel a beolvasásért
        public static List<Ember> Read(string path)
        {
            List<Ember> emberek = new List<Ember>();
            string[] inputStrings = File.ReadAllLines(path, Encoding.UTF8);

            for (int i = 2; i < inputStrings.Length; i++)
            {
                emberek.Add(new Ember(inputStrings[i]));
            }

            return emberek;
        }


    }
}
