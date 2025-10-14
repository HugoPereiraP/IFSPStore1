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
    public class SaleItemMap : IEntityTypeConfiguration<SaleItem>
    {
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.ToTable("SaleItem");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Quantity)
                .IsRequired();
            builder.Property(prop => prop.UnitaryValue)
                .IsRequired();

            builder.HasOne(prop => prop.Sale);
               
            builder.HasOne(prop => prop.Product);
               
            builder.Property(prop => prop.SaleTotal)
                .IsRequired();
        }
     }
}
