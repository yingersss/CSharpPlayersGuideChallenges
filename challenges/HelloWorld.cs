using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{

    public class HelloWorld : Challenge
    {
        public string challengeName => "HelloWorld Challenge, What Comes Next, The Makings of a Programmer Challenge";
        public int challengeNumber => 1;

        public void Run()
        {
            Console.WriteLine("Running Challenge " + challengeNumber + ": " + challengeName + "!");
            Console.WriteLine("Hello, World!"); 
            Console.WriteLine("This is also the 'What comes next challenge'");
            Console.WriteLine("As well as the 'The makings of a programmer challenge'");
            Console.WriteLine("The fourth console.writeline");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
