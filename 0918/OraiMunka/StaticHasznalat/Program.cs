using System;

namespace StaticHasznalat
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember ember = new Ember();
            Ember peter = new Ember(25, "Péter");

            Console.WriteLine(ember.ToString());
            Console.WriteLine(peter.ToString());

            Ember[] emberek = new Ember[100];

            for (int i = 0; i < emberek.Length; i++)
            {
                emberek[i] = new Ember(15 + i, $"{i}. ember");
            }

            Console.WriteLine(Ember.Statisztika());
        }
    }
}
