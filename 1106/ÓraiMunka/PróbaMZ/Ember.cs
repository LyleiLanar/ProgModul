namespace PróbaMZ
{
    class Ember
    {
        public enum csAllapot { igen, nem, ismeretlen, hiba }

        public string nev { get; }
        public int kor { get; }
        public string telepules { get; }
        public csAllapot hazas { get; }

        public Ember(string entity)
        {
            string[] adat = entity.Split('-');
            this.nev = adat[0];

            this.kor = int.Parse(adat[1]);

            this.telepules = adat[2];

            if (adat.Length == 4)
            {
                switch (adat[3])
                {
                    case "true":
                        this.hazas = csAllapot.igen;
                        break;

                    case "false":
                        this.hazas = csAllapot.nem;
                        break;

                    default:
                        this.hazas = csAllapot.hiba;
                        break;
                }
            }
            else
            {
                this.hazas = csAllapot.ismeretlen;
            }
        }

        public override string ToString()
        {
            return $"<{nev},{kor},{telepules},{hazas}>";
        }

    }
}
