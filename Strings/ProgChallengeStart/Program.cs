﻿using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            int inputInt = 0;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            switch (inputInt)
            {
                case inputInt < theNumber:
                    Console.WriteLine($"{inputInt} is less than the number");
                    break;
            }

            try
            {
                do
                {
                    inputInt = int.Parse(Console.ReadLine());
                    
                } while (inputInt != -1);
            }
            catch
            {
                Console.WriteLine("Please enter a number");
            }



            // Keep track of the number of guesses and the current user guess

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer

        }
    }
}
