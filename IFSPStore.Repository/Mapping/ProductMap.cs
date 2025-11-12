using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Repository.Mapping;

public class ProductMap : IEntityTypeConfiguration<Product>
{
    public ProductMap()
    {
        
    }

    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedOnAdd();

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(c => c.Value)
            .IsRequired()
            .HasPrecision(10, 2);
        builder.Property(c => c.Quantity)
            .IsRequired();
        builder.Property(c => c.PurchaseDate)
            .IsRequired();
        builder.Property(c => c.SaleUnity)
            .IsRequired()
            .HasMaxLength(10);

        builder.HasOne(c => c.Group);
            //.WithMany()
            //.HasForeignKey()
            //.HasConstraintName("FK_Product_Category_IFSP");
    }
}
