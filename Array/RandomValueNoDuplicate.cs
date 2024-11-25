using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class RandomValueNoDuplicate
    {
        public static void Mainx()
        {
            List<int> list = new List<int>();
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                int temp = rand.Next(n) + 1;

                if (list.Contains(temp))
                {
                    i--;
                    continue;
                }
                list.Add(temp);
            }
            
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
