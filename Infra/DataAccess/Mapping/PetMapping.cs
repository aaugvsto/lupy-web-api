using Lupy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Models
{
    public class PetMapping : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("PET");

            builder.HasKey(e => e.Id).HasName("PK_PET");

            builder.Property(e => e.Id).HasColumnName("ID_PET");
            builder.Property(e => e.IdUser).HasColumnName("ID_TUTOR");
            builder.Property(e => e.Name).HasColumnName("NAME");
            builder.Property(e => e.Age).HasColumnName("AGE");
            builder.Property(e => e.CreationUser).HasColumnName("CREATION_USER");
            builder.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(e => e.ModificationUser).HasColumnName("MODIFICATION_USER");
            builder.Property(e => e.ModificationDate).HasColumnName("MODIFICATION_DATE");

            builder.HasOne(e => e.User)
                .WithMany(x => x.Pet)
                .HasForeignKey(e => e.IdUser)
                .IsRequired();

            builder.HasIndex(x => x.IdUser);
        }
    }
}