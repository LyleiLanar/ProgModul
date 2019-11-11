namespace Mozi
{
    class Ulohely
    {
        public enum KATEGORIAK { szelso, kozepso, elso, hiba, ures }

        public KATEGORIAK Kategoria { get; }
        public int GetAr
        {
            get
            {
                switch (this.Kategoria)
                {
                    case KATEGORIAK.elso:
                        return 1800;

                    case KATEGORIAK.kozepso:
                        return 4300;

                    case KATEGORIAK.szelso:
                        return 2200;

                    case KATEGORIAK.ures:
                        return 0;

                    default:
                        return -1;
                }
            }
        }
        public bool Foglalt { get; }
        public Ulohely(char ulohely)
        {
            switch (ulohely)
            {
                case 's':
                    Kategoria = KATEGORIAK.szelso;
                    Foglalt = true;
                    break;

                case 'k':
                    Kategoria = KATEGORIAK.kozepso;
                    Foglalt = true;
                    break;

                case 'e':
                    Kategoria = KATEGORIAK.elso;
                    Foglalt = true;
                    break;

                case '#':
                    Kategoria = KATEGORIAK.ures;
                    Foglalt = false;
                    break;
                    
                default:
                    Kategoria = KATEGORIAK.hiba;
                    Foglalt = false;
                    break;
            }
        }


        public char GetSzimbolum()
        {
            if (this.Foglalt)
            {
                switch (this.Kategoria)
                {
                    case KATEGORIAK.szelso:
                        return 's';

                    case KATEGORIAK.kozepso:
                        return 'k';

                    case KATEGORIAK.elso:
                        return 'e';
                    default:
                        return '!';
                }
            }
            else
            {
                return '.';
            }
            
        }

    }
}
