using Class02Homework.Homework03.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Class02Homework.Homework03.Domain.Enums.Type;

namespace Class02Homework.Homework03.Domain.Models
{
    public class Truck : Vehicle
    {
        public Type Type { get; set; }
        public Truck(int year, string make, string model) : base(year, make, model)
        {
            Type = Type.Truck;
        }

        public override void Drive()
        {
            Console.WriteLine("Wellcome to my roadtrain...");
        }
    }
}
