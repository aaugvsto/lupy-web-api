﻿// <auto-generated />
using System;
using Infra.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Lupy.Infra.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Lupy.Domain.Entities.Clinic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID_CLINIC");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CREATION_DATE");

                    b.Property<string>("CreationUser")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CREATION_USER");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("MODIFICATION_DATE");

                    b.Property<string>("ModificationUser")
                        .HasColumnType("text")
                        .HasColumnName("MODIFICATION_USER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("character varying(25)")
                        .HasColumnName("NAME");

                    b.HasKey("Id")
                        .HasName("PK_CLINIC");

                    b.ToTable("CLINIC", (string)null);
                });

            modelBuilder.Entity("Lupy.Domain.Entities.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID_PET");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("AGE");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CREATION_DATE");

                    b.Property<string>("CreationUser")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CREATION_USER");

                    b.Property<int>("IdUser")
                        .HasColumnType("integer")
                        .HasColumnName("ID_TUTOR");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("MODIFICATION_DATE");

                    b.Property<string>("ModificationUser")
                        .HasColumnType("text")
                        .HasColumnName("MODIFICATION_USER");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("NAME");

                    b.HasKey("Id")
                        .HasName("PK_PET");

                    b.HasIndex("IdUser");

                    b.ToTable("PET", (string)null);
                });

            modelBuilder.Entity("Lupy.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CREATION_DATE");

                    b.Property<string>("CreationUser")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CREATION_USER");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("MODIFICATION_DATE");

                    b.Property<string>("ModificationUser")
                        .HasColumnType("text")
                        .HasColumnName("MODIFICATION_USER");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.ToTable("ROLES", (string)null);
                });

            modelBuilder.Entity("Lupy.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID_USER");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cellphone")
                        .HasColumnType("text")
                        .HasColumnName("CELLPHONE");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CREATION_DATE");

                    b.Property<string>("CreationUser")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CREATION_USER");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("EMAIL");

                    b.Property<int>("IdClinic")
                        .HasColumnType("integer")
                        .HasColumnName("CLINIC_ID");

                    b.Property<int>("IdRole")
                        .HasColumnType("integer")
                        .HasColumnName("ID_ROLE");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("MODIFICATION_DATE");

                    b.Property<string>("ModificationUser")
                        .HasColumnType("text")
                        .HasColumnName("MODIFICATION_USER");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("NAME");

                    b.Property<string>("Password")
                        .HasColumnType("text")
                        .HasColumnName("PASSWORD");

                    b.HasKey("Id")
                        .HasName("PK_USER");

                    b.HasIndex("IdClinic");

                    b.HasIndex("IdRole");

                    b.ToTable("USERS", (string)null);
                });

            modelBuilder.Entity("Lupy.Domain.Entities.Vaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID_VACCINE");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Batch")
                        .HasColumnType("text")
                        .HasColumnName("BATCH");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CREATION_DATE");

                    b.Property<string>("CreationUser")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CREATION_USER");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("EXPIRATION_DATE");

                    b.Property<int>("IdClinic")
                        .HasColumnType("integer")
                        .HasColumnName("ID_CLINIC");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("MODIFICATION_DATE");

                    b.Property<string>("ModificationUser")
                        .HasColumnType("text")
                        .HasColumnName("MODIFICATION_USER");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("NAME");

                    b.HasKey("Id")
                        .HasName("PK_VACCINE");

                    b.HasIndex("IdClinic");

                    b.ToTable("VACCINE", (string)null);
                });

            modelBuilder.Entity("Lupy.Domain.Entities.VaccinePet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID_VACCINE_PET");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CREATION_DATE");

                    b.Property<string>("CreationUser")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CREATION_USER");

                    b.Property<int>("IdClinic")
                        .HasColumnType("integer")
                        .HasColumnName("ID_CLINIC");

                    b.Property<int>("IdPet")
                        .HasColumnType("integer")
                        .HasColumnName("ID_PET");

                    b.Property<int>("IdVaccine")
                        .HasColumnType("integer")
                        .HasColumnName("ID_VACCINE");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("MODIFICATION_DATE");

                    b.Property<string>("ModificationUser")
                        .HasColumnType("text")
                        .HasColumnName("MODIFICATION_USER");

                    b.HasKey("Id")
                        .HasName("PK_VACCINE_PET");

                    b.HasIndex("IdClinic");

                    b.HasIndex("IdPet");

                    b.HasIndex("IdVaccine");

                    b.ToTable("VACCINE_PET", (string)null);
                });

            modelBuilder.Entity("Lupy.Domain.Entities.Pet", b =>
                {
                    b.HasOne("Lupy.Domain.Entities.User", "User")
                        .WithMany("Pet")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Lupy.Domain.Entities.User", b =>
                {
                    b.HasOne("Lupy.Domain.Entities.Clinic", "Clinic")
                        .WithMany("Users")
                        .HasForeignKey("IdClinic")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lupy.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("IdRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Lupy.Domain.Entities.Vaccine", b =>
                {
                    b.HasOne("Lupy.Domain.Entities.Clinic", "Clinic")
                        .WithMany("Vaccines")
                        .HasForeignKey("IdClinic")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_VACCINE_CLINIC");

                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("Lupy.Domain.Entities.VaccinePet", b =>
                {
                    b.HasOne("Lupy.Domain.Entities.Clinic", "Clinic")
                        .WithMany("VaccinePet")
                        .HasForeignKey("IdClinic")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_VACCINE_PET_CLINIC");

                    b.HasOne("Lupy.Domain.Entities.Pet", "Pet")
                        .WithMany("VaccinePet")
                        .HasForeignKey("IdPet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_VACCINEPET_PET");

                    b.HasOne("Lupy.Domain.Entities.Vaccine", "Vaccine")
                        .WithMany("VaccinePet")
                        .HasForeignKey("IdVaccine")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_VACCINEPET_VACCINE");

                    b.Navigation("Clinic");

                    b.Navigation("Pet");

                    b.Navigation("Vaccine");
                });

            modelBuilder.Entity("Lupy.Domain.Entities.Clinic", b =>
                {
                    b.Navigation("Users");

                    b.Navigation("VaccinePet");

                    b.Navigation("Vaccines");
                });

            modelBuilder.Entity("Lupy.Domain.Entities.Pet", b =>
                {
                    b.Navigation("VaccinePet");
                });

            modelBuilder.Entity("Lupy.Domain.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Lupy.Domain.Entities.User", b =>
                {
                    b.Navigation("Pet");
                });

            modelBuilder.Entity("Lupy.Domain.Entities.Vaccine", b =>
                {
                    b.Navigation("VaccinePet");
                });
#pragma warning restore 612, 618
        }
    }
}
