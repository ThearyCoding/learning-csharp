using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProductList.Product;

namespace ProductList
{
    

    public class Product
    {
        public enum ProductType
        {
            SOFTDRINK = 1,
            BERR = 2,
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

        public Product(int id, string name, ProductType type, double price, int qty)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Price = price;
            this.Qty = qty;
        }

        public Product() { }

        public static void InputProduct(List<Product> products)
        {
            Product product = new Product();

            Console.Write("Enter ID = ");
            product.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name = ");

            product.Name = Console.ReadLine();

            Console.WriteLine("Product Type : ");
            Console.WriteLine("1 = Soft Drink");
            Console.WriteLine("2 = BEER");

            int producttype = int.Parse(Console.ReadLine());

            switch(producttype)
            {
                case 1:
                    product.Type = ProductType.SOFTDRINK;
                    break;
                case 2:
                    product.Type = ProductType.BERR;
                    break;
            }

            Console.Write("Enter Price = ");
            product.Price = double.Parse(Console.ReadLine());
            Console.Write("Enter Qty = ");
            product.Qty = int.Parse(Console.ReadLine());
            products.Add(product);

        }
        public static void OutPutProductbyType(List<Product> products)
        {

            Console.WriteLine("Product Type : ");
            Console.WriteLine("1 = Soft Drink");
            Console.WriteLine("2 = BEER");

            int producttype = int.Parse(Console.ReadLine());
            ProductType productType;
            switch (producttype)
            {
                case 1:
                    producttype = (int)ProductType.SOFTDRINK;
                    break;
                case 2:
                    producttype = (int)ProductType.BERR;
                    break;
            }


            foreach (Product product in products)
            {
                if (product.Type == (ProductType)producttype)
                {
                    OutPutProduct(product);
                }
            }

        }

        public static void OutPutProduct(Product product)
        {
            Console.WriteLine($"ID : {product.Id}");
            Console.WriteLine($"Name : {product.Name}");
            Console.WriteLine($"Type : {product.Type}");
            Console.WriteLine($"Price : {product.Price}");
            Console.WriteLine($"Qty : {product.Qty}");
        }

        public static void OutPutAllProducts(List<Product> products)
        {
            Console.WriteLine("======================= All Product =====================");
            foreach(Product product in products)
            {
                OutPutProduct(product);
            }
        }
    }

}
