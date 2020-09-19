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

            var product = new Product("Phone", 14);
            Console.WriteLine($"{product.Name} {product.CategoryId}");

            var pr = new Product("first", 1) { Name = "second", CategoryId = 2 };
            //pr.LastName = "gege";
            Console.WriteLine(pr.Name + " " + pr.CategoryId);

            var (name, lastname) = p;
            Console.WriteLine($"{name} {lastname}");

            Product pr2 = new("3", 5);

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

    //#region Next Feature in progress

    //// Before
    //void Insert(string s)
    //{
    //    if (s is null)
    //        throw new ArgumentNullException(nameof(s));

    //}

    //// After
    //void Insert(string s!)
    //{

    //}

    //const string s1 = $"abc";

    //#endregion
}
