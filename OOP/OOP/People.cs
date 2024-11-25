using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class People
    {
        public string name;
        public DateTime dob;
        public string gender;
        public virtual double tSalary(int h , double w)
        {
            return h* w;
        }
        public int age()
        {
            int currentYear = DateTime.Now.Year;
            int yob = dob.Year;
            return currentYear - yob;
        }


    }
    class Employees: People
    {
        public int id;
        public string address;
        public Employees() { }
        public override double tSalary(int h,double w)
        {
            return h * w - h * w * 0.05;
        }
        public void addEmployee()
        {
            Employees e = new Employees();
            Console.Write("Enter ID = ");
            e.id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name = ");
            e.name = Console.ReadLine();
            Console.Write("Enter Gender = ");
            e.gender = Console.ReadLine();
            Console.Write("Enter Address = ");
            e.address = Console.ReadLine();
            e.dob = DateTime.Parse(Console.ReadLine());
        }

    }
}
