using Microsoft.EntityFrameworkCore;
using RetailManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailManagement
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> opt) :base(opt) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,4)");

            modelBuilder.Entity<Product>().HasData(new Product

            {
                Id = 1,
                ProductName = "T-Shirt",
                Brand = "KOTON",
                Price = 100000.0M,
                Description = "this is a T-shirt",
                Image = null,
                ProductLeft = 30,
                CategoryId = 1
            },
            new Product
            {
                Id = 2,
                ProductName = "Jacket",
                Brand = "KOTON",
                Price = 225000.0M,
                Description = "this is a Jacket for spring",
                Image = null,
                ProductLeft = 22,
                CategoryId = 1
            }

                );

            modelBuilder.Entity<Category>().HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Clothes"
                    }

                );
        }


        public virtual DbSet<Product> Products{ get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
