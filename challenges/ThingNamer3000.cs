using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{

    public class ThingNamer3000 : Challenge
    {
        public string challengeName => "The Thing Namer 3000";
        public int challengeNumber => 3;

        public void Run()
        {
            Console.WriteLine("What kind of thing are we talking about?");
            string a = Console.ReadLine(); // stores a string in variable a
			Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string b = Console.ReadLine(); // stires a string in variable b
			// string c = " of Doom"; /* stores a string in variable c */
			string c = "of Doom 3000!";
			//string d = "3000"; // stores a string in variable d
			Console.WriteLine($"The {b} {a} {c} "); // prints the string stored in variable b, a, c and d to the console with spaces in between
			Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

			/* we can make this code more undestandable by combining strings c and d and the ! into one string rather than multiple strings
             * like so
             * string c = "of Doom 3000!";
             * also we can utilize string interpolation to make the final console.writeline more readable like so
             * Console.WriteLine($"The {b} {a} {c} ");
             */
		}
	}
}
