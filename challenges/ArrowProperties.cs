using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpPlayersGuideChallenges.challenges.SimulaSoup;

namespace CSharpPlayersGuideChallenges.challenges
{
    public class ArrowVin
    {
        public enum ARROWHEAD { STEEL, WOOD, OBSIDIAN };
        public enum FLETCHING { PLASTIC, TURKEY_FEATHERS, GOOSE_FEATHERS };
        private int Length { get; set; } // in cm
        private ARROWHEAD ArrowHead { get; set; }
        private FLETCHING Fletching { get; set; }

        public ArrowVin()
        {
            this.ArrowHead = getArrowHead();
            this.Fletching = getFletching();
            this.Length = getLength();
        }

        public float getCost()
        {
            float cost = 0;

            if (ArrowHead == ARROWHEAD.STEEL) cost += 10;
            else if (ArrowHead == ARROWHEAD.WOOD) cost += 3;
            else if (ArrowHead == ARROWHEAD.OBSIDIAN) cost += 5;

            if (Fletching == FLETCHING.PLASTIC) cost += 10;
            else if (Fletching == FLETCHING.TURKEY_FEATHERS) cost += 5;
            else if (Fletching == FLETCHING.GOOSE_FEATHERS) cost += 3;
            cost += Length * 0.05f;

            return cost;
        }

        public ARROWHEAD getArrowHead()
        {
            Console.Write("Please choose an arrowhead from the list: STEEL, WOOD, OBSIDIAN: ");
            string arrowhead = Console.ReadLine().ToLower();

            switch (arrowhead)
            {
                case "steel": return ARROWHEAD.STEEL;
                case "wood": return ARROWHEAD.WOOD;
                case "obsidian": return ARROWHEAD.OBSIDIAN;
                default:
                    Console.WriteLine("Invalid, please try again.");
                    return getArrowHead();
            }

        }

        public FLETCHING getFletching()
        {
            Console.Write("Please choose fletching type from the list: PLASTIC, TURKEY, GOOSE: ");
            string fletching = Console.ReadLine().ToLower();

            switch (fletching)
            {
                case "plastic": return FLETCHING.PLASTIC;
                case "turkey": return FLETCHING.TURKEY_FEATHERS;
                case "goose": return FLETCHING.GOOSE_FEATHERS;
                default:
                    Console.WriteLine("Invalid, please try again.");
                    return getFletching();
            }
        }

        public int getLength()
        {
            Console.Write("Please choose an arrow length between 60 - 100: ");
            int length = int.Parse(Console.ReadLine());

            if (length < 60 || length > 100)
            {
                Console.WriteLine("Invalid arrow length, please try again.");
                return getLength();
            }

            return length;
        }

    }
    public class ArrowProperties : Challenge
    {
        public string challengeName => "The Properties of Arrows";
        public int challengeNumber => 22;

        public void Run()
        {
            ArrowVin arrow = new ArrowVin();
            Console.WriteLine($"The total cost of the arrow is {arrow.getCost()} coins.");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
