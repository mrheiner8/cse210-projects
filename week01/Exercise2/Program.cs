using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the Exercise2 Project.");
        
        // Ask the user for a grade in percentage.
        Console.Write("\nWhat is grade percentage? ");
        string gradePercent = Console.ReadLine();

        // Setup variables for latter
        int grade = int.Parse(gradePercent);
        string letter;
        int lastDigit = (grade % 10);
        string sign;

        // Determines the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign for the grade
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Handle A+ grades 
        // Grade >= 97 catches only last digits 7-9, since 93-96 already resolve to no sign
        if (grade >= 97)
        {
            sign = "";
        }

        // Handle F- and F+ Grades
        if (letter == "F")
        {
            sign = "";
        }


        // Tells the user if the class was passed
        Console.WriteLine($"\nYour letter grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats, you passed!\n");
        }
        else
        {
            Console.WriteLine("I'm sorry, you didn't pass.\n");
        }

    }
}