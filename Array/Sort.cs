using System;


namespace Array
{
    internal class Sort
    {
        public static void Mainx(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Enter Value [{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Before Sorting");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < n;i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    
                }
            }
            Console.WriteLine("After Sorting!");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
        
    }
}
