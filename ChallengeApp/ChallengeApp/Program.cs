using ChallengeApp;

var employee = new Employee("Imie_1", "Nazwisko_1");
employee.AddGrade("2");
employee.AddGrade((double)6);
employee.AddGrade((long)7);
employee.AddGrade(7.5);
employee.AddGrade((byte)10);

var statisticsForEach = employee.GetStattisticsWithForEach();
Console.WriteLine($"\n{employee.Name} {employee.Surname}");
Console.WriteLine($"Średnia ocen: {statisticsForEach.Average:N2} Min: {statisticsForEach.Min} Max: {statisticsForEach.Max} - pętla ForEach");

var statisticsFor = employee.GetStattisticsWithFor();
Console.WriteLine($"\n{employee.Name} {employee.Surname}");
Console.WriteLine($"Średnia ocen: {statisticsFor.Average:N2} Min: {statisticsFor.Min} Max: {statisticsFor.Max} - pętla For");

var statisticDoWhile = employee.GetStattisticsWithDoWhile();
Console.WriteLine($"\n{employee.Name} {employee.Surname}");
Console.WriteLine($"Średnia ocen: {statisticDoWhile.Average:N2} Min: {statisticDoWhile.Min} Max: {statisticDoWhile.Max} - pętla DoWhile ");

var statisticWhile = employee.GetStattisticsWithWhie();
Console.WriteLine($"\n{employee.Name} {employee.Surname}");
Console.WriteLine($"Średnia ocen: {statisticWhile.Average:N2} Min: {statisticWhile.Min} Max: {statisticWhile.Max} - pętla While");