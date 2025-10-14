using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolca557.Factory
{
    internal class Car : Vehicle
    {
        public override string Name => "Auto";
        public override int MaxSpeed => 240;
        public override MotorFuelType FuelType => MotorFuelType.Gas | MotorFuelType.LPG;

        protected override bool DoStart()
        {
            Console.WriteLine($"{Name} nastartovano!");
            return true;
        }

        protected override bool DoStop()
        {
            Console.WriteLine($"{Name} zastaveno!");
            return true;
        }
    }
}
