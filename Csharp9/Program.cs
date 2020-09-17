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
            //newp.LastName = "last";

            Console.WriteLine(p.FirstName);
            Console.WriteLine(newp.FirstName);

            #region Product

            //var product = new Product("Phone", 14);
            //Console.WriteLine($"{product.Name} {product.CategoryId}");

            //var (name, lastname) = p;
            //Console.WriteLine($"{name} {lastname}");

            #endregion

            Console.ReadKey();
        }
    }

    public record Person
    {
        public string FirstName { get; set; }
        public string LastName { get; init; }

        public void Deconstruct(out string firstName, out string lastName)
        {
            (firstName, lastName) = (FirstName, LastName);
        }
    }

    public record Product(string Name, int CategoryId);
}
