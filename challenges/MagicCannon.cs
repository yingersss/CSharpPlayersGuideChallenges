using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{
	public class MagicCannon : Challenge
	{
		public string challengeName => "The Magic Cannon";
		public int challengeNumber => 13;

		public void Run()
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
				{
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine($"{i}: Electric Fire");
				}
				else if (i % 3 == 0)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine($"{i}: Fire");
				}
				else if  (i % 5 == 0)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine($"{i}: Electric");
				}
				else
				{
					Console.ResetColor();
					Console.WriteLine($"{i}: Normal");
				}
			}

			Console.WriteLine();
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();

		}
	}
}
