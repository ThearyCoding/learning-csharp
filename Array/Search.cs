using System;

namespace Array
{
    internal class Search
    {
        public static void Mainx(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];


            for(int i = 0; i < n; i++)
            {
                Console.Write($"Enter Value of arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int value;
            Console.Write("Enter Value to Search = ");
            value = int.Parse(Console.ReadLine());

            for (int i = 0; i < n;i++)
            {
                if (value == arr[i])
                {
                    Console.WriteLine($"Found at index = {i} and The Value is = {arr[i]}");
                    break;
                }
                    
                
            }
            Console.ReadKey();
                

        }
    }
}
