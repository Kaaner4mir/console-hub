using System.Text;
using System.Text.Json;

class ChosingAction
{
    public static void Action()
    {
        try
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string filePath = "Data\\Database.json";

            if (File.Exists(filePath))
            {

                string jsonData = File.ReadAllText(filePath);
                SchoolData data = JsonSerializer.Deserialize<SchoolData>(jsonData);
            }

            while (true)
            {
                Console.Clear();
                Menu.MainMenu();

                short action = ConsoleManager.GetInput<short>("\n👉 Select your login management: ");

                switch (action)
                {
                    case 1: StudentLogin.Login(); break;
                    case 2: LecturerLogin.Login(); break;
                    case 3: AuthorizedLogin.Login(); break;
                    default: ConsoleManager.WriteColored("\n❌ Please perform a valid transaction!", ConsoleColor.Yellow); break;
                }
                ConsoleManager.WaitingScreen();
            }
        }
        catch (Exception exc)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occured: {exc.Message}", ConsoleColor.Red);
        }
    }
}