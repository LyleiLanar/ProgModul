using System;

namespace ExplicitInterface
{

    interface IRajzolFormra { void rajzol(); }
    interface IRajzolMemoriaba { void rajzol(); }
    interface IRajzolNyomtatora { void rajzol(); }

    class Alakzat : IRajzolFormra, IRajzolMemoriaba, IRajzolNyomtatora
    {

        void IRajzolFormra.rajzol()
        {
            System.Console.WriteLine("Rajzol formra!");
        }

        void IRajzolMemoriaba.rajzol()
        {
            System.Console.WriteLine("Rajzol memoriaba!");
        }

        void IRajzolNyomtatora.rajzol()
        {
            System.Console.WriteLine("Rajzol nyomtatora!");
        }

        //Itt ez nem túl fasza mert a sok Rajzol() metódus közül lövése sincs, hogy melyiket írja ki...
        //public void rajzol()
        //{
        //    throw new System.NotImplementedException();
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Alakzat a = new Alakzat();

            ((IRajzolFormra)a).rajzol();
            ((IRajzolMemoriaba)a).rajzol();
            ((IRajzolNyomtatora)a).rajzol();

            Console.ReadLine();

        }
    }
}
