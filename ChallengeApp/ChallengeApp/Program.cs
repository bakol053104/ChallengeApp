using ChallengeApp;

var employee = new EmployeeInFile("Imie_1", "Nazwisko_1", "Kierownik");
var emp = employee;

Console.WriteLine("\tWitamy  w programie do oceny pracowników");
Console.WriteLine("=========================================================\n");

if (emp.JobPost == "Kierownik")
{
    Console.WriteLine($"Oceny ( 1,2,3,4,5,6 +/-) dla stanowiska {emp.JobPost}:");
    UserInterface();
}
else if (emp.JobPost == "Pracownik")
{
    Console.WriteLine($"Oceny ( 0-100 lub E[e]-A[a] ) dla stanowiska {emp.JobPost}:");
    UserInterface();
}
else
{
    Console.WriteLine($"Wprowadzono nieprawidłowe stanowisko pracy");
}
void UserInterface()
{
    while (true)
    {
        Console.WriteLine($"Podaj ocenę: ");
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
  
}
