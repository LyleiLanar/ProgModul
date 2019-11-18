using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Etterem
{
    class Etterem
    {

        public List<Asztal> Asztalok { get; }
        public Dictionary<string,int> Etlap { get; }

        public Etterem()
        {
            string[] etelekInput = File.ReadAllLines("etelek.txt", Encoding.Default);
            string[] asztalokInput = File.ReadAllLines("asztalok.txt", Encoding.Default);
            

            Etlap = new Dictionary<string, int>();
            Asztalok = new List<Asztal>();

            foreach (string item in etelekInput)
            {
                Etlap.Add(new Etel(item).Nev, new Etel(item).Ar);
            }


            bool ujAsztal = true;
            int aktAsztal = 0;

            foreach (string item in asztalokInput)
            {
                if (ujAsztal)
                {
                    Asztalok.Add(new Asztal(item));
                    ujAsztal = false;
                }
                else
                {
                    if (item == "")
                    {
                        ujAsztal = true;
                        aktAsztal++;
                    }
                    else
                    {
                        Asztalok[aktAsztal].UjEtel(new Etel(item, Etlap[item]));
                    }
                }
            }
        }

        public void Kiir()
        {
            int sorhossz = 30; 
            foreach (Asztal item in Asztalok)
            {
                Console.WriteLine($"{item.Szin} asztal");
                Console.WriteLine(Vonal('=', sorhossz));
                item.Kiir();
                Console.WriteLine(Vonal('_',sorhossz));
                Console.Write($"Fizetendő: ");
                Console.WriteLine($"{item.TeljesOsszeg(),11} Ft");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        private string Vonal(char jel,int hossz)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hossz; i++)
            {
                sb.Append(jel);
            }
            return sb.ToString();
        }        
        public void AddAsztal(string szin)
        {
            this.Asztalok.Add(new Asztal(szin));
        }
        public void EtelRendeles(string asztal, string etelNeve)
        {
            int i = 0;
            while (i<Asztalok.Count && !(Asztalok[i].Szin == asztal))
            {
                i++;
            }
            if (i < Asztalok.Count)
            {
                try
                {
                    this.Asztalok[i].UjEtel(new Etel(etelNeve, Etlap[etelNeve]));
                }
                catch (System.Collections.Generic.KeyNotFoundException)
                {
                    //ilyenkor nem ad hozzá semmit
                    ;                   
                }
           
            }
            else
            {
                Console.WriteLine("Nincs ilyen étel!!!");
            }
        }
    }
}
