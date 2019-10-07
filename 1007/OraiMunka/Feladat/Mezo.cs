namespace Feladat
{
    class Mezo
    {
        public enum MezoErtek
        {
            O, X, URES
        }

        private MezoErtek mezoTipus;

        public Mezo(string szimbolum)
        {
            switch (szimbolum)
            {
                case "X":
                    this.mezoTipus = Mezo.MezoErtek.X;
                    break;
                case "O":
                    this.mezoTipus = Mezo.MezoErtek.O;
                    break;
                default:
                    this.mezoTipus = Mezo.MezoErtek.URES;
                    break;
            }
        }
        public MezoErtek MezoTipus
        {
            get { return mezoTipus; }
            set { mezoTipus = value; }
        }

        public override string ToString()
        {
            switch (this.mezoTipus)
            {
                case Mezo.MezoErtek.X:
                    return "X";
                    
                case Mezo.MezoErtek.O:
                    return "O";
                    
                default:
                    return " ";
                    
            }            
        }

    }
}
