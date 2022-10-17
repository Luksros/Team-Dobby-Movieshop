namespace Team_Dobby_Movieshop.Models
{
    public class Customer : User
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
