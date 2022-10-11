using Team_Dobby_Movieshop.Data;
using Team_Dobby_Movieshop.Interfaces;
using Team_Dobby_Movieshop.Models;

namespace Team_Dobby_Movieshop.Repos
{
    public class GenreRepo : IGenericRepo<Genre>
    {
        private readonly AppDbContext _context;
        public GenreRepo(AppDbContext context)
        {
            _context = context;
        }

        public Genre Add(Genre item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Genre Delete(int id)
        {
            var genreToDelete = GetById(id);
            if(genreToDelete != null)
            {
                _context.Genres.Remove(genreToDelete);
                _context.SaveChanges();
            }
            return genreToDelete;
        }

        public IEnumerable<Genre> GetAll()
        {
            return _context.Genres.ToList();
        }

        public Genre GetById(int id)
        {
            return _context.Genres.FirstOrDefault(g => g.GenreId == id);
        }

        public Genre Update(Genre item, int id)
        {
            var genreToUpdate = GetById(id);
            if(genreToUpdate != null)
            {
                genreToUpdate.GenreName = item.GenreName;
                _context.SaveChanges();
            }
            return genreToUpdate;

        }
    }
}
