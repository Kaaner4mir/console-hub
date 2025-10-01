using System.Text;

class Initializer
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "🧮 Advanced Calculator";

        try
        {
            while (true)
            {
                Console.Clear();

                Menu.MainMenu();

                short input = ConsoleManager.GetInput<short>("\n👉 Please enter the operation you wish to perform numerically: ");

                switch (input)
                {
                    case 1: Elementary.BasicOperation("addition", (val1, val2) => val1 + val2); break;
                    case 2: Elementary.BasicOperation("subtraction", (val1, val2) => val1 - val2); break;
                    case 3: Elementary.BasicOperation("multiplication", (val1, val2) => val1 * val2); break;
                    case 4: Elementary.BasicOperation("division", (val1, val2) => val1 / val2); break;
                    case 5: Advanced.Exponentiation("exponentiation", (baseNum, exponent) => Math.Pow(baseNum, exponent)); break;
                    case 6: Advanced.Root("root", (radicand, rootDegree) => Math.Pow(radicand, 1.0 / rootDegree)); break;
                    case 7: Advanced.Factorial("factorial");break;
                    default:
                        ConsoleManager.WriteColored(
                        "\n❓ The operation you want to perform could not be found.", ConsoleColor.Yellow); break;
                }
                ConsoleManager.WaitingScreen();
            }
        }
        catch (Exception exc)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occured: {exc.Message}");
        }
    }
}