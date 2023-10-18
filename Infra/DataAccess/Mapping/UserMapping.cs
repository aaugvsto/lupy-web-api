using Lupy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Models
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("USERS");

            builder.HasKey(x => x.Id).HasName("PK_USER");

            builder.Property(x => x.Id).HasColumnName("ID_USER");
            builder.Property(x => x.Name).HasColumnName("NAME");
            builder.Property(x => x.Email).HasColumnName("EMAIL");
            builder.Property(x => x.Cellphone).HasColumnName("CELLPHONE");
            builder.Property(x => x.Password).HasColumnName("PASSWORD");
            builder.Property(x => x.CreationUser).HasColumnName("CREATION_USER");
            builder.Property(x => x.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(x => x.ModificationUser).HasColumnName("MODIFICATION_USER");
            builder.Property(x => x.ModificationDate).HasColumnName("MODIFICATION_DATE");
            builder.Property(x => x.IdRole).HasColumnName("ID_ROLE");
            builder.Property(x => x.IdClinic).HasColumnName("CLINIC_ID");

            builder.HasMany(x => x.Pet)
                .WithOne(y => y.User)
                .HasForeignKey(x => x.IdUser)
                .IsRequired();

            builder.HasOne(x => x.Role)
                .WithMany(y => y.Users)
                .HasForeignKey(x => x.IdRole)
                .IsRequired();

            builder.HasOne(x => x.Clinic)
                .WithMany(y => y.Users)
                .HasForeignKey(x => x.IdClinic)
                .IsRequired();
        }
    }
}