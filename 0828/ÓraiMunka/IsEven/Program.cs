using System;

namespace IsEven
{
    class Program
    {
        static void Main(string[] args)
        {

            //A program kiírja az első 20 szám közül a párosakat.
            int[]  tomb = new int[20];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = i;
            }

            for (int i = 0; i < tomb.Length; i++)
            {
                if (isEven(tomb[i]))
                {
                    Console.Write(tomb[i]+" ");
                }
            }

         

            Console.ReadLine();
        }

        

       


    }
}
