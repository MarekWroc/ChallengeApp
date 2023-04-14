string name = "Marek";
string gender = "male"; // male, female
int age = 40;
if (age < 18)
{
    Console.Write("Niepełnoletni");
}
else if (age >= 18 && age < 30)
{
    Console.Write("Młod");
}
else if (age >= 30 && age < 55)
{
    Console.Write("Dojrzał");
}
else if (age >= 55)
{
    Console.Write("Star");
}
if (gender == "male")
{
    if (age < 18)
    {
        Console.Write(" mężczyzna");
    }
    else
    {
        Console.Write("y mężczyzna");
    }
}
else
{
    Console.Write("a kobieta");
}
Console.WriteLine(", o imieniu " + name + ".");



