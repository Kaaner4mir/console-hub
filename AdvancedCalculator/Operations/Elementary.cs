class Elementary
{
    public static double? BasicOperation(string operationName, Func<double, double, double> operation)
    {
        try
        {
            double val1 = ConsoleManager.GetInput<double>("\n➡️ Enter the first number: ");
            double val2 = ConsoleManager.GetInput<double>("➡️ Enter the second number: ");

            string opNameLower = operationName.ToLower();

            if (opNameLower == "division")
            {
                if (val1 == 0 && val2 == 0)
                {
                    ConsoleManager.WriteColored("\n⛔ Undefined!", ConsoleColor.Red);
                    return null;
                }

                if (val2 == 0)
                {
                    ConsoleManager.WriteColored("\n⛔ The divisor cannot be zero!", ConsoleColor.Red);
                    return null;
                }
            }

            double result = operation(val1, val2);

            return ShowResult(result, val1, val2, opNameLower);
        }
        catch (Exception exc)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occurred: {exc.Message}", ConsoleColor.Red);
            return null;
        }
    }

    public static double ShowResult(double result, double val1, double val2, string operationName)
    {
        string symbol = operationName switch
        {
            "addition" => "+",
            "subtraction" => "-",
            "multiplication" => "x",
            "division" => "/",
            _ => "?"
        };

        ConsoleManager.WriteColored($"\n✅ {val1} {symbol} {val2} = {result}", ConsoleColor.Green);
        return result;
    }
}
