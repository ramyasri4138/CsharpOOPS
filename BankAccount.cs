using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{

    public class BankAccount
    {
        private decimal balance;

        public BankAccount()
        {
            balance = 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Successfully deposited {amount:C}. New balance: {balance:C}.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Successfully withdrew {amount:C}. New balance: {balance:C}.");
                }
                else
                {
                    Console.WriteLine("Insufficient balance for withdrawal.");
                }
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }

}
