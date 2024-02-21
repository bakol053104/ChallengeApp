using ChallengeApp;

var employee = new EmployeeInFile("Imie_1", "Nazwisko_1");
var emp = employee;
emp.GradeAdded += EmployeeGradeAdded;

Console.WriteLine("\tWitamy  w programie do oceny pracowników");
Console.WriteLine("============================================================\n");
Console.WriteLine($"Podaj oceny (1,2,3,4,5,6 +/-) dla pracownika {emp.Name} {emp.Surname}\n");
UserInterface();

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

void UserInterface()
{
    var index = 1;
    while (true)
    {
        Console.WriteLine($"Ocena [{index}]: ");
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
            index--;
        }
        finally
        {
            Console.WriteLine();
            index++;
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
}
