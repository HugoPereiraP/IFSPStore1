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
    public class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(prop => prop.State)
                .HasMaxLength(2)
                .IsRequired();
        }
    }
}
