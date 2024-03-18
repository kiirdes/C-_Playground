using System.Collections;

class ExerciseClass
{
    static int? ParseUserInput(String userInput)
    {
        int userMax = -1;

        userInput = userInput.Trim();
        if (!int.TryParse(userInput, out userMax) || userMax < 1)
            return null;

        return userMax;
    }

    static String[] keywords = ["fizz", "buzz", "doom", "jong", "spow", "reng", "gaow", "pirt", "klek", "zdyn"];

    static void Main(String[] args)
    {
        String userInput = "";
        int userMax = 1;
        List<int?> divisors = [];

        if(args.Length == 0) {
            Console.WriteLine("Input max number.");
            userInput = Console.ReadLine() ?? "1";
            userMax = ParseUserInput(userInput) ?? 2;
        } else
        {
            int.TryParse(args[0], out userMax);
        }

        if (args.Length <= 1) {
            Console.WriteLine("Input a divisor.");
            userInput = Console.ReadLine() ?? "1";
            divisors.Add(ParseUserInput(userInput) ?? 2);
        }

        if(args.Length > 1) {
            for (int i = 0; i < args.Length; i++)
            {
                if (i == 0) continue;
                divisors.Add(ParseUserInput(args[i]));
            }
        }

        Console.WriteLine("Fizz buzzing for {0}", userMax);
        Console.Write("Divisors are: ");
        foreach (int divisor in divisors) Console.Write("{0} ", divisor);
        Console.WriteLine();
        for (int i = 1; i < userMax + 1; i++)
        {
            bool hasMatched = false;
            for(int j = 0; j < divisors.Count; j++)
            {
                if (0 == i % divisors[j])
                {
                    Console.Write(keywords[j]);
                    hasMatched = true;
                }
            }
            if (!hasMatched) {
                Console.Write(i);
            };
            Console.WriteLine();
        }
        
    }
}

