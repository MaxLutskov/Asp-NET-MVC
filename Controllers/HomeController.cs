using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name)
        {
            if(name!=null)
            {
                HelloName.Name = name;
                return View("HelloName");
            }
            
            return View();
        }
    }
}
