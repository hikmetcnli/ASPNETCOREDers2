using Microsoft.AspNetCore.Mvc;

namespace CORECRUD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
