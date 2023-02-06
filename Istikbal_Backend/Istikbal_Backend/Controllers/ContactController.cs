using Istikbal_Backend.DAL;
using Istikbal_Backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Istikbal_Backend.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public ContactController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        { 
            return View();
        }
       
        public IActionResult SendMes(string Name,string Email,string Filial,string Message)
        {
            if (!ModelState.IsValid) return View();
            Contact contact = new Contact
            { 
                Name = Name,
                Filial = Filial,
                Email = Email,
                Message = Message,
                Date = DateTime.Now,
            };

            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return RedirectToAction("index", "contact");

        }
    }
}
