class ConsoleManager
{
    public static T GetInput<T>(string message, ConsoleColor color = ConsoleColor.White)
    {
        while (true)
        {
            WriteColored(message, color, false);
            string? text = Console.ReadLine();

            try
            {
                if (typeof(T) == typeof(string))
                {
                    if (!string.IsNullOrWhiteSpace(text))
                        return (T)(object)text;
                }
                else
                {
                    return (T)Convert.ChangeType(text, typeof(T));
                }
            }
            catch
            {
                WriteColored($"\n⚠️ Please enter a valid {typeof(T).Name} value!", ConsoleColor.Red);
            }
        }
    }

    public static void WriteColored(string text, ConsoleColor color = ConsoleColor.White, bool newLine = true)
    {
        Console.ForegroundColor = color;
        if (newLine) Console.WriteLine(text);
        else Console.Write(text);
        Console.ResetColor();
    }

    public static void WaitingScreen(ConsoleColor color = ConsoleColor.White)
    {
        Console.CursorVisible = false;
        WriteColored("\n⏳ Press any key to continue ...", color);
        Console.ReadKey(intercept: true);
        Console.CursorVisible = true;
    }

}