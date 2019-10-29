using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Program
    {
        

        static void Main(string[] args)
        {
            List<Pont> pontokLista = new List<Pont>();

                   

            Pontok pontokHS = new Pontok(pontokLista);

            Console.WriteLine(pontokHS);
            Console.WriteLine(pontokHS.PontHalmaz.Count);

            pontokHS.Animation(10, 10);



            Console.ReadLine();

        }
    }
}
