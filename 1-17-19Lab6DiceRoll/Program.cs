using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_17_19Lab6DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;

            Console.WriteLine("Welcome to the casino!");
            Console.WriteLine("Would you like to roll the 2 dice? (y/n)");
            
            string roll = Console.ReadLine();
            int rollCount = 1;
            if (roll == "y")
            {
                do
                {
                    Console.WriteLine("How many sides do you want your 2 dice to have?\n");

                    int numberOfSides = int.Parse(Console.ReadLine());
                    while (numberOfSides <= 0)
                    {
                        Console.WriteLine("Please enter a number greater than 0: ");
                        numberOfSides = int.Parse(Console.ReadLine());
                    }
                    int firstRoll, secondRoll;

                    RDice(numberOfSides, out firstRoll, out secondRoll);
                    rollCount += 1;
                    Console.WriteLine("Roll {0}: {1}, {2}", rollCount, firstRoll, secondRoll);

                    Console.WriteLine("Would you like to roll again? (y/n)");
                    response = Console.ReadLine().ToLower();
                }
                while (response == "y");
                Console.WriteLine("Thanks for playing. Goodbye!");
            }
            else
            {
                Console.WriteLine("Goodbye! Hope you play next time.");
            }
        }
        public static void RDice(int sides, out int rollOne, out int rollTwo)
        {
            Random random = new Random();
            rollOne = random.Next(1, sides);
            rollTwo = random.Next(1, sides);
        }
    }
}


            ////Prompt the user to roll the dice

            //string userInput = Console.ReadLine();
            //int numOfSides = int.Parse(userInput);


            ////"Rolls" the two n-sided dice
            ////Display the results of each
            ////Ask usesr if they would like to roll the dice again

            ////Specifications: use static methods to generate random numbers
            ////Experiment with different random number generators that you can find on the internet.
            ////Use Random class to generate random number
            ////
