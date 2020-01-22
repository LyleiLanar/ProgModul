namespace Bankosdi
{
    class Ugyfel
    {

        public ATM Atm
        {
            get;
            set
            {
                if (Atm==null)
                {
                    new ATM();
                }
            }
        }
        public JUNIOR Junior { get; set; }
        public VISA Visa { get; set; }



    }
}
