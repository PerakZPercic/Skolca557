using Skolca557.Factory;
using System;

namespace Skolca557
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // AppSettings
            /*if (args.Length >= 1)
                AppSettings.Instance.LoadJSON(File.ReadAllText(args[0]));

            AppSettings.Instance.SetSetting("test", "val1");

            AppSettings.Instance.PrintSettings();*/

            Factory<Car> carFactory = new Factory<Car>();
            Factory<Bike> bikeFactory = new Factory<Bike>();
            Factory<Truck> truckFactory = new Factory<Truck>();

            carFactory.CreateVehicle().Start();

            Bike bike = bikeFactory.CreateVehicle();
            bike.Start();
            bike.Stop();

            truckFactory.CreateVehicle().Start();

            Console.ReadLine();
        }
    }
}