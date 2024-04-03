using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02Homework.Homework01.Domain.Models
{
    public class Programmer : Employee
    {
        private double _payPerHour {  get; set; }
        private int _hoursPerWeek { get; set; }

        public Programmer(string firstName, string lastName, int hoursPerWeek, double payPerHour):
            base(firstName, lastName)
        {
            if(hoursPerWeek <= 0 ||  payPerHour <= 0)
            {
                throw new ArgumentException("What's your problem? Gimme positive values!!");
            }
            _payPerHour = payPerHour;
            _hoursPerWeek = hoursPerWeek;
        }
        public override double CalculateSalary()
        {
            Salary = _hoursPerWeek * _payPerHour;
            return Salary;
        }

        public override void DisplayInfo()
        {
            if(Salary == 0)
            {
                throw new ArgumentException("You gotta calculate the salary first!!!");
            }
            Console.WriteLine($"Programmer {FirstName} {LastName}'s weekly salary is: {Salary}");
        }
    }
}
