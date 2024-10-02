using OnlineStoreManagementSystem.ManagementSystem.BLL.Discounts;
using OnlineStoreManagementSystem.ManagementSystem.BLL.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreManagementSystem.ManagementSystem.BLL.Orders
{
    public interface IOrder
    {
        bool CreateOrder(CustomerManagement.Customer customer, Product product, int quantity);
        void ApplyDiscount(IDiscount discount);
        void CompleteOrder();
    }
}
