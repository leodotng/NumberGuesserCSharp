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
        }
    }
}
