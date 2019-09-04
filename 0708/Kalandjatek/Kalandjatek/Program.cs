using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalandjatek
{
    class Program
    {
        static void Main(string[] args)
        {

            int aktSzoba = 1;
            string irany;
            bool kincs = false;

            Console.WriteLine("Beléptél a labirintusba!");
            Console.Write("Add meg, hogy merre akarsz menni (kelet, dél): ");
            irany = Console.ReadLine();

            if (irany == "kelet")
            {
                aktSzoba = 2;
            }
            else
            {
                aktSzoba = 4;
            }

            while (aktSzoba != 4)
            {
                if (aktSzoba == 1)
                {
                    Console.Write("Beléptél az első szobába, innen kelet, dél felé tudsz menni: ");
                    irany = Console.ReadLine();

                    if (irany == "kelet")
                    {
                        aktSzoba = 2;
                    }
                    else 
                    {
                        aktSzoba = 4;
                    }                    
                }

                if (aktSzoba == 2)
                {
                    Console.Write("Beléptél a második szobába, innen kelet, dél felé tudsz menni: ");
                    irany = Console.ReadLine();

                    if (irany == "kelet")
                    {
                        aktSzoba = 3;
                    }
                    else if (irany == "dél")
                    {
                        aktSzoba = 4;
                    }
                    else if (irany == "vissza")
                    {
                        aktSzoba = 1;
                    }                    
                }

                if (aktSzoba == 3)
                {
                    Console.Write("Beléptél a harmadik szobába, innen délnyugat és dél felé tudsz menni: ");
                    irany = Console.ReadLine();

                    if (irany == "délnyugat")
                    {
                        aktSzoba = 4;
                    }
                    else if (irany == "dél")
                    {
                        aktSzoba = 5;
                    }                    
                    else if (irany == "vissza")
                    {
                        aktSzoba = 2;
                    }
                }

                if (aktSzoba == 5)
                {
                    Console.Write("Beléptél a kincses szobába és megtaláltad a kincset, csak vissza felé tudsz menni: ");
                    irany = Console.ReadLine();
                    kincs = true;
                    
                    if (irany == "vissza")
                    {
                        aktSzoba = 3;
                    }
                }
            }

            if (kincs)
            {
                Console.WriteLine("Sikerült kijutni a labirintuból!");
            }
            else
            {
                Console.WriteLine("Meghaltál!");
            }
        }
    }
}
