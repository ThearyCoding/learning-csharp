using System;


namespace Array
{
    internal class Find_Max
    {
        public static void Mainx()
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for(int i =  0; i < arr.Length; i++)
            {
                Console.Write($"Enter All arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = arr[0];
            for(int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.Write($"Maximum is = {max}");
            Console.ReadKey();
        }
    }
}
