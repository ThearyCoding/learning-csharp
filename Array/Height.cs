using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Height
    {
        public static void Mainx(string[] args)
        {
            Console.Write("Enter number of height = ");
            int n = int.Parse(Console.ReadLine());
            int[] height = new int[n];
            int peakCount = 0;

            for (int i = 0; i < height.Length; i++)
            {
                Console.Write($"Enter height [{i}] = ");
                height[i] = int.Parse(Console.ReadLine());
            }
            
            if(height.Length > 0 && height[0] > height[1])
            {
                peakCount++;
            }
            for(int i = 1; i < height.Length -1; i++)
            {
                if (height[i] > height[i - 1] && height[i] > height[i + 1])
                {
                    peakCount++;
                }
            }

            if(height.Length > 1 && height[height.Length -1] > height[height.Length - 2])
            {
                peakCount++;
            }
            Console.WriteLine($"The Number Peaks = {peakCount}");

            Console.ReadKey();
        }
    }
}
