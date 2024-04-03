using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02Homework.Homework01.Domain.Models
{
    public class Manager : Employee
    {
        private int _hoursPerWeek {  get; set; }
        private double _payPerHour { get; set; }
        public Manager(string firstName, string lastName, int hoursPerWeek, double payPerHour) : base(firstName, lastName)
        {
            if (hoursPerWeek <= 0 || payPerHour <= 0)
            {
                throw new ArgumentException("What's your problem? Gimme positive values!!");
            }
            _hoursPerWeek = hoursPerWeek;
            _payPerHour = payPerHour;
        }

        public override double CalculateSalary()
        {
            Salary = _hoursPerWeek * _payPerHour;
            return Salary;
        }

        public override void DisplayInfo()
        {
            if (Salary == 0)
            {
                throw new ArgumentException("You gotta calculate the salary first!!!");
            }
            Console.WriteLine($"Manager {FirstName} {LastName}'s weekly salary is: {Salary}");
        }
    }
}
