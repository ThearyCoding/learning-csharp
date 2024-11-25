using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;
namespace OOP
{
    class Employee
    {
        public int id;
        public string name;
        public double houre;
        public double wage;
        public string gender;
        public DateTime dob;

        public Employee(int id, string name, double houre, double wage, string gender, DateTime dob)
        {
            this.id = id;
            this.name = name;
            this.houre = houre;
            this.wage = wage;
            this.gender = gender;
            this.dob = dob;
        }
        private static Random random = new Random();
        public Employee() { }
        

        public void InsertEmployee()
        {
            this.id = random.Next(100, 201); 

           
            string[] names = { "John", "Jane", "Michael", "Sarah", "Robert", "Emily" };
            this.name = names[random.Next(names.Length)];

            
            string[] genders = { "Male", "Female", "Other" };
            this.gender = genders[random.Next(genders.Length)];

     
            int year = random.Next(2000, 2007);
            int month = random.Next(1, 12);
            int day = random.Next(1, 31);
            this.dob = new DateTime(year, month, day);

            
            this.wage = random.NextDouble() * (50 - 10) + 10; 
            this.houre = random.NextDouble() * (40 - 10) + 10;

        }

        public double amount() => this.wage * this.houre;
    }
}
