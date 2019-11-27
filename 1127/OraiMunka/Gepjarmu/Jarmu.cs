using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepjarmu
{
    abstract class Jarmu
    {
        public string Szin { get;  }
        public string Tulaj { get;  }
        public bool GumiJo { get; set; }

        public bool IsGumiJo()
        {
            return this.GumiJo;
        }

        protected Jarmu(string szin, string tulaj)
        {
            Szin = szin;
            Tulaj = tulaj;
            GumiJo = true;
        }

        abstract public void Megy();
        public void Defect() 
        {
            GumiJo = false;
        }
        public void KerekCsere()
        {
            this.GumiJo = true;
        }
        public override string ToString()
        {
            return $"{Szin}, {Tulaj}";
        }
        public void Kiir()
        {
            Console.WriteLine(this);
        }
    }
}
