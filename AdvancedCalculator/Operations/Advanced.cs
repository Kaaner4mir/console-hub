class Advanced
{
    public static double? Exponentiation(string operationName, Func<double, double, double> operation)
    {
        try
        {
            double baseNum = ConsoleManager.GetInput<double>("\n➡️ Enter the base number: ");
            double exponent = ConsoleManager.GetInput<double>("➡️ Enter the exponent: ");

            if (baseNum == 0 && exponent == 0)
            {
                ConsoleManager.WriteColored("⛔ Undefined!", ConsoleColor.Yellow);
                return null;
            }

            double result = operation(baseNum, exponent);

            return ShowResult(result, baseNum, exponent, operationName);
        }
        catch (Exception exc)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occurred: {exc.Message}", ConsoleColor.Red);
            return null;
        }
    }

    public static double? Root(string operationName, Func<double, double, double> operation)
    {
        try
        {
            double radicand = ConsoleManager.GetInput<double>("\n➡️ Enter the radicand: ");
            double rootDegree = ConsoleManager.GetInput<double>("➡️ Enter the root degree: ");

            if (radicand < 0 && rootDegree % 2 == 0)
            {
                ConsoleManager.WriteColored("⛔ Undefined for negative radicand with even root!", ConsoleColor.Yellow);
                return null;
            }

            double result = operation(radicand, rootDegree);

            return ShowResult(result, radicand, rootDegree, operationName);
        }
        catch (Exception exc)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occurred: {exc.Message}", ConsoleColor.Red);
            return null;
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

    public static double? Modulo(string operationName, Func<double, double, double> operation)
    {
        try
        {
            int dividend = ConsoleManager.GetInput<int>("\n➡️ Enter the dividend: ");
            int divisor = ConsoleManager.GetInput<int>("\n➡️ Enter the divisor: ");

            if (dividend == 0 && divisor == 0)
            {
                ConsoleManager.WriteColored("\n⛔ Undefined!", ConsoleColor.Red);
                return null;
            }

            if (divisor == 0)
            {
                ConsoleManager.WriteColored("\n⛔ The divisor cannot be zero!", ConsoleColor.Red);
                return null;
            }

            double result = operation(dividend, divisor);

            return ShowResult(result, dividend, divisor, operationName);
        }
        catch (Exception exc)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occurred: {exc.Message}", ConsoleColor.Red);
            return null;
        }
    }

    public static double? Logarithm(string operationName, Func<double, double, double> operation)
    {
        try
        {
            double baseNum = ConsoleManager.GetInput<double>("\n➡️ Enter the base number: ");
            double argument = ConsoleManager.GetInput<double>("➡️ Enter the argument: ");

            if (baseNum <= 0 || baseNum == 1)
            {
                ConsoleManager.WriteColored("⛔ Undefined! Base must be > 0 and ≠ 1.", ConsoleColor.Yellow);
                return null;
            }

            if (argument <= 0)
            {
                ConsoleManager.WriteColored("⛔ Undefined! Argument must be > 0.", ConsoleColor.Yellow);
                return null;
            }

            double result = operation(baseNum, argument);

            return ShowResult(result, baseNum, argument, operationName);
        }
        catch (Exception exc)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occurred: {exc.Message}", ConsoleColor.Red);
            return null;
        }
    }

    public static void Trigonometry()
    {
        Console.Clear();
        Menu.TrigonometryMenu();

        short input = ConsoleManager.GetInput<short>("\n👉 Please enter the operation you wish to perform numerically: ");
        double degree = ConsoleManager.GetInput<double>("\n👉 Enter the degree: ");
        double radian = degree * (Math.PI / 180);

        double result;

        switch (input)
        {
            case 1:
                result = Math.Sin(radian);
                ShowResult(result, degree, 0, "sin");
                break;
            case 2:
                result = Math.Cos(radian);
                ShowResult(result, degree, 0, "cos");
                break;
            case 3:
                result = Math.Tan(radian);
                ShowResult(result, degree, 0, "tan");
                break;
            case 4:
                result = 1.0 / Math.Tan(radian);
                ShowResult(result, degree, 0, "cot");
                break;
            case 5:
                result = 1.0 / Math.Cos(radian);
                ShowResult(result, degree, 0, "sec");
                break;
            case 6:
                result = 1.0 / Math.Sin(radian);
                ShowResult(result, degree, 0, "csc");
                break;
            default:
                ConsoleManager.WriteColored(
                    "\n❓ The operation you want to perform could not be found.", ConsoleColor.Yellow);
                break;
        }
    }

    public static T ShowResult<T>(T result, double operand1, double operand2, string operationName)
    {
        string symbol = operationName.ToLower() switch
        {
            "exponentiation" => "^",
            "root" => "√",
            "factorial" => "!",
            "modulo" => "%",
            "logarithm" => "log",
            "sin" => "sin",
            "cos" => "cos",
            "tan" => "tan",
            "cot" => "cot",
            "sec" => "sec",
            "csc" => "csc",
            _ => "?"
        };

        if (operationName.ToLower() == "factorial")
            ConsoleManager.WriteColored($"\n✅ {operand1}{symbol} = {result}", ConsoleColor.Green);
        else if (operationName.ToLower() == "logarithm")
            ConsoleManager.WriteColored($"\n✅ {symbol}_{operand1}({operand2}) = {result}", ConsoleColor.Green);
        else if (operationName.ToLower() == "trigonometry")
        {
            ConsoleManager.WriteColored(
               $"\n✅ {operand1} {symbol} {(operand2 != 0 ? operand2.ToString() : "")} = {result}",
               ConsoleColor.Green);
        }
        else
            ConsoleManager.WriteColored($"\n✅ {operand1} {symbol} {operand2} = {result}", ConsoleColor.Green);



        return result;
    }
}


