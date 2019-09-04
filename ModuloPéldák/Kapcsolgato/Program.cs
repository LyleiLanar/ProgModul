using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapcsolgato
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLighing = false;
            int kapcsolasokSzama = 0;

            Console.WriteLine("A(z) {0}. kapcsoláskor a lámpa {1}", kapcsolasokSzama, isLighing ? "világít!" : "nem világít!");
            //kapcsolás
            //isLighing = isLighing ? isLighing = false : isLighing = true;
            isLighing = (kapcsolasokSzama % 2 == 0) ?  true : false;
            kapcsolasokSzama++;
            Console.WriteLine("A(z) {0}. kapcsoláskor a lámpa {1}",kapcsolasokSzama, isLighing ? "világít!": "nem világít!" );

            isLighing = (kapcsolasokSzama % 2 == 0) ? true : false;
            kapcsolasokSzama++;
            Console.WriteLine("A(z) {0}. kapcsoláskor a lámpa {1}", kapcsolasokSzama, isLighing ? "világít!" : "nem világít!");

            isLighing = (kapcsolasokSzama % 2 == 0) ? true : false;
            kapcsolasokSzama++;
            Console.WriteLine("A(z) {0}. kapcsoláskor a lámpa {1}", kapcsolasokSzama, isLighing ? "világít!" : "nem világít!");

            isLighing = (kapcsolasokSzama % 2 == 0) ? true : false;
            kapcsolasokSzama++;
            Console.WriteLine("A(z) {0}. kapcsoláskor a lámpa {1}", kapcsolasokSzama, isLighing ? "világít!" : "nem világít!");





        }
    }
}
