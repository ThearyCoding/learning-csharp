using ConsoleTables;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_OOP
{
    public class User : Action
    {
        private int id;
        private string username;
        private string password;
        private string status;
        private string roleName;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Status { get => status; set => status = value; }
        public string RoleName { get => roleName; set => roleName = value; }

        public User(int id, string username, string password, string status, string roleName)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Status = status;
            this.RoleName = roleName;
        }
        
       
        public User() { }
        private static ArrayList userList = new ArrayList()
        {
            new User(1,"kimleng","123","active","admin"),
            new User(2,"Pheng","1234","active","staff")
        };
        
        public override void Add()
        {
            Console.WriteLine("Enter user details: ");

            Console.Write("Input ID = ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Input Username = ");
            string username = Console.ReadLine();

            Console.Write("Input Password = ");
            string password = Console.ReadLine();

            Console.Write("Input Status = ");
            string status = Console.ReadLine();

            Console.Write("Input Role Name = ");
            string roleName = Console.ReadLine();

       
            User newUser = new User(id, username, password, status, roleName);
            
            userList.Add(newUser);

        }
        public override void Update()
        {
            Console.Write("Enter the user id to update = ");
            int updateId = int.Parse(Console.ReadLine());
           
            foreach (User user in userList)
            {
                if (user.Id == updateId)
                {
                    Console.WriteLine("Enter the new details for the user:");

                    Console.Write("Input new ID = ");
                    user.Id = int.Parse(Console.ReadLine());

                    Console.Write("Input new Password = ");
                    user.Password = Console.ReadLine();

                    Console.Write("Input new Status = ");
                    user.Status = Console.ReadLine();

                    Console.Write("Input new Role Name = ");
                    user.RoleName = Console.ReadLine();

                    Console.WriteLine("User with ID '" + updateId + "' updated successfully!");
                    break;
                }
                else
                {
                    Console.WriteLine("User with ID '" + updateId + "' not found.");
                }
            }

            
        }

        public override void Display()
        {
            string[] header = { "ID", "UserName", "Password", "Status", "Role Name" };
            var table = new ConsoleTable(header);

            foreach (User user in userList)
            {
                table.AddRow(user.Id, user.Username,user.Password,user.status,user.RoleName);
            }

            table.Write();
            if (table.Rows.Count == 0)
            {
                Console.WriteLine("No have product yet");
            }
        }

        public override string Login()
        {
            Console.WriteLine("------------------------- System Login -------------------------");
            Console.Write("Enter username (or type 'exit' to stop) : ");
            string inputUsername = Console.ReadLine();

            if (inputUsername.ToLower() == "exit")
            {
                return "exit";
            }
            // EXit -> exit - exiT -> exit

            bool usernameExists = false;
            foreach (User user in userList)
            {
                if (user.Username == inputUsername)
                {
                    usernameExists = true;
                    break;
                }
            }

 
            if (!usernameExists)
            {
                Console.WriteLine("Username not found. Please try again.");
                return ""; 
            }

            Console.Write("Enter password: ");
            string inputPassword = Console.ReadLine();


            bool loginSuccessful = false;
            string admin_staff = "";
            foreach (User user in userList)
            {
                if (user.Username == inputUsername && user.Password == inputPassword)
                {
                    loginSuccessful = true;
                    Console.WriteLine("Login successful! Welcome, " + user.Username);

                    admin_staff = user.roleName;
                    break;
                }
            }

            if (!loginSuccessful)
            {
                Console.WriteLine("Incorrect password. Please try again.");
            }

            return admin_staff;
        }


        public override void Search()
        {
            Console.WriteLine("Enter the ID of the user you want to search:");
            int searchById = int.Parse(Console.ReadLine());

            foreach (User user in userList)
            {
                if (user.Id == searchById)
                {
                    Console.WriteLine("User found:");
                    Console.WriteLine("ID: " + user.Id);
                    Console.WriteLine("Username: " + user.Username);
                    Console.WriteLine("Password: " + user.Password);
                    Console.WriteLine("Status: " + user.Status);
                    Console.WriteLine("Role Name: " + user.RoleName);
                    break;
                }
                else
                {
                    Console.WriteLine("User with ID '" + searchById + "' not found.");
                }
            }
        }


    }
}
