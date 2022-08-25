using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenbibliothekBeispiel
{
    public class Mensch : Lebewesen
    {
        public string Vorname { get; set; }

        public Mensch(string vorname, string name, string lieblingsnahrung, DateTime geburtstag, int größe) : base(name, lieblingsnahrung, geburtstag, größe)
        {
            this.Vorname = vorname;
        }

        public override string ToString()
        {
            return this.Vorname + " " + base.ToString();
        }

        public override void Wachse()
        {
            this.Größe += 10;
        }
    }
}
