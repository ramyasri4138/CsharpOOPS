using System;
using System.Security.Principal;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    public class Bank
    {
        // Static field for interest rate
        public static double InterestRate { get; private set; }

        public string Name { get; set; }
        public double Balance { get; set; }

        public Bank(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }

        // Static method to set the interest rate
        public static void SetInterestRate(double newRate)
        {
            InterestRate = newRate;
        }

        // Method to calculate interest for a specific bank account
        public double CalculateInterest()
        {
            return Balance * InterestRate / 100;
        }

        public override string ToString()
        {
            return $"Bank: {Name}, Balance: {Balance:C}, Interest Rate: {InterestRate}%";
        }
    }
}