class Memory
{
    public static void MemoryOperations()
    {
        Console.Clear();

        Menu.MemoryMenu();

        short input = ConsoleManager.GetInput<short>("\n👉 Please enter the operation you wish to perform numerically: ");

        double memory = 0;

        switch (input)
        {
            case 1:
                {
                    double inputMemory = ConsoleManager.GetInput<double>("\n👉 Enter the number you want to add to memory: ");
                    memory += inputMemory;
                    ConsoleManager.WriteColored($"\n💾 Memory: {memory}", ConsoleColor.Green);
                }
                break;
            case 2:
                {
                    double inputMemory = ConsoleManager.GetInput<double>("\n👉 Enter the number you want to substract from memory: ");
                    memory += inputMemory;
                    ConsoleManager.WriteColored($"\n💾 Memory: {memory}", ConsoleColor.Green);

                }
                break;
            case 3: memory = 0; ConsoleManager.WriteColored($"\n💾 Memory: {memory}", ConsoleColor.Green); break;
            case 4: ConsoleManager.WriteColored($"\n💾 Memory: {memory}", ConsoleColor.Green); break;
            default:
                ConsoleManager.WriteColored(
                "\n❓ The operation you want to perform could not be found.", ConsoleColor.Yellow); break;
        }
    }
}