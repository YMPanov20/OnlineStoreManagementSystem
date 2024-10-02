using OnlineStoreManagementSystem.ManagementSystem.BLL.Orders;
using OnlineStoreManagementSystem.ManagementSystem.DAL;
using OnlineStoreManagementSystem.ManagementSystem.BLL.CustomerManagement;
using OnlineStoreManagementSystem.ManagementSystem.BLL.Discounts;
using OnlineStoreManagementSystem.ManagementSystem.BLL.Payments;
using OnlineStoreManagementSystem.ManagementSystem.BLL.Products;

namespace OnlineStoreManagementSystem.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Customer
            Customer customer = new Customer("John", "Doe");

            // Create Products
            PhysicalProduct laptop = new PhysicalProduct("Laptop", 1000.00m, 5);
            PhysicalProduct smartphone = new PhysicalProduct("Smartphone", 700.00m, 2);

            // Subscribe to OutOfStock Events
            laptop.OutOfStockEvent += message => Console.WriteLine($"[EVENT] {message}");
            smartphone.OutOfStockEvent += message => Console.WriteLine($"[EVENT] {message}");

            // Create Repositories
            ProductRepository productRepo = new ProductRepository();
            OrderRepository orderRepo = new OrderRepository();

            // Add Products to Repository
            productRepo.AddProduct(laptop);
            productRepo.AddProduct(smartphone);

            // Create Orders
            IOrder laptopOrder = new Order();
            IOrder smartphoneOrder = new Order();

            if (laptopOrder.CreateOrder(customer, laptop, 2))
            {
                laptopOrder.ApplyDiscount(new PercentageDiscount(10));
                laptopOrder.CompleteOrder();
            }

            Console.WriteLine();

            if (smartphoneOrder.CreateOrder(customer, smartphone, 2))
            {
                smartphoneOrder.ApplyDiscount(new FixedDiscount(50));
                smartphoneOrder.CompleteOrder();
            }

            Console.WriteLine();

            if (!laptopOrder.CreateOrder(customer, laptop, 14))
            {
                Console.WriteLine("Failed to create second laptop order due to insufficient stock.");
            }
        }
    }
}