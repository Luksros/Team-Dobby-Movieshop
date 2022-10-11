using System.Xml.Linq;
using Team_Dobby_Movieshop.Data;
using Team_Dobby_Movieshop.Interfaces;
using Team_Dobby_Movieshop.Models;

namespace Team_Dobby_Movieshop.Repos
{
    public class MovieRepo : IMovieRepo
    {
        private readonly AppDbContext _context;

        public MovieRepo(AppDbContext context)
        {
            _context = context;
        }

        public Movie AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return movie;
        }

        public Movie DeleteMovie(int id)
        {
            var movieToDelete = GetMovieById(id);
            if(movieToDelete != null)
            {
                _context.Remove(movieToDelete);
                _context.SaveChanges();
            }
            return movieToDelete;
        }

        public Movie GetMovieById(int id)
        {
            return _context.Movies.FirstOrDefault(m => m.MovieId == id);
        }

        public Movie GetMovieByName(string name)
        {
            return _context.Movies.FirstOrDefault(m => m.Title == name);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }

        public IEnumerable<Movie> GetMoviesByGenre(int genreId)
        {
            return _context.Movies.Where(m => m.GenreId == genreId).ToList();
        }

        public Movie UpdateMovie(Movie movie, int id)
        {
            var movieToUpdate = GetMovieById(id);
            if(movieToUpdate != null)
            {
                movieToUpdate.Title = movie.Title;
                movieToUpdate.Director = movie.Director;
                movieToUpdate.Description = movie.Description;
                movieToUpdate.Stock = movie.Stock;
                movieToUpdate.Price = movie.Price;
                movieToUpdate.ReleaseYear = movie.ReleaseYear;
                movieToUpdate.GenreId = movie.GenreId;
                _context.SaveChanges();
            }
            return movieToUpdate;
        }
    }
}
