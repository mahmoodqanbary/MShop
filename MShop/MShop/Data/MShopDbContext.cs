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
    }
}
