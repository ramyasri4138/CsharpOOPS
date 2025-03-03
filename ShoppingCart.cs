using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    // Strategy interface
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal total);
    }

    // NoDiscount strategy
    public class NoDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal total)
        {
            return total;
        }
    }

    // PercentageDiscount strategy
    public class PercentageDiscount : IDiscountStrategy
    {
        private readonly decimal _percentage;

        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal ApplyDiscount(decimal total)
        {
            return total - (total * _percentage / 100);
        }
    }

    // FixedAmountDiscount strategy
    public class FixedAmountDiscount : IDiscountStrategy
    {
        private readonly decimal _discountAmount;

        public FixedAmountDiscount(decimal discountAmount)
        {
            _discountAmount = discountAmount;
        }

        public decimal ApplyDiscount(decimal total)
        {
            return total - _discountAmount;
        }
    }

    // ShoppingCart class
    public class ShoppingCart
    {
        private IDiscountStrategy _discountStrategy;

        public ShoppingCart(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculateTotal(decimal total)
        {
            return _discountStrategy.ApplyDiscount(total);
        }
    }
}
