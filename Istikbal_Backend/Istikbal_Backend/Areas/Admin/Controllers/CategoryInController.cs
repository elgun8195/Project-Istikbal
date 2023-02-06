using Istikbal_Backend.DAL;
using Istikbal_Backend.Extensions;
using Istikbal_Backend.Helpers;
using Istikbal_Backend.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace Istikbal_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryInController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;


        public CategoryInController(AppDbContext appDbContext, IWebHostEnvironment env)
        {
            _context = appDbContext;
            _env = env;
        }

        public IActionResult Index()
        {
            List<CategoryIn> CategoryInList = _context.CategoryIns.Where(s => !s.IsDeleted).ToList();
            return View(CategoryInList);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CategoryIn db = _context.CategoryIns.Find(id);
            if (db == null) return NotFound();
            db.IsDeleted = true;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryIn CategoryIn)
        {
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!CategoryIn.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Sekil Formati secin");
            }

            if (CategoryIn.Photo.CheckSize(20000))
            {
                ModelState.AddModelError("Photo", "Sekil 20 mb-dan boyuk ola bilmez");
            }


            string filename = await CategoryIn.Photo.SaveFile(_env, "assets/img/Category");
            CategoryIn.ImageUrl = filename;
            CategoryIn.CreatedTime = DateTime.Now;

            _context.CategoryIns.Add(CategoryIn);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CategoryIn CategoryIn = _context.CategoryIns.Find(id);
            if (CategoryIn == null)
            {
                return NotFound();
            }
            return View(CategoryIn);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int? id, CategoryIn CategoryIn)
        {
            if (id == null)
            {
                return NotFound();
            }


            CategoryIn db = _context.CategoryIns.Find(id);
            if (db == null)
            {
                return NotFound();
            }
            if (CategoryIn.Photo != null)
            {

                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }

                if (!CategoryIn.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Sekil Formati secin");
                }

                if (CategoryIn.Photo.CheckSize(20000))
                {
                    ModelState.AddModelError("Photo", "Sekil 20 mb-dan boyuk ola bilmez");
                }
                Helper.DeleteFile(_env, "assets/img/Category", db.ImageUrl);
                string filename = await CategoryIn.Photo.SaveFile(_env, "assets/img/Category");
                db.ImageUrl = filename;
            }
            else
            {
                db.ImageUrl = db.ImageUrl;
            }

            db.UpdatedTime = DateTime.Now;
            db.Name = CategoryIn.Name;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            CategoryIn CategoryIn = _context.CategoryIns.Where(b => !b.IsDeleted).FirstOrDefault(b => b.Id == id);
            if (CategoryIn == null)
            {
                return NotFound();
            }
            return View(CategoryIn);
        }


    }
}
