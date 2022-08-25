using KlassenbibliothekBeispiel;

namespace WerteUndReferenzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a;
            Console.WriteLine($"a:{a} b:{b}");

            a = 10;
            Console.WriteLine($"a:{a} b:{b}");

            Lebewesen lb1 = new Lebewesen("Anna", "Lasagne", new DateTime(), 180);
            Lebewesen lb2 = lb1;
            Console.WriteLine($"lb1:{lb1.Name} lb2:{lb2.Name}");

            lb1.Name = "Hugo";
            Console.WriteLine($"lb1:{lb1.Name} lb2:{lb2.Name}");


            PersonC classPerson = new PersonC("Anna", 30);
            PersonS structPerson = new PersonS("Hugo", 30);

            Console.WriteLine($"{classPerson.Name}: {classPerson.Alter}");
            Console.WriteLine($"{structPerson.Name}: {structPerson.Alter}");

            Altern(classPerson);
            Altern(structPerson);

            Console.WriteLine($"{classPerson.Name}: {classPerson.Alter}");
            Console.WriteLine($"{structPerson.Name}: {structPerson.Alter}");

            Altern(ref structPerson);
            Console.WriteLine($"{structPerson.Name}: {structPerson.Alter}");
        }

        public static void Altern(PersonC person)
        {
            person.Alter++;
        }
        public static void Altern(PersonS person)
        {
            person.Alter++;
        }

        public static void Altern(ref PersonS person)
        {
            person.Alter++;
        }
    }

    class PersonC
    {
        public int Alter { get; set; }
        public string Name { get; set; }

        public PersonC(string n, int a)
        {
            this.Alter = a;
            this.Name = n;
        }
    }

    struct PersonS
    {
        public int Alter { get; set; }
        public string Name { get; set; }

        public PersonS(string n, int a)
        {
            this.Alter = a;
            this.Name = n;
        }
    }


}