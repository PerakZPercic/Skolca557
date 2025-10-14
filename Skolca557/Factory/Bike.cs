using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolca557.Factory
{
    internal class Bike : Vehicle
    {
        public override string Name => "Motorka";
        public override int MaxSpeed => 230;
        public override MotorFuelType FuelType => MotorFuelType.Gas;

        protected override bool DoStart()
        {
            Console.WriteLine($"{Name} nastartovana!");
            return true;
        }

        protected override bool DoStop()
        {
            Console.WriteLine($"{Name} zastavena!");
            return true;
        }
    }
}
