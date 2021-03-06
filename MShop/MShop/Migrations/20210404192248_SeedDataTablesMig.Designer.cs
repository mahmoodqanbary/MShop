// <auto-generated />
using MShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MShop.Migrations
{
    [DbContext(typeof(MShopDbContext))]
    [Migration("20210404192248_SeedDataTablesMig")]
    partial class SeedDataTablesMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "مردانه",
                            Name = "لباس مردانه"
                        },
                        new
                        {
                            Id = 2,
                            Description = "زنانه",
                            Name = "لباس زنانه"
                        },
                        new
                        {
                            Id = 3,
                            Description = "بچگانه",
                            Name = "لباس بچگانه"
                        });
                });

            modelBuilder.Entity("MShop.Models.CategoryToProdact", b =>
                {
                    b.Property<int>("ProdactId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProdactId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryToProdacts");

                    b.HasData(
                        new
                        {
                            ProdactId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            ProdactId = 1,
                            CategoryId = 2
                        },
                        new
                        {
                            ProdactId = 1,
                            CategoryId = 3
                        },
                        new
                        {
                            ProdactId = 2,
                            CategoryId = 1
                        },
                        new
                        {
                            ProdactId = 2,
                            CategoryId = 2
                        },
                        new
                        {
                            ProdactId = 2,
                            CategoryId = 3
                        },
                        new
                        {
                            ProdactId = 3,
                            CategoryId = 1
                        },
                        new
                        {
                            ProdactId = 3,
                            CategoryId = 2
                        },
                        new
                        {
                            ProdactId = 3,
                            CategoryId = 3
                        });
                });

            modelBuilder.Entity("MShop.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price")
                        .HasColumnType("Money");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 3302.0m,
                            QuantityInStock = 8
                        },
                        new
                        {
                            Id = 2,
                            Price = 854.0m,
                            QuantityInStock = 5
                        },
                        new
                        {
                            Id = 3,
                            Price = 2500m,
                            QuantityInStock = 3
                        });
                });

            modelBuilder.Entity("MShop.Models.Prodact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.ToTable("Prodacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "پارچه کرپ حریر مناسب فصل تابستان و برای دوخت شومیز و مانتو مناسب است",
                            ItemId = 1,
                            Name = "پارچه کرپ حریر"
                        },
                        new
                        {
                            Id = 2,
                            Description = "پارچه نخی یک پارچه خنک و مناسب فصل تابستان است و برای دوخت بلوز شلوار و ماکسی بسیار مناسب است",
                            ItemId = 2,
                            Name = "پارچه نخی"
                        },
                        new
                        {
                            Id = 3,
                            Description = "پارچه کرپ مازراتی اتو رفت دارد اما بسیار شیک و برای دوخت مانتوهای مجلسی و گران قیمت مناسب است و همینطور زیر دست لطیف و نرمی دارد",
                            ItemId = 3,
                            Name = "پارچه کرپ مازراتی"
                        });
                });

            modelBuilder.Entity("MShop.Models.CategoryToProdact", b =>
                {
                    b.HasOne("MShop.Models.Category", "Category")
                        .WithMany("CategoryToProdacts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MShop.Models.Prodact", "Prodact")
                        .WithMany("CategoryToProdacts")
                        .HasForeignKey("ProdactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Prodact");
                });

            modelBuilder.Entity("MShop.Models.Prodact", b =>
                {
                    b.HasOne("MShop.Models.Item", "Item")
                        .WithOne("Prodact")
                        .HasForeignKey("MShop.Models.Prodact", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("MShop.Models.Category", b =>
                {
                    b.Navigation("CategoryToProdacts");
                });

            modelBuilder.Entity("MShop.Models.Item", b =>
                {
                    b.Navigation("Prodact");
                });

            modelBuilder.Entity("MShop.Models.Prodact", b =>
                {
                    b.Navigation("CategoryToProdacts");
                });
#pragma warning restore 612, 618
        }
    }
}
