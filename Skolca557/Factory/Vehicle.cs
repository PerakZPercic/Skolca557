using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolca557.Factory
{
    internal abstract class Vehicle
    {
        [Flags]
        public enum MotorFuelType
        {
            Gas = 1,
            Diesel = 2,
            LPG = 4
        }

        public abstract string Name { get; }
        public abstract int MaxSpeed { get; }
        public abstract MotorFuelType FuelType { get; }

        public bool Started { get; protected set; }

        protected abstract bool DoStart();
        protected abstract bool DoStop();

        public void Start()
        {
            if (Started) 
                return;
            if (DoStart())
                Started = true;
        }
        public void Stop()
        {
            if (!Started)
                return;
            if (DoStop()) 
                Started = false;
        }
    }
}
