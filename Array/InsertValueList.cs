using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class InsertValueList
    {
        public static void Maxin()
        {
            List<int> list = new List<int>();
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter list[{i}] = ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            int index;
            do
            { 
                Console.Write("Enter index to insert = ");
                index = int.Parse(Console.ReadLine());
            } while (!(index > 0 && index <= n));
            Console.Write("Enter value to insert = ");
            int value = int.Parse(Console.ReadLine());

            list.Insert(index, value);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"list[{i}] = " + list[i]);
            }
            Console.ReadLine();
        }
    }
}
