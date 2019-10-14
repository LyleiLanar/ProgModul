using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallgatokProgram5
{
    class Feladat
    {
        private string[] adatok;
        List<Hallgato> hallgatok;
        private HashSet<String> konzulensek; // ez lesz itt a halmaz!
        int index, hallgatokSzama;
        private Dictionary<string, int> kozNevDb;


        //konstruktor
        public Feladat()
        {
             hallgatok = new List<Hallgato>();

            this.adatok = File.ReadAllLines("hallgatok.txt", Encoding.Default);
            this.index = 0;
            this.hallgatokSzama = adatok.Length;

            for (int i = 0; i < hallgatokSzama; i++)
            {
                hallgatok.Add(new Hallgato(adatok[i]));
            }
        }


        public void f1()
        {
            Console.WriteLine("\n1.feladat:");
            double szum = 0;
            foreach (Hallgato hallgato in hallgatok)
            {
                szum += hallgato.GetKor();
            }
            Console.WriteLine($"Hallgatók átlagos életkora: {szum / hallgatokSzama}");
        }
        public void f2()
        {
            Console.WriteLine("\n2.feladat:");
            //minimum konzidő 3 óra.            

            while (index < hallgatokSzama && hallgatok[index].GetKonOra() > 3)
            {
                index++;
            }

            Console.WriteLine(index < hallgatokSzama ? "Nem mindenkinek sikerült a követelmény!" : "Mindenkinek sikerült a követelmény!");
        }
        public void f3()
        {
            Console.WriteLine("\n3.feladat:");
            //max konzidő 5 óra, van-e aki már többet nem konzultálhat
            index = 0;

            while (index < hallgatokSzama && !(hallgatok[index].GetKonOra() >= 5))
            {
                index++;
            }

            Console.WriteLine(index < hallgatokSzama ? "Van, aki már nem jöhet konzulátcióra!" : "Még mindenki jöhet konzultálni!");

        }
        public void f4()
        {
            Console.WriteLine("\n4.feladat:");
            //Mindenki neve P-vel kezdődik.

            index = 0;
            while (index < hallgatokSzama && hallgatok[index].GetNev()[0] == 'P')
            {
                index++;
            }

            Console.WriteLine(index < hallgatokSzama ? "Nem mindenkinek 'P'-re végződik " : "Mindenki neve 'P'-vel kezdődik!");


        }
        public void f5()
        {           

            //Console.WriteLine("5. feladat");
            //Console.WriteLine("Hány konzulens van, név szerint");
            //konzulensek = new HashSet<string>();//hallgatok.Length
            //int joNevDb = 0;
            //foreach (Hallgato hallgato in hallgatok)
            //{
            //    string konzulens = hallgato.getKonzulens();
            //    if (!konzulensek.Contains(konzulens))
            //    {
                    
            //        konzulensek.ElementAt(joNevDb) = konzulens;
                                        
            //    }
            //    //int i = 0;
            //    //while (i < joNevDb && !(konzulensek[i] == konzulens)) { i++; }
            //    //bool van = i < joNevDb;
            //    //if (!van) { konzulensek[joNevDb++] = konzulens; }
            //}
            //for (int i = 0; i < joNevDb; i++)
            //{
            //    Console.WriteLine(konzulensek.ElementAt(i));
            //}
        }
        public void f6()
        {
            Console.WriteLine("\n6.feladat:");
            //melyik konzulensnek mennyi konzultáltja van?
            kozNevDb = new Dictionary<string, int>();

            foreach (Hallgato hallgato in hallgatok) 
                //fel fogja venni a dictionarybe az új elemeket, ha pedig talál egy újat, akkor növeli az értékét eggyel
            {
                string kulcs = hallgato.GetKonz();
                if (kozNevDb.ContainsKey(kulcs))
                {
                    //int ertek = kozNevDb[kulcs];
                    //kozNevDb.Add(kulcs, ertek++);
                    kozNevDb[kulcs]++;
                }
                else
                {
                    kozNevDb.Add(kulcs, 1);
                }
            }

            foreach (var item in kozNevDb)
            {
                string kulcs = item.Key;
                int ertek = item.Value;

                Console.WriteLine($"{kulcs}:{ertek}");

            }            
        }
        public void f7()
        {
            Console.WriteLine("\n7.feladat:");
            //Legfiatalabb és legidősebb hallgató nevét és korát

            Hallgato idos, fiatal;

            index = 0;

            idos = hallgatok[0];
            fiatal = hallgatok[0];

            foreach (Hallgato hallgato in hallgatok)
            {
                if (hallgato.GetKor() < fiatal.GetKor())
                {
                    fiatal = hallgato;
                }

                if (hallgato.GetKor() > idos.GetKor())
                {
                    idos = hallgato;
                }
            }

            File.WriteAllText("leg.txt", fiatal.GetNev() + " " + fiatal.GetKor() +
                                "\r\n" + idos.GetNev() + " " + idos.GetKor());
        }

        public void Kiir()
        {
            Console.WriteLine("Hallgatok:\r\n");
            foreach (Hallgato hallgato in hallgatok)
            {
                Console.WriteLine(hallgato.ToString()); 
            }            
        }
    }
}
