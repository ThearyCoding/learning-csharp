using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Products
    {
        private int pid;
        private string description;
        private int stock;
        private double price;
        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }
        
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int Stock
        {
            get { return stock;}
            set { stock = value; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        public Products() 
        { 
            this.pid = 0;
            this.description = "unknow";
            this.stock = 0;
            this.price = 0.0;
        }
        public double amount() { return this.stock * this.price; }
        public Products(int pid, string description, int stock, double price)
        {
            this.pid = pid;
            this.description = description;
            this.stock = stock;
            this.price = price;
        }
        public void InsertProduct()
        {
            Console.Write("Enter Id = ");
            this.pid = int.Parse(Console.ReadLine());
            Console.Write("Enter Description = ");
            this.description = Console.ReadLine();
            Console.Write("Enter Stock = ");
            this.stock = int.Parse(Console.ReadLine());
            Console.Write("Enter Price = ");
            this.price = double.Parse(Console.ReadLine());
            this.amount();
        }
        public void InsertProduct( int pid, string description, int stock, double price)
        {
            this.pid = pid;
            this.description = description;
            this.stock = stock;
            this.price = price;
        }
        public void DisplayProduct()
        {
            Console.WriteLine($"{pid}\t{description}\t{stock}\t{price}\t{amount()}");
        }

    }
}
