int? ParseUserInput(String userInput)
{
    int userMax = -1;

    userInput = userInput.Trim();
    if (!int.TryParse(userInput, out userMax) || userMax < 1)
        return null;

    return userMax;
}

int main()
{
    String userInput = "";
    int? userMax;
    int fizz = 2;
    int buzz = 3;

    Console.WriteLine("Give me a number and I'll fizz buzz for {0} and {1}.", fizz, buzz);

    userInput = Console.ReadLine() ?? "0";
    if ((userMax = ParseUserInput(userInput)) == null) return -1;

    Console.WriteLine();
    for (int i = 1; i < userMax; i++)
    {
        if (0 == i % fizz) Console.Write("fizz");
        if (0 == i % buzz) Console.Write("buzz");
        if (0 != i % fizz && 0 != i % buzz) Console.Write(i);
        Console.WriteLine();
    }
    
    return 0;
}

main();
