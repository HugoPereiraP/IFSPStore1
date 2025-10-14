using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Repository.Mapping;

public class UserMap : IEntityTypeConfiguration<User>
{
    public UserMap()
    {
        
    }

    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(c => c.Email)
            .IsRequired()
            .HasMaxLength(45);
        builder.Property(c => c.Login)
            .IsRequired()
            .HasMaxLength(45);
        builder.Property(c => c.Password)
            .IsRequired()
            .HasMaxLength(45);
        builder.Property(c => c.RegisterDate)
            .IsRequired();
        builder.Property(c => c.IsActive)
            .HasColumnType("bit(1)");
    }
}
