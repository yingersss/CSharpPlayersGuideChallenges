using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{
    // incrementing and decrementing exercise
    public class DefenseOfConsolas : Challenge
    {
        public string challengeName => "The Defense of Consolas";
        public int challengeNumber => 8;

        // 6 5 -> (6, 4) (5, 5) (6, 6) (7,5)
        //        0 -1    -1 0   0  +1  +1 -1
        public void Run()
        {
            Console.Title = "Defense of Consolas";
            Console.Write("Target Row?: ");
            int targetRow = int.Parse(Console.ReadLine());
            Console.Write("Target Column?: ");
            int targetColumn = int.Parse(Console.ReadLine());

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Deploy to: \n" +
                $"({targetRow}, {targetColumn - 1}) \n" +
                $"({targetRow - 1}, {targetColumn}) \n" +
                $"({targetRow}, {targetColumn + 1}) \n" +
                $"({targetRow + 1}, {targetColumn - 1})");
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Console.Title = "C# Player's Guide Challenges";

        }
    }
}
