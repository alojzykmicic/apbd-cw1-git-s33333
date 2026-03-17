Console.WriteLine("Hello, World (with feature-conflict)!");
Console.WriteLine("Napisz cos: ");

string input  = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Błąd: nie wprowadzono danych");
    return;
}
Console.WriteLine("Wprowadzono dane poprawnie");
//jakis komentarz