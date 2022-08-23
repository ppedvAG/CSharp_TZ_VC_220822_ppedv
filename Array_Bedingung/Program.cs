namespace Array_Bedingung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen = { 2, 4, 78, -123, -8, 0, 11111 };
            Console.WriteLine(zahlen[2]);
            zahlen[2] = 1234;
            Console.WriteLine(zahlen[2]);

            string[] worte = new string[5];

            Console.WriteLine(zahlen.Contains(-123));
            Console.WriteLine(zahlen.Contains(555));

            Console.WriteLine(zahlen.Length);

            string beispiel = "Hallo";
            Console.WriteLine(beispiel[4]);

            int[,] mehrDimArray = new int[10, 10];
            mehrDimArray[2, 5] = 123;
            Console.WriteLine(mehrDimArray[2,5]);


            int a = 25;
            int b = 25;

            if(a < b)
            {
                Console.WriteLine("A ist kleiner als B");
            }
            else if(a > b)
            {
                Console.WriteLine("A ist größer als B");
            }
            else
                Console.WriteLine("A ist gleich B");

            Console.WriteLine("Ende des If-Blocks");


            string ergebnis = (a == b) ? "A ist gleich B" : "A ist ungleich B";

            string name1 = "Hans";
            string name2 = "Hans";

            if(name1.Equals(name2))
                Console.WriteLine("Gleich");
        }
    }
}