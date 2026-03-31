using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{
    // incrementing and decrementing exercise
    public class DominionOfKings : Challenge
    {
        public string challengeName => "The Dominion of Kings";
        public int challengeNumber => 7;
          
        public void Run()
        {
            Console.WriteLine("How many estates do you have in total?: ");
            int totalPoints = int.Parse(Console.ReadLine());
            Console.WriteLine("How many duchys do you have in total?: ");
            totalPoints += int.Parse(Console.ReadLine()) * 3;
            Console.WriteLine("How many provinces do you have in total?: ");
            totalPoints += int.Parse(Console.ReadLine()) * 6;

            Console.WriteLine($"You have a total of {totalPoints} Dominion points.");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
