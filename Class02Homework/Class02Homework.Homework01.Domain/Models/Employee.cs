using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02Homework.Homework01.Domain.Models
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        public Employee(string firstName, string lastName)
        {
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException("Oi!! Which employee??!!");
            }
            FirstName = firstName;
            LastName = lastName;
            Salary = 0;
        }

        public abstract double CalculateSalary();
        public abstract void DisplayInfo();
    }
}
