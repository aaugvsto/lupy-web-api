#nullable disable

using Lupy.Domain.Entities;
using Lupy.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Models
{
    public class VaccineMapping : IEntityTypeConfiguration<Vaccine>
    {
        public void Configure(EntityTypeBuilder<Vaccine> builder)
        {
            builder.ToTable("VACCINE");

            builder.HasKey(x => x.Id).HasName("PK_VACCINE");

            builder.Property(x => x.Id).HasColumnName("ID_VACCINE");
            builder.Property(x => x.Name).HasColumnName("NAME");
            builder.Property(x => x.Batch).HasColumnName("BATCH");
            builder.Property(x => x.ExpirationDate).HasColumnName("EXPIRATION_DATE");
            builder.Property(x => x.IdClinic).HasColumnName("ID_CLINIC");
            builder.Property(x => x.CreationUser).HasColumnName("CREATION_USER");
            builder.Property(x => x.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(x => x.ModificationUser).HasColumnName("MODIFICATION_USER");
            builder.Property(x => x.ModificationDate).HasColumnName("MODIFICATION_DATE");

            builder.HasOne(x => x.Clinic)
                .WithMany(x => x.Vaccines)
                .HasForeignKey(x => x.IdClinic)
                .HasConstraintName("FK_VACCINE_CLINIC");
        }
    }
}