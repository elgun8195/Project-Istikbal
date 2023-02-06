using Istikbal_Backend.DAL;
using Istikbal_Backend.Models;
using Istikbal_Backend.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Istikbal_Backend.Controllers
{
    public class BasketController : Controller
    {
        private AppDbContext _context;
        private UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _httpContext;
        public BasketController(AppDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
        {
            _context = context;
            _httpContext = httpContextAccessor;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                return RedirectToAction("login", "account");
            }
            OrderVM model = new OrderVM
            {

                BasketItems = _context.BasketItems.Include(b => b.Product).Include(b=>b.Product.ProductImages).Where(b => b.AppUserId == user.Id).ToList(),

            };


            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> Plus(int Id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            BasketItem basket = _context.BasketItems.Include(b => b.Product) .FirstOrDefault(b => b.ProductId == Id && b.AppUserId == user.Id);
            basket.Count++;
            _context.SaveChanges();
            int TotalPrice = 0;
            int Price = basket.Count *   basket.Product.Price ;
            List<BasketItem> basketItems = _context.BasketItems.Include(b => b.AppUser).Include(b => b.Product).Where(b => b.AppUserId == user.Id).ToList();
            foreach (BasketItem item in basketItems)
            {
                Product product = _context.Products.FirstOrDefault(b => b.Id == item.ProductId);

                BasketItemVM basketItemVM = new BasketItemVM
                {
                    Product = product,
                    Count = item.Count
                };
                basketItemVM.Price =  product.Price ;

                TotalPrice += basketItemVM.Price * basketItemVM.Count;

            }

            return Json(new { totalPrice = TotalPrice, Price });
        }
        public async Task<IActionResult> Minus(int Id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            BasketItem basket = _context.BasketItems.Include(b => b.Product).FirstOrDefault(b => b.ProductId == Id && b.AppUserId == user.Id);
            if (basket.Count == 1)
            {
                basket.Count = 1;
            }
            else
            {
                basket.Count--;
            }
            _context.SaveChanges();
            int TotalPrice = 0;
            int Price = basket.Count * basket.Product.Price;
            List<BasketItem> basketItems = _context.BasketItems.Include(b => b.AppUser).Include(b => b.Product).Where(b => b.AppUserId == user.Id).ToList();
            foreach (BasketItem item in basketItems)
            {
                Product product = _context.Products.FirstOrDefault(b => b.Id == item.ProductId);

                BasketItemVM basketItemVM = new BasketItemVM
                {
                    Product = product,
                    Count = item.Count
                };
                basketItemVM.Price = product.Price;

                TotalPrice += basketItemVM.Price * basketItemVM.Count;

            }

            return Json(new { totalPrice = TotalPrice, Price });
        }
 
        public async Task<IActionResult> Add(int id, int count)
        {
            Product product = _context.Products.FirstOrDefault(f => f.Id == id);


            if (User.Identity.IsAuthenticated && User.IsInRole("Member"))
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user == null)
                {
                    return RedirectToAction("login", "account");
                }
                BasketItem basketItem = _context.BasketItems.FirstOrDefault(b => b.ProductId == product.Id && b.AppUserId == user.Id);
                if (basketItem == null)
                {
                    basketItem = new BasketItem
                    {
                        AppUserId = user.Id,
                        ProductId = product.Id,
                        Count = count
                    };
                    _context.BasketItems.Add(basketItem);
                }
                else
                {
                    basketItem.Count += count;
                }
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

                //return View("_basketPartial");
            }



            return RedirectToAction("login", "account");
        }
    

        public async Task<IActionResult> Remove(int Id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("Member"))
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user == null)
                {
                    return RedirectToAction("login", "account");
                }
                List<BasketItem> basketItems = _context.BasketItems.Where(b => b.ProductId == Id && b.AppUserId == user.Id).ToList();
                if (basketItems == null) return Json(new { status = 404 });
                foreach (var item in basketItems)
                {

                    _context.BasketItems.Remove(item);
                }
            }

            _context.SaveChanges();


            return Json(new { status = 200 });
        }

         

        
    }
}
