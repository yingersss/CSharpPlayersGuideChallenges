using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{

    public class FourSistersDuckbear : Challenge
    {
        public string challengeName => "The Four Sisters and the Duckbear";
        public int challengeNumber => 6;

        public void Run()
        {
            Console.WriteLine("How many chocolate eggs were gathered today?: ");
            int eggs = int.Parse(Console.ReadLine());
            int eggsPerSister = eggs / 4;
            int leftoverEggs = eggs % 4;
            if (eggsPerSister == 1)
                Console.WriteLine($"The four sisters will each get {eggsPerSister} egg.");
            else
                Console.WriteLine($"The four sisters will each get {eggsPerSister} eggs.");

            if (leftoverEggs == 1)
                Console.WriteLine($"The Duckbear will get {leftoverEggs} egg.");
            else
                Console.WriteLine($"The Duckbear will get {leftoverEggs} eggs.");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
