﻿namespace Taschenrechner
{
    internal class Program
    {
        //Enum-Definition
        enum Rechenoperation { Addition = 1, Subtraktion, Multiplikation, Division }

        static void Main(string[] args)
        {
            //Schleife für Programm-Wiederholung
            do
            {
                //Löschen der Konsole
                Console.Clear();

                //Eingabe und Parsing der ersten Zahl (siehe Funktion unten)
                double zahl1 = Eingabe("Gib eine Zahl ein: ");

                //Eingabe und Parsing der zweiten Zahl
                double zahl2 = Eingabe("Gib eine weitere Zahl ein: ");

                //Anzeige der möglichen Rechenoperationen
                Console.WriteLine("\nWähle eine Rechenoperation:");
                for (int i = 1; i <= Enum.GetValues(typeof(Rechenoperation)).Length; i++)
                {
                    Console.WriteLine($"{i}: {(Rechenoperation)i}");
                }

                //Abfrage der Benutzereingabe
                Rechenoperation operation = (Rechenoperation)Eingabe("Auswahl: ");

                //Deklaration und Initialisierung der Ergebnisvariablen
                double ergebnis = Berechne(zahl1, zahl2, operation, out string symbol);

                //Aufruf der Ausgabe-Funktion
                Ausgabe(zahl1, zahl2, symbol, ergebnis);

                //Frage nach der Wiederholung des Programms
                Console.WriteLine("\nWiederholen? (Y/N) ");
                //Schleifenbedingungsprüfung anhand Tastendruck des Benutzers
            } while (Console.ReadKey(true).Key == ConsoleKey.Y);
        }

        //Funktion zur Eingabe, Prüfung und Parsing
        static double Eingabe(string anweisung)
        {
            double zahl;
            //Schleife für Wiederholung bei fehlgeschlagenem Parsing
            do
                //Ausgabe der Eingabe-Anweisung
                Console.Write(anweisung);
            //Schleifenbedingung mit Eingabe und Parsing
            while (!double.TryParse(Console.ReadLine(), out zahl));
            //Rückgabe des geparsten Werts
            return zahl;
        }

        static void Ausgabe(double zahl1, double zahl2, string symbol, double ergebnis)
        {
            //Prüfung, ob Ergebnis = Double.NaN (= Rechenoperation wurde falsch eingegeben)
            if (ergebnis.Equals(double.NaN))
                Console.WriteLine("\nFehlerhafte Eingabe der Rechenoperation");
            //Prüfung, ob Ergebnis = Infinity (= versuchte Teilung durch 0)
            else if (ergebnis == double.PositiveInfinity || ergebnis == double.NegativeInfinity)
                Console.WriteLine("\nEine Teilung durch 0 ist nicht möglich");
            else
                //Ausgabe des Ergebnisses
                Console.WriteLine($"\nErgebnis: {zahl1} {symbol} {zahl2} = {ergebnis}");
        }

        static double Berechne(double z1, double z2, Rechenoperation o, out string symbol)
        {
            symbol = "";

            //Switch zur Auswahl der Rechenoperation
            switch (o)
            {
                //Berechnung des Ergebnisses
                case Rechenoperation.Addition:
                    symbol = "+";
                    return z1 + z2;
                case Rechenoperation.Subtraktion:
                    symbol = "-";
                    return z1 - z2;
                case Rechenoperation.Multiplikation:
                    symbol = "*";
                    return z1 * z2;
                case Rechenoperation.Division:
                    symbol = "/";
                    return z1 / z2;
                default:
                    return double.NaN;
            }
        }
    }
}
