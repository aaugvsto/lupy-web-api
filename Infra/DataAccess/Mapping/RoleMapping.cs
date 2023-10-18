using Lupy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lupy.Infra.DataAccess.Mapping
{
    public class RoleMapping : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("ROLES");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Name).HasColumnName("NAME");
            builder.Property(x => x.CreationUser).HasColumnName("CREATION_USER");
            builder.Property(x => x.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(x => x.ModificationUser).HasColumnName("MODIFICATION_USER");
            builder.Property(x => x.ModificationDate).HasColumnName("MODIFICATION_DATE");

            builder.HasMany(x => x.Users)
                .WithOne(y => y.Role)
                .HasForeignKey(x => x.IdRole);
        }
    }
}
