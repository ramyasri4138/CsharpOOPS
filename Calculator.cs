using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    public class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Overloaded method to add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Overloaded method to add two double values
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

}
