using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpPlayersGuideChallenges.challenges.SimulaSoup;

namespace CSharpPlayersGuideChallenges.challenges
{
    public class SimulaSoup : Challenge
    {
        public string challengeName => "Simula's Soup";
        public int challengeNumber => 20;
        public enum SOUP_TYPE { SOUP, STEW, GUMBO };
        public enum MAIN_INGREDIENT { MUSHROOMS, CHICKEN, CARROTS, POTATOES };
        public enum SEASONING { SPICY, SALTY, SWEET };

        public SOUP_TYPE decideSoupType()
        {
            Console.Write("Please choose a Soup Type from the list: SOUP, STEW, or GUMBO: ");
            string tempSoupType = Console.ReadLine().ToLower();

            switch (tempSoupType)
            {
                case "soup":
                    return SOUP_TYPE.SOUP;
                case "stew":
                    return SOUP_TYPE.STEW;
                case "gumbo":
                    return SOUP_TYPE.GUMBO;
                default:
                    Console.WriteLine("Invalid soup type, try again.");
                    return decideSoupType();
            }
        }

        public MAIN_INGREDIENT decideMainIngredient()
        {
            Console.Write($"Please choose a Main Ingredient from the list: MUSHROOMS, CHICKEN, CARROTS, POTATOES: ");
            string tempMainIngredient = Console.ReadLine().ToLower();

            switch (tempMainIngredient)
            {
                case "mushrooms":
                    return MAIN_INGREDIENT.MUSHROOMS;
                case "chicken":
                    return MAIN_INGREDIENT.CHICKEN;
                case "carrots":
                    return MAIN_INGREDIENT.CARROTS;
                case "potatoes":
                    return MAIN_INGREDIENT.POTATOES;
                default:
                    Console.WriteLine("Invalid main ingredient type, try again");
                    return decideMainIngredient();
            }
        }

        public SEASONING decideSeasoning()
        {
            Console.Write($"Please choose a seasoning from the list: SPICY, SALTY, SWEET: ");
            string tempSeasoning = Console.ReadLine().ToLower();

            switch (tempSeasoning)
            {
                case "spicy":
                    return SEASONING.SPICY;
                case "salty":
                    return SEASONING.SALTY;
                case "sweet":
                    return SEASONING.SWEET;
                default:
                    Console.WriteLine("Invalid seasoning type, try again.");
                    return decideSeasoning();
            }
        }


        public void Run()
        {

            SOUP_TYPE soupType = decideSoupType();
            MAIN_INGREDIENT mainIngredient = decideMainIngredient();
            SEASONING seasoning = decideSeasoning();

            var soup = (soupType, mainIngredient, seasoning);

            Console.WriteLine($"You've made a {soup.Item3} {soup.Item2} {soup.Item1}.");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
