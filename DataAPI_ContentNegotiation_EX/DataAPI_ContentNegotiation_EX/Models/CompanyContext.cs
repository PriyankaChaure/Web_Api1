using Microsoft.EntityFrameworkCore;

namespace DataAPI_ContentNegotiation_EX.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //base.OnModelCreating(modelBuilder);
            mb.Entity<Product>().HasData
            (
                new Product { ProductId=1, ProductName="Pen", MfgName="Shine", Price=5 },
                new Product { ProductId=2, ProductName="Pencil", MfgName="Nataraj", Price=5 },
                new Product { ProductId=3, ProductName="Sacle", MfgName="Scala", Price=5 },
                new Product { ProductId=4, ProductName="Erasor", MfgName="Shine", Price=5 },
                new Product { ProductId=5, ProductName="Shopner", MfgName="Deft", Price=5 }
            );  
        }
        public DbSet<Product> Products { get; set; }
    }
}
