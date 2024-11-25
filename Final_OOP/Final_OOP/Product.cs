using ConsoleTables;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Final_OOP
{
    internal class Product : Action
    {
        private int id;
        private string name;
        private long barcode;
        private double sellprice;
        private int qtyintstock;
        private string categoryName;
        public Product(int id, string name, long barcode, double sellprice, int qtyintstock, string categoryName)
        {
            this.id = id;
            this.name = name;
            this.barcode = barcode;
            this.sellprice = sellprice;
            this.qtyintstock = qtyintstock;
            this.categoryName = categoryName;
        }

        public Product() { }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public long Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        public double SellPrice
        {
            get { return sellprice; }
            set { sellprice = value; }
        }

        public int QtyInStock
        {
            get { return qtyintstock; }
            set { qtyintstock = value; }
        }

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public override void Add()
        {
            while (true)
            {
                Console.Write("Input ID (or type 'exit' to stop adding): ");
                string inputId = Console.ReadLine();

                if (inputId.ToLower() == "exit")
                    break;

                int id = int.Parse(inputId);
                

                Console.Write("Input Name: ");
                string name = Console.ReadLine();

                Console.Write("Input Barcode: ");
                long barcode = long.Parse(Console.ReadLine());
                
                Console.Write("Input Sell Price: ");
                double sellPrice = double.Parse(Console.ReadLine());
                

                Console.Write("Input Quantity in Stock: ");
                int qtyInStock = int.Parse(Console.ReadLine());
                
                Console.Write("Input Category Name: ");
                string categoryName = Console.ReadLine();
                Product p = new Product(id, name, barcode, sellPrice, qtyInStock, categoryName);
                
                productList.Add(p);
                Console.WriteLine("Product added successfully.");
            }
        }



        private static ArrayList productList = new ArrayList();


        public override void Display()
        {
            string[] header = { "ID", "Name", "Barcode", "SellPrice", "Qty In Stock", "Category Name" };
            var table = new ConsoleTable(header);

            foreach (Product product in productList)
            {
                table.AddRow(product.Id, product.Name, product.Barcode, product.SellPrice, product.QtyInStock, product.CategoryName);
            }

            table.Write();
            if(table.Rows.Count == 0)
            {
                Console.WriteLine("No have product yet");
            }
        }
        public override void Update()
        {
            Console.Write("Enter the ID of the product to update = ");
            int updateId = int.Parse(Console.ReadLine());
            foreach (Product product in productList)
            {
                if (product.Id == updateId)
                {
                    if (product != null)
                    {
                        Console.WriteLine("Enter new values for the product properties:");
                        Console.Write("Input Name = ");
                        product.Name = Console.ReadLine();

                        Console.Write("Input Barcode = ");
                        product.Barcode = long.Parse(Console.ReadLine());
                        

                        Console.Write("Input Sell Price = ");
                        product.SellPrice = double.Parse(Console.ReadLine());   

                        Console.Write("Input Quantity in Stock = ");
                        product.QtyInStock = int.Parse(Console.ReadLine());

                        Console.Write("Input Category Name = ");
                        product.CategoryName = Console.ReadLine();

                        Console.WriteLine("Product with ID '" + updateId + "' updated successfully!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Product with ID '" + updateId + "' not found.");
                    }
                }
            }

            
        }


        public override void Search()
        {
            bool found = false;
            while (true) 
            {
                Console.Write("Enter the ID to search (or type 'exit' to stop searching): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break; 

                int searchId = int.Parse(input);
                

                foreach (Product product in productList)
                {
                    if (product.Id == searchId)
                    {
                        Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Barcode: {product.Barcode}, " +
                                          $"Sell Price: {product.SellPrice}, Quantity in Stock: {product.QtyInStock}, " +
                                          $"Category Name: {product.CategoryName}");
                        found = true;
                        break; 
                    }
                }

                if (found)
                    break; 

                Console.WriteLine("Product not found.");
            }
        }

        public override void Delete()
        {
            Console.Write("Enter the ID of the product to delete: ");
            int deletebyId = int.Parse(Console.ReadLine());
            
            foreach(Product product in productList)
            {
                if (product.Id == deletebyId)
                {
                    if (product != null)
                    {
                        productList.Remove(product);
                        Console.WriteLine("Product deleted successfully.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Product not found.");
                    }
                }
                
            }

            
        }

    }
}
