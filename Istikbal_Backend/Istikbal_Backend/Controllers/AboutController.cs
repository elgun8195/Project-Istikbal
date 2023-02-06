using Istikbal_Backend.DAL;
using Istikbal_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Istikbal_Backend.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Category> categories =await _context.Categories.Include(c=>c.CategoryDests).ThenInclude(c=>c.CategoryIn).ThenInclude(c=>c.ProductCategoryIns)
                .Include(c=>c.ProductCategories).ThenInclude(c=>c.Product) 
                .Where(c => !c.IsDeleted).ToListAsync();
            return View(categories);
        }
    }
}
