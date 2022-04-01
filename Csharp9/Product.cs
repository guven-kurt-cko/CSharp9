namespace Csharp9
{
    // Positional syntax for property definition
    public record Product(string Name, int Count);
    //The compiler creates:
    //A public init-only auto-implemented property for each positional parameter.
    //A primary constructor whose parameters match the positional parameters on the record declaration.
    //A Deconstruct method with an out parameter for each positional parameter provided in the record declaration.

}
