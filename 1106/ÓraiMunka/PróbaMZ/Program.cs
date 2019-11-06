using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PróbaMZ
{
    class Program
    {
        static List<Ember> emberek;
        static void Main(string[] args)
        {
            
            emberek = Feladatok.Read("emberek.txt");

            /* Feladatok*/
            Feladatok.f1(emberek);
            Feladatok.f2(emberek);
            Feladatok.f3(emberek);
            Feladatok.f4(emberek);
            Feladatok.f5(emberek);
            Feladatok.f6(emberek);
            Feladatok.f7(emberek);
            Feladatok.f8(emberek);
            Feladatok.f9(emberek);
            Feladatok.f10(emberek);
            Feladatok.f11(emberek);
            Feladatok.f12(emberek);
            Feladatok.f13(emberek);

            Console.ReadLine();

        }
    }
}
