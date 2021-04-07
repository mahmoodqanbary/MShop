using Microsoft.AspNetCore.Mvc;
using MShop.Data;
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
            return View("/Views/Components/ProductGroupsComponent.cshtml", _context.Categories);
        }
    }
}
