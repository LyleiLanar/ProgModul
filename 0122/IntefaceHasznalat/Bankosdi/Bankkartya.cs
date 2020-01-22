using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankosdi
{
    abstract class Bankkartya
    {
        public int Valuta { get; set; }
    }

    class ATM: Bankkartya
    {

    }

    class VISA : Bankkartya
    {

    }

    class JUNIOR : Bankkartya
    {

    }
}
