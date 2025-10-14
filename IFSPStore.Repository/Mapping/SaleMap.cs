using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Repository.Mapping
{
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sale");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.SaleDate)
                .IsRequired();
            builder.Property(prop => prop.totalPrice)
                .IsRequired();

            builder.HasOne(prop => prop.Salesman);
            builder.HasOne(prop => prop.Customer);
            builder.HasMany(prop => prop.SaleItems)
                .WithOne(prop => prop.Sale).OnDelete(DeleteBehavior.Cascade);
                

        }
    }
}
