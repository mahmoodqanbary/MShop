using Microsoft.AspNetCore.Mvc;
using MShop.Data;
using MShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MShop.Components
{
    public class ProductGroupComponents : ViewComponent
    {
        private MShopDbContext _context;
        public ProductGroupComponents(MShopDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = _context.Categories
                .Select(c => new ShowGroupViewModel()
                {
                    GroupId = c.Id,
                    Name = c.Name,
                    ProductCount = _context.CategoryToProdacts.Count(g => g.CategoryId == c.Id)
                }).ToList();
            return View("/Views/Components/ProductGroupsComponent.cshtml",categories);
        }
    }
}
