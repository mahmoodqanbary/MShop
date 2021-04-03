using Microsoft.EntityFrameworkCore;
using MShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MShop.Data
{
    public class MShopDbContext : DbContext
    {
        public MShopDbContext(DbContextOptions<MShopDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seed Data Category
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id=1,
                Name="لباس مردانه",
                Description="مردانه",
            },new Category()
            {
                Id = 2,
                Name = "لباس زنانه",
                Description = "زنانه",
            }, new Category()
            {
                Id = 3,
                Name = "لباس بچگانه",
                Description = "بچگانه",
            }
                );    
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
