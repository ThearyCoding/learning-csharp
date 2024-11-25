using System;

namespace Final_OOP
{
    internal class Program
    {
        static bool isAdminLoggedIn = false;

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                User user = new User();
                string admin_staff = user.Login();

                if (admin_staff.Equals("admin"))
                {
                    Console.WriteLine("======================== Admin Management ========================");
                    Console.WriteLine("1. Product Management");
                    Console.WriteLine("2. User Management");
                    Console.WriteLine("3. Logout");
                    Console.Write("Enter your choice: ");

                    int choice = int.Parse(Console.ReadLine());


                    switch (choice)
                    {
                        case 1:
                            ProductManagement();
                            break;
                        case 2:
                            UserManagement();
                            break;
                        case 3:
                            exit = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option from the menu.");
                            break;
                    }
                }
                else if (admin_staff.Equals("staff"))
                {
                    Console.WriteLine("======================== Sale Management ========================");
                    Console.WriteLine("1. Product Management");
                    Console.WriteLine("2. Logout");
                    Console.Write("Enter your choice: ");

                    int choice = int.Parse(Console.ReadLine());


                    switch (choice)
                    {
                        case 1:
                            ProductManagement();
                            break;
                        case 2:
                            exit = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option from the menu.");
                            break;
                    }
                }else if (admin_staff.ToLower().Equals("exit"))
                {
                    exit = true;
                }
                
            }

            Console.WriteLine("Exiting program. Press any key to close...");
            Console.ReadKey();
        }
       
        static void ProductManagement()
        {
            Product p = new Product();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nProduct Management Menu:");
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. Display all products");
                Console.WriteLine("3. Search for a product");
                Console.WriteLine("4. Update a product");
                Console.WriteLine("5. Delete a product");
                Console.WriteLine("6. Back to Main Menu");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());
               

                switch (choice)
                {
                    case 1:
                        p.Add();
                        break;
                    case 2:
                        p.Display();
                        break;
                    case 3:
                        p.Search();
                        break;
                    case 4:
                        p.Update();
                        break;
                    case 5:
                        p.Delete();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option from the menu.");
                        break;
                }
            }
        }

        static void UserManagement()
        {
            User user = new User();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== User Management System =====");
                Console.WriteLine("1. Add a user");
                Console.WriteLine("2. Display all users");
                Console.WriteLine("3. Search for a user");
                Console.WriteLine("4. Update a user");
                Console.WriteLine("5. Login");
                Console.WriteLine("6. Back to Main Menu");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        user.Add();
                        break;
                    case 2:
                        user.Display();
                        break;
                    case 3:
                        user.Search();
                        break;
                    case 4:
                        user.Update();
                        
                        break;
                    case 5:
                        user.Login();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option from the menu.");
                        break;
                }
            }
        }

    }
}
