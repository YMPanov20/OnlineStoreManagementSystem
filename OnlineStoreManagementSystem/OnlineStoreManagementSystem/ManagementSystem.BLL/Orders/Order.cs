using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStoreManagementSystem.ManagementSystem.BLL.CustomerManagement;
using OnlineStoreManagementSystem.ManagementSystem.BLL.Discounts;
using OnlineStoreManagementSystem.ManagementSystem.BLL.Products;

namespace OnlineStoreManagementSystem.ManagementSystem.BLL.Orders
{
    public class Order : IOrder
    {
        public Customer Customer { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public decimal FinalPrice { get; private set; }

        public bool CreateOrder(Customer customer, Product product, int quantity)
        {
            if (product.Stock >= quantity)
            {
                Customer = customer;
                Product = product;
                Quantity = quantity;
                FinalPrice = product.Price * quantity;
                product.DeductStock(quantity);
                return true;
            }
            else
            {
                Console.WriteLine($"Insufficient stock for {product.Name}. Available: {product.Stock}");
                return false;
            }
        }

        public void ApplyDiscount(IDiscount discount)
        {
            FinalPrice = discount.Apply(FinalPrice);
            Console.WriteLine($"Discount applied. Final price: {FinalPrice:C}");
        }

        public void CompleteOrder()
        {
            Console.WriteLine($"Order completed for {Customer.FirstName} {Customer.LastName}. Product shipped.");
        }
    }
}
