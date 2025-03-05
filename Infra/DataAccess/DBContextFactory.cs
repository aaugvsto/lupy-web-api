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
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .AddEnvironmentVariables()
                .Build();

            var connString = config.GetConnectionString("DefaultConnection");

            var builder = new DbContextOptionsBuilder<DBContext>()
                .UseSqlServer(connString, b => b.MigrationsAssembly("Lupy.Infra"));

            return new DBContext(builder.Options);
        }
    }
}