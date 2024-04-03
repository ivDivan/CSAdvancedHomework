using Class02Homework.Homework03.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02Homework.Homework03.Domain.Models
{
    public class CarWash : ICarWash
    {
        public void WashCar()
        {
            Console.WriteLine("Working at the car wash!!!");
        }

        public void WashTrailer()
        {
            Console.WriteLine("Working at the trailer wash!!!");
        }
    }
}
