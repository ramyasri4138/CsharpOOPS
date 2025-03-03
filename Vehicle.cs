using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }
    }

    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting with a roar...");
        }
    }

    public class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike is starting with a zoom...");
        }
    }
}
