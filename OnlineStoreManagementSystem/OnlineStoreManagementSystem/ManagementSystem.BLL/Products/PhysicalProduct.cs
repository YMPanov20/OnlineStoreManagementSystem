using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreManagementSystem.ManagementSystem.BLL.Products
{
    public class PhysicalProduct : Product
    {
        public PhysicalProduct(string name, decimal price, int stock)
            : base(name, price, stock)
        { }
    }
}
