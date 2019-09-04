using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI index kiszámítása");
            int magassag = bekeres("Testmagassag (cm) [100; 200]: ",100,200);
            int tomeg = bekeres("Testtomeg (kg) [40; 150]: ",40,150);

            eredmenyKiirasa(magassag,tomeg);
        }

        private static void eredmenyKiirasa(int magassag, int tomeg)
        {
            double bmi = bmiCalculator(magassag, tomeg);
            string eredmeny = bmiKiertekeles(bmi);

            Console.WriteLine($"Ön {magassag} cm magas és {tomeg} kg tömegű,\nígy BMI indexe {bmi:N1},\nTehát ön {eredmeny}.");
        }

        private static string bmiKiertekeles(double bmi)
        {
            if (bmi<20)
            {
                return "sovány";
            }
            else if (bmi<25)
            {
                return "normál";
            }
            else if (bmi<30)
            {
                return "túlsúlyos";
            }
            else
            {
                return "elhízott";
            }
            
        }

        private static double bmiCalculator(int magassag, int tomeg)
        {
            return tomeg / Math.Pow(magassag/100.0,2);
        }

        private static int bekeres(string szoveg, int alsoIntervallum, int felsőIntervallum)
        {
            
            bool megfelelo = false;
            int ertek;

            do
            {
                Console.Write(szoveg);
                Int32.TryParse(Console.ReadLine(), out ertek);
                if (ertek>=alsoIntervallum && ertek < felsőIntervallum)
                {
                    megfelelo = true;
                }

            } while (!megfelelo);

            return ertek;
        }


    }
}
