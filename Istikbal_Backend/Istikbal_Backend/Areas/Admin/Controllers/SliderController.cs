using Istikbal_Backend.DAL;
using Istikbal_Backend.Extensions;
using Istikbal_Backend.Helpers;
using Istikbal_Backend.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Istikbal_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;


        public SliderController(AppDbContext appDbContext, IWebHostEnvironment env)
        {
            _context = appDbContext;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Slider> sliderList = _context.Sliders.Where(s=>!s.IsDeleted).ToList();
            return View(sliderList);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Slider db = _context.Sliders.Find(id);
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
        public async Task<IActionResult> Create(Slider Slider)
        {
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!Slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Sekil Formati secin");
            }

            if (Slider.Photo.CheckSize(20000))
            {
                ModelState.AddModelError("Photo", "Sekil 20 mb-dan boyuk ola bilmez");
            }
             

            string filename = await Slider.Photo.SaveFile(_env, "assets/img/slider");
            Slider.ImageUrl = filename;
            Slider.CreatedTime = DateTime.Now;

            _context.Sliders.Add(Slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Slider Slider = _context.Sliders.Find(id);
            if (Slider == null)
            {
                return NotFound();
            }
            return View(Slider);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int? id, Slider Slider)
        {
            if (id == null)
            {
                return NotFound();
            }
             

            Slider db = _context.Sliders.Find(id);
            if (db == null)
            {
                return NotFound();
            }
            if (Slider.Photo != null)
            {

                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }

                if (!Slider.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Sekil Formati secin");
                }

                if (Slider.Photo.CheckSize(20000))
                {
                    ModelState.AddModelError("Photo", "Sekil 20 mb-dan boyuk ola bilmez");
                }
                Helper.DeleteFile(_env, "assets/img/slider", db.ImageUrl);
                string filename = await Slider.Photo.SaveFile(_env, "assets/img/slider");
                db.ImageUrl = filename;
            }
            else
            {
                db.ImageUrl = db.ImageUrl;
            }
             
            db.UpdatedTime = DateTime.Now;


            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Slider Slider = _context.Sliders.Where(b => !b.IsDeleted).FirstOrDefault(b => b.Id == id);
            if (Slider == null)
            {
                return NotFound();
            }
            return View(Slider);
        }
    }
}
