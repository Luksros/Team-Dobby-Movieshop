using Team_Dobby_Movieshop.Data;
using Team_Dobby_Movieshop.Interfaces;
using Team_Dobby_Movieshop.Models;

namespace Team_Dobby_Movieshop.Repos
{
    public class ShoppingCartItemRepo : IGenericRepo<ShoppingcartItems>
    {
        private readonly AppDbContext _context;
        public ShoppingCartItemRepo(AppDbContext context)
        {
            _context = context;
        }

        public ShoppingcartItems Add(ShoppingcartItems item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;
        }

        public ShoppingcartItems Delete(int id)
        {
            var cartToDelete = GetById(id);
            if (cartToDelete != null)
            {
                _context.ShoppingCartItems.Remove(cartToDelete);
                _context.SaveChanges();
            }
            return cartToDelete;
        }

        public IEnumerable<ShoppingcartItems> GetAll()
        {
            return _context.ShoppingCartItems.ToList();
        }

        public ShoppingcartItems GetById(int id)
        {
            return _context.ShoppingCartItems.FirstOrDefault(g => g.Id == id);
        }

        public ShoppingcartItems Update(ShoppingcartItems item, int id)
        {
            var cartToUpdate = GetById(id);
            if (cartToUpdate != null)
            {
                cartToUpdate.Quantity = item.Quantity;
                cartToUpdate.ShoppingcartId = item.ShoppingcartId;
                cartToUpdate.MovieId = item.MovieId;
                _context.SaveChanges();
            }
            return cartToUpdate;

        }
    }
}
