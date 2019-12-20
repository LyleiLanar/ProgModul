using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotesek
{
    class PrivateClass:A
    {        

        /* egy statikus metódussal tudunk létrehozni új példányt, mert a konstruktor nem látható. Ez itt az Object Factory!!!
         * Ez arra jó, hogy mivel private az egyetlen konstruktor, ezért nem lehet leszármazottat létrehozni belőle, mert nem tudja
         * a kis bogárka a kondstruktorláncot felépíteni.
         * Ha a célunk az öröklés lezárása, akkor a sealed kulcsszó is elég az osztály mellé
         */
        static public PrivateClass Create(int aValue)
        {
            return new PrivateClass(aValue);
        }

        private PrivateClass()
        {
            ;
        }

        private PrivateClass(int aValue)
        {
            AValue = aValue;
        }
    }
}
