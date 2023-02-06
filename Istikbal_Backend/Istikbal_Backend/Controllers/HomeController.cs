using Istikbal_Backend.DAL;
using Istikbal_Backend.Models;
using Istikbal_Backend.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Istikbal_Backend.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(UserManager<AppUser> userManager, AppDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM=new HomeVM()
            {
                Sliders=_context.Sliders.Where(s=>!s.IsDeleted).ToList(),
                Products=_context.Products.Include(p=>p.ProductImages).Where(s=>!s.IsDeleted).ToList()
            };
            return View(homeVM);
        }
    }
}
