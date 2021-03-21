using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.CustomerService;

namespace Onion_Architecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet(nameof(GetCustomer))]
        public IActionResult GetCustomer(int id)
        {
            var customer = _customerService.GetCustomer(id);
            if (customer is not null)
                return Ok(customer);
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetAllCustomer))]
        public IActionResult GetAllCustomer()
        {
            var listOfCustomers = _customerService.GetAllCustomers();

            if (listOfCustomers is not null)
                return Ok(listOfCustomers);
            return BadRequest("No records found");
        }

        [HttpPost(nameof(InsertCustomer))]
        public IActionResult InsertCustomer(Customer customer)
        {
            _customerService.InsertCustomer(customer);
            return Ok("Customer inserted");
        }

        [HttpPut(nameof(UpdateCustomer))]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerService.UpdateCustomer(customer);
            return Ok("Updation done");
        }

        [HttpDelete(nameof(DeleteCustomer))]
        public IActionResult DeleteCustomer(int id)
        {
            _customerService.DeleteCustomer(id);
            return Ok("Data deleted");
        }
    }
}
