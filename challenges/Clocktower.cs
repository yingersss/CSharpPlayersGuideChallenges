using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{
    public class Clocktower : Challenge
    {
        public string challengeName => "Repairing the Clocktower";
        public int challengeNumber => 9;

        public void Run()
        {
            Console.Write("Enter in a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("Tick");
            else
                Console.WriteLine("Tock");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
