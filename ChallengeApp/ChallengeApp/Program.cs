using ChallengeApp;

Console.WriteLine(" ==============================================");
Console.WriteLine("== Witaj w programie XYZ do oceny pracowników ==");
Console.WriteLine(" ==============================================");
Console.WriteLine();
Console.WriteLine("Wprowadzasz dane pracownika.");


var employee = new EmployeeInFile("Marek", "Marecki");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Ocena została dodana");
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
