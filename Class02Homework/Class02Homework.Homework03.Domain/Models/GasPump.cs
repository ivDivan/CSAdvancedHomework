using Class02Homework.Homework03.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02Homework.Homework03.Domain.Models
{
    public class GasPump : IGasPump
    {
        public void PumpGas()
        {
            Console.WriteLine("Pump, pump, pump the gas, gently down the street...");
        }
    }
}
