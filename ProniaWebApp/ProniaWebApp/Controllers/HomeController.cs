using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaWebApp.DAL;
using ProniaWebApp.Models;
using System.Diagnostics;

namespace ProniaWebApp.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _dbContext;
        public HomeController(AppDbContext context)
        {
            _dbContext = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> products =await _dbContext.Products.Include(x=>x.Photos).Where(x=>x.Photos.Count>0).ToListAsync();
            return View(products);
        }
        public IActionResult Detail(int? id)
        {
            return View();
        }
        
    }
}
