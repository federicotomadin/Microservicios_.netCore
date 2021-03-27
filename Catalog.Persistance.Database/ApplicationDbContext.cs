using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Catalog.Domain;
using Catalog.Persistance.Database.Configuration;

namespace Catalog.Persistance.Database
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option) { }
        

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInStock> Stocks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder) {

            optionBuilder.EnableSensitiveDataLogging();
        }


        protected override void OnModelCreating(ModelBuilder builder) {


            base.OnModelCreating(builder);

            builder.HasDefaultSchema("Catalog");


            ModelBuilder(builder);
        
        }

        private void ModelBuilder(ModelBuilder modelBuidler) {

            new ProductConfiguration(modelBuidler.Entity<Product>());
            new ProductInStockConfiguration(modelBuidler.Entity<ProductInStock>());

        } 


    }
}
