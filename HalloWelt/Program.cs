namespace HalloWelt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int Alter;

            Alter = 32;

            string Stadt = "Berlin";

            Console.WriteLine(Alter);
            Console.WriteLine(Stadt);

            int DoppeltestAlter = Alter * 2;

            Console.WriteLine(DoppeltestAlter + Alter);


            char Textzeichen = 'A';

            double Kosten = 78.123;
            Console.WriteLine(Kosten);

            bool wahrheitswert = false;


            string Satz = "Ich bin " + Alter.ToString() + " Jahre alt und wohne in " + Stadt + ".";
            Console.WriteLine(Satz);

            Console.WriteLine("Ich bin " + Alter.ToString() + " Jahre alt und wohne in " + Stadt + ".");

            Satz = $"Ich bin {Alter} Jahre alt und wohne in {Stadt}.";
            Console.WriteLine(Satz);
            Console.WriteLine($"Ich bin {Alter} Jahre alt und wohne in {Stadt}.");

            Console.WriteLine("Ich bin {0:0.00} Jahre alt und wohne in {1}.", Alter, Stadt);

            int a = 12;
            int b = 45;
            Console.WriteLine($"{a} + {b} = {a+b}");

            string bsp = "Dies ist ein \tTabulator und dies ein \nZeilenumbruch.";
            Console.WriteLine(bsp);

            string path = $"{{\"C:\\Programme\\Programm.exe\"}}";
            Console.WriteLine(path);

            bsp = @"Dies ist ein    Tabulator und dies ein
Zeilenumbruch";
            Console.WriteLine(bsp);

            path = @"C:\Programme\Programm.exe";
            Console.WriteLine(path);

            Console.Write("Bitte gib deinen Namen ein: ");
            string eingabe = Console.ReadLine();
            Console.WriteLine($"Du heißt also {eingabe}.");

            Console.ReadKey();

            Console.Write("Bitte gib deine Lieblingszahl ein: ");
            string zahlAlsString = Console.ReadLine();
            int zahl = int.Parse(zahlAlsString);
            zahl = zahl * 2;
            Console.WriteLine(zahl);

            int intZahl = 45;
            double doubleZahl = intZahl;

            doubleZahl = 45.23;
            intZahl = (int)doubleZahl;

            intZahl = Convert.ToInt32(23.56);

            double zero = 0.0;
            double z = 45 / zero;
            Console.WriteLine(z);

        }
    }
}