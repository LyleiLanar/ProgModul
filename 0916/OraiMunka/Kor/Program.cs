using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Kor kor1 = new Kor(3, new Pont(2,2));
            kor1.Print();

            Pont origo = new Pont();

            Console.WriteLine(Pont.KetPontTavolsaga(kor1.Center,origo));

            Kor kor2 = new Kor(10,new Pont(2,5));

            Console.WriteLine(Pont.KetPontTavolsaga(kor1.Center,kor2.Center));


            if (kor1.Center.TavolsagaOrigotol() > kor2.Center.TavolsagaOrigotol())
            {
                Console.WriteLine("K messzebb van az origótol, mint K2");
            }
            else
            {
                Console.WriteLine("K2 messzebb van az origótol, mint K");
            }            
            */

            Kor k1 = new Kor(4,1,1);            
            Teglalap t1 = new Teglalap(2,2,2,2);

            Console.WriteLine(t1.ToString());

        }
    }
}
