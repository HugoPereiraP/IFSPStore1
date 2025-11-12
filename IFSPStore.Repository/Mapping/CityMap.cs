using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping;

public class CityMap : IEntityTypeConfiguration<City>
{
    public CityMap()
    {
    }

    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.ToTable("Cities");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedOnAdd();

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(c => c.State)
            .IsRequired()
            .HasMaxLength(2);
    }
}
