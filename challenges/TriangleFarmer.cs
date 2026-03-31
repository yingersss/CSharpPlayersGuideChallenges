using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{

    public class TriangleFarmer : Challenge
    {
        public string challengeName => "The Triangle Farmer";
        public int challengeNumber => 5;

        public void Run()
        {
            Console.WriteLine("Please enter in the base of the triangle: ");
            int triangleBase = int.Parse(Console.ReadLine()); // parse the user input as an integer and store it in the variable base, string -> int
            Console.WriteLine("Please enter in the height of the triangle: ");
            int height = int.Parse(Console.ReadLine());

            int area = triangleBase * height / 2;
            Console.WriteLine($"The area of the triangle is {area}.");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
