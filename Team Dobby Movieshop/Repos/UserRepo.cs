using Team_Dobby_Movieshop.Data;
using Team_Dobby_Movieshop.Interfaces;
using Team_Dobby_Movieshop.Models;

namespace Team_Dobby_Movieshop.Repos
{
    //public class UserRepo : IGenericRepo<User>
    //{
    //    private readonly AppDbContext _context;
    //    public UserRepo(AppDbContext context)
    //    {
    //        _context = context;
    //    }

    //    public User Add(User item)
    //    {
    //        _context.Users.Add(item);
    //        _context.SaveChanges();
    //        return item;
    //    }

    //    public User Delete(int id)
    //    {
    //        var userToDelete = GetById(id);
    //        if(userToDelete != null)
    //        {
    //            _context.Remove(userToDelete);
    //            _context.SaveChanges();
    //        }
    //        return userToDelete;
    //    }

    //    public IEnumerable<User> GetAll()
    //    {
    //        return _context.Users.ToList();
    //    }

    //    public User GetById(int id)
    //    {
    //        return _context.Users.FirstOrDefault(u => u.Id == id);
    //    }

    //    public User Update(User item, int id)
    //    {
    //        var userToUpdate = GetById(id);
    //        if (userToUpdate != null)
    //        {
    //            userToUpdate.UserName = item.UserName;
    //            userToUpdate.IsAdmin = item.IsAdmin;
    //            userToUpdate.Password = item.Password;
    //            _context.SaveChanges();
    //        }
    //        return userToUpdate;
    //    }
    //}
}
