using ChallengeApp;
using System;

Console.WriteLine("Witamy  w programie do oceny pracowników");
Console.WriteLine("========================================");
Console.WriteLine();

var employee = new Employee("Imie_1", "Nazwisko_1");

while (true)
{
    Console.WriteLine("\nPodaj ocenę pracownika:");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStattistics();
if (statistics != null)
{
    Console.WriteLine($"\nOcena liczbowa:{statistics.Average:N2}");
    Console.WriteLine($"Ocena literowa:{statistics.AverageLetter}");
    Console.WriteLine($"Min:{statistics.Min:N2}");
    Console.WriteLine($"Max:{statistics.Max:N2}");
}
else
{
    Console.WriteLine($"\nBrak wprowadzonych ocen pracownika");
}