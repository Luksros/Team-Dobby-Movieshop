namespace Team_Dobby_Movieshop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
