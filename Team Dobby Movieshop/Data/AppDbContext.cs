using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Team_Dobby_Movieshop.Models;

namespace Team_Dobby_Movieshop.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingcartItems> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            { Id = "9fa474d4-0246-47db-834e-5b44c2d3ae19", Name = "User", NormalizedName ="USER" });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            { Id = "d49bc437-f9e7-41c4-be19-c17ad1691612", Name = "Admin", NormalizedName = "ADMIN" });

        }
    }
}
