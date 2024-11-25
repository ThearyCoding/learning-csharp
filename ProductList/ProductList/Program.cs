using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();


            do
            {
                Console.WriteLine("1 = Input Product");
                Console.WriteLine("2 = OutPut Product by Type");
                Console.WriteLine("3 = OutPut All Prodcut");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Product.InputProduct(productList);
                        break;
                    case 2:
                        Product.OutPutProductbyType(productList);
                        break;
                    case 3:
                        Product.OutPutAllProducts(productList);
                        break;
                }
            } while (true);
            Console.ReadKey();
        }
    }
}
