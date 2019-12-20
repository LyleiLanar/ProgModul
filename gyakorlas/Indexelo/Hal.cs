using System;

namespace Indexelo
{
    class Hal
    {
        protected double suly;
        public double Suly
        {
            get { return suly; }
            set
            {
                if (value < 0 || value > 50.0) throw new ArgumentException("Nem megfelelő a hal súlya!");
                else suly = value;
            }
        }
    
        public Hal(double suly)
        {
            this.suly = suly;
        }
    }
}
