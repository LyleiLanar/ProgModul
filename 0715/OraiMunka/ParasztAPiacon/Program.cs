using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParasztAPiacon
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 100 arany 100 db állat
             * minden állatból akar venni egyet
             * sertés 3,5
             * kecske 1,3
             * juh 0,5
             */
            double gazdaPenz = 100;
            double sertesAr = 3.5;
            double kecskeAr = 4.0/3.0 ;
            double juhAr = 0.5;
            double allatokSzama = 100;

            int eredmeny = 0;
            int futas = 0;

            for (int sertes = 1; sertes < (int)(gazdaPenz - (kecskeAr + juhAr)) / sertesAr; sertes++)
            {
                for (int kecske = 1; kecske < (int)(gazdaPenz - (sertesAr + juhAr)) / kecskeAr; kecske++)
                {
                    for (int juh = 1; juh < (int)(gazdaPenz - (sertesAr + kecskeAr)) / juhAr; juh++)
                    {
                        if (((sertes + juh + kecske) == allatokSzama)
                            && ((sertes * sertesAr + kecske * kecskeAr + juh * juhAr) == gazdaPenz))
                        { 
                            eredmeny++;
                        }

                        futas++;
                    }
                }
            }
            Console.WriteLine(eredmeny);
            Console.WriteLine(futas);
        }
    }
}
