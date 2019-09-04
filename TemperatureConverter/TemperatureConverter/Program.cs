using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérlek add meg a hőmérsékletet: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérlek add meg a mértékegységet (°C)elsius, (°F)ahrenheit: ");
            string tempType = Console.ReadLine();

            switch (tempType)
            {
                case "C":
                    Console.WriteLine("A hőmérséklet {0:N2} °F", CelsiusToFahrenheit(temperature));
                    break;
                case "F":
                    Console.WriteLine("A hőmérséklet {0:N2} °C", FahrenheitToCelsius(temperature));
                    break;
                default:
                    Console.WriteLine("Nem megfelelő a mértékegység, amit megadtál!!!");
                    break;
            }
        }

        static double CelsiusToFahrenheit(double temperature)
        {
            //°F = °C * 9/5 + 3
            return (double)(temperature * (9.0 / 5.0) + 32);
        }

        static double FahrenheitToCelsius(double temperature)
        {
            //°C = (°F - 32) * 5/9
            return (double)((temperature -32) * (5.0 / 9.0));
        }
    }
}
