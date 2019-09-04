using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusvetTanar
{
    class Program
    {
        static void Main(string[] args)
        {

            const int KEZDO_EV = 1900;
            const int VEGZO_EV = 2099;
            Console.Write($"Év ({KEZDO_EV}..{VEGZO_EV}): ");
            int ev = Convert.ToInt32(Console.ReadLine());
            if (ev >= KEZDO_EV && ev <= VEGZO_EV)
            {
                int a = ev % 19;
                int b = ev % 4;
                int c = ev % 7;

                const int M = 24;
                const int N = 5;
                int d = (19 * a + M) % 30;
                int e = (2 * b + 4 * c + 6 * d + N) % 7;

                if (d + e < 10)
                {
                    Console.WriteLine($"március {d + e + 22}. napja volt húsvét vasárnap!");
                }
                else
                {

                    int nap = d + e - 9;
                    switch (nap)
                    {
                        case 26:
                            Console.WriteLine($"április 19. napja volt húsvét vasárnap!");//2071 
                            break;
                        case 25:
                            if (d == 28 && e == 6 && a > 10)
                            {
                                Console.WriteLine($"április 18. napja volt húsvét vasárnap!");//2049 
                            }
                            else
                            {
                                Console.WriteLine($"április {nap}. napja volt húsvét vasárnap!");
                            }
                            break;
                        default:
                            Console.WriteLine($"április {nap}. napja volt húsvét vasárnap!");
                            break;

                    }
                }
            }
            else
            {
                Console.WriteLine($"A program csak {KEZDO_EV}..{VEGZO_EV} intrvallumban dolgozik!");
            }

            Console.ReadLine();
        }
    }
}
