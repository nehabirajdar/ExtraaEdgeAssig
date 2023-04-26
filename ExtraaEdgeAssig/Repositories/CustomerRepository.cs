using ExtraaEdgeAssig.Data;
using ExtraaEdgeAssig.Models;

namespace ExtraaEdgeAssig.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly ApplicationDbContext db;
        public CustomerRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            int res = db.SaveChanges();
            return res;
        }

        public int DeleteCustomer(int id)
        {
            int res = 0;
            var emp = db.Customers.Find(id);
            if (emp != null)
            {
                db.Customers.Remove(emp);
                res = db.SaveChanges();
            }
            return res;
        }
        public Customer GetCustomerById(int id)
        {
            var emp = db.Customers.Find(id);
            return emp;
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        

        public int UpdateCustomer(Customer customer)
        {
            int res = 0;
            var e = db.Customers.Where(x => x.CustId == customer.CustId).FirstOrDefault();
            if (e != null)
            {
                e.CustName=customer.CustName;
                e.Email=customer.Email;
                e.PhoneNo=customer.PhoneNo;
                e.Address=customer.Address;
                res = db.SaveChanges();
            }
            return res;
        }
    }
}
