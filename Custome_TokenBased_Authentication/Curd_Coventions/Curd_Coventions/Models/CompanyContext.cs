using Microsoft.EntityFrameworkCore;

namespace Curd_Coventions.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt)
        { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Product>().HasData(new Product() { ProductID=1, ProductName="Mouse", MfgName="Intex", Price=410 });
            mb.Entity<Product>().HasData(new Product() { ProductID = 2, ProductName = "Keyboard", MfgName = "Logitech", Price = 410 });
            mb.Entity<Product>().HasData(new Product() { ProductID = 3, ProductName = "Monitor", MfgName = "LG", Price = 4100 });
            mb.Entity<Product>().HasData(new Product() { ProductID = 4, ProductName = "Marker", MfgName = "Renolds", Price = 50 });

            mb.Entity<User>().HasData(new User() { UserId=1, FirstName="Priyanka", LastName="Chaure", EmailId="priya@gmail.com", Password="123" });
            mb.Entity<User>().HasData(new User() { UserId=2, FirstName="Sweety", LastName="Chaure", EmailId="sweety@gmail.com", Password="123" });

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }
    }
}
