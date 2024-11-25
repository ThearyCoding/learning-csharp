using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>();

            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n;i++)
            {
                Employees emp = new Employees();
                emp.addEmployee();
                employees.Add(emp);
            }
            foreach(Employees emp in employees)
            {
                Console.WriteLine(
                    $"{emp.name} \t {emp.id} \t {emp.address} \t {emp.gender} \t {emp.age()} \t {emp.dob}"
                    );
            }
            Console.ReadKey();
        }

        private static void MainMethod()
        {
            List<Products> products = new List<Products>();
            int op;
            Console.Write("Enter number of product: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Products p = new Products();
                p.InsertProduct();
                products.Add(p);
            }
            do
            {
                Console.WriteLine("\n1. Add\r\n2. Delete\r\n3. View\r\n4. Quit \n");
                Console.Write("Input your choice : ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Products p = new Products();
                        Console.Write("Enter Id = ");
                        int pid = int.Parse(Console.ReadLine());
                        Console.Write("Enter Description = ");
                        string description = Console.ReadLine();
                        Console.Write("Enter Stock = ");
                        int stock = int.Parse(Console.ReadLine());
                        Console.Write("Enter Price = ");
                        double price = double.Parse(Console.ReadLine());
                        p = new Products(pid, description, stock, price);
                        products.Add(p);
                        break;
                    case 2:
                        Console.Write("Enter PID to Delete = ");
                        int tmpid = int.Parse(Console.ReadLine());
                        bool isdeleted = false;
                        foreach (Products product in products)
                        {
                            if (product.Pid == tmpid)
                            {
                                isdeleted = true;
                                products.Remove(product);
                                break;
                            }
                        }
                        if (isdeleted)
                        {
                            Console.WriteLine($"This product id {tmpid} have been deleted ");
                        }
                        else
                        {
                            Console.Write($"This product id {tmpid} not found in list");
                        }

                        break;
                    case 3:
                        foreach (Products product in products)
                        {
                            product.DisplayProduct();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Invalid Input please choose options (1-4)");
                        break;
                }

            } while (op != 4);
        }
    }
}
