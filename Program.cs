
Console.WriteLine("Hello, World!");
Console.WriteLine("Napisz cos: ");

string input  = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Błąd: nie wprowadzono danych");
    return;
}
Console.WriteLine("Wprowadzono dane poprawnie");
