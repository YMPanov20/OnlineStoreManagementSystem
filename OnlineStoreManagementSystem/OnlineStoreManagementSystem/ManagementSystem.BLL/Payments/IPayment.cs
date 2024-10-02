using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreManagementSystem.ManagementSystem.BLL.Payments
{
    public interface IPayment{
        void ProcessPayment(decimal amount);
    }
}
