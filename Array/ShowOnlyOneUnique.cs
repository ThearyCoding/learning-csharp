using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ShowOnlyOneUnique
    {
        public static void Mainx(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            System.Random rand = new System.Random();

            int count = 0;
            for(int i  = 0; i < n; i++)
            {
                //Console.Write("Enter Value = ");
                arr[i] = rand.Next(10, 50);

            }
            int notUnique = 0;
            
            for(int i = 0; i < n;i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        isDuplicate = true;
                    }
                }
                if (!isDuplicate)
                {
                    
                    count++;
                    Console.WriteLine($"{arr[i]} it's an Unique!");
                }
                else
                {
                    Console.WriteLine($"{arr[i]} it's Not an Unique!");
                    notUnique++;
                }
               
            }
            Console.WriteLine($"Is Unique = {count}");
            Console.WriteLine($"It's note An Unique = {notUnique}");

            Console.ReadKey();
            
        }
    }
}
