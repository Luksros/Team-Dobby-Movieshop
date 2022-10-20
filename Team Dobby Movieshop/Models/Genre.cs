using System.ComponentModel.DataAnnotations;

namespace Team_Dobby_Movieshop.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string GenreName { get; set; }
    }
}
