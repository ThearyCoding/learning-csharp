using System;

namespace Array
{
    internal class Deletevalue
    {
        public static void Mxain(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int val;
            Console.Write("Enter Value to remove = ");
            val = int.Parse(Console.ReadLine());
            int count = 0;
            
            for(int i = 0; i < n; i++)
            {
                if (arr[i] == val)
                    count++;
            }

            if(count > 0)
            {
                int[] temp = arr;
                arr = new int[n - count];
                for (int i = 0, j = 0; i < temp.Length; i++)
                {
                    if (val == temp[i])
                    {
                        continue;
                    }
                    arr[j] = temp[i];
                    j++;
                }

                    Console.WriteLine("Array have benn delete is  = " + count + " Value(s)");
            }
            else
            {
                Console.WriteLine("Delete not found!");
            }
            
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = "+ arr[i]);
            }
            Console.ReadLine();
        }
    }
}
