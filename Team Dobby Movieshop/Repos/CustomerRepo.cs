using Team_Dobby_Movieshop.Data;
using Team_Dobby_Movieshop.Interfaces;
using Team_Dobby_Movieshop.Models;

namespace Team_Dobby_Movieshop.Repos
{
    public class CustomerRepo : IGenericRepo<Customer>
    {
        private readonly AppDbContext _context;
        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }

        public Customer Add(Customer item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Customer Delete(int id)
        {
            var existing = GetById(id);
            if (existing != null)
            {
                _context.Customers.Remove(existing);
                _context.SaveChanges();
            }
            return existing;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return _context.Customers.FirstOrDefault(c => c.CustomerId == id);
        }

        public Customer Update(Customer item, int id)
        {
            Customer customerToUpdate = _context.Customers.FirstOrDefault(c => c.CustomerId == id);
            if (customerToUpdate != null)
            {
                customerToUpdate.CustomerName = item.CustomerName;
                customerToUpdate.UserName = item.UserName;
                customerToUpdate.PhoneNumber = item.PhoneNumber;
                customerToUpdate.Address = item.Address;
                _context.SaveChanges();
                return customerToUpdate;
            }
            return null;
        }
    }
}
