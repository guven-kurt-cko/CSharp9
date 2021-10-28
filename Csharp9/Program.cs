using System;

namespace Csharp9
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                FirstName = "guven",
                LastName = "kurt"
            };

            var anotherPerson = person with {  };
            anotherPerson.FirstName = "changed";
            //newp.LastName = "last";

            if (person is not null)
                Console.WriteLine("not null");

            Console.WriteLine(person.FirstName);
            Console.WriteLine(anotherPerson.FirstName);


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

            var tt = new GvnStruct
            {
                Name = "ggg",
                Age = 31
            };
            Console.WriteLine(tt.Name + " " + tt.Age);

            // deconstructor
            var (name, lastname) = person;
            Console.WriteLine($"{name} {lastname}");

            Product pr2 = new("3", 5);

            var (namePr2, lastnamePr2) = pr2;
            Console.WriteLine($"{namePr2} {lastnamePr2}");

            var dummy1 = new Product("Gvn", 1);
            var dummy21 = new Product("Gvn", 1);

            if (dummy1 == dummy21)
            {
                Console.WriteLine("Equals");
            }
            #endregion

            Console.ReadKey();
        }
    }

    public struct GvnStruct
    {
        public string Name { get; set; }
        public int Age { get; set; }
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
    public record Product(string Name, int CategoryId);

    public record Person
    {
        public string FirstName { get; set; }
        public string LastName { get; init; }

        public void Deconstruct(out string firstName, out string lastName)
        {
            (firstName, lastName) = (FirstName, LastName);
        }
    }
}
