class Advanced
{
    public static T? Exponentiation<T>(string operationName, Func<double, double, T> operation)
    {
        try
        {
            double baseNum = ConsoleManager.GetInput<double>("\n➡️ Enter the base number: ");
            double exponent = ConsoleManager.GetInput<double>("➡️ Enter the exponent: ");

            if (baseNum == 0 && exponent == 0)
            {
                ConsoleManager.WriteColored("⛔ Undefined!", ConsoleColor.Yellow);
                return default;
            }

            T result = operation(baseNum, exponent);

            return ShowResult(result, baseNum, exponent, operationName);
        }
        catch (Exception exc)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occurred: {exc.Message}", ConsoleColor.Red);
            return default;
        }
    }

    public static T? Root<T>(string operationName, Func<double, double, T> operation)
    {
        try
        {
            double radicand = ConsoleManager.GetInput<double>("\n➡️ Enter the radicand: ");
            double rootDegree = ConsoleManager.GetInput<double>("➡️ Enter the root degree: ");

            if (rootDegree % 2 == 0 && rootDegree < 0)
            {
                ConsoleManager.WriteColored("⛔ Undefined!", ConsoleColor.Yellow);
                return default;
            }

            T result = operation(radicand, rootDegree);

            return ShowResult(result, radicand, rootDegree, operationName);
        }
        catch (Exception exc)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occurred: {exc.Message}", ConsoleColor.Red);
            return default;
        }
    }

    public static long? Factorial(string operationName)
    {
        try
        {
            int number = ConsoleManager.GetInput<int>("\n➡️ Enter the number you want to learn factorial value: ");

            if (number < 0)
            {
                ConsoleManager.WriteColored("\n⛔ Please enter a positive value!", ConsoleColor.Yellow);
                return null;
            }

            long result = 1;

            for (int i = 1; i <= number; i++)
                result *= i;

            return ShowResult(result, number, 0, operationName);
        }
        catch (Exception exc)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occurred: {exc.Message}", ConsoleColor.Red);
            return null;
        }
    }


    public static T ShowResult<T>(T result, double operand1, double operand2, string operationName)
    {
        string symbol = operationName switch
        {
            "exponentiation" => "^",
            "root" => "√",
            "factorial" => "!",
            _ => "?"
        };

        if (operationName == "factorial")
            ConsoleManager.WriteColored($"\n✅ {operand1}{symbol} = {result}", ConsoleColor.Green);
        else
            ConsoleManager.WriteColored($"\n✅ {operand1}{symbol}{operand2} = {result}", ConsoleColor.Green);

        return result;
    }
}
