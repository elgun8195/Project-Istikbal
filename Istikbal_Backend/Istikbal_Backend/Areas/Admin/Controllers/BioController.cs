using Istikbal_Backend.DAL;
using Istikbal_Backend.Helpers;
using Istikbal_Backend.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace Istikbal_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BioController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;


        public BioController(AppDbContext appDbContext, IWebHostEnvironment env)
        {
            _context = appDbContext;
            _env = env;
        }

        public IActionResult Index()
        {
            Bio BioList = _context.Bio.FirstOrDefault();
            return View(BioList);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bio db = _context.Bio.Find(id);
            if (db == null) return NotFound();
            _context.Remove(db);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Bio Bio)
        {



            _context.Bio.Add(Bio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bio Bio = _context.Bio.Find(id);
            if (Bio == null)
            {
                return NotFound();
            }
            return View(Bio);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int? id, Bio Bio)
        {
            if (id == null)
            {
                return NotFound();
            }


            Bio db = _context.Bio.Find(id);

            db.Youtube = Bio.Youtube;
            db.Phone = Bio.Phone;
            db.Email = Bio.Email; 
            db.Facebook = Bio.Facebook;
            db.İnstagram = Bio.İnstagram;



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

       
    }
}
