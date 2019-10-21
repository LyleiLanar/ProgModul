using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakk
{
    class Jatek
    {
        private Tabla jatekTabla;

        public void Teszt()
        {
            jatekTabla = new Tabla();

            jatekTabla.Lerak(new Kiraly(Babu.Szin.RED), new Koord(1, 7));
            Console.WriteLine();
            jatekTabla.Megjelenit();
            Console.ReadLine();
            Console.Clear();
            
            jatekTabla.Mozgat(new Koord(1, 7), new Koord(-1, 1));
            Console.WriteLine();
            jatekTabla.Megjelenit();
        }

    }
}
