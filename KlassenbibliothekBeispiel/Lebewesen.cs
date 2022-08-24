namespace KlassenbibliothekBeispiel
{
    public class Lebewesen
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 0)
                    name = value;
            }
        }

        public string Lieblingsnahrung { get; set; }

        public DateTime Geburtsdatum { get; private set; }

        public int Alter
        {
            get { return ((DateTime.Now - this.Geburtsdatum).Days / 365); }
        }

        public int Größe { get; set; }

        public Lebewesen(string name, string nahrung, DateTime geburtsdatum, int größe)
        {
            this.name = name;
            this.Lieblingsnahrung = nahrung;
            this.Geburtsdatum = geburtsdatum;
            this.Größe = größe;
        }

        public void Wachse()
        {
            this.Größe += 5;
        }

        public Lebewesen ProduziereNachwuchs(string kindname)
        {
            return new Lebewesen(kindname, "Muttermilch", DateTime.Now, 30);
        }

    }
}