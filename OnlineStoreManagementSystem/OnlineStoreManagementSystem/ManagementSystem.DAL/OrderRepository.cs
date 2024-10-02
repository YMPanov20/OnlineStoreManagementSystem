using OnlineStoreManagementSystem.ManagementSystem.BLL.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreManagementSystem.ManagementSystem.DAL
{
    public class OrderRepository
    {
        private List<Order> _orders = new List<Order>();

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public List<Order> GetAllOrders()
        {
            return _orders;
        }
    }
}
