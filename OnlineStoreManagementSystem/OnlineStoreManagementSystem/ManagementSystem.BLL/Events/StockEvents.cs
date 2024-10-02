using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreManagementSystem.ManagementSystem.BLL.Events
{
    public static class StockEvents
    {
        public static event Action<string> OutOfStockEvent;

        public static void RaiseOutOfStockEvent(string productName)
        {
            OutOfStockEvent?.Invoke($"{productName} is out of stock!");
        }
    }
}
