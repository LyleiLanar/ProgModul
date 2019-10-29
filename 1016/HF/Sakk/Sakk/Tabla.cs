using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakk
{
    class Tabla
    {
        private int[,] Mezok;

        public Tabla()
        {
            this.Mezok = new int[8,8];
        }

        public void Kiir()
        {
            for (int i = 0; i < Mezok.GetLength(0); i++)
            {
                for (int j = 0; j < Mezok.GetLength(1); j++)
                {
                    Console.Write(". ");
                }
                Console.WriteLine();
            }
        }
    }
}
