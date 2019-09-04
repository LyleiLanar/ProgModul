using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGen
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();            
            Random rnd2 = new Random(12); //seedelés cucc


            //univerzális módszer
            int also = 1;
            int felso = 6;            
            int dobas = (int)(rnd.NextDouble() * felso) + also;
            Console.WriteLine(dobas);

            //egy paraméteres overloading (zárt intervallum, 10 nyílt intervallum)
            Console.WriteLine(rnd.Next(10)); 

            //két paraméteres overloading (20 zárt intervallum, 25 nyílt intervallum)
            Console.WriteLine(rnd.Next(20,25));

            Console.WriteLine($"A következő lottó nyerőszáma: {rnd.Next(1,91)}");

            Console.WriteLine(rnd.Next(10,100));

            Console.WriteLine(rnd2.Next());

        }
    }
}
