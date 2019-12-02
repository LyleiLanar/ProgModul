using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosodApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Mosoda mosoda = new Mosoda();

            mosoda.Bevesz(new Ruha("Karcsi", false));
            mosoda.Bevesz(new Ruha("Béla", false));
            mosoda.Bevesz(new Ing("Mari", false));
            mosoda.Bevesz(new Ing("Kitty", false));

            Console.WriteLine(mosoda.ToString());

          

            Console.ReadLine();

        }
    }
}
