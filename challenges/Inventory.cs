using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{
    public class Inventory : Challenge
    {
        public string challengeName => "Buying Inventory & Discounted Inventory";
        public int challengeNumber => 11;

        public void Run()
        {
            Console.WriteLine("The following items are available:");
            Console.WriteLine
                ("1 - Rope \n" +
                 "2 - Torches \n" +
                 "3 - Climbing Equipment \n" +
                 "4 - Clean Water \n" +
                 "5 - Machete \n" +
                 "6 - Canoe \n" +
                 "7 - Food Supplies \n");
            Console.WriteLine("What number do you want to see the price of? ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Hey, what's your name by the way?");
            string playerName = Console.ReadLine();
            double GOLD_DISCOUNT = 1; // 1 = no discount, .5 = 50% discount, etc.

            if (playerName.ToLower() == "iris")
                GOLD_DISCOUNT = .5;

            switch(choice)
            {
                case 1:
                    Console.WriteLine($"Ropes are {10 * GOLD_DISCOUNT} gold each.");
                    break;
                case 2:
                    Console.WriteLine($"Torches are {15 * GOLD_DISCOUNT} gold each.");
                    break;
                case 3:
                    Console.WriteLine($"A set of Climbing Equipment is {25 * GOLD_DISCOUNT} gold.");
                    break;
                case 4:
                    Console.WriteLine($"Clean Water is {15 * GOLD_DISCOUNT} gold each.");
                    break;
                case 5:
                    Console.WriteLine($"Machetes are {20 * GOLD_DISCOUNT} gold each.");
                    break;
                case 6:
                    Console.WriteLine($"Canoes are {200 * GOLD_DISCOUNT} gold each.");
                    break;
                case 7:
                    Console.WriteLine($"Food Supplies are {1 * GOLD_DISCOUNT} gold each.");
                    break;
                default:
                    Console.WriteLine("I'm sorry, I don't have that item in stock.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
