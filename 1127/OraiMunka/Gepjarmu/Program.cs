using System;

namespace Gepjarmu
{
    class Program
    {

        //tartalmazáshoz
        static public Jarmu[] jarmuvek = 
            {
                new Auto("Piros", "Mari", "HJK-487"),
                new Auto("Kék", "Jani", "FGH-745"),
                new Auto("Fehér", "Feri", "DER-111"),
                new Bicikli("Piros", "Sári"),
                new Bicikli("Lila", "Margit")
            };


        static void Main(string[] args)
        {


            jarmuvek[0].Defect();
            jarmuvek[2].Megy();

            Console.WriteLine("*********  INDUL A VERSENY  *********");
            foreach (Jarmu item in jarmuvek)
            {
                //item.Kiir();
                if (item is Auto)
                {
                    ((Auto)item).Tankol();
                    item.Megy();
                }
            }

            Console.ReadLine();
        }
    }
}

