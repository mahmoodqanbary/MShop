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
        public DbSet<Prodact> Prodacts { get; set; }
        public DbSet<CategoryToProdact> CategoryToProdacts { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryToProdact>()
                .HasKey(t => new { t.ProdactId, t.CategoryId });

            modelBuilder.Entity<Item>(i =>
            {
                i.Property(w => w.Price).HasColumnType("Money");
                i.HasKey(w => w.Id);
            });

            modelBuilder.Entity<Prodact>().HasData(new Prodact()
            {
                Id = 1,
                ItemId = 1,
                Name = "پارچه کرپ حریر",
                Description = "پارچه کرپ حریر مناسب فصل تابستان و برای دوخت شومیز و مانتو مناسب است"


            },
            new Prodact()
            {
                Id = 2,
                ItemId = 2,
                Name = "پارچه نخی",
                Description = "پارچه نخی یک پارچه خنک و مناسب فصل تابستان است و برای دوخت بلوز شلوار و ماکسی بسیار مناسب است"


            },
            new Prodact()
            {
                Id = 3,
                ItemId = 3,
                Name = "پارچه کرپ مازراتی",
                Description = "پارچه کرپ مازراتی اتو رفت دارد اما بسیار شیک و برای دوخت مانتوهای مجلسی و گران قیمت مناسب است و همینطور زیر دست لطیف و نرمی دارد"


            });
            modelBuilder.Entity<Prodact>().HasKey(w => w.Id);




            modelBuilder.Entity<CategoryToProdact>().HasData(
                new CategoryToProdact() { CategoryId = 1, ProdactId = 1 },
                new CategoryToProdact() { CategoryId = 2, ProdactId = 1 },
                new CategoryToProdact() { CategoryId = 3, ProdactId = 1 },
                new CategoryToProdact() { CategoryId = 1, ProdactId = 2 },
                new CategoryToProdact() { CategoryId = 2, ProdactId = 2 },
                new CategoryToProdact() { CategoryId = 3, ProdactId = 2 },
                new CategoryToProdact() { CategoryId = 1, ProdactId = 3 },
                new CategoryToProdact() { CategoryId = 2, ProdactId = 3 },
                new CategoryToProdact() { CategoryId = 3, ProdactId = 3 }

                );
            modelBuilder.Entity<Item>().HasData(new Item()
            {
                Id = 1,
                Price = 3302.0M,
                QuantityInStock = 8
            },
            new Item()
            {
                Id = 2,
                Price = 854.0M,
                QuantityInStock = 5
            },
            new Item()
            {
                Id = 3,
                Price = 2500,
                QuantityInStock = 3
            }
            );


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

           // modelBuilder.Entity<Prodact>(
           //   p =>
           //    {
           //       p.HasKey(w => w.Id);
           //       p.OwnsOne<Item>(w => w.Item);
           //       p.HasOne<Item>(w => w.Item)
           //           .WithOne(w => w.Prodact)
           //          .HasForeignKey<Item>(w => w.Id);
           //   }
           //);

            base.OnModelCreating(modelBuilder);
        }
    }
}
