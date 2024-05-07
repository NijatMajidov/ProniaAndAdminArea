using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaWebApp.DAL;
using ProniaWebApp.Models;

namespace ProniaWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        AppDbContext _dbcontext;
        public CategoryController(AppDbContext context)
        {
            _dbcontext = context;
        }
        public IActionResult Index()
        {
            List<Category> categories = _dbcontext.Categories.Include(x=>x.Products).ToList();
            return View(categories);
        }

        public IActionResult Delete(int? id) {
            var category = _dbcontext.Categories.FirstOrDefault(x=>x.Id == id);
            _dbcontext.Categories.Remove(category);
            _dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
