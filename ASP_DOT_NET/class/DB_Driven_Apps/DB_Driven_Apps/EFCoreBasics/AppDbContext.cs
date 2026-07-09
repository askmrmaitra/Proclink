using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreBasics
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;DataBase=BikeStore;TrustServerCertificate=true;Encrypt=True; Integrated Security=SSPI;Persist Security Info=False;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                        .HasKey(p => p.ProductId);

            modelBuilder.Entity<Product>()
                        .Property(p => p.Name)
                        .HasMaxLength(100)
                        .IsRequired();

            modelBuilder.Entity<Product>()
                        .Property(p => p.Price)
                        .IsRequired();
        }
    }
}
