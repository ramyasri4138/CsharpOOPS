using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    public abstract class Shape
    {
        // Abstract method to calculate area
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Override the abstract method to calculate area of the circle
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Override the abstract method to calculate area of the rectangle
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    

}
