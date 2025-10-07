using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IFSPStore.Repository.Context;

public class IFSPStoreDbContext : DbContext
{
    public IFSPStoreDbContext() : base()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("Server=localhost;DataBase=IFSPStoreDb;Uid=Developer;Pwd=123456789");
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleItem> SaleItems { get; set; }
    public DbSet<User> Users { get; set; }
}
