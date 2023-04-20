using ChallengeApp;

var employee = new Employee("Marek", "Marecki");

employee.AddGrade(9f);
employee.AddGrade("200");
employee.AddGrade(3);
employee.AddGrade(4);

var statistics = employee.GetStatistics();

Console.WriteLine($"Imie: {employee.Name}");
Console.WriteLine($"Nazwisko: {employee.Surname}");
Console.WriteLine($"Średnia: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");