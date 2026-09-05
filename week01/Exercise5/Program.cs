using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        // Call functions into main
        DisplayWelcome();

        // Store variable from called functions
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();

        // Use stored variable to perform the square math
        int sqrNumber = SquareNumber(favNumber);

        // Display a message with the values stored in 'userName' and 'sqrNumber'
        DisplayResult(userName, sqrNumber);
    }

    // Display a welcome 
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Ask for and return the users name as a string
    static string PromptUserName()
    {
        Console.Write("What is your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    // Ask for and return the users favorite number as an int converted from a string
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number: ");
        string number = Console.ReadLine();
        int favNumber = int.Parse(number);
        return favNumber;
    }

    // Multiply the users favorite number by itself and return the answer as an int
    static int SquareNumber(int favNumber)
    {
        int sqrNumber = favNumber * favNumber;
        return sqrNumber;
    }

    // Display the users name and square of their favorite number 
    static void DisplayResult(string userName, int sqrNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {sqrNumber}");
    }

}