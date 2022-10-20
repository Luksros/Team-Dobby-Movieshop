using System.ComponentModel.DataAnnotations;

namespace Team_Dobby_Movieshop.Models
{
    public class ShoppingcartItems
    {
        [Key]
        public int Id { get; set; }
        public int ShoppingcartId { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int Quantity { get; set; }
    }
}
