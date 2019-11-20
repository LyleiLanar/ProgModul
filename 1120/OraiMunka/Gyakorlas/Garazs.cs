using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas
{
    class Garazs
    {
        private Auto[] auto;


        public Auto[] Auto 
        {
            get
            {
                return auto;
            } 
            
             set
            {
                if (value is Auto[])
                {
                    this.auto = value;
                }
                else
                {                    
                    this.auto = null;
                }
            }
            
        }

        public Garazs(int Merete)
        {
            auto = new Auto[Merete];
        }

        public override string ToString()
        {
            string allapot;

            if (Auto == null) 
            {
                allapot = "Nincs a garázsban autó."; 
            }
            else 
            { 
                allapot = Auto.ToString();             
            }
            return allapot;
        }

        //itt meg kellene oldani, az auto beparkolását.
        public void addAuto(Auto auto)
        {
            int i = 0;
            while (i<auto.)
            {

            }
            this.Auto = auto;
            Console.WriteLine($"A(z) {auto.Marka} beállt a gárázsba");
        }

    }
}
