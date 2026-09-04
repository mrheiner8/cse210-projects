using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the Exercise3 Project.");

        // Welcome the user to the game
        Console.WriteLine("\nHello, and welcome to the Random Number Guessing Game!\nWe will generate random number from 1 - 100 and you try to guess what that number is.\nYou have unlimited guesses and you can play as long as you would like!");

        // Start replay while loop
        string keepPlaying = "yes";
        while (keepPlaying == "yes")
        {
            // generate the random magic number
            Random randomGenerator = new Random();


            // Setup variables for later
            int magicNumber = randomGenerator.Next(1, 101);
            int guessNumber = -1;
            int guessCount = 0;

            while (guessNumber != magicNumber)
            {

                // Ask the user for their guess number
                Console.Write("\nWhat is your guess? ");
                string userGuess = Console.ReadLine();

                // Transform string variable into int variable
                guessNumber = int.Parse(userGuess);

                // Count the number of guesses
                guessCount = guessCount + 1;

                // Determines if the guessNumber greater than, less than, or equal to the magicNumber 
                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("\nHigher");
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("\nLower");
                }
                else
                {
                    Console.WriteLine($"\nYou guessed it!\nIt took you {guessCount} guesses.");

                }
            }
            // Ask if the user would like to keep playing
            Console.Write("\nWould you like to play again (yes/no)? ");
            keepPlaying = Console.ReadLine();
        }
        // Thank the user for playing
        Console.Write("\nThank you for playing. Goodbye.\n");
    }
}