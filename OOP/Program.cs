using KlassenbibliothekBeispiel;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Modul 06: OOP
            ////Deklarierung von Lebewesen-Variablen und Instanziierung von neuen Lebewesen-Objekten per Konstruktor
            //KlassenbibliothekBeispiel.Lebewesen lebewesen1;
            //lebewesen1 = new Lebewesen("Hugo Schmidt", "Pizza", new DateTime(2002, 2, 12), 185);
            //Lebewesen lebewesen2 = new Lebewesen("Bello", "Knochen", new DateTime(2020, 3, 15), 50);

            ////Lesezugriff auf Property per Getter
            //Console.WriteLine("Lebewesen1 heißt " + lebewesen1.Name);
            ////Schreibzugriff auf Property per Setter
            //lebewesen1.Name = "Anna Schmidt";

            //Console.WriteLine("Lebewesen1 heißt " + lebewesen1.Name);
            //Console.WriteLine("Lebewesen2 heißt " + lebewesen2.Name);

            //Console.WriteLine(lebewesen1.Geburtsdatum);
            //Console.WriteLine(lebewesen2.Alter);

            ////Aufruf von klasseneigenen Funktionen
            //lebewesen1.Wachse();
            //lebewesen2.Wachse();
            //Lebewesen kind = lebewesen1.ProduziereNachwuchs("Maria");

            ////Aufruf einer Property eines abhängigen Objekts
            //Console.WriteLine(lebewesen1.Geburtsdatum.Day);
            #endregion

            #region Modul 07: Statische Member und GC

            ////Variablendklaration
            //Lebewesen lebewesen;

            ////Schleife zur neubelegung der Variablen (um die GarbageCOllection zu demonstrieren)
            //for (int i = 0; i < 10; i++)
            //{
            //    //Neuzuweisung der Varablen (alte Objekte werden derefernziert -> Destruktor wird ausgeführt)
            //    lebewesen = new Lebewesen();
            //    lebewesen.Name = $"LW{i}";
            //}

            ////Manueller Aufruf der GC und Programmpause, bis alle Destruktoren beendet wurden
            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            ////Aufruf eines statischen Members der Person-Klasse
            //Console.WriteLine(Lebewesen.AnzahlLebewesen);
            //Lebewesen.ZeigeAnzahlLebewesen();

            #endregion

            #region Modul 08: Vererbung

            ////Instanziierung eines Objekts der vererbenden Klasse
            //Lebewesen lebewesen = new Lebewesen("Bello", "Fleisch", new DateTime(2007, 4, 23), 80);
            ////Instanziierung eines Objekts der abgeleiteten Klasse
            //Mensch mensch = new Mensch("Anna", "Meier", "Lasagne", new DateTime(1984, 5, 6), 189);

            ////Aufruf von Properties und Methoden, welche aus der Mutterklasse stammen
            //Console.WriteLine(mensch.Alter);
            //Console.WriteLine(mensch.Name);

            ////Aufruf einer Property der abgeleiteten Klasse
            //Console.WriteLine(mensch.Vorname);

            ////Ausgabe der (überschriebenen) ToString()-Methoden
            //Console.WriteLine(lebewesen);
            //Console.WriteLine(mensch);

            #endregion

            Lebewesen lebewesen;

            Mensch mensch = new Mensch("Anna", "Meier", "Lasagne", new DateTime(1984, 5, 6), 189);

            lebewesen = mensch;

            Console.WriteLine(mensch.Vorname);

            lebewesen.Wachse();

            ÄndereName(mensch, "Rainer");

            Console.WriteLine(lebewesen.GetType());

            if (lebewesen.GetType() == typeof(Mensch))
            { 
                mensch = (Mensch)lebewesen;
                Console.WriteLine(mensch.Vorname);

                Console.WriteLine(((Mensch)lebewesen).Vorname);
            }

            if(lebewesen is Mensch)
            {
                mensch = lebewesen as Mensch;
                Console.WriteLine(mensch.Vorname);

                Console.WriteLine((lebewesen as Mensch).Vorname);
            }

            Console.WriteLine(lebewesen.ToString());

            lebewesen.Essen();
        }

        public static void ÄndereName(Lebewesen lebewesen, string neuerName)
        {
            lebewesen.Name = neuerName;
        }
    }
}