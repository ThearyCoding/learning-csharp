using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class RandomNoDuplicate2
    {
        public static void Mainx()
        {
            List<int> list = new List<int>();
            List<int> temp = new List<int>();
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for(int i = 1; i <= n; i++)
            {
                temp.Add(i);
            }
            for(int i = 0; i < n; i++)
            {
                int index = rand.Next(temp.Count);

                list.Add(temp[index]);

                temp.RemoveAt(index);
                Console.WriteLine($"arr[{i}] = {list[i]}");
            }
            Console.ReadLine();
        }
    }
}
