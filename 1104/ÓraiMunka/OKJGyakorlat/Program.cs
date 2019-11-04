using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKJGyakorlat
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string path = "C:\\Users\\Szoft46\\source\\repos\\LyleiLanar\\ProgModul\\1104\\ÓraiMunka\\OKJGyakorlat\\bin\\Debug\\hegyek.txt";

            string[] sorok = File.ReadAllLines(path, Encoding.Default);
            List<Hegy> hegyek = new List<Hegy>();

            int length = sorok.Length;

            for (int i = 1; i < length; i++)
            {
                hegyek.Add(new Hegy(sorok[i]));
            }

            /* Hány hegy van */
            Console.WriteLine("1. feladat:");
            Console.WriteLine($"Összesen {hegyek.Count} darab hegy van.");
            Console.WriteLine();
            
            /* A hegyek teljes magassága */
            Console.WriteLine("2. feladat:");
            int teljesMagassag = 0;

            foreach (Hegy hegy in hegyek)
            {
                teljesMagassag += hegy.Magssag;
            }

            Console.WriteLine($"A hegyek teljes magassága: {teljesMagassag} méter.");
            Console.WriteLine();

            /* Átlagos magasság */
            Console.WriteLine("3. feladat:");
            Console.WriteLine($"A hegyek átlagmagassága: {(double)teljesMagassag/hegyek.Count:N3} méter.");
            Console.WriteLine();

            /* *********************************************************************************************************************** */
            /* A bükk vidék legmagasabb hegye */
            Console.WriteLine("4. feladat:");

            int maxI;
            int index = 1;
            string videk = "Börzsöny";
            // Kiválasztás tételével megkeressük az első Bükk-vidékit
            while (hegyek[index].Hegyseg!= videk)
            {
                index++;
            }
            maxI = index;

            //innen a max kivalasztas megy

            for (int i = maxI+1; i < hegyek.Count; i++)
            {
                if (hegyek[i].Hegyseg == videk && hegyek[maxI].Magssag<hegyek[i].Magssag)
                {
                    maxI = i;
                }
            }

            Console.WriteLine($"A legmagasabb {videk}i hegy a {hegyek[maxI].Nev}");
            Console.WriteLine();

            /* *********************************************************************************************************************** */
            /* A bükk vidék hegyeinek a száma */
            Console.WriteLine("5. feladat:");

            int hegyekSzama = 0;
            videk = "Börzsöny";
            foreach (Hegy hegy in hegyek)
            {
                if (hegy.Hegyseg == videk)
                {
                    hegyekSzama++;
                }
            }

            Console.WriteLine($"A {videk} hegységben összesen {hegyekSzama} csúcs van.");
            Console.WriteLine();

            /* *********************************************************************************************************************** */
            /*Van-e az adott vidéken n méternél magasabb hegy.*/
            Console.WriteLine("6. feladat:");
            int maxMagassag = 940;
            videk = "Börzsöny";
            index = 0;
            while (index < hegyek.Count && !(hegyek[index].Hegyseg == videk  && hegyek[index].Magssag>maxMagassag))
            {
                index++;
            }

            string valasz = (index < hegyek.Count ? "van" : "nincs");

            Console.WriteLine($"A {videk} hegységben {valasz} {maxMagassag} méternél magasabb hegy!");
            Console.WriteLine();

            /* *********************************************************************************************************************** */
            /*Minden hegy 700 m-nél magasabb-e?*/
            Console.WriteLine("7. feladat:");
            int minMagassag = 1000;
            index = 0;

            while (index < hegyek.Count && !(hegyek[index].Magssag<minMagassag))
            {
                index++;
            }

            valasz = (index < hegyek.Count ? "Nem minden" : "Minden");
            Console.WriteLine($"{valasz} hegy magasabb, mint {minMagassag} méter.");
            Console.WriteLine();

            /* *********************************************************************************************************************** */
            /*Hány hegységünk van*/

            Console.WriteLine("8. feladat:");

            HashSet<string> hegyseg= new HashSet<string>();

            foreach (Hegy hegy in hegyek)
            {
                hegyseg.Add(hegy.Hegyseg);
            }
            Console.WriteLine($"Összesen {hegyseg.Count} hegység van.");
            Console.WriteLine();

            /* *********************************************************************************************************************** */
            /*Dictionary. Melyik hegységben mennyi csucs van?*/

            Console.WriteLine("9. feladat:");

            Dictionary<string, int> nevekDb = new Dictionary<string, int>();

            foreach (Hegy hegy in hegyek)
            {
                if (nevekDb.ContainsKey(hegy.Hegyseg))
                {
                    nevekDb[hegy.Hegyseg]++;
                }
                else
                {
                    nevekDb.Add(hegy.Hegyseg,1);
                }
            }


            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string,int> item in nevekDb)
            {
                sb.Append(item.Key);
                sb.Append(": ");
                sb.Append(item.Value);
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());            

            /* *********************************************************************************************************************** */
            /*Dictionary. Melyik hegységben mennyi csucs van?*/
            Console.WriteLine("10. feladat");

            File.WriteAllText("nevek.txt",sb.ToString());
            Console.WriteLine("Sikerült a mindenség!!!");

            Console.ReadLine();

        }
    }
}
