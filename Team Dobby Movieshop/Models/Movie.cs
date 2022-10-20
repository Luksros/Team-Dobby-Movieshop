using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team_Dobby_Movieshop.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseYear { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
