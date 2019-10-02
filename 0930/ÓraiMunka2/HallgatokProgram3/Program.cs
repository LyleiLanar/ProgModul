﻿using System;
using System.IO;
using System.Text;

namespace HallgatokProgram3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] adatok = File.ReadAllLines("hallgatok.txt", Encoding.Default);

            Hallgato[] hallgatok = new Hallgato[adatok.Length - 1];

            for (int i = 0; i < hallgatok.Length; i++)
            {
                hallgatok[i] = new Hallgato(adatok[i + 1]);
            }


            Console.WriteLine("Hallgatók:");
            foreach (Hallgato hallgato in hallgatok)
            {
                hallgato.Kiir();
            }


            Console.WriteLine("\n1.feladat:");
            double szum = 0;
            foreach (Hallgato hallgato in hallgatok)
            {
                szum += hallgato.GetKor();
            }
            Console.WriteLine($"Hallgatók átlagos életkora: {szum / hallgatok.Length}");


            Console.WriteLine("\n2.feladat:");
            //minimum konzidő 3 óra.
            int index = 0;
            int hallgatokSzama = hallgatok.Length;

            while (index < hallgatokSzama && hallgatok[index].GetKonOra() > 3)
            {
                index++;
            }

            Console.WriteLine(index < hallgatokSzama ? "Nem mindenkinek sikerült a követelmény!" : "Mindenkinek sikerült a követelmény!");


            Console.WriteLine("\n3.feladat:");
            //max konzidő 5 óra, van-e aki már többet nem konzultálhat
            index = 0;

            while (index < hallgatokSzama && !(hallgatok[index].GetKonOra() >= 5))
            {
                index++;
            }

            Console.WriteLine(index < hallgatokSzama ? "Van, aki már nem jöhet konzulátcióra!" : "Még mindenki jöhet konzultálni!");


            Console.WriteLine("\n4.feladat:");
            //Mindenki neve P-vel kezdődik.

            index = 0;
            while (index < hallgatokSzama && hallgatok[index].GetNev()[0] == 'P')
            {
                index++;
            }

            Console.WriteLine(index < hallgatokSzama ? "Nem mindenkinek 'P'-re végződik " : "Mindenki neve 'P'-vel kezdődik!");


            Console.WriteLine("\n5.feladat:");
            //hány konzulnes van név szerint?                                    

            Console.WriteLine("\n6.feladat:");
            //melyik konzulensnek mennyi konzultáltja van?

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

            File.WriteAllText("leg.txt", fiatal.GetNev() +" "+fiatal.GetKor()+
                                "\r\n" + idos.GetNev() + " " + idos.GetKor());
            
        }
    }

}

