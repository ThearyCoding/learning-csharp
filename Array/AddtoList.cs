using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class AddtoList
    {
        public static void Mainx(string[] args)
        {
            List<int> list = new List<int>();
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Enter list[{i}] = ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("Enter number to add = ");
            int add = int.Parse(Console.ReadLine());

            for(int i = n; i < n+add; i++)
            {
                Console.Write($"Enter list[{i}] = ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            for(int i = 0; i < n+add ; i++)
            {
                Console.WriteLine($"list[{i}] = {list[i]}");
            }
            Console.ReadLine();
        }
    }
}
