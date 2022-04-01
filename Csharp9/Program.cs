using System;
using System.Collections.Generic;
using System.Linq;

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

            //// deconstructor
            //var (name, lastname) = person1;
            //Console.WriteLine($"{name} {lastname}");

            // With-expressions
            var person2 = person1 with { FirstName = "Robert" };

            // auto ToString() method
            Console.WriteLine(person1);
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

            var (name2, categoryId) = product2;
            Console.WriteLine($"{name2} {categoryId}");

            // equality comparison
            var a = new MyClass() { Name = "1" };
            var b = new MyClass() { Name = "1" };

            if (a == b)
            {
                Console.WriteLine("a == b");
            }

            var c = new Product("shelf", 2);
            var d = new Product("shelf", 2);

            if (c == d)
            {
                Console.WriteLine("c == d");
            }
            #endregion



            //#error version

            // Static Anonymous Functions 
            // is used to indicate a lambda or anonymous functions cannot capture local variables
            var p = new Program();

            int y = 100;
            var res = p.DoSomething(x => y + y); // captures 'y', causing unintended allocation.
            Console.WriteLine(res);

            //p.DoSomething(static x => x + y); // error

            const int z = 10;
            p.DoSomething(static x => x + z); // good
            //In C#, anonymous functions that refer to local variables require allocating a temporary object.
            //The local parameter is then moved out of the method and into the object
            //so it will continue to exist after the currently executing function ends.
            //This is necessary because an anonymous function may exist longer than the function that created it.

            Console.ReadKey();
        }

        public static bool IsLetterOrSeparator2(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')
                || c == '.' || c == ',';
        }
        // pattern matching, works only with constant values
        public static bool IsLetterOrSeparator1(char c)
        {
            return c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';
        }


        public int DoSomething(Func<int, int> func)
        {
            return func.Invoke(5);
        }

        // paste it to sharplab.io to see created "closure" class (DisplayClass)
        public int GetCount(int num)
        {
            var abc = 12;
            return new List<int>().Count(x => x == num + abc);
        }
    }

}
