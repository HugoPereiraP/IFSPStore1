using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.X509;

namespace IFSPStore.Repository.Context;

public class IFSPStoreDbContext : DbContext
{
    public IFSPStoreDbContext() : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("Server=localhost;DataBase=IFSPStoreDb;Uid=Developer;Pwd=123456789");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.Entity<Category>(new CategoryMap().Configure);
        //modelBuilder.Entity<City>(new CityMap().Configure);
        //modelBuilder.Entity<Customer>(new CustomerMap().Configure);
        //modelBuilder.Entity<Product>(new ProductMap().Configure);
        //modelBuilder.Entity<Sale>(new SaleMap().Configure);
        //modelBuilder.Entity<SaleItem>(new SaleItemMap().Configure);
        //modelBuilder.Entity<User>(new UserMap().Configure);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IFSPStoreDbContext).Assembly);
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleItem> SaleItems { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Banana> Bananas { get; set; }
}
