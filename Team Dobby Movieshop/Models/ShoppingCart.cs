namespace Team_Dobby_Movieshop.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
        public List<ShoppingcartItems> Items { get; set; }
        public decimal Total { get; set; }
    }
}
