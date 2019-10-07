using System;

namespace Kiralynok_OKJ
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabla tabla1 = new Tabla('#');

            Console.WriteLine("4. feladat: Az üres tábla:");
            tabla1.Megjelenit();
            tabla1.Elhelyez(8);
            Console.WriteLine("6. feladat: A feltöltött tábla:");
            tabla1.Megjelenit();

            Console.WriteLine("Üres oszlopok és sorok száma: ");
            Console.WriteLine($"Oszlopok: {tabla1.UresOszlopokSzama}");
            Console.WriteLine($"Sorok: {tabla1.UresSorokSzama}");

            Tabla.FajlbaIr();
            //StringBuilder + 
        }
    }
}
