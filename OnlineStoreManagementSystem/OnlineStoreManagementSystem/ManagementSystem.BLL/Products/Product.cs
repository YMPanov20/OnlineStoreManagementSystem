using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreManagementSystem.ManagementSystem.BLL.Products
{
    public abstract class Product
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public int Stock { get; protected set; }

        public event Action<string> OutOfStockEvent;

        public Product(string name, decimal price, int stock = 0)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public virtual void DeductStock(int quantity)
        {
            if (Stock >= quantity)
            {
                Stock -= quantity;
                if (Stock == 0)
                {
                    OutOfStockEvent?.Invoke(Name);
                }
            }
            else
            {
                throw new InvalidOperationException("Not enough stock available.");
            }
        }

        public virtual void DisplayProductInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}, Stock: {Stock}");
        }
    }
}
