using System;

namespace gyakorlatiFeladat
{
    class Program
    {
        static int[,] data;
        public enum Header
        {
            TOP, LEFT, BOTH, WITHOUT
        }

        static void Main(string[] args)
        {
            int size = 3;

            printMatrix(size, Header.LEFT);
            Console.WriteLine();
            printMatrix(size, Header.TOP);
            Console.WriteLine();
            printMatrix(size, Header.BOTH);
            Console.WriteLine();
            printMatrix(size, Header.WITHOUT);

        }

        private static void printMatrix(int size, Header header)
        {
            generate(size + 1);
            calculateHeader();

            switch (header)

            {
                case Header.TOP:

                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            if (i == 0 && j == 0)
                            {
                                Console.Write($"{"+",3} ");
                            }
                            else if (j == 0)
                            {
                                Console.Write($"{"_",3} ");
                            }
                            else
                            {
                                Console.Write($"{data[i, j],3} ");
                            }
                        }
                        Console.WriteLine();
                    }

                    break;

                case Header.LEFT:

                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            if (i == 0 && j == 0)
                            {
                                Console.Write($"{"+",3} ");
                            }
                            else if (i == 0)
                            {
                                Console.Write($"{"_",3} ");
                            }
                            else
                            {
                                Console.Write($"{data[i, j],3} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    break;

                case Header.BOTH:

                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            if (i == 0 && j == 0)
                            {
                                Console.Write($"{"+",3} ");
                            }
                            else
                            {
                                Console.Write($"{data[i, j],3} ");
                            }
                        }
                        Console.WriteLine();
                    }

                    break;
                case Header.WITHOUT:

                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            if (i == 0 && j == 0)
                            {
                                Console.Write($"{"+",3} ");
                            }
                            else if (i == 0 || j ==0)
                            {
                                Console.Write($"{"_",3} ");
                            }
                            else
                            {
                                Console.Write($"{data[i, j],3} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    break;
            }

        }

        private static void calculateHeader()
        {
          
            for (int i = 1; i < data.GetLength(0); i++)
            {
                for (int j = 1; j < data.GetLength(1); j++)
                {
                    data[0, j] += data[i, j];
                    data[i, 0] += data[i, j];
                }
            }
        }        

        private static void generate(int size)
        {

            Random rnd = new Random();

            data = new int[size, size];

            for (int i = 1; i < size; i++)
            {
                for (int j = 1; j < size; j++)
                {
                    data[i, j] = rnd.Next(-20, 31);
                }
            }
        }
    }
}
