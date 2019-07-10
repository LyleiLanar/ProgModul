using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarkanyokFejei
{
    class Program
    {
        static void Main(string[] args)
        {
            //7 fejű sárkányok
            //11 fejű sárkányok
            //145 fej

            Console.Write("Add meg a fejek számát: ");
            int fejek = Convert.ToInt32(Console.ReadLine());            

            for (int hetF = 0; hetF < (fejek-11)/7; hetF++)
            {
                for (int tizenegyF = 0; tizenegyF < (fejek - 7) / 11; tizenegyF++)
                {
                    if (7*hetF + 11* tizenegyF == fejek )
                    {
                        Console.WriteLine($"{hetF} hétfejű, {tizenegyF} tizenegyfejű");                        
                    }
                }
            }            
        }
    }
}
