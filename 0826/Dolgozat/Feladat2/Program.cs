using System;

namespace Feladat2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Molnár Patrik
            
            Random rnd = new Random();
            string folytatas;
            int meccsek = 0, gyozelem = 0, vereseg = 0, dontetlen = 0;
            do
            {
                Console.Clear();
                meccsek++;
                bool sikeresValasztas = false;                
                int jatekosFegyver;

                do
                {
                    Console.WriteLine("Válassz fegyvert, úgy hogy leütöd a megfelelő számot: ");
                    Console.WriteLine("1. Kő");
                    Console.WriteLine("2. Papír");
                    Console.WriteLine("3. Olló");

                    int.TryParse(Console.ReadLine(), out jatekosFegyver);
                    if (jatekosFegyver >= 1 && jatekosFegyver <= 3)
                    {
                        sikeresValasztas = true;
                    }
                    else
                    {
                        Console.Clear();
                    }



                } while (!sikeresValasztas);

                int cpuFegyver = rnd.Next(1, 4);
                Console.WriteLine();
                //ide jönnek a játékos nyerései
                switch (jatekosFegyver)
                {
                    case 1:
                        switch (cpuFegyver)
                        {
                            case 1:
                                Console.WriteLine("Te követ, Jani pedig szintén követ mutatott. DÖNTETLEN!!!");
                                dontetlen++;
                                break;

                            case 2:
                                Console.WriteLine("Te követ Jani pedig papírt mutatott. VESZTETTÉL!!!");
                                vereseg++;
                                break;

                            case 3:
                                Console.WriteLine("Te követ Jani pedig ollót mutatott. NYERTÉL!!!");
                                gyozelem++;
                                break;
                        }
                        break;

                    case 2:
                        switch (cpuFegyver)
                        {
                            case 1:
                                Console.WriteLine("Te papírt Jani pedig követ mutatott. NYERTÉL!!!");
                                gyozelem++;
                                break;

                            case 2:
                                Console.WriteLine("Te papírt, Jani pedig szintén papírt mutatott. DÖNTETLEN!!!");
                                dontetlen++;
                                break;

                            case 3:
                                Console.WriteLine("Te papírt Jani pedig ollót mutatott. VESZTETTÉL!!!");
                                vereseg++;
                                break;
                        }
                        break;

                    case 3:
                        switch (cpuFegyver)
                        {
                            case 1:
                                Console.WriteLine("Te ollót Jani pedig követ mutatott. VESZTETTÉL!!!");
                                vereseg++;
                                break;

                            case 2:
                                Console.WriteLine("Te ollót Jani pedig papírt mutatott. NYERTÉL!!!");
                                gyozelem++;
                                break;

                            case 3:
                                Console.WriteLine("Te ollót, Jani pedig szintén ollót mutatott. DÖNTETLEN!!!");
                                dontetlen++;
                                break;
                        }
                        break;

                }

                bool sikeresString = false;
                do
                {
                    
                    Console.WriteLine("\nAkarsz még játszani? (i)gen/(n)em");
                    folytatas = Console.ReadLine();

                    if (folytatas == "i" || folytatas == "n")
                    {
                        sikeresString = true;
                    }
                    else
                    {
                        Console.Clear();
                    }

                } while (!sikeresString);
            } while (folytatas == "i");


            // kiértékelés

            Console.Clear();

            Console.WriteLine($"Meccsek száma: {meccsek}");
            Console.WriteLine($"Győzelmek száma: {gyozelem}");
            Console.WriteLine($"Vereségek száma: {vereseg}");
            Console.WriteLine($"Döntetlenek száma: {dontetlen}");







        }
    }
}
