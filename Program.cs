string? name = Console.ReadLine();

if (!string.IsNullOrEmpty(name))
{
    Console.WriteLine($"your name is {name}");
}
else
{
    Console.WriteLine("You're supposed to give a name");
}
