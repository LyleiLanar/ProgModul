using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallgatokProgram4
{
    class Feladat
    {
        private string[] adatok;
        private Hallgato[] hallgatok;
        int index, hallgatokSzama;

        //konstruktor
        public Feladat()
        {
            this.adatok = File.ReadAllLines("hallgatok.txt", Encoding.Default);
            this.hallgatok = new Hallgato[adatok.Length - 1];
            this.index = 0;
            this.hallgatokSzama = hallgatok.Length;

            for (int i = 0; i < hallgatok.Length; i++)
            {
                hallgatok[i] = new Hallgato(adatok[i + 1]);
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
            Console.WriteLine($"Hallgatók átlagos életkora: {szum / hallgatok.Length}");
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
            Console.WriteLine("\n5.feladat:");
            //hány konzulnes van név szerint? 
        }
        public void f6()
        {
            Console.WriteLine("\n6.feladat:");
            //melyik konzulensnek mennyi konzultáltja van?
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
