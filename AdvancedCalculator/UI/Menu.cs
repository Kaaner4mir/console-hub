class Menu
{
    public static void MainMenu()
    {
        var mainMenuItems = new (string Text, ConsoleColor Color)[]
        {
            (" ----- 🧮 Elementary Mathematics -----\n", ConsoleColor.Cyan),
            (" 1. Addition", ConsoleColor.Yellow),
            (" 2. Subtraction", ConsoleColor.DarkYellow),
            (" 3. Multiplication", ConsoleColor.Red),
            (" 4. Division\n", ConsoleColor.DarkRed),

            (" ----- 🔢 Advanced Mathematics -----\n", ConsoleColor.Cyan),
            (" 5. Exponentiation", ConsoleColor.Green),
            (" 6. Root", ConsoleColor.DarkGreen),
            (" 7. Factorial", ConsoleColor.Blue),
            (" 8. Modulo", ConsoleColor.DarkBlue),
            (" 9. Logarithm", ConsoleColor.Magenta),
            ("10. Trigonometry\n", ConsoleColor.DarkMagenta),

            (" ----- 💾 Memory Operations -----\n", ConsoleColor.Cyan),
            ("11. Memory Operations", ConsoleColor.Gray),
            ("12. Exit", ConsoleColor.White)
        };

        foreach (var item in mainMenuItems)
        {
            ConsoleManager.WriteColored(item.Text, item.Color);
        }
    }

    public static void TrigonometryMenu()
    {
        var mainMenuItems = new (string Text, ConsoleColor Color)[]
       {
            (" ----- 📐 Trigonometry -----\n", ConsoleColor.Cyan),
            (" 1. Sine", ConsoleColor.Yellow),
            (" 2. Cosine", ConsoleColor.Red),
            (" 3. Tangent", ConsoleColor.Cyan),
            (" 4. Cotangent", ConsoleColor.Blue),
            (" 5. Secant", ConsoleColor.Magenta),
            (" 6. Cosecant", ConsoleColor.White),
       };

        foreach (var item in mainMenuItems)
        {
            ConsoleManager.WriteColored(item.Text, item.Color);
        }
    }

    public static void MemoryMenu()
    {
        var mainMenuItems = new (string Text, ConsoleColor Color)[]
      {
            (" ----- 💾 Memory Operations -----\n", ConsoleColor.Cyan),
            (" 1. Memory Add", ConsoleColor.White),
            (" 2. Memory Subtract", ConsoleColor.Magenta),
            (" 3. Memory Recall", ConsoleColor.Red),
            (" 4. Memory Clear", ConsoleColor.Blue),
      };

        foreach (var item in mainMenuItems)
        {
            ConsoleManager.WriteColored(item.Text, item.Color);
        }
    }
}