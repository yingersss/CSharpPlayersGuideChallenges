using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{
    public class Freach : Challenge
    {
        public string challengeName => "The Laws of Freach";
        public int challengeNumber => 15;

        public void Run()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("\nPlease enter in a number to put into the array: ");
                int temp = int.Parse(Console.ReadLine());
                array[i] = temp;
            }

            int sum = 0;

            foreach (int i in array) // only used for reading array not modifying whatsoever
                sum += i;

            float avg = (float)sum / array.Length;
            Console.WriteLine($"The average is {sum}/{array.Length} = {avg}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
