using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{
    public class ManticoreHunt: Challenge
    {
        public string challengeName => "Hunting the Manticore";
        public int challengeNumber => 18;
        int MANTICORE_MAX_HEALTH = 10;
        int MANTICORE_HEALTH = 10;
        int CITY_MAX_HEALTH = 15;
        int CITY_HEALTH = 15;
        int roundNumber = 1;
        int manticoreDistance;
        int cannonDamage;

        public void reset()
        {
            MANTICORE_HEALTH = MANTICORE_MAX_HEALTH;
            CITY_HEALTH = CITY_MAX_HEALTH;
            roundNumber = 1;
            manticoreDistance = 0;
            cannonDamage = 0;
        }

        public void cannonAttack(int shotDistance)
        {

            if (shotDistance == manticoreDistance)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("That round was a DIRECT HIT!");
                MANTICORE_HEALTH -= cannonDamage;
                Console.ResetColor();
            }
            else if (shotDistance < manticoreDistance)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The shot fell short.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The shot was too far.");
                Console.ResetColor();
            }
        }

        public void setManticoreDistance()
        {
            do
            {
                Console.Write("Player 1, how far away from the city do you want to station the Manticore?: ");
                manticoreDistance = int.Parse(Console.ReadLine());
                if (manticoreDistance < 1 || manticoreDistance > 100)
                    Console.WriteLine("Please enter a distance between 1 and 100.");
            }
            while (manticoreDistance < 1 || manticoreDistance > 100);

            Console.Clear();

        }

        public void player2Turn()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"STATUS: Round: {roundNumber} City: {CITY_HEALTH}/{CITY_MAX_HEALTH} Manticore: {MANTICORE_HEALTH}/{MANTICORE_MAX_HEALTH} ");

            if (roundNumber % 3 == 0 && roundNumber % 5 == 0) // if the round number is a multiple of both 3 and 5, the cannon will deal 10 damage
            {
                cannonDamage = 10;
                Console.WriteLine("The cannon is is expected to deal 10 damage this round.");
            }
            else if (roundNumber % 3 == 0 || roundNumber % 5 == 0) // if the round number is a multiple of either 3 or 5, the cannon will deal 3 damage
            {
                cannonDamage = 3;
                Console.WriteLine("The cannon is expected to deal 3 damage this round.");
            }
            else
            {
                cannonDamage = 1; // default 1 damage
                Console.WriteLine("The cannon is is expected to deal 1 damage this round.");
            }

            Console.Write("Enter desired cannon range: ");
            int shotDistance = int.Parse(Console.ReadLine());
            cannonAttack(shotDistance); // call the cannon attack function with the shot distance

            roundNumber++;
            CITY_HEALTH--;

        }

        public void Run()
        {
            reset(); // reset the game state
            setManticoreDistance(); // player 1 sets the distance of the manticore from the city

            Console.WriteLine("Player 2, it is now your turn.");

            while (MANTICORE_HEALTH > 0)
            {
                player2Turn(); // while the manticore is still alive, player 2 will continue to take their turns attacking the manticore

                if (MANTICORE_HEALTH <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations! You have defeated the Manticore and saved the city!");
                    Console.ResetColor();
                    break;
                }
                else if (CITY_HEALTH <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The Manticore has destroyed the city.");
                    Console.ResetColor();
                    break;
                }
            }


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
