using OnlineStoreManagementSystem.ManagementSystem.BLL.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreManagementSystem.ManagementSystem.DAL
{
    public class ProductRepository
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public Product GetProductByName(string name)
        {
            return _products.FirstOrDefault(p => p.Name == name);
        }
    }
}
