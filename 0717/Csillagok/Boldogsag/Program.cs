using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boldogsag
{
    class Program
    {
        static void Main(string[] args)
        {
            int eletkor;           
            string orszag;
            string hazas;
            string gyermekek;
            double boldogsag;
            bool eletkorErv, orszagErv, hazasErv, gyermekekErv, boldogsagErv;

            do
            {

                Console.WriteLine("Kérem adja meg az életkorát (18-140, kötelező):");
                bool szam = int.TryParse(Console.ReadLine(), out eletkor);
                eletkorErv = szam && (eletkor >= 18 && eletkor < 140);

            } while (!eletkorErv);

            
            do
            {

                Console.WriteLine("Melyik országban lakik (szöveges, kötelező): ");
                orszag = Console.ReadLine();
                orszagErv = orszag != "";

            } while (!orszagErv);

            
            do
            {

                Console.WriteLine("Házas (Igen/nem, nem kötelező):");
                hazas = Console.ReadLine();
                hazasErv = hazas == "igen" || hazas == "nem" || hazas == "";

            } while (!hazasErv);

            if (hazas=="igen")
            {
                hazas = "I";
            }
            else if (hazas == "nem" )
            {
                hazas = "N";
            }
            else
            {
                hazas = "NA";
            }
            
            do
            {
                Console.WriteLine("Gyermekek száma (nem negatív egész szám, nem kötelező)");
                string szöveg = Console.ReadLine();
                bool szam = int.TryParse(szöveg, out gyermekek);

                gyermekekErv = gyermekek >= 0;
                gyermekek = szöveg == "" ? "NA" : gyermekek;
              
            } while (!gyermekekErv);

            //ezt be kell fejezni faszom


            Console.WriteLine($"{eletkor};{orszag};{hazas};{gyermekek}");
        }
    }
}
