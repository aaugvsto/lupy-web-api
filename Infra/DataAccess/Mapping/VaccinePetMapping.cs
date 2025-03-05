#nullable disable

using Lupy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Models
{
    public class VaccinePetMapping : IEntityTypeConfiguration<VaccinePet>
    {
        public void Configure(EntityTypeBuilder<VaccinePet> builder)
        {
            builder.ToTable("VACCINE_PET");

            builder.HasKey(x => x.Id).HasName("PK_VACCINE_PET");

            builder.Property(x => x.Id).HasColumnName("ID_VACCINE_PET");
            builder.Property(x => x.IdClinic).HasColumnName("ID_CLINIC");
            builder.Property(x => x.IdPet).HasColumnName("ID_PET");
            builder.Property(x => x.IdVaccine).HasColumnName("ID_VACCINE");
            builder.Property(x => x.CreationUser).HasColumnName("CREATION_USER");
            builder.Property(x => x.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(x => x.ModificationUser).HasColumnName("MODIFICATION_USER");
            builder.Property(x => x.ModificationDate).HasColumnName("MODIFICATION_DATE");


            builder.HasOne(x => x.Pet)
                .WithMany(x => x.VaccinePet)
                .HasForeignKey(x => x.IdPet)
                .HasConstraintName("FK_VACCINEPET_PET");

            builder.HasOne(x => x.Clinic)
                .WithMany(x => x.VaccinePet)
                .HasForeignKey(x => x.IdClinic)
                .HasConstraintName("FK_VACCINE_PET_CLINIC")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Vaccine)
                .WithMany(x => x.VaccinePet)
                .HasForeignKey(x => x.IdVaccine)
                .HasConstraintName("FK_VACCINEPET_VACCINE")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}