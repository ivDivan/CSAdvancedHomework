using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04Homework.Task01.Domain.Models
{
    public static class ExtensionMethods
    {
        public static void PrintInfo(this Circle circle)
        {
            Console.WriteLine($"Shape Circle with Id {circle.Id} has a radius of {circle.Radius}, area of {circle.GetArea()} and perimeter of {circle.GetPerimeter()}");
        }

        public static void PrintInfo(this Rectangle rectangle)
        {
            Console.WriteLine($"Shape Rectangle with Id {rectangle.Id} has a side A of {rectangle.SideA}, side B of {rectangle.SideB}, area of {rectangle.GetArea()} and perimeter of {rectangle.GetPerimeter()}");
        }
    }
}
