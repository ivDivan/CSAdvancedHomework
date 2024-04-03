using Class02Homework.Homework03.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02Homework.Homework03.Domain.Models
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        private CarWash _carWash = new CarWash();
        private GasPump _gasPump = new GasPump();
        private RepairService _repairService = new RepairService();

        public void CheckVehicle()
        {
            _repairService.CheckVehicle();
        }

        public void FixVehicle()
        {
            _repairService.FixVehicle();
        }

        public void PumpGas()
        {
            _gasPump.PumpGas();
        }

        public void WashCar()
        {
            _carWash.WashCar();
        }

        public void WashTrailer()
        {
            _carWash.WashTrailer();
        }
    }
}
