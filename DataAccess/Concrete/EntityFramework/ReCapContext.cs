using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=RecapDB;Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rental> Rentals { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent Mapping
            modelBuilder.Entity<Customer>().Property(p => p.CustomerId).HasColumnName("Id");
            modelBuilder.Entity<User>().Property(p => p.UserId).HasColumnName("Id");
        }
    }
}
