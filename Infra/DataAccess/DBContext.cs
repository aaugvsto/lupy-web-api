using Lupy.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.DataAccess
{
    public class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        { 
        }

        public virtual DbSet<Clinic> Clinics { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vaccine> Vaccines { get; set; }
        public virtual DbSet<VaccinePet> VaccinePets { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Data Source=BDMC6Q3;Initial Catalog=LUPY;User ID=admin;Password=admin");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DBContext).Assembly);
        }
    }
}