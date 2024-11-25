using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class AddvalueToList
    {
        public static void Mainx()
        {
            List<int> list = new List<int>();
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.Write($"Enter arr[{i}] = ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
