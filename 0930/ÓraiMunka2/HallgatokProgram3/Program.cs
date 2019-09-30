using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallgatokProgram3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] adatok = File.ReadAllLines("hallgatok.txt", Encoding.Default);

            Hallgato[] hallgatok = new Hallgato[adatok.Length-1];

            for (int i = 0; i < hallgatok.Length; i++)
            {
                hallgatok[i] = new Hallgato(adatok[i+1]);
            }


            Console.WriteLine("Hallgatók:");
            foreach (Hallgato hallgato in hallgatok)
            {
                hallgato.Kiir();
            }


            Console.WriteLine("\n1.feladat:");
            double szum=0;
            foreach (Hallgato hallgato in hallgatok)
            {
                szum += hallgato.GetKor();
            }
            Console.WriteLine($"Hallgatók átlagos életkora: {szum/hallgatok.Length}");


            Console.WriteLine("\n2.feladat:");
            //minimum konzidő 3 óra.
            int index = 0;
            int hallgatokSzama = hallgatok.Length;
            
            while (index<hallgatokSzama && hallgatok[index].GetKonOra()>3)
            {
                index++;
            }

            Console.WriteLine(index < hallgatokSzama? "Nem mindenkinek sikerült a követelmény!": "Mindenkinek sikerült a követelmény!");


            Console.WriteLine("\n3.feladat:");
            //max konzidő 5 óra, van-e aki már többet nem konzultálhat
            index = 0;            

            while (index < hallgatokSzama && !(hallgatok[index].GetKonOra() >= 5))
            {
                index++;
            }

            Console.WriteLine(index < hallgatokSzama ? "Van, aki már nem jöhet konzulátcióra!": "Még mindenki jöhet konzultálni!");


            Console.WriteLine("\n4.feladat:");
            //Mindenki neve P-vel kezdődik.

            index = 0;
            while (index < hallgatokSzama && hallgatok[index].GetNev()[0] == 'P')
            {
                index++;
            }

            Console.WriteLine(index < hallgatokSzama ? "Nem mindenkinek 'P'-re végződik ": "Mindenki neve 'P'-vel kezdődik!");

        }
    }
}
