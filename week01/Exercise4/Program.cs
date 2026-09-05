using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the Exercise4 Project.");

        // Ask the user to supply a list. of numbers
        Console.WriteLine("\nEnter a list of numbers, type 0 when finished.");

        // List and Number variable
        List<int> numbers = new List<int>();
        int listNumber = -1;
        int total = 0;
        

        // loop to get a list of numbers from the user
        while (listNumber != 0)
        {
            // Ask the user for their guess number
            Console.Write("\nEnter number: ");
            string usersNumber = Console.ReadLine();

            // Transform string variable into int variable
            listNumber = int.Parse(usersNumber);

            //add to list
            if (listNumber != 0)
            {
                numbers.Add(listNumber);
            }
        }

        // Calculate the total of all the numbers in the list
        foreach (int totalNumber in numbers)
        {
            total += totalNumber;
        }
        Console.WriteLine($"\nThe sum is: {total}");

        // Calculates the average of all numbers in the list
        int count = numbers.Count;
        float average = (float)total / count;
        Console.WriteLine($"\nThe average is: {average}");
    /*
    # Calculate the lagest number of all the numbers in the list
    max = -1
    for number in numbers:
        if number > max:
            max = number
    print(f'The largest number is: {max}')

    # Calculate the smallest positive number of all the numbers in the list
    smallest = 9999999999999999
    for number in numbers:
        if number > 0 and number < smallest:
            smallest = number
    print(f'The smallest positive number is: {smallest}')
    */
    }
}