﻿using IFSPStore.Domain.Entities;    
using Microsoft.EntityFrameworkCore;



namespace IFSPStore.Repository.Context
{
    public class IFSPStoreContext : DbContext
    {
        public IFSPStoreContext() : base()
        {
            Database.EnsureCreated(); // Create the database if it does not exist   
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseMySQL("server = localhost;database=IFSPStore;user=root;password=");

        }

        
        
        public DbSet<User> Users { get; set; }

        public DbSet<City> Cities { get; set; } 

        public DbSet<Product> Products { get; set; }
           
        public DbSet<Category> Categories { get; set; }
           
        public DbSet<Customer> Customers { get; set; }
           
        public DbSet<Sale> Sales { get; set; }   
            
        public  DbSet<SaleItem> SaleItems { get; set; } 
        
    }
}
