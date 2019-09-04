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
            double súly;
            double magassag;
            string ujra;

            do
            {

                do
                {
                    Console.WriteLine("Add meg a testsúlyodat (kg): ");
                    súly = Convert.ToDouble(Console.ReadLine());
                } while (!(súly > 20 && súly < 300));

                do
                {
                    Console.WriteLine("Add meg a magasságodat (m): ");
                    magassag = Convert.ToDouble(Console.ReadLine());
                } while (!(magassag > 1.0 && magassag < 2.4));

                double bmi = súly / (magassag * magassag);
                string ertekeles;

                if (bmi < 16)
                {
                    ertekeles = "súlyos soványság";
                }
                else if (bmi < 17)
                {
                    ertekeles = "mérsékelt soványság";
                }

                else if (bmi < 18.5)
                {
                    ertekeles = "enyhe soványság";
                }

                else if (bmi < 25)
                {
                    ertekeles = "normális testsúly";
                }

                else if (bmi < 30)
                {
                    ertekeles = "túlsúlyos";
                }

                else if (bmi < 35)
                {
                    ertekeles = "I. fokú elhízás";
                }

                else if (bmi < 40)
                {
                    ertekeles = "II. fokú elhízás";
                }

                else
                {
                    ertekeles = "III. fokú elhízás";
                }

                Console.WriteLine($"A testtömegindexed: {bmi:N2}. Ez {ertekeles}.");
                Console.WriteLine();

                do
                {
                    Console.Write("Akarsz még egy menetet\n(i)gen/(n)em: ");
                    ujra = Console.ReadLine();
                } while (!(ujra=="i" || ujra =="n"));

            } while (ujra=="i");
        }
    }
}
