using ChallengeApp;

Console.WriteLine(" ==============================================");
Console.WriteLine("== Witaj w programie XYZ do oceny pracowników ==");
Console.WriteLine(" ==============================================");
Console.WriteLine();
Console.WriteLine("Wprowadzasz dane pracownika.");
Console.WriteLine("Podaj imię:");
var name = Console.ReadLine();
Console.WriteLine("Podaj nazwisko:");
var surname = Console.ReadLine();

var employee = new EmployeeInFile(name, surname);
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Ocena została dodana");
}

try
{
    EmployeeInFile emp = null;

}
catch(Exception exception)
{
    Console.WriteLine(exception.Message);
}
finally
{
    Console.WriteLine("Finally ...");
}

Console.WriteLine("Podaj ocenę pracownika:");
var input = Console.ReadLine();
employee.AddGrade(input);

while (true)
{
    Console.WriteLine("Podaj kolejną (jeśli chcesz zakończyć, podaj (q):");
    input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine();
Console.WriteLine(" ==============================================");
Console.WriteLine($"Statystyki pracownika {employee.Name} {employee.Surname}");
Console.WriteLine($"AvgLetter: {statistics.AverageLetter}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
