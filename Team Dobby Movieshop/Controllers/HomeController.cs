using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Team_Dobby_Movieshop.Models;
using Team_Dobby_Movieshop.Repos;
using Team_Dobby_Movieshop.Views.ViewModels;

namespace Team_Dobby_Movieshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MovieRepo movieRepo;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var moviesSold = movieRepo.GetMovies().Sum(x => x.GenreId); //ungabunga propertys example
            var movieSalesTot = movieRepo.GetMovies().Sum(x => x.Price); //ungabunga propertys example
            var top10Movies = movieRepo.GetMovies().Where(x => x.Stock < 2).ToList(); //ungabunga propertys example
            var lowStockMovies = movieRepo.GetMovies().Where(x => x.Stock <= 2).ToList();
            DashboardViewModel test = new DashboardViewModel()
            {
                MoviesSold = moviesSold,
                MovieSalesTotal = movieSalesTot,
                Top10Movies = top10Movies,
                LowStock = lowStockMovies
            };
            return View(test);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}