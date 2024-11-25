using System;
using System.Collections.Generic;

class RandomList
{
    static void Mainx()
    {
        Random rnd = new Random();
        List<int> list = new List<int>();
        Console.Write("Enter a nummber for random = ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            list.Add(rnd.Next(n) + 1);
        }
        Console.WriteLine();
        
            
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"List[{i}] = " + list[i]);
            
        }
        Console.WriteLine();

        // Find missing numbers
        Console.Write("Missing number : ");
        for (int i = 1; i <= n; i++)
        {
            if (!list.Contains(i))
            {
                Console.Write( i + ", ");
            }
        }
        // Find repeating numbers
        List<int> repeatingNumbers = new List<int>();
        List<int> uniqueNumbers = new List<int>();

        foreach (var number in list)
        {
            if (!uniqueNumbers.Contains(number))
            {
                uniqueNumbers.Add(number);
            }
            else
            {
                if (!repeatingNumbers.Contains(number))
                {
                    repeatingNumbers.Add(number);
                }
            }
        }
        Console.WriteLine();
        Console.Write("Repeating numbers: ");
        foreach (var num in repeatingNumbers)
        {
            Console.Write(num + ", ");
        }
        Console.ReadKey();
    }
}
