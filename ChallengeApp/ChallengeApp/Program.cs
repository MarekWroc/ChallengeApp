using ChallengeApp;

Employee employee1 = new Employee("Mariola", 22);
Employee employee2 = new Employee("Antoni", 27);
Employee employee3 = new Employee("Henryk", 31);

employee1.AddScore(4);
employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(2);
employee1.AddScore(9);

employee2.AddScore(9);
employee2.AddScore(6);
employee2.AddScore(7);
employee2.AddScore(9);
employee2.AddScore(4);

employee3.AddScore(5);
employee3.AddScore(3);
employee3.AddScore(6);
employee3.AddScore(2);
employee3.AddScore(1);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxValue = 0;
Employee employeeWithMaxValue = null;

foreach(var employee in employees)
{
    if(employee.Value >  maxValue)
    {
        maxValue = employee.Value;
        employeeWithMaxValue = employee;
    }
}

Console.WriteLine("The winner is:...");
Console.WriteLine(employeeWithMaxValue.Name + " !!!");
Console.WriteLine("Lat - " + employeeWithMaxValue.Age);
Console.WriteLine("Zwyciężył/a z liczbą punktów w ilości: " + maxValue);