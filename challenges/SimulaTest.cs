using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{
    public class SimulaTest : Challenge
    {
        public string challengeName => "Simula's Test";
        public int challengeNumber => 19;
        public enum CHEST_STATE { OPEN, CLOSED, LOCKED }

        public CHEST_STATE setChestState(CHEST_STATE chest) 
        {   
            if (chest == CHEST_STATE.OPEN)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (chest == CHEST_STATE.CLOSED)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            Console.Write($"The chest is {chest}.");
            Console.ResetColor();
            Console.Write(" What do you want to do?: ");
            string temp = Console.ReadLine();
            temp = temp.ToLower();

            switch(temp)
            {
                case "open":
                    if (chest == CHEST_STATE.LOCKED) // if chest is locked, you can't open it
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The chest is locked, you can't open it.");
                        Console.ResetColor();
                        return setChestState(chest);
                    }
                    else if (chest == CHEST_STATE.CLOSED) // if chest is closed, open it
                    {
                        chest = CHEST_STATE.OPEN;
                        return setChestState(chest);
                    }
                    else // if chest is already open, just return the state
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The chest is already opened.");
                        Console.ResetColor();
                        return setChestState(chest);
                    }


                case "close":
                    if (chest == CHEST_STATE.OPEN)
                    {
                        chest = CHEST_STATE.CLOSED;
                        return setChestState(chest);
                    }
                    else if (chest == CHEST_STATE.LOCKED)
                    {  // if chest is locked , it's already closed , just return the state
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The chest is already locked, you can't close it.");
                        Console.ResetColor();
                        return setChestState(chest);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The chest is already closed.");
                        Console.ResetColor();
                        return setChestState(chest);
                    }


                case "lock":
                    if (chest == CHEST_STATE.CLOSED) // if chest is closed, lock it
                    {
                        chest = CHEST_STATE.LOCKED;
                        return setChestState(chest);
                    }
                    else if (chest == CHEST_STATE.OPEN)// if chest is open || locked, you can't lock it, just return the state
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The chest is already opened, you can't lock it.");
                        Console.ResetColor();
                        return setChestState(chest);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The chest is already locked, you can't lock it.");
                        Console.ResetColor();
                        return setChestState(chest);
                    }


                case "unlock":
                    if (chest == CHEST_STATE.LOCKED) // if chest is locked, unlock it
                    {
                        chest = CHEST_STATE.CLOSED;
                        return setChestState(chest);
                    }
                    else if (chest == CHEST_STATE.OPEN) // if chest is open, you can't unlock it, just return the state
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The chest is already opened, you can't unlock it.");
                        Console.ResetColor();
                        return setChestState(chest);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The chest is already unlocked, you can't unlock it.");
                        Console.ResetColor();
                        return setChestState(chest);
                    }


                default:
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Invalid input, try again.");
                    Console.ResetColor();
                    return setChestState(chest);
            }
            
        }


        public void Run()
        {
            CHEST_STATE chest = CHEST_STATE.LOCKED; // default state of the chest is locked

            while (true)
                setChestState(chest);

        }
    }
}
