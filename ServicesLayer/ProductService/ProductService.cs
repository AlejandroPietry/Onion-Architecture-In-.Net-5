using DomainLayer.Models;
using RepositoryLayer.RepositoryPattern;
using System.Collections.Generic;

namespace ServicesLayer.ProductService
{
    public class ProductService : IProductService
    {
        private IRepository<Product> _repository;
        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
            Product product = _repository.Get(id);
            _repository.Delete(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _repository.GetAll();
        }

        public Product GetProduct(int id)
        {
            return _repository.Get(id);
        }

        public void Insert(Product product)
        {
            _repository.Insert(product);
        }

        public void Update(Product product)
        {
            _repository.Update(product);
        }
    }
}
