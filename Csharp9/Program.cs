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

            var newp = p with { };
            newp.FirstName = "changed";

            var product = new Product("Phone", 14);

            var (name, lastname) = p;

            Console.WriteLine($"{name} {lastname}");
            Console.WriteLine($"{product.Name} {product.CategoryId}");

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
