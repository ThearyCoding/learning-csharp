using System;
namespace Array
{
    internal class AddEltoArr
    {
        public static void Mainx(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter number to add = ");
            int add = int.Parse(Console.ReadLine());
            int[] temp = arr;
            arr = new int[arr.Length + add];
            for(int i = 0; i < temp.Length; i++)
            {
                arr[i] = temp[i];
            }
            for (int i = temp.Length; i < arr.Length; i++)
            {
                Console.Write($"Enter arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
            Console.ReadKey();
        }
    }
}
