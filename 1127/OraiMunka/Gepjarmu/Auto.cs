using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepjarmu
{
    class Auto : Jarmu
    {
        
        public string Rendszam { get; }
        public bool Benzin { get; set; }

        public Auto(string szin, string tulaj, string rendszam):base(szin,tulaj)
        {
            Rendszam = rendszam;
            Benzin = true;
        }

        public override void Megy()
        {
            if (Benzin && IsGumiJo())
            {
                Console.WriteLine($"Megy az auto ({Rendszam})!");
                Benzin = false;
            }
            else
            {
                string s="";
                if (!Benzin)
                {
                    s = $"Elfogyott a benzin! ";
                }
                if (!IsGumiJo())
                {
                    s += $"Defekt!";
                }

                Console.WriteLine(s+ "(" + Rendszam + ")");
            }            
        }
        public void Tankol()
        {
            Benzin = true;
        }
        public override string ToString()
        {
            string str = base.ToString();
            return $"<{str}, {Rendszam}>";
        }
    }
}
