using System;

namespace NimGame
{
    static class Printer
    {
        //console size

        const int TEXTBOX = 40;

        //console colors
        public const ConsoleColor mainCl = ConsoleColor.DarkGreen;
        public const ConsoleColor empCl = ConsoleColor.Magenta;
        public const ConsoleColor errorCl = ConsoleColor.Red;
        public const ConsoleColor headerCl = ConsoleColor.Cyan;
        public const ConsoleColor mstImportantCl = ConsoleColor.Yellow;

        public enum Orientation
        {
            RIGHT, LEFT, MIDDLE
        }

        //text orientation
        public static void ClearTextBox()
        {
            Console.Clear();
            Print("NORADSTICK2019\n", Orientation.MIDDLE, mstImportantCl);
            PrintStripe('#', headerCl);
            Console.WriteLine();
        }

        public static void Br()
        {
            Console.WriteLine();
        }

        //print metódusok
        public static void Print(string text, Orientation irany, ConsoleColor color)
        {
            if (text.Length > TEXTBOX)
            {
                Print(text.Remove(TEXTBOX), irany, color);
                Console.Write("\n");
                Print(text.Remove(0, TEXTBOX), irany, color);
            }
            else
            {

                Console.ForegroundColor = color;
                switch (irany)
                {
                    case Orientation.RIGHT:
                        for (int i = 0; i < TEXTBOX - text.Length; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(text);
                        Console.ResetColor();
                        break;

                    case Orientation.MIDDLE:
                        for (int i = 0; i < TEXTBOX / 2 - text.Length / 2; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(text);
                        Console.ResetColor();
                        break;

                    default:
                        Console.Write(text);
                        Console.ResetColor();
                        break;
                }
            }
        }
        public static void Print(string text, Orientation irany)
        {
            if (text.Length > TEXTBOX)
            {
                Print(text.Remove(TEXTBOX), irany, mainCl);
                Console.Write("\n");
                Print(text.Remove(0, TEXTBOX), irany, mainCl);
            }
            else
            {

                Console.ForegroundColor = mainCl;
                switch (irany)
                {
                    case Orientation.RIGHT:
                        for (int i = 0; i < TEXTBOX - text.Length; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(text);
                        Console.ResetColor();
                        break;

                    case Orientation.MIDDLE:
                        for (int i = 0; i < TEXTBOX / 2 - text.Length / 2; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(text);
                        Console.ResetColor();
                        break;

                    default:
                        Console.Write(text);
                        Console.ResetColor();
                        break;
                }
            }
        }
        public static void Print(string text, ConsoleColor color)
        {
            if (text.Length > TEXTBOX)
            {
                Print(text.Remove(TEXTBOX), Orientation.LEFT, color);
                Console.Write("\n");
                Print(text.Remove(0, TEXTBOX), Orientation.LEFT, color);
            }
            else
                Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();

        }
        public static void Print(string text)
        {
            if (text.Length > TEXTBOX)
            {
                Print(text.Remove(TEXTBOX), Orientation.LEFT, mainCl);
                Console.Write("\n");
                Print(text.Remove(0, TEXTBOX), Orientation.LEFT, mainCl);
            }
            else
            {

                Console.ForegroundColor = mainCl;
                Console.Write(text);
                Console.ResetColor();
            }
        }        

        //printStripe
        public static void PrintStripe(char c, ConsoleColor color)
        {
            for (int i = 0; i < TEXTBOX; i++)
            {
                Console.ForegroundColor = color;
                Console.Write(c);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void PrintStripe(char c)
        {
            for (int i = 0; i < TEXTBOX; i++)
            {
                Console.ForegroundColor = color;
                Console.Write(c);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
