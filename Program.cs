using System.Reflection;

// run dotnet restore
// dotnet build
// when pulling or cloning, run dotnet restore to get the dependencies

// use dotnet watch run to automatically rebuild and rerun the program when you make changes
// dotnet watch run
// so you dont have to manually stop and restart the program every time you make a change
class Program
{
    static List<Challenge> LoadChallenges()
    {
        var challengeInterface = typeof(Challenge);

        return Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t =>
                t.IsClass &&
                !t.IsAbstract &&
                challengeInterface.IsAssignableFrom(t))
            .Select(t => (Challenge)Activator.CreateInstance(t)!)
            .OrderBy(c => c.challengeNumber)
            .ToList();
    }

    static void DisplayChallenges(List<Challenge> challenges)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Select a challenge to run:\n");

            foreach (var challenge in challenges)
            {
                Console.WriteLine($"{challenge.challengeNumber}. {challenge.challengeName}");
            }

            Console.WriteLine("0. Exit");
            Console.Write("\nEnter challenge number: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
                continue;

            if (choice == 0)
                return;

            var selected =
                challenges.FirstOrDefault(c => c.challengeNumber == choice);

            if (selected != null)
            {
                Console.Clear();
                selected.Run();
            }
            else
            {
                Console.WriteLine("Invalid selection.");
                Console.WriteLine("Press any key to try again...");
                Console.ReadKey();
            }
        }
    }

    static void Main()
    {
        var challenges = LoadChallenges();

        if (challenges.Count == 0)
        {
            Console.WriteLine("No challenges found.");
            Console.ReadKey();
            return;
        }

        DisplayChallenges(challenges);

        Console.WriteLine("\nProgram finished.");
    }
}