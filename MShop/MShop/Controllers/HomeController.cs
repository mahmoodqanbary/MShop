using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MShop.Data;
using MShop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MShopDbContext _context;
        private static Cart _cart = new Cart();

        public HomeController(ILogger<HomeController> logger, MShopDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = _context.Prodacts.ToList();
            return View(products);
        }
        public IActionResult Details(int id)
        {
            var product = _context.Prodacts
                .Include(p => p.Item)
                .SingleOrDefault(c => c.Id == id);

            if(product == null)
            {
                return NotFound();
            }
            var categories = _context.Prodacts
                .Where(p => p.Id == id)
                .SelectMany(c => c.CategoryToProdacts)
                .Select(ca => ca.Category)
                .ToList();
            var vm = new DetailsViewModel()
            {
                Prodact = product,
                Categories = categories
            };

            return View(vm);
        }
        public IActionResult AddToCart(int itemId)
        {
            var product = _context.Prodacts.Include(i => i.Item).SingleOrDefault(c => c.ItemId == itemId);
            
            if(product != null)
            {
                var cartItem = new CartItem() 
                {
                    Item = product.Item,
                    Quantity = 1
                };
                _cart.addItem(cartItem);
            }

            return RedirectToAction("ShowCart");
        }

        public IActionResult ShowCart()
        {
            var cartVm = new CartViewModel()
            {
               CartItems = _cart.CartItems,
               OrderTotal = _cart.CartItems.Sum(p => p.GetTotalPrice())
            };
            return View(cartVm);
        }
        
        public IActionResult RemoveCart(int itemId)
        {
            _cart.removeItem(itemId);
            return RedirectToAction("ShowCart");
        }
        [Route("/ContactUs")]
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
