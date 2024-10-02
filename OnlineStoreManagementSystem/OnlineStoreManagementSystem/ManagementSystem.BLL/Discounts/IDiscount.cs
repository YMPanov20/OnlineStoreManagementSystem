using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreManagementSystem.ManagementSystem.BLL.Discounts
{
    public interface IDiscount{
        decimal Apply(decimal price);
    }
}
