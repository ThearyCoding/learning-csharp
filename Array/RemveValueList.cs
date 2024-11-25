using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class RemveValueList
    {
        public static void Maxin()
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter list[{i}] = ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("Enter value to remove = ");
            int value = int.Parse(Console.ReadLine());
            int count = 0;
            while (list.Remove(value))
            {
                count++;
            };
            if (count > 0)
            {
                Console.WriteLine($"Have Benn delete = {count}");
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"list[{i}] = " + list[i]);
            }
            Console.ReadLine();
        }
    }
}
