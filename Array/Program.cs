using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        public static void Mainx(string[] args)
        {
            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter Element of arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Reverse Order : \n");
            for(int i = arr.Length -1; i >= 0; i--)
            {
                Console.Write(" " + arr[i]);
            }
            Console.ReadKey();
        }
    }
}
