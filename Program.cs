﻿using System;

// Namespace

namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Josh";
            // Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;
            // Write out App info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion,appAuthor);
            // Reset Text Color
            Console.ResetColor();
            // Ask users name
            Console.WriteLine("What is your name?");
            // Get user input
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
            // Init correct number
            int correctNumber = 7;
            // Init guess var
            int guess = 0;
            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            // While guess is not correct
            while(guess != correctNumber) {
                // Get users input
                string input = Console.ReadLine();

                // Make sure its a number

                //Cast to int and put in guess
                guess = Int32.Parse(input);

                // Math guess to correct number

                if(guess != correctNumber) {
                    // Change Text Color
                    Console.ForegroundColor = ConsoleColor.Red;
                    // Tell user its wrong number
                    Console.WriteLine("Wrong Number, please try again");
                    // Reset Text Color
                    Console.ResetColor();
                }
            }

            // Output success message
            // Change Text Color
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Tell user correct number
            Console.WriteLine("You are correct!");
            // Reset Text Color
            Console.ResetColor();
        }
    }
}
