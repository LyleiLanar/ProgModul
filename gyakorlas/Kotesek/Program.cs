using Kotesek.Singleton;
using System;

namespace Kotesek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A dinamikus és A statikus típusú példány létrehozása: ");
            A a = new A(1);
            Console.WriteLine($"A statikus adattagja: {A.common}");
            Console.WriteLine();
            Console.WriteLine("B dinamikus és A statikus típusú példány létrehozása: ");
            A b = new B(1, 1);
            Console.WriteLine();
            Console.WriteLine("C dinamikus és B statikus típusú példány létrehozása:  ");
            B c = new C(1, 1, 1);
            Console.WriteLine();
            
            Console.WriteLine($"A, osztály statikus adattagja: {A.common}");
            Console.WriteLine($"B, osztály statikus adattagja: {B.common}");
            Console.WriteLine($"C, osztály statikus adattagja: {C.common}");
            Console.WriteLine();

            // itt a statikus alapján kerülnek kiválasztásra a metódusok:
            int szum = a.GetValueKorai(); //statikus: *A | dinamikus: A
            szum = b.GetValueKorai(); //statikus: *A | dinamikus: B
            szum = c.GetValueKorai(); //statikus: *B | dinamikus: C

            // itt pedig a dinamikus típus alapján kerülnek kiválasztásra a metódusok:
            szum = a.GetValueKesoi(); //statikus: A | dinamikus: *A
            szum = b.GetValueKesoi(); //statikus: A | dinamikus: *B
            szum = c.GetValueKesoi(); //statikus: B | dinamikus: *C

            //manuális késői kötés
            szum = (a as A).GetValueKorai(); //statikus: A | dinamikus: *A
            szum = (b as B).GetValueKorai(); //statikus: A | dinamikus: *B
            szum = (c as C).GetValueKorai(); //statikus: B | dinamikus: *C            
            szum = new C().GetValueKesoi();
            Console.WriteLine();
            Console.WriteLine($"Szum értéke 'new C().GetValueKesoi();' esetében: {szum}");


            //private konstruktor class létrehozása 
            Console.WriteLine();
            Console.WriteLine("Hozzunk létre egy PrivateClass példányt:");
            PrivateClass pv = PrivateClass.Create(100);

            pv.PrintValue();


            Console.WriteLine("Példányosítsuk a Singleton osztályt, majd írjuk ki az értékét:");
            SingletonClass Sing = SingletonClass.Create(666);
            Sing.PrintSingletonValue();
            Console.WriteLine("Most próbáljuk meg újra példányosítani:");
            SingletonClass Sing2 = SingletonClass.Create(111);
            Console.WriteLine("Nézzük meg mennyi lesz a második SingletonClass példány valueja:");
            Sing2.PrintSingletonValue();

            Console.ReadLine();
        }
    }
}
