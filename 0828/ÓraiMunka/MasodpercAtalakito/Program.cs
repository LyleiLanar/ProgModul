using System;

namespace MasodpercAtalakito
{
    class Program
    {
        static void Main(string[] args)
        {
            // egy másodperc értékről váltson vissza óra:perc:másodperc értékre.

            Console.WriteLine(TimeFromSec(1250000));
            Console.WriteLine(TimeToSec(1,1,1));
        }

        static int TimeToSec(int hours, int minutes, int secunds)
        {
            return hours * 3600 + minutes * 60 + secunds;
        }

        static string TimeFromSec(int secunds)
        {
            int minutes = secunds / 60;
            secunds %= 60;

            int hours = minutes / 60;
            minutes %= 60;

            int days = hours / 24;
            hours %= 24;

            return $"{secunds:D2} nap {hours:D2}:{minutes:D2}:{secunds:D2}";
        }


    }
}
