using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat
{
    class Jatek
    {
        public Mezo[,] JatekTer { get; set; }

        public Jatek()
        {
            this.JatekTer = new Mezo[3, 3];
            string[] adatsorok = File.ReadAllLines("adat.txt",Encoding.Default);

            for (int sor = 0; sor < 3; sor++)
            {
                string[] adatHarmas = adatsorok[sor].Split(';');

                for (int oszlop = 0; oszlop < 3; oszlop++)
                {
                    this.JatekTer[sor, oszlop] = new Mezo(adatHarmas[oszlop]);
                }
            }
        }

        public void Kirajzol()
        {
            for (int i = 0; i < this.JatekTer.GetLength(0); i++)
            {
                for (int j = 0; j < this.JatekTer.GetLength(1); j++)
                {
                    Console.Write(this.JatekTer[i,j].ToString()+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
