using System;
namespace Array
{
    internal class InsertinArray
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

            int index;
            do
            {
                Console.Write("Enter index to insert = ");
                index = int.Parse(Console.ReadLine());
            } while(!(index > 0 && index <= n));
            Console.Write("Enter Value to insert = ");
            int value = int.Parse(Console.ReadLine());
            int[] temp = arr;
            arr = new int[n + 1];
            for(int i = 0,j=0; i < arr.Length; i++)
            {
                if(index == i)
                {
                    arr[i] = value;
                    continue;
                }
                arr[i] = temp[j];
                j++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = " + arr[i]);
            }
            Console.ReadKey();
        }
    }
}
