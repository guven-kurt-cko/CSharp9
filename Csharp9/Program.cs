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

            if (p is not null)
                Console.WriteLine("not null");

            // another way of is not null
            //string str = "g";
            //if (str is object)
            //    Console.WriteLine("string is not null");

            Console.WriteLine(p.FirstName);
            Console.WriteLine(newp.FirstName);


            //var dummy = new Dummy()
            //{
            //    FirstName = "Test"
            //};


            #region Product
            // Target-typed new expressions
            Product product = new("Parfume", 33);
            Console.WriteLine(product);

            // ctor and obj-initializer
            var pr = new Product("first", 1)
            {
                Name = "second",
                CategoryId = 2
            };
            //pr.LastName = "gege";
            Console.WriteLine(pr.Name + " " + pr.CategoryId);


            // deconstructor
            var (name, lastname) = p;
            Console.WriteLine($"{name} {lastname}");

            Product pr2 = new("3", 5);

            #endregion

            Console.ReadKey();
        }
    }

    public class Dummy
    {
        public Dummy() { }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Dummy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
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
