using DomainLayer.Models;
using System.Collections.Generic;

namespace ServicesLayer.ProductService
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);
        void Insert(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
