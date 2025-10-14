
using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    internal class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(prop => prop.Name);
            builder.Property(prop => prop.Name)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(prop => prop.Description)
                .HasMaxLength(1000);
        }
    }
}
