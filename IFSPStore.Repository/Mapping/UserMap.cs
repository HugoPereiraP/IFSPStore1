
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
    public class UserMap : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(prop => prop.Email)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(prop => prop.Login)
                .HasMaxLength(20)
                .IsRequired();
            builder.Property(prop => prop.Password);
            builder.Property(prop => prop.RegisterDate)
                .IsRequired();
            builder.Property(prop => prop.LoginDate)
                .IsRequired();
            builder.Property(prop => prop.IsActive)
                .IsRequired();
           

        }
    }
}
