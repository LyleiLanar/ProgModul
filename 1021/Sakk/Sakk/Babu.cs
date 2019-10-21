using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakk
{
   abstract class Babu
    {
        public enum Szin{RED, BLUE};

        private Szin szin;
        private char jel;

        public Szin GetSzint()
        {
            return this.szin;
        }
        public char GetJel()
        {
            return this.jel;
        }

        public Babu(Szin szin, char jel)
        {
            this.szin = szin;
            this.jel = jel;
        }

        public override string ToString()
        {
            return $"<{this.szin};{this.jel}>";
        }

        public void Megjelenit()
        {
            Console.ForegroundColor = szin == Szin.RED ? ConsoleColor.DarkRed : ConsoleColor.DarkBlue;
            Console.Write(this.jel);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public abstract bool Lepes(Koord honnan, Koord hova);
        
    }
}
