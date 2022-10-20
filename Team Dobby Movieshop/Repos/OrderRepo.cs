using Team_Dobby_Movieshop.Data;
using Team_Dobby_Movieshop.Interfaces;
using Team_Dobby_Movieshop.Models;

namespace Team_Dobby_Movieshop.Repos
{
    public class OrderRepo : IGenericRepo<Order>
    {
        private readonly AppDbContext _context;
        public Order Add(Order item)
        {
            _context.Orders.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Order Delete(int id)
        {
            var orderToDelete = GetById(id);
            if(orderToDelete != null)
            {
                _context.Orders.Remove(orderToDelete);
                _context.SaveChanges();
            }
            return orderToDelete;
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return _context.Orders.FirstOrDefault(o => o.Id == id);
        }

        public Order Update(Order item, int id)
        {
            var orderToUpdate = GetById(id);
            if( orderToUpdate != null)
            {
                orderToUpdate.OrderDate = item.OrderDate;
                orderToUpdate.ShoppingCartId = item.ShoppingCartId;
                orderToUpdate.CustomerId = item.CustomerId;
            }
            return null;
        }
    }
}
