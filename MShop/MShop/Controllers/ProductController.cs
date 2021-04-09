using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MShop.Controllers
{
    public class ProductController : Controller
    {
        private MShopDbContext _context;
        public ProductController(MShopDbContext context)
        {
            _context = context;
        }
        [Route("Group/{id}/{name}")]
        public IActionResult ShowProductByGroupId(int id, string name)
        {
            ViewData["GroupName"] = name;
            var prodact = _context.CategoryToProdacts
                .Where(c => c.CategoryId == id)
                .Include(c => c.Prodact)
                .Select(c => c.Prodact)
                .ToList();
            return View(prodact);
        }
    }
}
