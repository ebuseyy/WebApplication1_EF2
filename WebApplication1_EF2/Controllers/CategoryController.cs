using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1_EF2.Models;

namespace WebApplication1_EF2.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindContext dbcontext = new NorthwindContext();
        public IActionResult Index()
        {
            
            return View(dbcontext.Categories);
        }

        [HttpGet]
        public IActionResult Ekleme()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekleme(Category category)
        {
            dbcontext.Categories.Add(category);
            dbcontext.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Guncelleme(int ID)
        {
            return View(dbcontext.Categories.FirstOrDefault(c=>c.CategoryId==ID));
        }

        [HttpPost]
        public IActionResult Guncelleme(Category category)
        {
            dbcontext.Categories.Update(category);
            dbcontext.SaveChanges();
            return RedirectToAction("index");
        }


        public ActionResult Delete(int ID)
        {
            return View(dbcontext.Categories.FirstOrDefault(c => c.CategoryId == ID));
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            dbcontext.Categories.Remove(category);
            dbcontext.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
