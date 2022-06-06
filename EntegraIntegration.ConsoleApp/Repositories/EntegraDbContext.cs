using EntegraIntegration.ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EntegraIntegration.ConsoleApp.Repositories
{
    public class EntegraDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        
        public string DbPath { get; }

        public EntegraDbContext()
        {
            var path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "entegra.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

}
