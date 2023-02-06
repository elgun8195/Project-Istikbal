using Istikbal_Backend.DAL;
using Istikbal_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Istikbal_Backend.ViewComponents
{
    public class FooterViewComponent: ViewComponent
    {
        private readonly AppDbContext _db;

        public FooterViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio model = _db.Bio.FirstOrDefault();
            return View(await Task.FromResult(model));
        }
    }
}
