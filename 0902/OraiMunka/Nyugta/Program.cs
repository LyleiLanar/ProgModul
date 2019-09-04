namespace Nyugta
{
    using System;
    class Program
    {
        static int TEXTBOX_X = 30;
        enum Irany
        {
            JOBBRA, BALRA, KOZEPRE
        }

        static void Main(string[] args)
        {
            string text= "kutya";
            vonal('#');
            kiir(text, Irany.KOZEPRE);
            kiir(text, Irany.JOBBRA);
            kiir(text, Irany.KOZEPRE);
            kiir(text, Irany.JOBBRA);
            kiir(text, Irany.BALRA);

            Console.ReadLine();
        }

        static void kiir(string szoveg, Irany irany)
        {            
            switch (irany)
            {
                case Program.Irany.JOBBRA:
                    for (int i = 0; i < TEXTBOX_X - szoveg.Length; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(szoveg);
                    break;

                case Program.Irany.KOZEPRE:
                    for (int i = 0; i < TEXTBOX_X / 2 - szoveg.Length / 2; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(szoveg);
                    break;

                default:
                    Console.WriteLine(szoveg);
                    break;
            }
        }
        static void vonal(char c)
        {
            for (int i = 0; i < TEXTBOX_X; i++)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
