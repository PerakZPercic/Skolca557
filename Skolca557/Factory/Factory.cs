using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolca557.Factory
{
    internal class Factory<T> where T : Vehicle
    {
        private List<T> _VehiclesCreated = new List<T>();
        public T[] MadeVehicles => _VehiclesCreated.ToArray();

        public T CreateVehicle()
        {
            T v = Activator.CreateInstance<T>();
            _VehiclesCreated.Add(v);

            return v;
        }
    }
}
