using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MZ
{
    static class Feladatok
    {
        static Elem[] elemek;
        static string path = "vegyjelek1.csv";

        static Feladatok()
        {
            string[] elemekInput = File.ReadAllLines(path, Encoding.Default);

            elemek = new Elem[elemekInput.Length - 1];
            //itt egytől indulunk, hogy a fejléc ne kerüljön bele az elemekbe.
            for (int i = 1; i < elemekInput.Length; i++)
            {
                elemek[i - 1] = new Elem(elemekInput[i]);
            }
        }

        static public void ElemekKiir()
        {
            foreach (Elem item in elemek)
            {
                Console.WriteLine(item);
            }
        }

        static public void FeladatokVegrahajtasa()
        {
            Feladatok.Feladat2();
            Feladatok.KovetkezoFeladat();
            
            Feladatok.Feladat3();
            Feladatok.KovetkezoFeladat();

            Feladatok.Feladat4();
            Feladatok.KovetkezoFeladat();

            Feladatok.Feladat5();
            Feladatok.KovetkezoFeladat();

            Feladatok.Feladat6();
            Feladatok.KovetkezoFeladat();

            Feladatok.Feladat7();
            Feladatok.KovetkezoFeladat();

            Feladatok.Feladat8();
            Feladatok.KovetkezoFeladat();

            Feladatok.Feladat9();
            Feladatok.KovetkezoFeladat();

            Feladatok.Feladat10();
            Feladatok.Vege();
        }

        private static void Vege()
        {
            Console.Clear();
            Console.WriteLine("Köszömöm, hogy megnézted a Modulzáró programomat!\r\n");
            Console.WriteLine("Üdv,\r\nMolnár Patrik");
        }

        private static void KovetkezoFeladat()
        {            
            Console.WriteLine();
            Console.WriteLine("Üss entert a következő feladathoz...");
            Console.ReadLine();
            Console.Clear();
        }

        static public void Feladat2()
        {
            int darab = 0;

            foreach (Elem item in elemek)
            {
                darab++;
            }
            Console.WriteLine("2. Hány kémiai elem felfedezési adatai találhatóak a fájlban?\r\n");
            Console.WriteLine($"Összesen: {darab} darab.");
        }
        static public void Feladat3()
        {
            int darab = 0;

            foreach (Elem item in elemek)
            {
                if (item.Ev < 1800)
                {
                    darab++;
                }

            }
            Console.WriteLine("3. Hány elemet fedeztek fel 1800 előtt?\r\n");
            Console.WriteLine($"Összesen: {darab} darab.");
        }
        static public void Feladat4()
        {
            string nev = "Titán";
            int index = 0;
            while (index < elemek.Length && !(elemek[index].Nev == nev))
            {
                index++;
            }

            string megoldas = (index < elemek.Length ? $"A {nev} elemet {elemek[index].Ev}. esztendőben fedezték fel." : "Nincs ilyen elem!");

            Console.WriteLine("4. Mikor fedezték fel a Titán elemet?\r\n");
            Console.WriteLine(megoldas);
        }        
        static public void Feladat5()
        {
            Console.WriteLine("5. Minden rendszám legalább kétjegyű?\r\n");

            int index = 0;
            while (index < elemek.Length && (elemek[index].Rendszam > 9 && elemek[index].Rendszam < 1000))
            {
                index++;
            }
            
            string megoldas = (index < elemek.Length ? "Nem, van olyan elem, aminek a rendszáma NEM kétjegyű!" : $"Igen, az összes elem rendszáma kétjegyű!");

            Console.WriteLine(megoldas);
        }
        static public void Feladat6()
        {
            int maxRendszam = 110;
            int index = 0;
            while (index < elemek.Length && !(elemek[index].Rendszam > maxRendszam))
            {
                index++;
            }

            string megoldas = (index < elemek.Length ? $"Igen, van!" : "Nem, nincs!");

            Console.WriteLine("6. Van  rendszám 110 felett?\r\n");
            Console.WriteLine(megoldas);
        }
        static public void Feladat7()
        {
            string vegyjel;
            bool helyes = false;
            int index = 0;

            Console.WriteLine("7. Kérjünk be egy vegyjelet, ami pontosan 2 betű kell, hogy legyen! Írjunk ki róla mindent, " +
                              "ha nem található, akkor „nincs ilyen elem az adatforrásban” szöveget!");
            Console.WriteLine();

            do
            {
                Console.Write("Add meg a vegyjelet (két karakternek kell lennie): ");
                vegyjel = Console.ReadLine();

                if (vegyjel.Length == 2)
                {
                    helyes = true;
                }

            } while (!helyes);


            //kersés
            while (index < elemek.Length && !(elemek[index].Vegyjel == vegyjel))
            {
                index++;
            }

            Console.WriteLine();
            string megoldas = (index < elemek.Length ? $"A {elemek[index].Nev} elem összesített adatai: {elemek[index]}" : "Nincs ilyen elem!");
            Console.WriteLine(megoldas);
        }
        static public void Feladat8()
        {
            Console.WriteLine("8. Mely években történt felfedezés?\r\n");

            HashSet<int> felvedezesiEvek = new HashSet<int>();

            foreach (Elem item in elemek)
            {
                felvedezesiEvek.Add(item.Ev);
            }

            StringBuilder megoldas = new StringBuilder();

            megoldas.Append("A következő években történt felfedezés:\r\n");
            foreach (int item in felvedezesiEvek)
            {
                megoldas.Append(" ");
                megoldas.Append(item);
            }
            megoldas.Append(".");

            Console.WriteLine(megoldas.ToString());
        }
        static public void Feladat9()
        {
            Console.WriteLine("9. Melyik évben hány felfedezés történt?\r\n");

            Dictionary<int, int> evenkentiFelfedezesek = new Dictionary<int, int>();


            foreach (Elem item in elemek)
            {
                if (evenkentiFelfedezesek.ContainsKey(item.Ev))
                {
                    evenkentiFelfedezesek[item.Ev]++;
                }

                else
                {
                    evenkentiFelfedezesek.Add(item.Ev, 1);
                }
            }

            Console.WriteLine("Üss ENTER-t a lista megjelenítéséhez!");
            Console.ReadLine();
            Console.WriteLine("Év: Felfedezések száma");
            StringBuilder megoldas = new StringBuilder();

            foreach (var item in evenkentiFelfedezesek)
            {
                megoldas.AppendLine($"{item.Key}:{item.Value}");

            }

            Console.WriteLine(megoldas.ToString());
        }
        static public void Feladat10()
        {
            Console.WriteLine("10.	Kérjünk be egy betűt! Az ezzel a betűvel kezdődő összes elemet az eredeti formátumnak megfelelően írjuk ki az „egyelem.csv” fájlba\r\n");

            string path = "egyelem.csv";

            StringBuilder toFileText = new StringBuilder();

            toFileText.AppendLine("Év; Elem; Vegyjel; Rendszám; Felfedező");
            Console.Write("Adj meg egy karaktert: ");
            char nev = Console.ReadKey().KeyChar;

            foreach (Elem item in elemek)
            {
                if (item.Nev[0]==nev)
                {
                    toFileText.AppendLine(item.ToString());
                }                
            }

            File.WriteAllText(path, toFileText.ToString());
            
            Console.WriteLine("\r\nFájlba írás kész! Az eredmény a <egyelem.csv> fájlban található. A folytatáshoz üss egy ENTER-t!!!");
            Console.ReadLine();


        }
    }

}
