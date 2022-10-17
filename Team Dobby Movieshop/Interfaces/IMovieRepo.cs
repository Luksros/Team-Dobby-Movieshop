using Team_Dobby_Movieshop.Models;

namespace Team_Dobby_Movieshop.Interfaces
{
    public interface IMovieRepo
    {
        public IEnumerable<Movie> GetMovies();
        public Movie GetMovieById(int id);  
        public Movie GetMovieByName(string name);
        public IEnumerable<Movie> GetMoviesByGenre(int genreId);
        public Movie AddMovie(Movie movie);
        public Movie UpdateMovie(Movie movie, int id);
        public Movie DeleteMovie(int id);
    }
}
