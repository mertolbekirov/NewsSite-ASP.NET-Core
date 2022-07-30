using Microsoft.AspNetCore.Mvc;

namespace NewsSite.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }   
    }
}
