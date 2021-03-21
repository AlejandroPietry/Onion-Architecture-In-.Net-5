using DomainLayer.Models;
using System.Collections.Generic;

namespace ServicesLayer.CustomerService
{
    /// <summary>
    /// This contains the Core Business Logic as part of our project which acts as a
    /// layer between the Repositorylayer and Controller.
    /// </summary>
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomer(int id);
        void InsertCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}
