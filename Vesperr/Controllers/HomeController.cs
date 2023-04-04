using Microsoft.AspNetCore.Mvc;

namespace Vesper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
