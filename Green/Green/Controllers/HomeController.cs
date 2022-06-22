using Microsoft.AspNetCore.Mvc;

namespace Green.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
