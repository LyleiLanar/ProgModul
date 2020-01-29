using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCloneable
{
    class Pontleiras
    {
        public Pontleiras(string nev)
        {
            Nev = nev;
            Id = Guid.NewGuid();
        }

        public string Nev { get; set; }
        public Guid Id { get; set; }

    }
}
