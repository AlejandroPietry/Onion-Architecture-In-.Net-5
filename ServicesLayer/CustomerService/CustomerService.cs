using DomainLayer.Models;
using RepositoryLayer.RepositoryPattern;
using System.Collections.Generic;

namespace ServicesLayer.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private IRepository<Customer> _repository;
        public CustomerService(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public void DeleteCustomer(int id)
        {
            Customer customer = GetCustomer(id);
            _repository.Delete(customer);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _repository.GetAll();
        }

        public Customer GetCustomer(int id)
        {
            return _repository.Get(id);
        }

        public void InsertCustomer(Customer customer)
        {
            _repository.Insert(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _repository.Update(customer);
        }
    }
}
