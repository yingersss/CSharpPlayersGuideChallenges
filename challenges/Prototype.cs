using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{
    public class Prototype : Challenge
    {
        public string challengeName => "The Prototype";
        public int challengeNumber => 12;

        public void Run()
        {
            int targetNumber;
            int guess;

            do
            {
                Console.Write("User 1, please enter in a number from 0 - 100: ");
                targetNumber = int.Parse(Console.ReadLine());
            }
            while (targetNumber < 0 || targetNumber > 100);

            Console.Clear(); // clear console

            do
            {
                Console.Write("User 2, please enter in your guess: ");
                guess = int.Parse(Console.ReadLine());
                if (guess == targetNumber)
                {
                    Console.WriteLine("Congratulations! You've guessed the number!");
                    break;
                }
                else if (guess < targetNumber)
                    Console.WriteLine($"{guess} is too low!");
                else
                    Console.WriteLine($"{guess} is too high!");
            }
            while (guess != targetNumber);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
