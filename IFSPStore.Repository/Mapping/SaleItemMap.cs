using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Repository.Mapping;

public class SaleItemMap : IEntityTypeConfiguration<SaleItem>
{
    public SaleItemMap()
    {
        
    }

    public void Configure(EntityTypeBuilder<SaleItem> builder)
    {
        builder.ToTable("SaleItems");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Quantity)
            .IsRequired();
        builder.Property(c => c.UnitaryValue)
            .IsRequired()
            .HasPrecision(10, 2);
        builder.Property(c => c.TotalValue)
            .IsRequired()
            .HasPrecision(10, 2);

        builder.HasOne(c => c.Product);
            //.WithMany()
            //.HasForeignKey()
            //.HasConstraintName("FK_SaleItem_Product_IFSP");
    }
}
