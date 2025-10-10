class Menu
{
    public static void MainMenu()
    {
        var mainMenuItems = new (string Text, ConsoleColor Color)[]
        {
            (" < 🏫 School Tracking System >\n", ConsoleColor.Cyan),
            ("👨‍🎓 1. Student", ConsoleColor.Blue),
            ("👩‍🏫 2. Lecturer", ConsoleColor.Red),
            ("👩‍💼 3. Authorized", ConsoleColor.White),
        };

        foreach (var item in mainMenuItems)
        {
            ConsoleManager.WriteColored(item.Text, item.Color);
        }
    }
}