using Istikbal_Backend.DAL;
using Istikbal_Backend.Extensions;
using Istikbal_Backend.Helpers;
using Istikbal_Backend.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Istikbal_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CategoryController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.Where(s => !s.IsDeleted).ToList();
            return View(categories);
        }
        public IActionResult Detail(int? id)
        {
            Category categories = _context.Categories.Include(s=>s.CategoryDests).ThenInclude(s=>s.CategoryIn).Where(s => !s.IsDeleted).FirstOrDefault(s=>s.Id==id);
            return View(categories);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category db = _context.Categories.Find(id);
            if (db == null) return NotFound();
            _context.Remove(db);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Create()
        {
            ViewBag.CategoryIns = _context.CategoryIns.Where(c => !c.IsDeleted).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            ViewBag.CategoryIns = _context.CategoryIns.Where(c => !c.IsDeleted).ToList();


            if (!category.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Sekil Formati secin");
            }

            if (category.Photo.CheckSize(20000))
            {
                ModelState.AddModelError("Photo", "Sekil 20 mb-dan boyuk ola bilmez");
            }


            string filename = await category.Photo.SaveFile(_env, "assets/img/Category");
            category.ImageUrl = filename;
            category.CreatedTime = DateTime.Now;

            category.CategoryDests = new List<CategoryDest>();
            if (category.CategoryInIds != null)
            {
                foreach (var categoryInId in category.CategoryInIds)
                {
                    CategoryDest pCategoryIn = new CategoryDest
                    {
                        Category = category,
                        CategoryInId = categoryInId
                    };
                    _context.CategoryDests.Add(pCategoryIn);
                }
            }



            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int? id)
        {
            ViewBag.CategoryIns = _context.CategoryIns.ToList();

            if (id == null)
            {
                return NotFound();
            }

            Category category = _context.Categories.Include(c => c.CategoryDests).ThenInclude(c => c.CategoryIn).FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int? id, Category category)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.CategoryIns = _context.CategoryIns.ToList();

            Category db = _context.Categories.Include(c => c.CategoryDests).ThenInclude(c => c.CategoryIn).FirstOrDefault(c => c.Id == id);
            if (db == null)
            {
                return NotFound();
            }
            if (category.Photo != null)
            {

                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }

                if (!category.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Sekil Formati secin");
                }

                if (category.Photo.CheckSize(20000))
                {
                    ModelState.AddModelError("Photo", "Sekil 20 mb-dan boyuk ola bilmez");
                }
                Helper.DeleteFile(_env, "assets/img/Category", db.ImageUrl);
                string filename = await category.Photo.SaveFile(_env, "assets/img/Category");
                db.ImageUrl = filename;
            }
            else
            {
                db.ImageUrl = db.ImageUrl;
            }

            db.UpdatedTime = DateTime.Now;
            db.Name = category.Name;

            var existCategoryIns = _context.CategoryDests.Where(x => x.CategoryId == category.Id).ToList();
            if (category.CategoryInIds != null)
            {
                foreach (var categoryInId in category.CategoryInIds)
                {
                    var existCategoryIn = existCategoryIns.FirstOrDefault(x => x.CategoryInId == categoryInId);
                    if (existCategoryIn == null)
                    {
                        CategoryDest pCategoryIn = new CategoryDest
                        {
                            CategoryId = category.Id,
                            CategoryInId = categoryInId,
                        };

                        _context.CategoryDests.Add(pCategoryIn);
                    }
                    else
                    {
                        existCategoryIns.Remove(existCategoryIn);
                    }
                }

            }
            _context.CategoryDests.RemoveRange(existCategoryIns);


            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
