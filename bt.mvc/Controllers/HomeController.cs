using Microsoft.AspNetCore.Mvc;

namespace bt.mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Weekend()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }
    }
}