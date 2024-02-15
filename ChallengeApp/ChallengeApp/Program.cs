using ChallengeApp;

var employee = new Employee("Imie_1", "Nazwisko_1");
employee.AddGrade("29,5");
employee.AddGrade((double)6);
employee.AddGrade((long)7);
employee.AddGrade(7.5);
employee.AddGrade((byte)10);

var statistics = employee.GetStattistics();
Console.WriteLine($"\n{employee.Name} {employee.Surname}");
Console.WriteLine($"Średnia ocen: {statistics.Average:N2} Min: {statistics.Min} Max: {statistics.Max} ");
