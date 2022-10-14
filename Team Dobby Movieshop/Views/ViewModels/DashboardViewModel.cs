using Team_Dobby_Movieshop.Models;

namespace Team_Dobby_Movieshop.Views.ViewModels
{
    public class DashboardViewModel
    {
        public int MoviesSold { get; set; }
        public decimal MovieSalesTotal { get; set; }
        public List<Movie> Top10Movies { get; set; }
        public List<Movie> LowStock { get; set; }
        
    }
}
