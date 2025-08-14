using MIddleware.Models;

namespace MIddleware.Services
{
    public class ProductService
    {
        public List<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1500 },
                new Product { Id = 2, Name = "Phone", Price = 800 }
            };
        }
    }
}
