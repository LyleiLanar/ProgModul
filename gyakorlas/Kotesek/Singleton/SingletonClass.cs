using System;

namespace Kotesek.Singleton
{

    /*
     * Singleton arra jó, hogy maximum csak egyszer lehessen egy osztályt példányosítani, ha újra példányosítani akarjuk, akkor
     * valójában csak egy aliast hozunk létre.
     */
    class SingletonClass
    {
        public static SingletonClass theOnlyOneInstance = null;

        public static SingletonClass Create(int value)
        {
            if (theOnlyOneInstance != null)
            {
                Console.WriteLine("Már lett példányosítva az osztály!!!");
                return theOnlyOneInstance;
            }

            Console.WriteLine("Még NEM lett példányosítva az osztály!!!");
            theOnlyOneInstance = new SingletonClass(value);

            return theOnlyOneInstance;

        }
        public int SingletonValue { get; set; }

        private SingletonClass(int value)
        {
            this.SingletonValue = value;
        }

        public void PrintSingletonValue()
        {
            Console.WriteLine($"A singleton értéke: {SingletonValue}");
        }
    }
}
