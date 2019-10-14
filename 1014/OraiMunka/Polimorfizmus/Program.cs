using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizmus
{
    class Program
    {
        static void Main(string[] args)
        {
            Kor kor = new Kor(4);
            //kor.Kiir();

            Teglalap teglalap = new Teglalap(2, 3);
            //teglalap.Kiir();
            
            List<Alakzat> alakzatokList = new List<Alakzat>();

            alakzatokList.Add(kor);
            alakzatokList.Add(teglalap);
            alakzatokList.Add(new Kor(10));
            alakzatokList.Add(new Teglalap(2, 5));
            // alakzatokList.Add(new Alakzat()); Mivel már abstract osztály, ezért nem lehet példányosítani.

            foreach (Alakzat alakzat in alakzatokList)
            {
                alakzat.Kiir();
                alakzat.KiirTerulet(); Console.WriteLine();
            }

            


        }
    }
}
