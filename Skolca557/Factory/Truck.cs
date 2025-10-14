using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolca557.Factory
{
    internal class Truck : Vehicle
    {
        public override string Name => "Kamion";
        public override int MaxSpeed => 180;
        public override MotorFuelType FuelType => MotorFuelType.Diesel;

        protected override bool DoStart()
        {
            Console.WriteLine($"{Name} nastartovan!");
            return true;
        }

        protected override bool DoStop()
        {
            Console.WriteLine($"{Name} zastaven!");
            return true;
        }
    }
}
