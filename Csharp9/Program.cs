using System;

namespace Csharp9
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person()
            {
                FirstName = "guven",
                LastName = "kurt"
            };

            var newp = p;
            newp.FirstName = "hasan";

            var product = new Product("Hah", 4);

            var (name, lastname) = p;

            Console.WriteLine(name + lastname);

            Console.WriteLine(p.FirstName);
            Console.WriteLine(newp.FirstName);

            Console.ReadKey();
        }
    }

    public record Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Deconstruct(out string firstName, out string lastName)
        {
            (firstName, lastName) = (FirstName, LastName);
        }
    }

    public record Product(string Name, int CategoryId);
}
