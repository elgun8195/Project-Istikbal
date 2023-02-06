using Istikbal_Backend.DAL;
using Istikbal_Backend.Models;
using Istikbal_Backend.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Istikbal_Backend.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int sortId, int id)
        {
            List<Product> products = _context.Products.Include(b => b.ProductImages).Include(b => b.ProductCategories).Where(c => !c.IsDeleted && c.ProductCategories.Any(bt => bt.CategoryId == id)).ToList();

            ViewBag.cid = id;
            ViewBag.id = sortId;
            switch (sortId)
            {
                case 4:
                    products = await _context.Products.Include(p => p.ProductImages).Where(c => !c.IsDeleted && c.ProductCategories.Any(bt => bt.CategoryId == id)).ToListAsync();
                    break;
                case 1:
                    products = await _context.Products.Include(p => p.ProductImages).Where(c => !c.IsDeleted && c.ProductCategories.Any(bt => bt.CategoryId == id)).OrderByDescending(p => p.CreatedTime).ToListAsync();
                    break;
                case 2:
                    products = await _context.Products.Include(p => p.ProductImages).Where(c => !c.IsDeleted && c.ProductCategories.Any(bt => bt.CategoryId == id)).OrderBy(p => p.Price).ToListAsync();
                    break;
                case 3:
                    products = await _context.Products.Include(p => p.ProductImages).Where(c => !c.IsDeleted && c.ProductCategories.Any(bt => bt.CategoryId == id)).OrderByDescending(p => p.Price).ToListAsync();
                    break;
                default:
                    break;
            }
            ViewBag.Notice = products.Count;

            return View(products);
        }
        public async Task<IActionResult> Dest(int sortId, int id)
        {
            List<Product> products = _context.Products.Include(b => b.ProductImages).Include(b => b.ProductCategorIns).Where(c => !c.IsDeleted && c.ProductCategorIns.Any(bt => bt.CategoryInId == id)).ToList();

            ViewBag.cid = id;
            ViewBag.id = sortId;
            switch (sortId)
            {
                case 4:
                    products = await _context.Products.Include(p => p.ProductImages).Where(c => !c.IsDeleted && c.ProductCategorIns.Any(bt => bt.CategoryInId == id)).ToListAsync();
                    break;
                case 1:
                    products = await _context.Products.Include(p => p.ProductImages).Where(c => !c.IsDeleted && c.ProductCategorIns.Any(bt => bt.CategoryInId == id)).OrderByDescending(p => p.CreatedTime).ToListAsync();
                    break;
                case 2:
                    products = await _context.Products.Include(p => p.ProductImages).Where(c => !c.IsDeleted && c.ProductCategorIns.Any(bt => bt.CategoryInId == id)).OrderBy(p => p.Price).ToListAsync();
                    break;
                case 3:
                    products = await _context.Products.Include(p => p.ProductImages).Where(c => !c.IsDeleted && c.ProductCategorIns.Any(bt => bt.CategoryInId == id)).OrderByDescending(p => p.Price).ToListAsync();
                    break;
                default:
                    break;
            }
            ViewBag.Notice = products.Count;
            return View(products);
        }
        public async Task<IActionResult> Detail(int id)
        {
            Product product = await _context.Products.Include(b => b.ProductImages).Where(b => !b.IsDeleted && b.Id == id).FirstOrDefaultAsync();
            if (product == null)
            {
                return RedirectToAction("index", "error");
            }
            List<Category> categories = _context.Categories.Include(c => c.ProductCategories).ThenInclude(bc => bc.Product).Where(b => b.ProductCategories.Any(bc => bc.ProductId == id)).ToList();

            List<Product> relatedProducts = new List<Product>();
            foreach (var item in categories)
            {
                relatedProducts = _context.Products.Include(b => b.ProductImages).Where(b => b.ProductCategories.Any(bc => bc.CategoryId == item.Id)).ToList();
            }
            ProductDetailVM productDetailVM = new ProductDetailVM()
            {
                RelatedProducts = relatedProducts,
                Categories = categories,
                Product = product,
            };
            return View(productDetailVM);
        }
        public IActionResult Search(string search)
        {
            List<Product> products = _context.Products.Where(p => p.Name.ToLower().Contains(search.ToLower())).ToList();
            return PartialView("_SearchPartial", products);
        }

        public async Task<IActionResult> Mehsullar(int sortId)
        {
            List<Product> products = _context.Products.Include(b => b.ProductImages).Include(b => b.ProductCategories).Where(c => !c.IsDeleted).ToList();


            ViewBag.id = sortId;
            switch (sortId)
            {
                case 4:
                    products = await _context.Products.Include(p => p.ProductImages).Where(c => !c.IsDeleted).ToListAsync();
                    break;
                case 1:
                    products = await _context.Products.Include(p => p.ProductImages).Where(c => !c.IsDeleted).OrderByDescending(p => p.CreatedTime).ToListAsync();
                    break;
                case 2:
                    products = await _context.Products.Include(p => p.ProductImages).Where(c => !c.IsDeleted).OrderBy(p => p.Price).ToListAsync();
                    break;
                case 3:
                    products = await _context.Products.Include(p => p.ProductImages).Where(c => !c.IsDeleted).OrderByDescending(p => p.Price).ToListAsync();
                    break;
                default:
                    break;
            }
            ViewBag.Notice = products.Count;

            return View(products);
        }
    }
}
