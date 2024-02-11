using ChallengeApp;

Employee employee1 = new Employee("Imie_1", "Nazwisko_1", 21);
Employee employee2 = new Employee("Imie_2", "Nazwisko_2", 22);
Employee employee3 = new Employee("Imie_3", "Nazwisko_3", 23);

List<Employee> employees = new List<Employee>();

employee1.AddGrade(1);
employee1.AddGrade(5);
employee1.AddGrade(7);
employee1.AddGrade(6);
employee1.AddGrade(9);
Console.WriteLine($"{employee1.Name} {employee1.Surname} Wiek: {employee1.Age} Ocena: {employee1.Result} ");

employee2.AddGrade(2);
employee2.AddGrade(9);
employee2.AddGrade(8);
employee2.AddGrade(7);
employee2.AddGrade(6);
Console.WriteLine($"{employee2.Name} {employee2.Surname} Wiek: {employee2.Age} Ocena: {employee2.Result} ");

employee3.AddGrade(3);
employee3.AddGrade(4);
employee3.AddGrade(6);
employee3.AddGrade(9);
employee3.AddGrade(3);
Console.WriteLine($"{employee3.Name} {employee3.Surname} Wiek: {employee3.Age} Ocena: {employee3.Result} ");

employees.Add(employee1);
employees.Add(employee2);
employees.Add(employee3);

var maxResultTemp = -1;
Employee employeeMaxResultData = null;

foreach (Employee emp in employees)
{
    if (emp.Result > maxResultTemp)
    {
        maxResultTemp = emp.Result;
        employeeMaxResultData = emp;
    }

}
Console.WriteLine($"\nWynik: \n\n{employeeMaxResultData.Name} {employeeMaxResultData.Surname} Wiek: {employeeMaxResultData.Age} Ocena: {employeeMaxResultData.Result} ");
