using System;

namespace Csharp9
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person()
            {
                FirstName = "Joe",
                LastName = "White"
            };
            //person1.FirstName = "first";
            //person1.LastName = "last";

            if (person1 is not null)
                Console.WriteLine("not null");

            // deconstructor
            //var (name, lastname) = person1;
            //Console.WriteLine($"{name} {lastname}");

            // With-expressions
            var person2 = person1 with { FirstName = "Robert" };

            // auto ToString() method
            Console.WriteLine(person2);

            #region Product
            // Target-typed new expressions
            Product product1 = new("Parfume", 33);
            Console.WriteLine(product1);

            // ctor and obj-initializer
            var product2 = new Product("first", 1)
            {
                Name = "second",
                Count = 2
            };
            //product1.Name = "test";
            //product1.Count = 5;

            Console.WriteLine(product2);

            var (name, categoryId) = product2;
            Console.WriteLine($"{name} {categoryId}");

            var test1 = new Product("shelf", 2);
            var test2 = new Product("shelf", 2);

            if (test1 == test2)
            {
                Console.WriteLine("Equals");
            }
            #endregion

            //#error version

            Console.ReadKey();
        }

        //public static bool IsLetterOrSeparator2(char c)
        //{
        //    return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == '.' || c == ',';
        //}
        // pattern matching, works only with constant values
        //public static bool IsLetterOrSeparator1(char c)
        //{
        //    return c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';
        //}
    }

}
