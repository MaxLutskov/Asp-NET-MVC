using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name)
        {
            if(name!=null)
            {
                ViewData["Message"] = "Hello " + name;
                return View("HelloName");
            }
            
            return View();
        }
    }
}
