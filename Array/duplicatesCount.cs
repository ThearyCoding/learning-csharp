using System;
namespace Array
{
    internal class duplicatesCount
    {
        public static void Mainx(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int count = 0;


            for(int i = 0; i < n; i++)
            {
                Console.Write($"Enter Value of arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            for(int i = 0; i < arr.Length;i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        Console.Write(arr[i] + " ");
                        break;
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine($"Count is = {count}");
            Console.ReadKey();
        }
    }
}
