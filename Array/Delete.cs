using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Delete
    {
        public static void Mainx(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter Value [{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());

            }
            int value;
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Enter Value to Delete = ");
            value = int.Parse(Console.ReadLine());
            bool found = false;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    arr[i] = arr[i + 1];
                    found = true;

                    break;
                }
            }

            if(found == true)
            {
                Console.WriteLine("Delete Successfully!\n");
            }
            else
            {
                Console.WriteLine("Delete Not Found try again!\t");
            }
            Console.WriteLine();
            for(int i = 1; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
