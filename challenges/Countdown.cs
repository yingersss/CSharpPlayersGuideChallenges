using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{
    public class Countdown : Challenge
    {
        public string challengeName => "Countdown";
        public int challengeNumber => 16;

        public void CountdownFrom(int number)
        {
            if (number == 0) return; // base case, if number is 0, return out of the function
            Console.WriteLine(number); // print the number
            CountdownFrom(number - 1); // recursive call, calling the function again with number - 1
        }

        public void Run()
        {
            CountdownFrom(10);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
