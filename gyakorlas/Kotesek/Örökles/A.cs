using System;

namespace Kotesek
{
    class A
    {
        public int AValue { get; set; }
        public static int common;
        
        //static konstruktor a static adattagok beállítására. Nem lehet paramétere, nem lehet védelni szintje.
        static A()
        {
            Console.WriteLine("A Statikus konstruktor meghívása.");
            common = 1;
        }

        //ősosztály konstruktora
        public A(int aValue)
        {
            Console.WriteLine("A, parameteres konstruktor");
            AValue = aValue;
        }

        //ősosztály paraméter nélküli konstruktora, ami hívja az egyparaméteres konstruktort.
        public A():this(0)
        {
            Console.WriteLine("A, parameter NÉLKÜLI konstruktor");            
        }

        /* Itt nem virtuális metódust csináltunk, tehát itt korai kötés van. Fordítási időben lesz eldöntve, hogy melyik metódus kerül
         *meghívásra. A felülírt metódusoknak kell egy new kulcsszó. Gyorsabb, mint a késői kötés, de nem elég rugalmas.
         * Nem igazán használt.
         */
        public int GetValueKorai()
        {
            return AValue;
        }

        /* Ez pedig késői kötés, ha ezt a metódust hívjuk, akkor a fordító fordítási időben fogja eldönteni, hogy a dinamikus típus 
         * alapján legyen eldöntve, hogy melyik metódus kerül meghívásra. 
         * 
         */
        virtual public int GetValueKesoi()
        {
            return AValue;
        }

        /* Mivel itt ez a metódus az A osztályhoz tartozik ezért itt egy A típus vár, amibe persze bele lehet rakni egy 
         * B vagy C metódust is, de ebben az esetben a statikus típus mindig A lesz. Tehát hiába hívom meg a B, vagy C típusó példányt 
         * ezzel, akkor is A típusúnak lesz értelmezve.
         */
        public void PrintValue()
        {
            Console.WriteLine(GetValueKesoi());
        }

    }
}
