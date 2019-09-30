using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallgatokProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string adat1 = "Péter;30";
            string adat2 = "Pál;31";

            Hallgato k1 = new Hallgato(adat1);
            Hallgato k2 = new Hallgato(adat2);

            k1.Kiir();
            k2.Kiir();



        }
    }
}
