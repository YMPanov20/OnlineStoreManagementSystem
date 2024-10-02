using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreManagementSystem.ManagementSystem.BLL.Products
{
    public class DigitalProduct : Product
    {
        public DigitalProduct(string name, decimal price)
            : base(name, price)
        { }

        public override void DeductStock(int quantity)
        {
        }
    }
}
