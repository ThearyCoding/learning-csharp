using System;

class Program
{
    static void Mainx(string[] args)
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted array in descending order:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"arr[{i}] = {arr[i]}");
        }
        Console.ReadKey();
    }
}
