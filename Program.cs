using System;

// Namespace

namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run Get App Info Function to get info
            GreetUser(); // Ask for users name and greet user
            while (true)
            {
                // Init correct number
                //int correctNumber = 7;

                // Create a new Random Object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;
                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        // Keep Going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Math guess to correct number

                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number, please try again");
                    }
                }

                // Output success message
                PrintColorMessage(ConsoleColor.Yellow, "Correct you guessed it!");

                // Ask to play again
                Console.WriteLine("Play again? [Y or n]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        // Get and display app info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Josh";
            // Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;
            // Write out App info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            // Reset Text Color
            Console.ResetColor();

        }
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");
            // Get user input
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", inputName);

        }
        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change Text Color
            Console.ForegroundColor = color;

            // Tell user its not a number

            Console.WriteLine(message);
            // Reset Text Color
            Console.ResetColor();
        }
    }
}
