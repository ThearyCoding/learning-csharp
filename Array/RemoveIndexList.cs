using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class RemoveIndexList
    {
        public static void Mainx()
        {
            List<int> list = new List<int>();
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter list[{i}] = ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("Enter index to remove = ");
            int index = int.Parse(Console.ReadLine());

            list.RemoveAt(index);
            Console.WriteLine("Display List Value");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"List[{i}] = {list[i]}");
            }
            Console.ReadLine();
        }
    }
}
