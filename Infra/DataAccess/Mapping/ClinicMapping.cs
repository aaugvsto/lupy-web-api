using Lupy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Models
{
    public class ClinicMapping : IEntityTypeConfiguration<Clinic>
    {
        public void Configure(EntityTypeBuilder<Clinic> builder)
        {
            builder.ToTable("CLINIC");

            builder.HasKey(e => e.Id).HasName("PK_CLINIC");

            builder.Property(e => e.Id).HasColumnName("ID_CLINIC");
            builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            builder.Property(e => e.CreationUser).HasColumnName("CREATION_USER");
            builder.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(e => e.ModificationUser).HasColumnName("MODIFICATION_USER");
            builder.Property(e => e.ModificationDate).HasColumnName("MODIFICATION_DATE");
        }
    }
}