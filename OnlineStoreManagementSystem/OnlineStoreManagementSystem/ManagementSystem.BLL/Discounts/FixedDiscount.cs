using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreManagementSystem.ManagementSystem.BLL.Discounts
{
    public class FixedDiscount : IDiscount
    {
        private decimal Amount;

        public FixedDiscount(decimal amount)
        {
            Amount = amount;
        }

        public decimal Apply(decimal price)
        {
            return price - Amount;
        }
    }
}
