using System;

namespace CustomInterface
{

    interface IKinyithato
    {
        void Kinyit();
    }

    class Ajto : IKinyithato
    {
        public void Kinyit()
        {
            Console.WriteLine("Ajto kinyilt!");
        }
    }

    class Esernyo : IKinyithato
    {
        public void Kinyit()
        {
            Console.WriteLine("Esernyő kinyilt!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ajto ajto = new Ajto();
            Esernyo esernyo = new Esernyo();

            IKinyithato[] nyithatoCuccok = { ajto, esernyo };

            foreach (IKinyithato item in nyithatoCuccok)
            {
                item.Kinyit();
            }

            Console.ReadLine();

        }
    }
}
