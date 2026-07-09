using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Code
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=PLK-LAP0487\\SQLEXPRESS;Initial Catalog=BikeStore;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
            
        }
    }

}
