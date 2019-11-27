using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepjarmu
{
    class Bicikli : Jarmu
    {

        public Bicikli(string szin, string tulaj): base(szin,tulaj)
        {
            ;
        }

        public override void Megy()
        {
            if (IsGumiJo())
            {
                Console.WriteLine("Megy a bicikli!"); 
            }
        }
        public override string ToString()
        {
            string str = base.ToString();
            return $"<{str}>";
        }

    }
}
