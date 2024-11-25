using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string gender { get; set; }
        public DateTime dob;

        public double wage;
        public double houre;

        public Employee(int id, string name, string gender, DateTime dob, double wage, double houre)
        {
            this.Id = id;
            this.Name = name;
            this.gender = gender;
            this.dob = dob;
            this.wage = wage;
            this.houre = houre;
        }
        public Employee()
        {
            Id = 0;
            Name = "No Name";
            gender = "Other";
            dob = DateTime.Now;
            wage = 0.0;
            houre = 0.0;
        }

        public double calculateSalary(double wage , double houre)
        {
            this.wage = wage;
            this.houre = houre;
            return wage * houre;
        }

    }
}
