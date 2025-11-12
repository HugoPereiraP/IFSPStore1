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
        public SaleMap()
        {
            
        }

        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sales");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
            .ValueGeneratedOnAdd();

            builder.Property(c => c.Date)
                .IsRequired();
            builder.Property(c => c.TotalValue)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.HasOne(c => c.Salesman);

            builder.HasOne(c => c.Customer);

            builder.HasMany(c => c.Items)
                .WithOne(li => li.Sale)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
