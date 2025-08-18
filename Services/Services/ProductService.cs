using BussinessObject.Models;
using DataAccessLayer.ReqDTO;
using DataAccessLayer.ResDTO;

namespace Services.Services
{
    public class ProductService
    {
        private static List<Product> _db = new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 1500 },
            new Product { Id = 2, Name = "Phone", Price = 800 }
        };

        public IEnumerable<ProductRes> GetAll()
        {
            return _db.Select(p => new ProductRes { Id = p.Id, Name = p.Name, Price = p.Price });
        }

        public ProductRes GetById(int id)
        {
            var p = _db.FirstOrDefault(x => x.Id == id);
            return p == null ? null : new ProductRes { Id = p.Id, Name = p.Name, Price = p.Price };
        }

        public ProductRes Create(ProductCreateReq req)
        {
            var newId = _db.Max(p => p.Id) + 1;
            var product = new Product { Id = newId, Name = req.Name, Price = req.Price };
            _db.Add(product);
            return new ProductRes { Id = product.Id, Name = product.Name, Price = product.Price };
        }
    }
}
