using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping;

public class CategoryMap : IEntityTypeConfiguration<Category>
{
    public CategoryMap()
    {
    }

    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedOnAdd();

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(60);
        builder.Property(c => c.Description)
            .IsRequired()
            .HasMaxLength(1000);
    }
}
