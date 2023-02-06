using Istikbal_Backend.DAL;
using Istikbal_Backend.Extensions;
using Istikbal_Backend.Helpers;
using Istikbal_Backend.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Istikbal_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Product> products = _context.Products.Include(p => p.ProductImages).Where(p => !p.IsDeleted).ToList();
            return View(products);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product db = _context.Products.Find(id);
            if (db == null) return NotFound();
            _context.Remove(db);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.Where(c => !c.IsDeleted).ToList();
            ViewBag.CategoryIns = _context.CategoryIns.Where(c => !c.IsDeleted).ToList();

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            if (!ModelState.IsValid) return View();

            ViewBag.Categories = _context.Categories.Where(c => !c.IsDeleted).ToList();
            ViewBag.CategoryIns = _context.CategoryIns.Where(c => !c.IsDeleted).ToList();


            List<ProductImage> Images = new List<ProductImage>();
            foreach (var item in product.Photo)
            {

                ProductImage image = new ProductImage();
                image.ImageUrl = item.Savemage(_env, "assets/img/product");
                Images.Add(image);
            }
            product.ProductImages = Images;
            product.CreatedTime = DateTime.Now;
            product.IsDeleted = false;
            product.ProductImages[0].IsMain = true;
            product.ProductCategories = new List<ProductCategory>();
            if (product.CategoryIds != null)
            {
                foreach (var categoryId in product.CategoryIds)
                {
                    ProductCategory pCategory = new ProductCategory
                    {
                        Product = product,
                        CategoryId = categoryId
                    };
                    _context.ProductCategories.Add(pCategory);
                }
            }

            product.ProductCategorIns = new List<ProductCategoryIn>();
            if (product.CategoryInIds != null)
            {
                foreach (var categoryInId in product.CategoryInIds)
                {
                    ProductCategoryIn pCategoryIn = new ProductCategoryIn
                    {
                        Product = product,
                        CategoryInId = categoryInId
                    };
                    _context.ProductCategoryIns.Add(pCategoryIn);
                }
            }



            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();


            return RedirectToAction("index");
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _context.Categories.Where(c => !c.IsDeleted).ToList();
            ViewBag.CategoryIns = _context.CategoryIns.Where(c => !c.IsDeleted).ToList();
            Product product = _context.Products.Include(p => p.ProductCategories).ThenInclude(p => p.Category).Include(p => p.ProductCategorIns).ThenInclude(p => p.CategoryIn).Where(p => p.IsDeleted == false).FirstOrDefault(p => p.Id == id);
            if (product == null) return RedirectToAction("Index");
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Product product)
        {
            ViewBag.Categories = _context.Categories.Where(c => !c.IsDeleted).ToList();
            ViewBag.CategoryIns = _context.CategoryIns.Where(c => !c.IsDeleted).ToList();

            if (!ModelState.IsValid)
            {
                return View();
            }
            Product dbProduct = await _context.Products
                .Include(p => p.ProductImages).Include(p => p.ProductCategories).ThenInclude(p => p.Category).Include(p => p.ProductCategorIns).ThenInclude(p => p.CategoryIn)
                .Where(p => !p.IsDeleted)
                .FirstOrDefaultAsync(b => b.Id == product.Id);
            if (dbProduct == null)
            {
                return View();
            }
            List<ProductImage> images = new List<ProductImage>();
            string path = "";
            if (product.Photo == null)
            {
                foreach (var image in dbProduct.ProductImages)
                {
                    image.ImageUrl = image.ImageUrl;
                    _context.SaveChanges();
                }
            }
            else
            {
                foreach (var item in product.Photo)
                {
                    if (item == null)
                    {
                        ModelState.AddModelError("Photo", "Can not be empty");
                        return View();
                    }
                    if (!item.IsImage())
                    {
                        ModelState.AddModelError("Photo", "Only images");
                        return View();
                    }

                    if (item.CheckSize(20000))
                    {
                        ModelState.AddModelError("Photo", "The image size is larger than required size(max 20 mb)");
                        return View();
                    }
                    ProductImage image = new ProductImage();
                    image.ImageUrl = item.Savemage(_env, "assets/img/product");

                    if (product.Photo.Count == 1)
                    {
                        image.IsMain = true;
                    }
                    else
                    {
                        for (int i = 0; i < images.Count; i++)
                        {
                            images[0].IsMain = true;
                        }
                    }
                    images.Add(image);
                }

                foreach (var item in product.Photo)
                {
                    if (!item.IsImage())
                    {
                        ModelState.AddModelError("Photo", "Images only");
                        return View();
                    }

                    if (item.CheckSize(20000))
                    {
                        ModelState.AddModelError("Photo", "The image size is larger than required size(max 20 mb)");
                        return View();
                    }
                }
            }

            //foreach (var item in dbProduct.ProductImages)
            //{
            //    if (item.ImageUrl != null)
            //    {
            //        path = Path.Combine(_env.WebRootPath, "assets/img/product", item.ImageUrl);
            //    }
            //}
            //if (path != null)
            //{
            //    Helper.Deletemage(path);
            //}
            //else return NotFound();



            var existCategories = _context.ProductCategories.Where(x => x.ProductId == product.Id).ToList();
            if (product.CategoryIds != null)
            {
                foreach (var categoryId in product.CategoryIds)
                {
                    var existCategory = existCategories.FirstOrDefault(x => x.CategoryId == categoryId);
                    if (existCategory == null)
                    {
                        ProductCategory pCategory = new ProductCategory
                        {
                            ProductId = product.Id,
                            CategoryId = categoryId,
                        };

                        _context.ProductCategories.Add(pCategory);
                    }
                    else
                    {
                        existCategories.Remove(existCategory);
                    }
                }

            }
            _context.ProductCategories.RemoveRange(existCategories);

            var existCategoryIns = _context.ProductCategoryIns.Where(x => x.ProductId == product.Id).ToList();
            if (product.CategoryInIds != null)
            {
                foreach (var categoryInId in product.CategoryInIds)
                {
                    var existCategoryIn = existCategoryIns.FirstOrDefault(x => x.CategoryInId == categoryInId);
                    if (existCategoryIn == null)
                    {
                        ProductCategoryIn pCategoryIn = new ProductCategoryIn
                        {
                            ProductId = product.Id,
                            CategoryInId = categoryInId,
                        };

                        _context.ProductCategoryIns.Add(pCategoryIn);
                    }
                    else
                    {
                        existCategoryIns.Remove(existCategoryIn);
                    }
                }

            }
            _context.ProductCategoryIns.RemoveRange(existCategoryIns);

            dbProduct.Name = product.Name;
            dbProduct.Price = product.Price;
            dbProduct.ProductImages = images;
            dbProduct.Count = product.Count;
            dbProduct.UpdatedTime = DateTime.Now;
            dbProduct.Description = product.Description;
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product product = _context.Products.Include(b => b.ProductImages).Include(b => b.ProductCategorIns).ThenInclude(b => b.CategoryIn)
                .Include(b => b.ProductCategories).ThenInclude(b => b.Category)
                .Where(b => !b.IsDeleted).FirstOrDefault(b => b.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
