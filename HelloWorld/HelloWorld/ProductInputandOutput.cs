using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class ProductInputandOutput
    {
        public static void OutputReport(double dis, double disPrice, double total, double payment)
        {
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Discount: " + dis);
            Console.WriteLine("Discount Price: " + disPrice);
            Console.WriteLine("Payment: " + payment);
        }

        public static double FindDiscount(double total)
        {
            double dis;
            if (total <= 50)
                dis = 5;
            else if (total <= 100)
                dis = 10;
            else if (total <= 150)
                dis = 15;
            else
                dis = 20;
            return dis;
        }

        public static void InputPrice(out double p1, out double p2, out double p3)
        {
            Console.Write("Enter p1: ");
            p1 = double.Parse(Console.ReadLine());
            Console.Write("Enter p2: ");
            p2 = double.Parse(Console.ReadLine());
            Console.Write("Enter p3: ");
            p3 = double.Parse(Console.ReadLine());
        }
        public static double FindTotal(double p1, double p2, double p3)
        {
            return p1 + p2 + p3;
        }

        public static double FindDisprice(double dis, double total)
        {
            return total * dis / 100;
        }

        public static double FIndPayment(double disprice, double total)
        {
            return total - disprice;
        }
    }
}
