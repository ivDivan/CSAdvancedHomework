using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07Homework.CarApp.Domain.Models
{
    public static class PrintHelper
    {
        public static void PrintCars(IEnumerable<Car> cars)
        {
            foreach (Car car in cars)
            {
                Console.Write(car.Model + ", ");
            }
        }
    }
}
