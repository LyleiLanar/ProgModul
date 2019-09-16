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

            HashSet<Ember> Karakterek = new HashSet<Ember>();

            Karakterek.Add(new Ember(Ember.nemek.FERFI, "Karcsi", 23));
            Karakterek.Add(new Ember(Ember.nemek.NO, "Klári", 31));
            Karakterek.Add(new Ember(Ember.nemek.FERFI, "Jani", 14));

            Console.WriteLine(Karakterek.ElementAt(2).Nev);

        }
    }
}
