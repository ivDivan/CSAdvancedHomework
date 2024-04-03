using Class02Homework.Homework03.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02Homework.Homework03.Domain.Models
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("Hmmmmmm, now this is odd...");
        }

        public void FixVehicle()
        {
            Console.WriteLine("It purrs like a kitten...");
        }
    }
}
