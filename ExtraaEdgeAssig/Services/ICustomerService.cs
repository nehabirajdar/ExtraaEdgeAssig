using ExtraaEdgeAssig.Models;

namespace ExtraaEdgeAssig.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        int AddCustomer(Customer customer);
        int UpdateCustomer(Customer customer);
        int DeleteCustomer(int id);
        
    }
}
