namespace Schleifen_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 10;

            while (a < b)
            {
                Console.WriteLine("A ist kleiner als B");

                a++;

                if (a == 5)
                    break;
            }

            Console.WriteLine("Ende der Schleife");

            a = -45;

            do
            {
                Console.WriteLine(a);

                a--;

                continue;

            } while (a > 0);


            for (int index = 0; index < 10; index += 2)
            {
                Console.WriteLine(index);

                index++;
            }

            int[] zahlen = { 2, 4, 5, 12, 67, 99 };
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]);
            }

            foreach (var item in zahlen)
            {
                Console.WriteLine(item);
            }


            Wochentag heutigerTag = Wochentag.Dienstag;
            Console.WriteLine($"Heute ist also {heutigerTag}.");

            Console.WriteLine("Was ist dein Lieblingswochentag?");
            for (int i = 1; i <= Enum.GetValues(typeof(Wochentag)).Length; i++)
            {
                Console.WriteLine($"{i}:{(Wochentag)i}");
            }
            heutigerTag = (Wochentag)int.Parse(Console.ReadLine());
            Console.WriteLine($"Dein Lieblingstag ist {heutigerTag}.");

            heutigerTag = (Wochentag)Enum.Parse(typeof(Wochentag), "Freitag");
            Console.WriteLine($"Dein Lieblingstag ist {heutigerTag}.");

            if(Console.ReadKey().Key == ConsoleKey.Enter)
                Console.WriteLine("Du hast Enter gedrückt");

            switch (heutigerTag)
            {
                case Wochentag.Montag:
                    Console.WriteLine("Wochenstart");
                    break;
                case Wochentag.Dienstag:
                case Wochentag.Mittwoch:
                case Wochentag.Donnerstag:
                    Console.WriteLine("Normaler Arbeitstag");
                    break;
                default:
                    Console.WriteLine("Wochenende");
                    break;
            }

            int zahl = -45;
            switch (zahl)
            {
                case 5:
                    Console.WriteLine("5");
                    break;
                case int z when z < 0:
                    Console.WriteLine("kleiner 0");
                    break;
                default:
                    break;
            }
        }
    }

    enum Wochentag { Montag = 1, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag }
}