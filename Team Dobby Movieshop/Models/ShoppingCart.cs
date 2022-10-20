using System.ComponentModel.DataAnnotations;

namespace Team_Dobby_Movieshop.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        public List<ShoppingcartItems> Items { get; set; }
        public decimal Total { get; set; }
    }
}
