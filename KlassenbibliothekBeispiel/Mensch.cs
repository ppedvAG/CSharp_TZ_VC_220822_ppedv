using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenbibliothekBeispiel
{
    //Mensch erbt mittels des :-Zeichens von der Lebewesen-Klasse und übernimmt somit alle Eigenschaften und Methoden von dieser.
    public class Mensch : Lebewesen, IArbeitend, ICloneable
    {
        //Zusätzliche Mensch-eigene Eigenschaften
        public string Vorname { get; set; }
        
        //Mensch-Konstruktor, welcher per BASE-Stichwort den Konstruktor der Personklasse aufruft. Dieser erstellt dann ein Lebewesen, gibt diese
        ///an diesen Konstruktor zurück, welcher dann die zusätzlichen Eigenschaften einfügt
        public Mensch(string vorname, string nachname, string lieblingsnahrung, DateTime geburtsdatum, int größe) : base(nachname, lieblingsnahrung, geburtsdatum, größe)
        {
            this.Vorname = vorname;
        }

        //Mittels OVERRIDE können Methoden der Mutterklassen, welche mit VIRTUAL markiert sind, überschrieben werden. Bei Aufruf wird die neue Methode ausgeführt.
        //Mittels BASE kann ein Rückbezug zur nächst-höheren Klasse hergestellt werden.
        //Mit SEALED kann eine Überschreibung durch Kindklassen verindert werden.
        public sealed override string ToString()
        {
            return $"Der Mensch {this.Vorname} " + base.ToString();
        }

        public override void Wachse()
        {
            this.Größe += 10;
        }

        //Durch Mutterklasse erzwungene (weil dort abstrakte) Methode
        public override void Essen()
        {
            Console.WriteLine($"{this.Vorname} konsumiert {this.Lieblingsnahrung}.");
        }

        public int Gehalt { get; set; } = 3600;
        public string Job { get; set; } = "Marketingchef";

        public void Auszahlung()
        {
            Console.WriteLine($"{this.Name} hat für den Job als {this.Job} {this.Gehalt}€ erhalten.");
        }

        public object Clone()
        {
            Mensch mensch = (Mensch)this.MemberwiseClone();

            mensch.Geburtsdatum = new DateTime(this.Geburtsdatum.Year, this.Geburtsdatum.Month, this.Geburtsdatum.Day);

            return mensch;
        }
    }
}
