using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{
    public class TakingANumber : Challenge
    {
        public string challengeName => "Taking a Number";
        public int challengeNumber => 16;

        int AskForANumber(string text)
        {
            Console.WriteLine($"{text}");
            return int.Parse(Console.ReadLine());
        }

        int AskForANumberInRange(string text, int min, int max)
        {
            min = AskForANumber("Please enter a number in for the minimum. ");
            max = AskForANumber("Please enter a number in for the maximum. ");
            int guess = AskForANumber(text);

            while (guess < min || guess > max)
                guess = AskForANumber(text);

            return guess;
        }

        public void Run()
        {
            int number = AskForANumberInRange("Please enter a number between the minimum and maximum. ", 0, 100);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
