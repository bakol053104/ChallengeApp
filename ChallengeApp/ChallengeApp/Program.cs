using ChallengeApp;

var employee = new Employee("Imie_1", "Nazwisko_1");
var supervisor = new Supervisor("Imie_2", "Nazwisko_2");

Console.WriteLine("\tWitamy  w programie do oceny pracowników");
Console.WriteLine("=========================================================\n");

var emp = employee;

while (true)
{
    if (emp.Jobpost == "Kierownik")
    {
        Console.WriteLine($"Podaj ocenę ( 1,2,3,4,5,6 +/-) dla stanowiska {emp.Jobpost}:");
    }
    else
    {
        Console.WriteLine($"Podaj ocenę ( 0-100 lub A[a]-E[e] ) dla stanowiska {emp.Jobpost}:");
    }

    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        emp.AddGrade(input);
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
var statistics = emp.GetStattistics();
if (statistics != null)
{
    Console.WriteLine($"\n{emp.Name}  {emp.Surname}");
    Console.WriteLine($"Średnia ocena liczbowa: {statistics.Average:N2}");
    Console.WriteLine($"Średnia ocena szkolna: {statistics.AverageLetter}");
    Console.WriteLine($"Min: {statistics.Min:N2}");
    Console.WriteLine($"Max: {statistics.Max:N2}");
}
else
{
    Console.WriteLine($"\nBrak wprowadzonych ocen pracownika");
}

var super = supervisor;

while (true)
{
    if (super.Jobpost == "Kierownik")
    {
        Console.WriteLine($"Podaj ocenę ( 1,2,3,4,5,6 +/-) dla stanowiska {super.Jobpost}:");
    }
    else
    {
        Console.WriteLine($"Podaj ocenę ( 0-100 lub A[a]-E[e] ) dla stanowiska {super.Jobpost}:");
    }

    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        super.AddGrade(input);
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
var statistics1 = super.GetStattistics();
if (statistics1 != null)
{
    Console.WriteLine($"\n{super.Name}  {super.Surname}");
    Console.WriteLine($"Średnia ocena liczbowa: {statistics1.Average:N2}");
    Console.WriteLine($"Średnia ocena szkolna: {statistics1.AverageLetter}");
    Console.WriteLine($"Min: {statistics1.Min:N2}");
    Console.WriteLine($"Max: {statistics1.Max:N2}\n");
}
else
{
    Console.WriteLine($"\nBrak wprowadzonych ocen pracownika");
}

