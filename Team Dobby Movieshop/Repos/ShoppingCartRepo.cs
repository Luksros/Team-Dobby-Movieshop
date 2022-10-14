using Team_Dobby_Movieshop.Data;
using Team_Dobby_Movieshop.Interfaces;
using Team_Dobby_Movieshop.Models;

namespace Team_Dobby_Movieshop.Repos
{
    public class ShoppingCartRepo : IGenericRepo<ShoppingCart>
    {
        private readonly AppDbContext _context;
        public ShoppingCartRepo(AppDbContext context)
        {
            _context = context;
        }

        public ShoppingCart Add(ShoppingCart item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;
        }

        public ShoppingCart Delete(int id)
        {
            var cartToDelete = GetById(id);
            if (cartToDelete != null)
            {
                _context.ShoppingCarts.Remove(cartToDelete);
                _context.SaveChanges();
            }
            return cartToDelete;
        }

        public IEnumerable<ShoppingCart> GetAll()
        {
            return _context.ShoppingCarts.ToList();
        }

        public ShoppingCart GetById(int id)
        {
            return _context.ShoppingCarts.FirstOrDefault(g => g.ShoppingCartId == id);
        }

        public ShoppingCart Update(ShoppingCart item, int id)
        {
            var cartToUpdate = GetById(id);
            if (cartToUpdate != null)
            {
                cartToUpdate.Total = item.Total;
                cartToUpdate.Items = item.Items;
                _context.SaveChanges();
            }
            return cartToUpdate;

        }
    }
}
