namespace Csharp9
{

    public record Person // records inherit only from records and object type and classes cant inherit from records
    {
        public string FirstName { get; set; }
        public string LastName { get; init; }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
    }
    // When to use
    // entities that doesnt change
    // Read-only data
    // DTOs
    // Events

    public class MyClass
    {
        public string Name { get; set; }
    }
}
