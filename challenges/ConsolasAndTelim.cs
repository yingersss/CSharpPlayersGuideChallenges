using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{

    public class ConsolasAndTelim : Challenge
    {
        public string challengeName => "Consalas and Telim";
        public int challengeNumber => 2;

        public void Run()
        {
            string personName;
            Console.WriteLine("Bread is ready.");
            Console.WriteLine("Who is the bread for?");
            personName = Console.ReadLine();
            Console.WriteLine("Noted. " + personName + " got the bread.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
