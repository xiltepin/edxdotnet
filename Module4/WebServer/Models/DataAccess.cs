using System;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;
namespace WebServer.Models
{
    public class SakilaDbContext : DbContext
    {
        public SakilaDbContext(DbContextOptions<SakilaDbContext> options)
        : base(options) { }

        public DbSet<Film> Film { get; set; }

    }



    class SakilaDbContextFactory
    {
        public static SakilaDbContext Create(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SakilaDbContext>();
            optionsBuilder.UseMySQL(connectionString);
            var sakilaDbContext = new SakilaDbContext(optionsBuilder.Options);
            return sakilaDbContext;
        }
    }
}
