using KlassenbibliothekBeispiel;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlassenbibliothekBeispiel.Lebewesen lebewesen1;

            lebewesen1 = new Lebewesen("Hugo Schmidt", "Spagetti", new DateTime(2002, 2, 12), 185);
            Lebewesen lebewesen2 = new Lebewesen("Bello", "Knochen", new DateTime(2020, 12, 24), 50);

            Console.WriteLine(lebewesen1.Name);
            lebewesen1.Name = "Anna Schmidt";

            Console.WriteLine(lebewesen1.Name);
            Console.WriteLine(lebewesen2.Name);

            Console.WriteLine(lebewesen1.Geburtsdatum);
            Console.WriteLine(lebewesen1.Alter);

            Console.WriteLine(lebewesen1.Größe);
            lebewesen1.Wachse();
            Console.WriteLine(lebewesen1.Größe);

            Lebewesen kind = lebewesen1.ProduziereNachwuchs("Maria Schmidt");
        }
    }
}