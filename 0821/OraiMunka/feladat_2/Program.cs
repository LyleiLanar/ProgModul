using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            double szazalek;
            int dontes;

            int elsoSzam;
            int masodikSzam;
            string eredmenyValasz;
            int joEredmeny;
            int szamlaloHelyes = 0;
            int szamlaloHelytelen = 0;
            string valasz;
            int InteredmenyValasz;
            
            int ciklus;

            int szam1, szam2, csere, valasz, eredmeny;
            int pld = 0;
            int joMeg = 0;
                

            
            bool rosszSzampar = true;
            int tipp = -1;


            Console.WriteLine("Válasz ki mivel szeretnél játszani?");
            Console.WriteLine("|| Összeadás(1) || Kivonás(2) || Szorzás(3) || Osztás(4) || Kilépés(5) ||");
            int.TryParse(Console.ReadLine(), out dontes);


            switch (dontes)
            {
                case 1://Összeadás


                    Console.WriteLine("Összadást szeretnél gyakorolni? i/n, v-re visszalép");
                    valasz = Console.ReadLine();
                    int.TryParse(valasz, out ciklus);

                    while (valasz == "i")
                    {
                        elsoSzam = rnd.Next(0, 101);
                        masodikSzam = rnd.Next(0, 100 - elsoSzam);
                        joEredmeny = elsoSzam + masodikSzam;

                        Console.WriteLine($"Mennyi {elsoSzam}+{masodikSzam} = __ ?");
                        eredmenyValasz = Console.ReadLine();

                        InteredmenyValasz = Convert.ToInt32(eredmenyValasz);
                        if (InteredmenyValasz == joEredmeny)
                        {
                            szamlaloHelyes++;
                            Console.WriteLine("Helyes megoldas!");
                        }
                        else
                        {
                            Console.WriteLine("Helytelen megoldas");
                            szamlaloHelytelen++;
                        }

                        Console.WriteLine("Összadást szeretnél gyakorolni? i/n, v-re visszalép");
                        valasz = Console.ReadLine();

                        if (valasz != "i")
                        {
                            break;
                        }
                    }


                    //statisztika
                    Console.WriteLine($"szamlaloHelyes: {szamlaloHelyes}");
                    Console.WriteLine($"szamlaloHelytelen: {szamlaloHelytelen}");
                    Console.WriteLine($"Összesen { szamlaloHelyes + szamlaloHelytelen} db feladatot oldottál meg.");
                    Console.WriteLine($"Ebből {szamlaloHelyes / (szamlaloHelyes + szamlaloHelytelen + 1) * 100} % volt helyes.");

                    Console.ReadLine();


                    break;
                case 2://Kivonás


                    //do
                    //{
                    szam1 = rnd.Next(1, 101);
                    szam2 = rnd.Next(1, 101);

                    if (szam1 > szam2)
                    {
                        csere = szam1;
                        szam1 = szam2;
                        szam2 = csere;
                    }

                    Console.WriteLine("Kivonás gyakorlás:");
                    Console.Write($"Mennyi {szam2} - {szam1}? ");
                    //valasz = Convert.ToInt32(Console.ReadLine());
                    int.TryParse(Console.ReadLine(), out valasz);
                    pld++;
                    eredmeny = szam2 - szam1;

                    if (eredmeny == valasz)
                    {
                        Console.WriteLine("Helyes megoldás");
                        joMeg++;
                    }
                    else
                    {
                        Console.WriteLine($"Rossz megoldás");
                    }



                    //Console.WriteLine("Ha akarsz még egy feladatot nyomd meg az \"i\" betűt");
                    //char.TryParse(Console.ReadLine(), out ujra);


                    //} while (ujra=='i');
                    //Console.WriteLine($"Példák száma: {pld}, Jó megoldás: {joMeg}");

                    Console.ReadLine();


                    break;
                case 3://Szorzás


                    int tenyezo1;
                    int tenyezo2;
                    int bekert;
                    do
                    {
                        tenyezo1 = rnd.Next(2, 51);
                        tenyezo2 = rnd.Next(2, 51);

                    } while (tenyezo1 * tenyezo2 > 100);

                    Console.Write($"{tenyezo1} * {tenyezo2} = ");
                    int.TryParse(Console.ReadLine(), out bekert);
                    if (bekert == tenyezo1 * tenyezo2)
                    {
                        Console.WriteLine("Helyes megoldás");
                        pld++;
                        joMeg++;
                    }
                    else
                    {
                        Console.WriteLine("Rossz megoldás");
                        pld++;
                    }
            

            break;
                case 4://Osztás
                  
                    
                    pld++;

                    //számpár generálása
                    do
                    {
                        szam1 = rnd.Next(1, 101);
                        szam2 = rnd.Next(1, 101);

                        if (szam1 % szam2 == 0)
                        {
                            rosszSzampar = false;
                        }

                    } while (rosszSzampar);

                    Console.Write($"Mennyi {szam1} és {szam2} hányadosa?: ");

                    int.TryParse(Console.ReadLine(), out tipp);

                    if (tipp == szam1 / szam2)
                    {
                        Console.WriteLine("Helyes megoldás!");
                        joMeg++;
                    }
                    else
                    {
                        Console.WriteLine("Rossz megoldás!");
                    }
                    //Console.WriteLine(pld);
                    //Console.WriteLine(joMeg);
                    break;

                case 5:
                    Console.WriteLine($"Az eredményed: {pld} / {joMeg}");
                    Console.WriteLine($"   {szazalek = joMeg / pld * 100}%");
                    break;
            }
            // osztás




        }
    }
}

                   
                


            
        //összeadás

        /*4 alapmuveletet gyakoroltató program: 
         * összeadás 0 és 50  
         * szorzás osztás kivonás
         mindegyik feladatot a 100-as tartományban kell megcsinálni 0-100 közötti eredménynek kell lenni
         user tudjon egy menüből választani, hogy melyik alapműveletet szeretné gyakorolni
         A program az adott témakörben legenerál egy feladatot, 

        kiiírja

        kérjük be az eredményt, mondjuk meg h helyes-e vagy sem

        kilépésnél mondjuk meg, hogy hány feladatot oldott meg és hány százalékos volt az eredménye
        pl 4 feladatot oldott meg
         */
        



        //Kivonás

        //char ujra;

        

        //szorzás 

       

                //szorzás vége

                
                
        





        //Osztás művelet megoldása
        
