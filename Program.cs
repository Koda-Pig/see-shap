Console.WriteLine("Please provide your name:");

// C# doesn't check for overflow by default.
// You have to add this checked thing.
// Example here is with a byte var type that has a max val of 255
// adding 1 to it causes an overflow, which will only be caught in a checked code block.
checked
{
    byte number = 255;
    var number2 = 255; // defaults to int when using var and type isn't specified
    number2++;
    const byte number3 = 10;
    Console.WriteLine(number3);
    // number3++; // that's illegal! No reassigning consts.

    // number++;
    Console.WriteLine(number); // overflow
}

Console.WriteLine(byte.MaxValue);

string? name = Console.ReadLine();

if (!string.IsNullOrEmpty(name))
{
    Console.WriteLine($"your name is {name}");
}
else
{
    Console.WriteLine("You're supposed to give a name");
}
