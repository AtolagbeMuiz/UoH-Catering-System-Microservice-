using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection;
using System;
using Microsoft.EntityFrameworkCore;
using UoHCateringSystem.Product.Microservice;

namespace UoHCateringSystem.Product.Microservice.DBContext
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
        : base(options)
        {

        }
        public DbSet<UoHCateringSystem.Product.Microservice.Models.Product> Product { get; set; }
        




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UoHCateringSystem.Product.Microservice.Models.Product>().HasData(
                new Models.Product
                {
                    ProductId = Guid.NewGuid(),
                    ProductName = "Pizza",
                    ImagePath = "/assets/Pizza.jpeg",
                    Amount = 2
                }
            );

            modelBuilder.Entity<Models.Product>().HasData(
               new Models.Product
               {
                   ProductId = Guid.NewGuid(),
                   ProductName = "Cofee",
                   ImagePath = "/assets/Coffee.jpeg",
                   Amount = 1.5
               }
            );

            modelBuilder.Entity<Models.Product>().HasData(
             new Models.Product
             {
                 ProductId = Guid.NewGuid(),
                 ProductName = "Cake",
                 ImagePath = "/assets/Cake.jpeg",
                 Amount = 3
             }
          );

        }
    }
}
