using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    public abstract class Vehicle1
    {
        public abstract void Drive();
    }

    // Implement the Car class that inherits from Vehicle1
    public class Car1 : Vehicle1
    {
        public override void Drive()
        {
            Console.WriteLine("Car is driving...");
        }
    }

    // Implement the Bike class that inherits from Vehicle1
    public class Bike1 : Vehicle1
    {
        public override void Drive()
        {
            Console.WriteLine("Bike is driving...");
        }
    }

    // Implement the VehicleFactory class
    public class VehicleFactory
    {
        public static Vehicle1 CreateVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car1();
                case "bike":
                    return new Bike1();
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}
