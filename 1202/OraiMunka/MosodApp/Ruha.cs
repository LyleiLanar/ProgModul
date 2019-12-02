using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosodApp
{
    class Ruha
    {
        
        public string Tulaj { get; private set; }
        public bool Tiszta { get; private set; }

        public Ruha(string tulaj, bool tiszta)
        {
            Tulaj = tulaj;
            Tiszta = tiszta;

        }

        public virtual void Kimosva()
        {
            this.Tiszta = true;            
        }
        public void Hord()
        {
            this.Tiszta = false;
        }
        public override string ToString()
        {
            string s = (Tiszta ? "Tiszta" : "Koszos");
            return $"<Ruha: {Tulaj}|{s}>";
        }
    }
}
