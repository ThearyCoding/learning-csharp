using System;
using System.Collections.Generic;

class CountRandom
{
    static void Mainx()
    {
        Console.Write("Enter number of elements: ");
        int numberOfElements = Convert.ToInt32(Console.ReadLine());

        // Creating a list to hold the random numbers
        List<int> list = new List<int>();

        // Creating a list to store unique numbers
        List<int> uniqueNumbers = new List<int>();

        // Creating a list to store counts of respective numbers
        List<int> counts = new List<int>();

        // Creating a Random instance to generate random numbers
        Random rand = new Random();

        // Generating random numbers and adding them to the list
        for (int i = 0; i < numberOfElements; i++)
        {
            int randomNumber = rand.Next(numberOfElements)+1; // Generates a random number between 1 and 10
            list.Add(randomNumber);
            Console.WriteLine($"list[{i}] = {randomNumber}");

            if (!uniqueNumbers.Contains(randomNumber))
            {
                uniqueNumbers.Add(randomNumber);
                counts.Add(1);
            }
            else
            {
                int index = uniqueNumbers.IndexOf(randomNumber);
                counts[index]++;
            }
        }

        Console.WriteLine("=================");

        // Printing the counts
        for (int i = 0; i < uniqueNumbers.Count; i++)
        {
            Console.WriteLine($"{uniqueNumbers[i]} count {counts[i]}");
        }
        Console.ReadLine();
    }
}