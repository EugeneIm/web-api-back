using daytwo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace daytwo.DataHelpers
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data.
            modelBuilder.Entity<Product>().HasData(
                new { ProduceID = 1, Description = "Oranges", Price = 12},
                new { ProduceID = 2, Description = "Apples", Price = 5 }
            );
        }
    }

}
