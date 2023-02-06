using Istikbal_Backend.DAL;
using Istikbal_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Istikbal_Backend.ViewComponents
{
    public class HeaderViewComponent: ViewComponent
    {
        private readonly AppDbContext _db;

        public HeaderViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio model = _db.Bio.FirstOrDefault();
            ViewBag.Categories = _db.Categories.Where(c=>!c.IsDeleted).Take(10).ToList();
            return View(await Task.FromResult(model));
        }
    }
}
