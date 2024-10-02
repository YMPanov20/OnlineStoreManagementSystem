using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreManagementSystem.ManagementSystem.BLL.Discounts
{
    public class PercentageDiscount : IDiscount
    {
        private decimal Percentage;

        public PercentageDiscount(decimal percentage)
        {
            Percentage = percentage;
        }

        public decimal Apply(decimal price)
        {
            return price - (price * Percentage / 100);
        }
    }
}
