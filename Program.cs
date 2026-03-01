using System.Reflection;

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
            .OrderBy(c => c.number)
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
                Console.WriteLine($"{challenge.number}. {challenge.name}");
            }

            Console.WriteLine("0. Exit");
            Console.Write("\nEnter challenge number: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
                continue;

            if (choice == 0)
                return;

            var selected =
                challenges.FirstOrDefault(c => c.number == choice);

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