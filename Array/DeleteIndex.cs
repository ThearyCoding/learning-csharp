using System;

class DeleteIndex
{
    static void Maidn(string[] args)
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int index;
        Console.Write("Enter index to remove = ");
        index = int.Parse(Console.ReadLine());

        int[] temp = arr;

        arr = new int[n - 1];

        for (int i = 0, j = 0; i < temp.Length; i++)
        {
            if (index == i)
            {
                continue;
            }
            arr[j] = temp[i];
            j++;
        }

        Console.WriteLine("Display array Value");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Arr[{i}] = {arr[i]}");
        }
        Console.ReadKey();
    }
}
