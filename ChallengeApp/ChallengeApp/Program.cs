using ChallengeApp;

Console.WriteLine("Witamy  w programie do oceny pracowników");
Console.WriteLine("========================================");
Console.WriteLine();

var employee = new Employee("Imie_1", "Nazwisko_1", "Mężczyzna");

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika:");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception exception)
    {
        Console.WriteLine($"\nWywołanie wyjątku: {exception.Message}");
    }
    finally
    {
        Console.WriteLine();
    }
}
var statistics = employee.GetStattistics();
if (statistics != null)
{
    Console.WriteLine($"\n{employee.Name}  {employee.Surname}");
    Console.WriteLine($"Ocena liczbowa:{statistics.Average:N2}");
    Console.WriteLine($"Ocena literowa:{statistics.AverageLetter}");
    Console.WriteLine($"Min:{statistics.Min:N2}");
    Console.WriteLine($"Max:{statistics.Max:N2}");
}
else
{
    Console.WriteLine($"\nBrak wprowadzonych ocen pracownika");
}