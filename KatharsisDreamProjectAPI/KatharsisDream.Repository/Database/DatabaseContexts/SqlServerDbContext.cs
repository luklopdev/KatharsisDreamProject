using KatharsisDream.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatharsisDream.Repository.Database.DatabaseContexts
{
    public class SqlServerDbContext : DbContext, IDbContext
    {
        private readonly IConfiguration Configuration;

        DbSet<Account> Accounts { get; set; }

        public SqlServerDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("KatharsisDreamDatabase"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
