using System;


namespace Array
{
    internal class OddandEven
    {
        public static void Mainx(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
        
            int evensum = 0;
            int oddsum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter Value [{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());

            }
            int oddCount = 0;
            int evenCount = 0;
            string outputEven = "";
            string outputOdd = "";
            for(int i = 0; i < n;i++)
            {
                if (arr[i] %2 == 0)
                {
                    evenCount++;
                    evensum += arr[i];
                    outputEven += arr[i].ToString() + "+"; 
                    
                }
                else
                {
                    oddCount++;
                    oddsum += arr[i];
                    outputOdd += arr[i].ToString() + "+";
                    
                }
            }
            Console.WriteLine();
            outputEven = outputEven.Substring(0, outputEven.Length - 1);
            outputOdd = outputOdd.Substring(0, outputOdd.Length - 1);
            Console.WriteLine(" " + outputEven + "=" + evensum);
            Console.WriteLine(" " + outputOdd + "=" + oddsum);
            Console.WriteLine($"Count Of Even Number = {evenCount}");
            Console.WriteLine($"Count Of Odd Number = {oddCount}");
            Console.ReadLine();
        }
    }
}
