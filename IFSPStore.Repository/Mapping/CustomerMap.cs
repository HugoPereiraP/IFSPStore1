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
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name)
                .HasMaxLength(100)
                .IsRequired();
           builder.Property(prop => prop.Address)
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(prop => prop.Neighborhood)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(prop => prop.Document)
                .HasMaxLength(14)
                .IsRequired();




        }
    }
}
