using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Repository.Mapping;

public class CustomerMap : IEntityTypeConfiguration<Customer>
{
    public CustomerMap()
    {
        
    }

    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customers");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(c => c.Address)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(c => c.Document)
            .IsRequired()
            .HasMaxLength(45);
        builder.Property(c => c.Neighborhood)
            .IsRequired()
            .HasMaxLength(45);

        builder.HasOne(c => c.City);
            //.WithMany()
            //.HasForeignKey("CityId")
            //.HasConstraintName("FK_Customer_City_IFSP");
    }
}
