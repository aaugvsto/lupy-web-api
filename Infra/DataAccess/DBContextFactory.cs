using Lupy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infra.DataAccess
{
    public class DBContextFactory : IDesignTimeDbContextFactory<DBContext>
    {
        public DBContext CreateDbContext(string[] args)
        {
            var connString = "Host=<server>;Database=<dbName>;Username=<user>;Password=<password>";
            
            var builder = new DbContextOptionsBuilder<DBContext>()
                .UseNpgsql(connString, b => b.MigrationsAssembly("Lupy.Infra"));

            return new DBContext(builder.Options);
        }
    }
}