using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{
    public class Replicator : Challenge
    {
        public string challengeName => "The Replicator of D'To";
        public int challengeNumber => 14;

        public void Run()
        {
            Console.WriteLine("Creating an array with length of 5...");

            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++) // putting numbers into the array
            {
                Console.Write("\nPlease enter in a number to put into the array: ");
                int temp = int.Parse(Console.ReadLine());
                array[i] = temp;

                foreach (int k in array)
                { // printing the array one by one as they're pushed in
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"[{k}] ");
                    Console.ResetColor();
                }
            }

            int[] newArray = new int[5];

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nRepliating Array[{i}]: [{array[i]}] into New Array[{i}]...");
                newArray[i] = array[i];
                array[i] = 0; // setting the original array's value to 0 to show that it's been copied over
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Array: ");
                foreach (int k in array) // printing the array one by one as they're pushed in
                    Console.Write($"[{k}] ");

                Console.ResetColor();

                Console.WriteLine();


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("New Array: ");
                foreach (int j in newArray) // printing array
                    Console.Write($"[{j}] ");

                Console.ResetColor();
                if (i != newArray.Length - 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue copying...");
                    Console.ReadKey();
                }
            }

                Console.WriteLine();
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();

            }
        }
    }
