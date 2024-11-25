using System;
namespace Array
{
    internal class No_duplicates
    {
        public static void Mainx(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                if(i == 0)
                {
                    Console.Write($"Enter arr[{i}] = ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write($"Enter arr[{i}] = ");
                    int temp = int.Parse(Console.ReadLine());
                    bool b = false;

                    for (int j = 0; j < i; j++)
                    {
                        if (arr[j] == temp)
                        {
                            b = true;
                            break;
                        } 
                    }
                    if (b)
                    {
                        i--;
                        continue;
                    }
                    arr[i] = temp;
                }
            }
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            
        }
    }
}
