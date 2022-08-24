namespace Funktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summe = Addiere(5, 12);
            Console.WriteLine(summe);

            double dblSumme = Addiere(5.4, 12.6);
            Console.WriteLine(dblSumme);

            int diff = Subtrahiere(2, 5, d:5);

            summe = BildeSumme(1, 34, 56, 12, -34, 999);
            summe = BildeSumme(new int[] { 1, 45, 7 });

            summe = AddiereUndSubtrahiere(1, 2, out int differenz);
            Console.WriteLine(summe);
            Console.WriteLine(differenz);

            string eingabe = Console.ReadLine();

            if(int.TryParse(eingabe, out int result))
            {
                Console.WriteLine(result * 5);
            }
        }

        static int Addiere(int a, int b)
        {
            //int c = a + b;
            //return c;

            return a + b;
        }

        static double Addiere(double a, double b)
        {
            return a + b;
        }

        static int Subtrahiere(int a, int b, int c = 0, int d = 0)
        {
            return a - b - c - d;
        }

        static int BildeSumme(params int[] summanden)
        {
            int summe = 0;
            foreach (var item in summanden)
            {
                summe += item;
            }
            return summe;
        }

        static int AddiereUndSubtrahiere(int a, int b, out int diff)
        {
            diff = a - b;

            return a + b;
        }
    }
}