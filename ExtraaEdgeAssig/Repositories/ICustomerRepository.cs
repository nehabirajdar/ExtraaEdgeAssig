using ExtraaEdgeAssig.Models;

namespace ExtraaEdgeAssig.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        int AddCustomer(Customer customer);
        int UpdateCustomer(Customer customer);
        int DeleteCustomer(int id);

    }
}
