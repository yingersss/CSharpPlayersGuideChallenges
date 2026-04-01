using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{
    public class Watchtower : Challenge
    {
        public string challengeName => "Watchtower";
        public int challengeNumber => 10;

        public void Run()
        {
            Console.Write("Enter in the x-coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter in the y-coordinate: ");
            int y = int.Parse(Console.ReadLine());

            string direction = "";

            if (y > 0)
                direction = "North";
            else if (y < 0)
                direction = "South";

            if (x > 0)
                direction += "East";
            else if (x < 0)
                direction += "West";

            if (y == 0 && x == 0)
                Console.WriteLine("The enemy is here!");
            else
                Console.WriteLine($"The enemy is to the {direction}!");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
