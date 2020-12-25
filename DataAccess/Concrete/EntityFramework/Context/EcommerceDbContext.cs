using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class EcommerceDbContext:DbContext
    {
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.\;Database=ManagamentPanel;Trusted_Connection=True;MultipleActiveResultSets=true");

        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<CategoryHiearchy> CategoryHiearchy { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<CompanyContact> CompanyContact { get; set; }
        public DbSet<CompanyDetail> CompanyDetail { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<MainCategory> MainCategory { get; set; }
        public DbSet<Option> Option { get; set; }
        public DbSet<OptionGroup> OptionGroup { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductBrand> ProductBrand { get; set; }
        public DbSet<ProductCatHiearchy> ProductCatHiearchy { get; set; }
        public DbSet<ProductOption> ProductOption { get; set; }
        public DbSet<ProductProductImage> ProductProductImage { get; set; }
        public DbSet<ProductReview> ProductReview { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<ProductMeta> ProductMeta { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<User> User { get; set; }
    }
}
