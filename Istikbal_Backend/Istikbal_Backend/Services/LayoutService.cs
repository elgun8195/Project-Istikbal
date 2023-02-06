using Istikbal_Backend.DAL;
using Istikbal_Backend.Models;
using Istikbal_Backend.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Istikbal_Backend.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<AppUser> _userManager;

        public LayoutService(AppDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
        {
            _context = context;
            _httpContext = httpContextAccessor;
            _userManager = userManager;
        }
        public async Task<BasketVM> ShowBasket()
        {

            BasketVM basketData = new BasketVM
            {
                TotalPrice = 0,
                BasketItems = new List<BasketItemVM>(),
                Count = 0
            };
            if (_httpContext.HttpContext.User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(_httpContext.HttpContext.User.Identity.Name);
                List<BasketItem> basketItems = _context.BasketItems.Include(b => b.AppUser).Where(b => b.AppUserId == user.Id).ToList();
                foreach (BasketItem item in basketItems)
                {
                    Product product = _context.Products.Include(f => f.ProductImages).FirstOrDefault(f => f.Id == item.ProductId);
                    if (product != null)
                    {
                        BasketItemVM basketItemVM = new BasketItemVM
                        {
                            Product = product,
                            Count = item.Count
                        };
                        basketItemVM.Price =  basketItemVM.Product.Price ;
                        basketData.BasketItems.Add(basketItemVM);
                        basketData.Count++;
                        basketData.TotalPrice += basketItemVM.Price * basketItemVM.Count;
                    }
                }
            }


            return basketData;

        }
    }
}
