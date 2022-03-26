namespace Csharp9
{

    public record Person
    {
        public string FirstName { get; set; }
        public string LastName { get; init; }

        //public void Deconstruct(out string firstName, out string lastName)
        //{
        //    (firstName, lastName) = (FirstName, LastName);
        //}
    }

    public record Product(string Name, int Count);

}
